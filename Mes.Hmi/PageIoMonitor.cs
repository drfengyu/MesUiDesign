using Mes.Business;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// IO 监视页（《Automation UI V3.11》P23/P24）：左边一列、右边一列把输入或输出点位排开，
    /// 每行一个状态点 + "地址 信号名"，右侧上一页/下一页。
    ///
    /// 输入监控和输出监控是同一张版面、同一套读法，差别只在取哪张表，所以一个类按 kind 复用：
    /// 两页各建一个实例，不复制两份画点位的代码。
    ///
    /// 读法：整页地址一次 ReadBits 往返（不是一点一次），在后台线程做；界面定时器只拿快照上色。
    /// 这一点是 P23 那 30 个点决定的——一点一次往返在真机上就是一百多毫秒，全压在界面线程上。
    /// </summary>
    public partial class PageIoMonitor : UserControl
    {
        private const int RowsPerPage = 15;
        private const int SlotsPerPage = RowsPerPage * 2;
        private const int PollMs = 300;

        private static readonly Color OnColor = Color.FromArgb(0, 170, 70);
        private static readonly Color OffColor = Color.FromArgb(170, 174, 180);
        private static readonly Color NameColor = Color.FromArgb(45, 50, 55);
        private static readonly Color QuietColor = Color.FromArgb(90, 96, 105);
        private static readonly Color ErrorColor = Color.FromArgb(200, 40, 40);

        private readonly StationContext station;
        private readonly char kind;
        private readonly IoPoint[] points;
        private readonly string[] addresses;
        private readonly object snapGate = new object();
        private bool[] snapshot;
        private bool[] shown;
        private string error;
        private int page;
        private volatile bool pumping;

        public PageIoMonitor()
        {
            InitializeComponent();
            grid.Rows.Add(RowsPerPage);
            grid.ClearSelection();
            Disposed += delegate { pumping = false; refresh.Stop(); };
        }

        public PageIoMonitor(StationContext station, char kind) : this()
        {
            this.station = station;
            this.kind = kind;
            points = (kind == 'Q' ? station.Io.Outputs : station.Io.Inputs).ToArray();
            addresses = new string[points.Length];
            for (var i = 0; i < points.Length; i++) addresses[i] = points[i].Address;
            shown = new bool[points.Length];
            ApplyPage();
            StartPump();
            refresh.Enabled = true;
        }

        private int PageCount
        {
            get { return Math.Max(1, (points.Length + SlotsPerPage - 1) / SlotsPerPage); }
        }

        // ── 后台读 PLC ─────────────────────────────────────────────────────

        private void StartPump()
        {
            pumping = true;
            var thread = new Thread(PumpLoop);
            thread.IsBackground = true;
            thread.Name = kind == 'Q' ? "输出监控刷新" : "输入监控刷新";
            thread.Start();
        }

        private void PumpLoop()
        {
            while (pumping)
            {
                bool[] next = null;
                string message = null;
                try
                {
                    next = station.Plc.ReadBits(addresses);
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                lock (snapGate)
                {
                    snapshot = next;
                    error = message;
                }
                Thread.Sleep(PollMs);
            }
        }

        // ── 版面 ───────────────────────────────────────────────────────────

        /// <summary>把当前页的 30 个位置贴上地址和信号名；空位留白，不画假点。</summary>
        private void ApplyPage()
        {
            var first = page * SlotsPerPage;
            for (var row = 0; row < RowsPerPage; row++)
            {
                for (var side = 0; side < 2; side++)
                {
                    var index = first + side * RowsPerPage + row;
                    var dot = grid[side == 0 ? 0 : 2, row];
                    var name = grid[side == 0 ? 1 : 3, row];
                    if (index < points.Length)
                    {
                        var point = points[index];
                        dot.Value = "●";
                        PaintDot(dot, false);
                        dot.ToolTipText = point.Address;
                        name.Value = point.Address.Replace(" ", string.Empty) + "  " + ShortName(point.Name);
                        name.Style.ForeColor = NameColor;
                        name.Style.SelectionForeColor = NameColor;
                    }
                    else
                    {
                        dot.Value = string.Empty;
                        name.Value = string.Empty;
                    }
                }
            }
            for (var i = 0; i < shown.Length; i++) shown[i] = false;
            UpdatePager();
        }

        private static void PaintDot(DataGridViewCell dot, bool on)
        {
            var color = on ? OnColor : OffColor;
            dot.Style.ForeColor = color;
            dot.Style.SelectionForeColor = color;
        }

        private void UpdatePager()
        {
            btnPrevious.Enabled = page > 0;
            btnNext.Enabled = page + 1 < PageCount;
            pageLabel.ForeColor = QuietColor;
            pageLabel.Text = (kind == 'Q' ? "输出监控　" : "输入监控　")
                + points.Length + " 点　第 " + (page + 1) + " / " + PageCount + " 页";
        }

        /// <summary>"输入_压持1缸_原点" → "压持1缸_原点"：前缀在三列里已经由页签说明了。</summary>
        private static string ShortName(string name)
        {
            var text = name ?? string.Empty;
            if (text.StartsWith("输入_") || text.StartsWith("输出_")) return text.Substring(3);
            return text;
        }

        // ── 刷新与翻页 ─────────────────────────────────────────────────────

        private void refresh_Tick(object sender, EventArgs e)
        {
            bool[] frame;
            string err;
            lock (snapGate)
            {
                frame = snapshot;
                err = error;
            }
            if (err != null)
            {
                pageLabel.ForeColor = ErrorColor;
                pageLabel.Text = "读取失败：" + err;
                return;
            }
            if (frame == null) return;
            UpdatePager();
            var first = page * SlotsPerPage;
            for (var row = 0; row < RowsPerPage; row++)
            {
                for (var side = 0; side < 2; side++)
                {
                    var index = first + side * RowsPerPage + row;
                    if (index >= points.Length || index >= frame.Length) continue;
                    var on = frame[index];
                    if (shown[index] == on) continue;
                    shown[index] = on;
                    PaintDot(grid[side == 0 ? 0 : 2, row], on);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page == 0) return;
            page--;
            ApplyPage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page + 1 >= PageCount) return;
            page++;
            ApplyPage();
        }

        /// <summary>窗口缩到 1024×600 时 15 行放不下：按可用高度均分，不让最后几行被裁掉。</summary>
        private void grid_Resize(object sender, EventArgs e)
        {
            if (points == null || grid.Rows.Count == 0) return;
            var height = Math.Max(24, (grid.ClientSize.Height - 2) / RowsPerPage);
            if (grid.Rows[0].Height == height) return;
            grid.RowTemplate.Height = height;
            foreach (DataGridViewRow row in grid.Rows) row.Height = height;
        }
    }
}
