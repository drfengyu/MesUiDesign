using Mes.Business;
using Mes.Devices;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 帮助/模拟机台：这一页站在 PLC 那一侧，把真机上"人动手"的几件事搬到界面上——
    /// 拨 MA 旋钮、改节拍、改报警间隔/通道、手动注入报警、拨四颗连接灯。
    ///
    /// 为什么要有这一页：手动操作页在自动档下必须拒绝点动，而模拟机的 MA 档位原本是
    /// MachineSimulator.AutoMode 这个字段，界面上没有入口就打不到手动，那页永远测不了。
    /// 真机上这个旋钮是面板上的物理开关，所以这一页只对模拟驱动有意义，接真机后删除。
    /// </summary>
    public partial class PageMachineSimulator : UserControl
    {
        private static readonly Color AutoBack = Color.FromArgb(214, 244, 222);
        private static readonly Color ManualBack = Color.FromArgb(253, 235, 200);
        private static readonly Color WarnColor = Color.FromArgb(200, 40, 40);

        private readonly StationContext station;
        private readonly object linkGate = new object();
        private CheckBox[] links;
        private short[] linkValues;
        private bool loading;
        private int linkChangedAt;
        private volatile bool pumping;

        public PageMachineSimulator()
        {
            InitializeComponent();
            Disposed += delegate { pumping = false; refresh.Stop(); };
        }

        public PageMachineSimulator(StationContext station) : this()
        {
            this.station = station;
            links = new[] { checkLink1, checkLink2, checkLink3, checkLink4 };
            LoadSettings();
            StartLinkPump();
            station.Machine.OnEvent += OnMachineEvent;
            Disposed += delegate { station.Machine.OnEvent -= OnMachineEvent; };
            UpdateMode();
            refresh.Enabled = true;
        }

        private void LoadSettings()
        {
            loading = true;
            numericCycle.Value = Clamp(station.Machine.CycleMs, numericCycle);
            numericAlarmEvery.Value = Clamp(station.Machine.AlarmEvery, numericAlarmEvery);
            numericChannel.Value = Clamp(station.Machine.AlarmChannel, numericChannel);
            loading = false;
        }

        private static decimal Clamp(int value, NumericUpDown box)
        {
            if (value < box.Minimum) return box.Minimum;
            if (value > box.Maximum) return box.Maximum;
            return value;
        }

        /// <summary>
        /// 四个连接字是机台侧写给界面看的。读放在后台线程（这一页不占界面线程等 PLC），
        /// 定时器只把最近一次读数贴到勾选框上。
        /// </summary>
        private void StartLinkPump()
        {
            pumping = true;
            var thread = new Thread(LinkLoop);
            thread.IsBackground = true;
            thread.Name = "连接灯监视";
            thread.Start();
        }

        private void LinkLoop()
        {
            while (pumping)
            {
                short[] next = null;
                try
                {
                    next = station.Plc.Read(PlcAddresses.Mw(PlcAddresses.DeviceLinkBase), 4);
                }
                catch (Exception)
                {
                }
                lock (linkGate) { linkValues = next; }
                Thread.Sleep(500);
            }
        }

        // ── MA 旋钮 ────────────────────────────────────────────────────────

        private void btnMa_Click(object sender, EventArgs e)
        {
            var auto = !station.Machine.AutoMode;
            station.Machine.AutoMode = auto;
            // 模拟机线程 200ms 后才把位拨过去；这里立刻拨一下，手动操作页不用等。
            station.Plc.PokeBit(ManualOperations.AutoSelectorBit, auto);
            station.Log.Write(station.User, "MA旋钮", "模拟机台", auto ? "手动" : "自动", auto ? "自动" : "手动");
            station.Say("MA 旋钮打到" + (auto ? "自动" : "手动"));
            UpdateMode();
        }

        private void UpdateMode()
        {
            var auto = station.Machine.AutoMode;
            btnMa.Text = auto ? "自动" : "手动";
            btnMa.BackColor = auto ? AutoBack : ManualBack;
            statusLabel.ForeColor = SystemColors.ControlText;
            statusLabel.Text = "机台线程：" + (station.Machine.Running ? "运行中" : "未运行")
                + "　MA 旋钮：" + (auto ? "自动" : "手动");
        }

        // ── 节拍与报警 ─────────────────────────────────────────────────────

        private void numericCycle_ValueChanged(object sender, EventArgs e)
        {
            if (loading) return;
            station.Machine.CycleMs = (int)numericCycle.Value;
            station.Say("模拟节拍改为 " + station.Machine.CycleMs + " ms");
        }

        private void numericAlarmEvery_ValueChanged(object sender, EventArgs e)
        {
            if (loading) return;
            station.Machine.AlarmEvery = (int)numericAlarmEvery.Value;
        }

        private void numericChannel_ValueChanged(object sender, EventArgs e)
        {
            if (loading) return;
            station.Machine.AlarmChannel = (int)numericChannel.Value;
        }

        private void btnInjectAlarm_Click(object sender, EventArgs e)
        {
            if (station.Machine.InjectAlarmNow()) return;
            statusLabel.ForeColor = WarnColor;
            statusLabel.Text = "报警目录里没有可注入的报警（需要序号有效且属于非计划类）";
        }

        // ── 连接灯 ─────────────────────────────────────────────────────────

        private void link_CheckedChanged(object sender, EventArgs e)
        {
            if (loading || station == null) return;
            var index = Array.IndexOf(links, (CheckBox)sender);
            if (index < 0) return;
            var on = links[index].Checked;
            linkChangedAt = Environment.TickCount;
            station.Plc.Poke(PlcAddresses.Mw(PlcAddresses.DeviceLinkBase + index), (short)(on ? 1 : 0));
            station.Say(PlcAddresses.DeviceLinkNames[index] + "连接灯 = " + (on ? "OK" : "NG"));
        }

        private void btnLinksAll_Click(object sender, EventArgs e)
        {
            linkChangedAt = Environment.TickCount;
            loading = true;
            foreach (var check in links) check.Checked = true;
            loading = false;
            for (var i = 0; i < links.Length; i++)
            {
                station.Plc.Poke(PlcAddresses.Mw(PlcAddresses.DeviceLinkBase + i), 1);
            }
            station.Say("四颗连接灯全部置 OK");
        }

        // ── 事件日志 ───────────────────────────────────────────────────────

        private void OnMachineEvent(string text)
        {
            if (IsDisposed || !IsHandleCreated) return;
            try
            {
                BeginInvoke(new Action<string>(AppendEvent), text);
            }
            catch (ObjectDisposedException)
            {
            }
            catch (InvalidOperationException)
            {
            }
        }

        private void AppendEvent(string text)
        {
            if (IsDisposed) return;
            eventList.Items.Add(DateTime.Now.ToString("HH:mm:ss") + "  " + text);
            if (eventList.Items.Count > 300)
            {
                for (var i = 0; i < 100; i++) eventList.Items.RemoveAt(0);
            }
            eventList.TopIndex = eventList.Items.Count - 1;
        }

        private void btnClearLog_Click(object sender, EventArgs e)
        {
            eventList.Items.Clear();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            UpdateMode();
            // 刚拨过勾选框的 0.8s 内不拿旧快照覆盖它：写下去到下一次读回来之间有个窗口，
            // 不挡的话勾选框会自己弹回去一次。
            if (Environment.TickCount - linkChangedAt < 800) return;
            short[] values;
            lock (linkGate) { values = linkValues; }
            if (values == null || values.Length < links.Length) return;
            loading = true;
            for (var i = 0; i < links.Length; i++)
            {
                var on = values[i] != 0;
                if (links[i].Checked != on) links[i].Checked = on;
            }
            loading = false;
        }
    }
}
