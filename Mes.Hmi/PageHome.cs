using Mes.Business;
using Mes.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 主界面（《Automation UI V3.11》P4 那张标准图）：
    /// 区域4 主页面功能按钮、区域5 机台分模组信息、区域7 扫码传入、区域8 当前报警、区域9 产能摘要。
    /// 版面在 PageHome.Designer.cs，这里只有取值和跳转。
    /// </summary>
    public partial class PageHome : UserControl
    {
        private static readonly Color OkText = Color.FromArgb(0, 150, 60);
        private static readonly Color NgText = Color.FromArgb(200, 40, 40);
        private static readonly Color RowOk = Color.FromArgb(223, 245, 227);
        private static readonly Color RowNg = Color.FromArgb(250, 216, 216);

        /// <summary>后台读 PLC 的周期。界面定时器 500ms 一次，两边各管各的。</summary>
        private const int PollMs = 300;

        private readonly StationContext station;
        private readonly object snapGate = new object();
        private Label[] lamps;
        private Label[] cavityStates;
        private HomeSnapshot snapshot;
        private volatile bool pumping;
        private int alarmShown = -1;
        private string alarmLast = string.Empty;

        /// <summary>"图形测试"要跳到参数图表页，跳转由外壳决定，页面自己不动导航。</summary>
        public event Action<string> NavigateRequested;

        public PageHome()
        {
            InitializeComponent();
            lamps = new[] { lampCamera, lampOffset, lampScanner, lampRobot };
            cavityStates = new[] { cavityState1, cavityState2, cavityState3, cavityState4 };
            Disposed += delegate { pumping = false; };
        }

        public PageHome(StationContext station) : this()
        {
            this.station = station;
            refresh.Enabled = true;
            PrepareActionButtons();
            StartPump();
        }

        // ── 后台刷新 ───────────────────────────────────────────────────────

        /// <summary>
        /// 主界面每半秒要刷新一大片，但一次 PLC 往返在真机上就是几毫秒到几十毫秒。
        /// 这些读放在界面线程上，操作员每按一下都要排在它们后面——现场说的"点不动"就是这么来的。
        /// 所以 PLC 读全搬到这条后台线程，攒成一帧快照，界面只负责把快照画出来。
        ///
        /// 读法也合并过：四颗连接灯一次块读，两个滑台的送码位一次块读，
        /// 四个过站触发一次块读，四个腔体温度一次块读——一轮 6 次往返，而不是原来十几二十次。
        /// </summary>
        private void StartPump()
        {
            pumping = true;
            var thread = new Thread(PumpLoop);
            thread.IsBackground = true;
            thread.Name = "主界面刷新";
            thread.Start();
        }

        private void PumpLoop()
        {
            var batch = new BatchNumbers();
            var cycle = 0;
            while (pumping)
            {
                HomeSnapshot next;
                try
                {
                    // 产能摘要是整表扫一遍，虽然不再复制，但也没必要每 300ms 做；三帧一次即可。
                    if (cycle++ % 3 == 0) batch = station.Batch.Read();
                    next = ReadSnapshot(batch);
                }
                catch (Exception ex)
                {
                    next = new HomeSnapshot { Error = ex.Message };
                }
                lock (snapGate) { snapshot = next; }
                Thread.Sleep(PollMs);
            }
        }

        private HomeSnapshot ReadSnapshot(BatchNumbers batch)
        {
            var plc = station.Plc;
            var frame = new HomeSnapshot { Batch = batch };

            var links = plc.Read(PlcAddresses.Mw(PlcAddresses.DeviceLinkBase), 4);
            for (var i = 0; i < frame.Links.Length; i++) frame.Links[i] = links[i] != 0;

            // 63000 / 63002 是左右滑台报站触发，中间夹着两个结果字，一次读 4 个字。
            var checkIn = plc.Read(PlcAddresses.Mw(PlcAddresses.LeftCheckInTrigger), 4);
            frame.Sending[0] = checkIn[0] != 0;
            frame.Sending[1] = checkIn[2] != 0;

            // 63020/63022/63024/63026 是四个工位的过站触发，一次读 8 个字。
            var checkOut = plc.Read(PlcAddresses.Mw(PlcAddresses.CheckOutTrigger(1)), 8);
            frame.Welded[0] = checkOut[0] != 0 || checkOut[2] != 0;
            frame.Welded[1] = checkOut[4] != 0 || checkOut[6] != 0;

            // 四个 WD 区从 15900 起每 4 个字一块，一次读 16 个字；
            // 每块的第一个浮点在读回数组里的下标是 0、2、4、6。
            var wd = plc.ReadFloatArray(PlcAddresses.Mw(PlcAddresses.WdArea(1)), 16);
            for (var i = 0; i < frame.WeldTemp.Length; i++)
            {
                var value = wd[i * 2];
                frame.WeldTemp[i] = value;
                frame.WeldBad[i] = value > 0 && station.Limits.Violations(new[]
                {
                    new KeyValuePair<string, double>("微动补偿X", value),
                }).Count > 0;
            }

            frame.LeftCode = Barcode(PlcAddresses.LeftBarcodeArea);
            frame.RightCode = Barcode(PlcAddresses.RightBarcodeArea);
            frame.Fixture = LastFixture();
            return frame;
        }

        /// <summary>后台线程读回来的一帧。界面只拿它画，不再自己去问 PLC。</summary>
        private sealed class HomeSnapshot
        {
            public readonly bool[] Links = new bool[4];
            public readonly bool[] Sending = new bool[2];
            public readonly bool[] Welded = new bool[2];
            public readonly double[] WeldTemp = new double[4];
            public readonly bool[] WeldBad = new bool[4];
            public string LeftCode = string.Empty;
            public string RightCode = string.Empty;
            public string Fixture = string.Empty;
            public BatchNumbers Batch = new BatchNumbers();
            public string Error;
        }

        /// <summary>
        /// 补料那颗按钮对应哪个 IO 由 数据\IO输入输出表.csv 说了算：表里没有就置灰，
        /// 不硬编一个本机没有的地址（硬编出来的按钮按下去什么也不动，比没有更糟）。
        /// 触摸屏上 ToolTip 没人看得见，所以原因直接写在按钮上。
        /// </summary>
        private void PrepareActionButtons()
        {
            var refill = station.Io.ByName("补料");
            if (refill != null) return;
            btnRefillLeft.Enabled = false;
            btnRefillRight.Enabled = false;
            btnRefillLeft.Text = "左料仓补料（IO 表里没有这一点）";
            btnRefillRight.Text = "右料仓补料（IO 表里没有这一点）";
        }

        // ── 区域4 ─────────────────────────────────────────────────────────

        private void btnReset_Click(object sender, EventArgs e)
        {
            station.Flow.ResetAlarms();
        }

        private void btnEStop_Click(object sender, EventArgs e)
        {
            station.Flow.EmergencyStop();
        }

        private void btnRefillLeft_Click(object sender, EventArgs e)
        {
            Refill("左料仓补料");
        }

        private void btnRefillRight_Click(object sender, EventArgs e)
        {
            Refill("右料仓补料");
        }

        private void Refill(string name)
        {
            var point = station.Io.ByName(name);
            if (point == null) point = station.Io.ByName("补料");
            if (point == null)
            {
                station.Say("未找到补料 IO 点：" + name);
                return;
            }
            var on = !station.Plc.PeekBit(point.Address);
            station.Plc.PokeBit(point.Address, on);
            station.Log.Write(station.User, "手动补料", point.Address, on ? "关" : "开", on ? "开" : "关");
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            var handler = NavigateRequested;
            if (handler != null) handler(StationPage.ParamChart);
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (!station.Flow.SilenceBuzzer())
            {
                btnMute.Enabled = false;
                station.Say("IO 表里没有蜂鸣点，屏蔽蜂鸣不可用");
            }
        }

        // ── 区域5 / 7 / 8 / 9 绘制 ───────────────────────────────────────

        private void refresh_Tick(object sender, EventArgs e)
        {
            HomeSnapshot frame;
            lock (snapGate) { frame = snapshot; }
            if (frame == null) return;
            try
            {
                if (frame.Error != null)
                {
                    // 读失败只写状态行，不弹框：后台线程下一轮自己会恢复。
                    slideStatusLabel.Text = "读取失败：" + frame.Error;
                    slideStatusLabel.ForeColor = NgText;
                    return;
                }
                ApplyLamps(frame);
                ApplySlide(frame);
                ApplyCavity(frame);
                ApplyCodes(frame);
                PaintBatch(frame.Batch);
                RefreshAlarms();
            }
            catch (Exception ex)
            {
                // 界面线程上抛出去就是整个程序退出：状态行给出原因，下一轮再试。
                slideStatusLabel.Text = "显示失败：" + ex.Message;
                slideStatusLabel.ForeColor = NgText;
            }
        }

        private void ApplyLamps(HomeSnapshot frame)
        {
            for (var i = 0; i < lamps.Length; i++)
            {
                var on = frame.Links[i];
                var text = PlcAddresses.DeviceLinkNames[i] + "连接" + (on ? "OK" : "NG");
                if (lamps[i].Text != text) lamps[i].Text = text;
                lamps[i].ForeColor = on ? OkText : NgText;
            }
        }

        private void slideTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            HomeSnapshot frame;
            lock (snapGate) { frame = snapshot; }
            if (frame != null && frame.Error == null) ApplySlide(frame);
        }

        private void ApplySlide(HomeSnapshot frame)
        {
            var slide = slideTabs.SelectedIndex == 0 ? 0 : 1;
            var text = frame.Sending[slide] ? "滑台状态：送码中"
                : frame.Welded[slide] ? "滑台状态：焊接完成，等待判定"
                : "滑台状态OK,等待上料...";
            if (slideStatusLabel.Text != text) slideStatusLabel.Text = text;
            slideStatusLabel.ForeColor = SystemColors.ControlText;
        }

        /// <summary>
        /// 四个腔体的当前状态：温度取各工位 WD 区第一个浮点（就是主项目里"微动补偿X"那一列），
        /// 窗口取自 数据\判定上下限.csv（后台线程已经判好，这里只上色）。
        /// 没焊过的工位读回来是 0，显示等待装载而不是"温度 0"。
        /// </summary>
        private void ApplyCavity(HomeSnapshot frame)
        {
            for (var i = 0; i < cavityStates.Length; i++)
            {
                var row = cavityStates[i];
                var value = frame.WeldTemp[i];
                if (value <= 0)
                {
                    if (row.Text != "腔体正常，正在等待装载零件") row.Text = "腔体正常，正在等待装载零件";
                    row.BackColor = RowOk;
                    continue;
                }
                row.Text = frame.WeldBad[i]
                    ? "腔体NG，温度NG（" + value.ToString("0.0") + "）"
                    : "腔体正常，温度 " + value.ToString("0.0");
                row.BackColor = frame.WeldBad[i] ? RowNg : RowOk;
            }
        }

        private void ApplyCodes(HomeSnapshot frame)
        {
            SetText(txtLeftCode, frame.LeftCode);
            SetText(txtRightCode, frame.RightCode);
            SetText(txtFixture, frame.Fixture);
        }

        /// <summary>Text 属性每次赋值都会重写窗口文本、触发一次重绘，值没变就别写。</summary>
        private static void SetText(TextBox box, string text)
        {
            if (box.Text != text) box.Text = text;
        }

        private static void SetText(Label label, string text)
        {
            if (label.Text != text) label.Text = text;
        }

        /// <summary>
        /// 当前治具取"最近一条已经填了治具号的记录"，不是最近一条：
        /// 刚报站的那片还没上治具，直接取最后一条会让这一栏一闪一闪地变空。
        /// </summary>
        private string LastFixture()
        {
            var row = station.ProductLog.Last(r => r.Get("治具号").Length > 0);
            return row == null ? string.Empty : row.Get("治具号");
        }

        private string Barcode(int area)
        {
            var raw = WordCodec.WordsToAscii(
                station.Plc.Read(PlcAddresses.Mw(area), PlcAddresses.BarcodeWords));
            return (raw ?? string.Empty).Trim().TrimEnd('\0').Trim();
        }

        private void RefreshAlarms()
        {
            var active = station.ActiveAlarms.Snapshot();
            var last = active.Count == 0 ? string.Empty : active[active.Count - 1].ToString();
            if (active.Count == alarmShown && last == alarmLast) return;
            alarmShown = active.Count;
            alarmLast = last;
            alarmList.BeginUpdate();
            alarmList.Items.Clear();
            for (var i = active.Count - 1; i >= 0; i--) alarmList.Items.Add(active[i].ToString());
            alarmList.EndUpdate();
        }

        private void PaintBatch(BatchNumbers n)
        {
            SetText(valInput, n.Input.ToString());
            SetText(valOutput, n.Completed.ToString());
            SetText(valNg, n.Ng.ToString());
            SetText(valYield, n.Yield.ToString("0.0") + "%");
            SetText(valCt, n.AverageCt.ToString("0.0"));
        }

        private void btnResetBatch_Click(object sender, EventArgs e)
        {
            station.Batch.Reset();
            station.Log.Write(station.User, "重置批次统计", "区域9", string.Empty, string.Empty);
            station.Say("批次统计已重置");
            PaintBatch(station.Batch.Read());
        }

        private void txtWorkOrder_Leave(object sender, EventArgs e)
        {
            station.Log.Write(station.User, "工单号", txtWorkOrder.Text.Trim(), string.Empty, string.Empty);
        }
    }
}
