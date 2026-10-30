using Mes.Business;
using Mes.Devices;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 手动操作页（《Automation UI V3.11》P26）：每个气缸一行，"原点 / 动点"两颗点动按钮，
    /// 两个到位灯，以及从下阀到到位信号真正亮起的实测耗时。
    ///
    /// 到位灯只认机台给的磁感应开关，不跟着按钮自己点亮：
    /// 页面写阀之后，模拟机台要过 300ms 才把到位位置 1（真机看气压和缸径）。
    /// 这样"阀没电、气管没接、感应头坏了"在界面上就能看出来，而不是按下去就亮绿灯。
    ///
    /// 互锁按现场规矩：MA 旋钮在自动档时不接受点动，读的是 PLC 位，不是页面自己的变量。
    /// </summary>
    public partial class PageManualOperation : UserControl
    {
        private const int PollMs = 100;
        private const int SensorTimeoutMs = 5000;

        private static readonly Color OnColor = Color.FromArgb(0, 170, 70);
        private static readonly Color OffColor = Color.FromArgb(170, 174, 180);
        private static readonly Color ManualColor = Color.FromArgb(0, 140, 60);
        private static readonly Color AutoColor = Color.FromArgb(200, 40, 40);
        private static readonly Color QuietColor = Color.FromArgb(60, 66, 72);
        private static readonly Color WarnColor = Color.FromArgb(200, 40, 40);

        private readonly StationContext station;
        private readonly CylinderRuntime[] cylinders;
        private readonly string[] readAddresses;
        private readonly object snapGate = new object();
        private ManualSnapshot snapshot;
        private volatile bool pumping;

        public PageManualOperation()
        {
            InitializeComponent();
            grid.ClearSelection();
            Disposed += delegate { pumping = false; refresh.Stop(); };
        }

        public PageManualOperation(StationContext station) : this()
        {
            this.station = station;
            cylinders = new CylinderRuntime[ManualOperations.Cylinders.Count];
            readAddresses = new string[cylinders.Length * 2 + 1];
            for (var i = 0; i < cylinders.Length; i++)
            {
                var model = ManualOperations.Cylinders[i];
                cylinders[i] = new CylinderRuntime { Model = model, Name = CylinderName(station, model) };
                readAddresses[i * 2] = model.HomeSensor;
                readAddresses[i * 2 + 1] = model.WorkSensor;
            }
            readAddresses[readAddresses.Length - 1] = ManualOperations.AutoSelectorBit;
            BuildRows();
            StartPump();
            refresh.Enabled = true;
        }

        // ── 行与后台读 ─────────────────────────────────────────────────────

        /// <summary>行数来自 IO 表，设计器里摆不出来；表里删掉一个气缸，这一页跟着少一行。</summary>
        private void BuildRows()
        {
            grid.Rows.Clear();
            for (var i = 0; i < cylinders.Length; i++)
            {
                var row = grid.Rows[grid.Rows.Add()];
                row.Cells[0].Value = cylinders[i].Name;
                row.Cells[1].Value = "原点";
                row.Cells[2].Value = "动点";
                row.Cells[3].Value = "●";
                row.Cells[4].Value = "●";
                row.Cells[5].Value = "—";
                PaintDot(row.Cells[3], false);
                PaintDot(row.Cells[4], false);
            }
            grid.ClearSelection();
        }

        private void StartPump()
        {
            pumping = true;
            var thread = new Thread(PumpLoop);
            thread.IsBackground = true;
            thread.Name = "手动操作刷新";
            thread.Start();
        }

        private void PumpLoop()
        {
            while (pumping)
            {
                ManualSnapshot next;
                try
                {
                    next = new ManualSnapshot
                    {
                        Sensors = station.Plc.ReadBits(readAddresses),
                    };
                }
                catch (Exception ex)
                {
                    next = new ManualSnapshot { Error = ex.Message };
                }
                lock (snapGate) { snapshot = next; }
                Thread.Sleep(PollMs);
            }
        }

        private sealed class ManualSnapshot
        {
            public bool[] Sensors;
            public string Error;
        }

        private sealed class CylinderRuntime
        {
            public Cylinder Model;
            public string Name;

            /// <summary>0=等原点到、1=等动点到、-1=没有在等</summary>
            public int Waiting = -1;
            public int StartedAt;
            public string TimeText = "—";
            public bool HomeShown;
            public bool WorkShown;
        }

        // ── 界面刷新 ───────────────────────────────────────────────────────

        private void refresh_Tick(object sender, EventArgs e)
        {
            ManualSnapshot frame;
            lock (snapGate) { frame = snapshot; }
            if (frame == null) return;
            if (frame.Error != null)
            {
                SetHint("读取失败：" + frame.Error, true);
                return;
            }
            var auto = frame.Sensors[readAddresses.Length - 1];
            modeLabel.Text = auto ? "MA 旋钮：自动（禁止点动）" : "MA 旋钮：手动";
            modeLabel.ForeColor = auto ? AutoColor : ManualColor;
            for (var i = 0; i < cylinders.Length; i++)
            {
                var home = frame.Sensors[i * 2];
                var work = frame.Sensors[i * 2 + 1];
                var runtime = cylinders[i];
                if (runtime.HomeShown != home)
                {
                    runtime.HomeShown = home;
                    PaintDot(grid[3, i], home);
                }
                if (runtime.WorkShown != work)
                {
                    runtime.WorkShown = work;
                    PaintDot(grid[4, i], work);
                }
                CheckArrival(runtime, home, work);
            }
        }

        private void CheckArrival(CylinderRuntime runtime, bool home, bool work)
        {
            if (runtime.Waiting < 0) return;
            var arrived = runtime.Waiting == 0 ? home : work;
            if (arrived)
            {
                var seconds = (Environment.TickCount - runtime.StartedAt) / 1000.0;
                runtime.Waiting = -1;
                runtime.TimeText = seconds.ToString("0.00") + " s";
                SetText(grid[5, IndexOf(runtime)], runtime.TimeText);
                SetHint(runtime.Name + " 到位，用时 " + runtime.TimeText, false);
                return;
            }
            if (Environment.TickCount - runtime.StartedAt < SensorTimeoutMs) return;
            runtime.Waiting = -1;
            runtime.TimeText = "超时";
            SetText(grid[5, IndexOf(runtime)], runtime.TimeText);
            SetHint(runtime.Name + " 超过 5s 没有到位信号：检查阀、气源和感应开关", true);
        }

        private int IndexOf(CylinderRuntime runtime)
        {
            for (var i = 0; i < cylinders.Length; i++)
            {
                if (ReferenceEquals(cylinders[i], runtime)) return i;
            }
            return -1;
        }

        private static void PaintDot(DataGridViewCell dot, bool on)
        {
            var color = on ? OnColor : OffColor;
            dot.Style.ForeColor = color;
            dot.Style.SelectionForeColor = color;
        }

        private static void SetText(DataGridViewCell cell, string text)
        {
            if (!Equals(cell.Value, text)) cell.Value = text;
        }

        private void SetHint(string text, bool warn)
        {
            statusLabel.Text = text;
            statusLabel.ForeColor = warn ? WarnColor : QuietColor;
        }

        // ── 点动 ───────────────────────────────────────────────────────────

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= cylinders.Length) return;
            if (e.ColumnIndex == colHome.Index) Jog(e.RowIndex, 0);
            else if (e.ColumnIndex == colWork.Index) Jog(e.RowIndex, 1);
        }

        private void Jog(int index, int side)
        {
            bool auto;
            try
            {
                auto = station.Plc.ReadBits(new[] { ManualOperations.AutoSelectorBit })[0];
            }
            catch (Exception ex)
            {
                SetHint("读取 MA 旋钮失败：" + ex.Message, true);
                return;
            }
            var runtime = cylinders[index];
            if (auto)
            {
                SetHint("MA 旋钮在自动档，点动被拒绝：请先到 帮助/模拟机台 把旋钮打到手动", true);
                return;
            }
            try
            {
                station.Plc.WriteBitChecked(side == 0 ? runtime.Model.HomeValve : runtime.Model.WorkValve, true);
                station.Plc.WriteBitChecked(side == 0 ? runtime.Model.WorkValve : runtime.Model.HomeValve, false);
            }
            catch (Exception ex)
            {
                SetHint("写阀失败：" + ex.Message, true);
                return;
            }
            var position = side == 0 ? "原点" : "动点";
            runtime.Waiting = side;
            runtime.StartedAt = Environment.TickCount;
            runtime.TimeText = "计时中…";
            SetText(grid[5, index], runtime.TimeText);
            SetHint(runtime.Name + " → " + position + "，等待到位信号", false);
            station.Log.Write(station.User, "点动气缸", runtime.Name, string.Empty, position);
        }

        /// <summary>原点侧先通、动点侧先断：双电控缸两边同时得电会顶气，真机上要按这个顺序写。</summary>
        private void btnHomeAll_Click(object sender, EventArgs e)
        {
            bool auto;
            try
            {
                auto = station.Plc.ReadBits(new[] { ManualOperations.AutoSelectorBit })[0];
            }
            catch (Exception ex)
            {
                SetHint("读取 MA 旋钮失败：" + ex.Message, true);
                return;
            }
            if (auto)
            {
                SetHint("MA 旋钮在自动档，全部回原点被拒绝", true);
                return;
            }
            for (var i = 0; i < cylinders.Length; i++)
            {
                var runtime = cylinders[i];
                try
                {
                    station.Plc.WriteBitChecked(runtime.Model.HomeValve, true);
                    station.Plc.WriteBitChecked(runtime.Model.WorkValve, false);
                }
                catch (Exception ex)
                {
                    SetHint("写阀失败（" + runtime.Name + "）：" + ex.Message, true);
                    return;
                }
                runtime.Waiting = 0;
                runtime.StartedAt = Environment.TickCount;
                runtime.TimeText = "计时中…";
                SetText(grid[5, i], runtime.TimeText);
            }
            SetHint("全部回原点：已下发 " + cylinders.Length + " 个气缸", false);
            station.Log.Write(station.User, "点动气缸", "全部", string.Empty, "原点");
        }

        private void btnResetAlarms_Click(object sender, EventArgs e)
        {
            station.Flow.ResetAlarms();
            SetHint("报警已复位", false);
        }

        /// <summary>小窗口下 9 行 × 44px 会顶出可视区：按可用高度均分，按钮不至于被裁掉。</summary>
        private void grid_Resize(object sender, EventArgs e)
        {
            if (cylinders == null || grid.Rows.Count == 0) return;
            var height = Math.Max(38, (grid.ClientSize.Height - grid.ColumnHeadersHeight - 2) / grid.Rows.Count);
            if (grid.Rows[0].Height == height) return;
            grid.RowTemplate.Height = height;
            foreach (DataGridViewRow row in grid.Rows) row.Height = height;
        }

        // ── 名字 ───────────────────────────────────────────────────────────

        /// <summary>"输出_压持1缸_原点侧阀" → "压持1缸"；表里没有这个地址就把地址显示出来，不编名字。</summary>
        private static string CylinderName(StationContext station, Cylinder cylinder)
        {
            var point = station.Io.Find(cylinder.HomeValve);
            if (point == null || string.IsNullOrEmpty(point.Name)) return cylinder.HomeValve;
            var name = point.Name;
            if (name.StartsWith("输出_")) name = name.Substring(3);
            var cut = name.IndexOf('_');
            return cut > 0 ? name.Substring(0, cut) : name;
        }
    }
}
