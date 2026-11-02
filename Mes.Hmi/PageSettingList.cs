using Mes.Business;
using Mes.Devices;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 时间设置（《Automation UI V3.11》P28）与通讯设置（P29）。两页版面一模一样，
    /// 只是标题前缀、单位和读哪一段寄存器不同，所以做成一个控件两种模式，免得两份代码各改各的。
    ///
    /// 二十个格子在代码里摆：数量跟着 PLC 区长度走（SettingWords ÷ 2），不是版面拍脑袋定的；
    /// 列宽行高这些真正的版面参数仍然在 Designer 里。
    /// </summary>
    public partial class PageSettingList : UserControl
    {
        public enum Kind
        {
            Time,
            Comm,
        }

        private const int Count = PlcAddresses.SettingWords / 2;

        private readonly StationContext station;
        private readonly Kind kind;
        private readonly int area;
        private readonly TextBox[] boxes = new TextBox[Count];
        private readonly string[] pushed = new string[Count];
        private readonly object gate = new object();
        private Snapshot snapshot;
        private volatile bool pumping;
        private int revision;
        private int shownRevision = -1;

        public PageSettingList()
        {
            InitializeComponent();
            Disposed += delegate { pumping = false; };
        }

        public PageSettingList(StationContext station, Kind kind) : this()
        {
            this.station = station;
            this.kind = kind;
            this.area = kind == Kind.Time ? PlcAddresses.TimeSettingArea : PlcAddresses.CommSettingArea;
            BuildCells();
            var editable = CanEdit;
            for (var i = 0; i < Count; i++)
            {
                boxes[i].ReadOnly = !editable;
                boxes[i].BackColor = editable ? Color.White : Color.FromArgb(246, 248, 250);
            }
            refresh.Enabled = true;
            pumping = true;
            var thread = new Thread(PumpLoop);
            thread.IsBackground = true;
            thread.Name = kind == Kind.Time ? "时间设定读取" : "通讯设定读取";
            thread.Start();
        }

        /// <summary>文档把这两页写成"查看…设定项目"，所以只有工程师以上才允许改值。</summary>
        private bool CanEdit
        {
            get { return station != null && station.Level >= LoginLevel.Engineer; }
        }

        private void BuildCells()
        {
            var prefix = kind == Kind.Time ? "时间设定" : "通讯设定";
            var unit = kind == Kind.Time ? "s" : string.Empty;
            for (var i = 0; i < Count; i++)
            {
                var col = i < Count / 2 ? 0 : 4;
                var row = i % (Count / 2);

                var label = new Label
                {
                    Text = prefix + "(" + i.ToString(CultureInfo.InvariantCulture) + ")",
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleRight,
                    Font = new Font("微软雅黑", 9.5F),
                    ForeColor = Color.FromArgb(60, 66, 72),
                    Margin = new Padding(0, 0, 6, 0),
                };
                var box = new TextBox
                {
                    Dock = DockStyle.Fill,
                    Font = new Font("微软雅黑", 10F),
                    TextAlign = HorizontalAlignment.Left,
                    Margin = new Padding(0, 6, 0, 6),
                    Text = "--",
                };
                box.KeyDown += Setting_KeyDown;
                var tail = new Label
                {
                    Text = unit,
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("微软雅黑", 9.5F),
                    ForeColor = Color.FromArgb(120, 126, 134),
                    Margin = new Padding(6, 0, 0, 0),
                };
                root.Controls.Add(label, col, row);
                root.Controls.Add(box, col + 1, row);
                root.Controls.Add(tail, col + 2, row);
                boxes[i] = box;
                pushed[i] = box.Text;
            }
        }

        private void PumpLoop()
        {
            while (pumping)
            {
                try
                {
                    var values = station.Plc.ReadFloatArray(PlcAddresses.Mw(area), PlcAddresses.SettingWords);
                    lock (gate) { snapshot = new Snapshot { Revision = ++revision, Values = values }; }
                }
                catch (Exception ex)
                {
                    lock (gate) { snapshot = new Snapshot { Revision = ++revision, Error = ex.Message }; }
                }
                Thread.Sleep(500);
            }
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            Snapshot frame;
            lock (gate) { frame = snapshot; }
            if (frame == null || frame.Revision == shownRevision) return;
            shownRevision = frame.Revision;
            if (frame.Error != null)
            {
                station.Say("设定区读取失败：" + frame.Error);
                return;
            }
            for (var i = 0; i < Count; i++)
            {
                var value = frame.Values != null && i < frame.Values.Length ? frame.Values[i] : double.NaN;
                var text = double.IsNaN(value) ? "--" : value.ToString("0.000", CultureInfo.InvariantCulture);
                // 只有"这一格被人改过、而且还没下发"才躲开刷新；光有焦点不算在敲。
                if (boxes[i].Focused && boxes[i].Text != pushed[i]) continue;
                pushed[i] = text;
                boxes[i].Text = text;
            }
        }

        private void Setting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.Handled = true;
            e.SuppressKeyPress = true;
            var box = (TextBox)sender;
            var index = Array.IndexOf(boxes, box);
            if (index < 0) return;
            if (!CanEdit)
            {
                station.Say("需要工程师以上权限才能修改设定值");
                return;
            }
            double value;
            if (!double.TryParse(box.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out value))
            {
                station.Say("设定值必须是数字");
                return;
            }
            var address = PlcAddresses.Mw(area + index * 2);
            try
            {
                station.Plc.WriteFloatChecked(address, value);
            }
            catch (Exception ex)
            {
                station.Log.Write(station.User, "设定下发失败", address, value.ToString(CultureInfo.InvariantCulture), ex.Message);
                station.Say("下发失败：" + ex.Message);
                return;
            }
            station.Log.Write(station.User, "设定下发", address, value.ToString(CultureInfo.InvariantCulture), string.Empty);
            station.Say("已下发 " + address + " = " + value.ToString("0.000", CultureInfo.InvariantCulture));
        }

        private sealed class Snapshot
        {
            public int Revision;
            public double[] Values;
            public string Error;
        }
    }
}
