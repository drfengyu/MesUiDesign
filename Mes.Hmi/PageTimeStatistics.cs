using Mes.Business;
using Mes.Common;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 时间统计（《Automation UI V3.11》P16/P17）：列表页是白班/晚班两张按小时拆分的
    /// 运行/待机/计划停机/异常时间表，右侧实时显示最近 10 片 CT 和平均 CT；
    /// 图形页是 24 小时堆叠柱。时间来自 Uptime 台账，CT 来自追溯表的 CT 列。
    /// 待机（待料/闲置）本机没有信号，列保留但恒为 0，不拿运行时间去凑。
    /// </summary>
    public partial class PageTimeStatistics : UserControl
    {
        private static readonly Color SummaryBack = Color.FromArgb(240, 242, 245);
        private static readonly Font SummaryFont = new Font("微软雅黑", 9.5F, FontStyle.Bold);

        private readonly StationContext station;
        private TimeStatisticsReport report;
        private double[] recentCt = new double[0];
        private string viewKey = string.Empty;
        private bool syncing;

        public PageTimeStatistics()
        {
            InitializeComponent();
        }

        public PageTimeStatistics(StationContext station) : this()
        {
            this.station = station;
            ChartKit.StylePlot(plotTime);
            ChartKit.Empty(plotTime, "暂无数据");
            // 文档 P17 的标题是蓝字、Y 轴每 2 分钟一格；StylePlot 统一成了深灰 9 号，
            // 这一页照文档改回来。
            plotTime.Titles[0].Font = new Font("微软雅黑", 12F, FontStyle.Bold);
            plotTime.Titles[0].ForeColor = Color.FromArgb(30, 70, 140);
            plotTime.ChartAreas[0].AxisX.LabelStyle.Font = new Font("微软雅黑", 8F);
            plotTime.ChartAreas[0].AxisY.LabelStyle.Font = new Font("微软雅黑", 8F);

            var now = DateTime.Now;
            var shiftDay = now.Hour >= 8 ? now.Date : now.Date.AddDays(-1);
            syncing = true;
            dateStart.Value = shiftDay;
            dateEnd.Value = shiftDay;
            fromPicker.Value = shiftDay.AddHours(8);
            toPicker.Value = shiftDay.AddDays(1).AddHours(8);
            syncing = false;

            gridDay.Resize += grid_Resize;
            gridNight.Resize += grid_Resize;
            gridCt.Resize += grid_Resize;
            refresh.Enabled = true;
            Query();
        }

        // ── 查询与计算 ─────────────────────────────────────────────────────

        private void refresh_Tick(object sender, EventArgs e)
        {
            if (station == null || !autoRefresh.Checked) return;
            Query();
        }

        /// <summary>
        /// 台账和追溯表都不大，3 秒重算一次；只有分钟数或 CT 真的变了才重填，
        /// 避免每 3 秒整表闪一下。故障记录还没结束时按"到当前时刻"算，数字会自己涨。
        /// </summary>
        private void Query()
        {
            if (station == null) return;
            var from = fromPicker.Value;
            var to = toPicker.Value;
            if (to <= from)
            {
                station.Say("结束时间必须晚于开始时间，请重新选择");
                return;
            }

            report = TimeStatisticsReport.Build(station.Uptime.All(), from, to, DateTime.Now);
            recentCt = TimeStatisticsReport.RecentCt(station.ProductLog, from, to, 10);

            var key = ViewKey();
            if (key == viewKey) return;
            viewKey = key;
            FillList();
            if (!radioList.Checked) PaintChart();
        }

        private string ViewKey()
        {
            if (report == null) return string.Empty;
            var sb = new StringBuilder();
            sb.Append(fromPicker.Value.Ticks).Append('|').Append(toPicker.Value.Ticks).Append('|');
            foreach (var cell in report.Hours)
            {
                sb.Append(cell.Span.ToString("0.###", CultureInfo.InvariantCulture)).Append(',')
                    .Append(cell.Run.ToString("0.###", CultureInfo.InvariantCulture)).Append(',')
                    .Append(cell.Idle.ToString("0.###", CultureInfo.InvariantCulture)).Append(',')
                    .Append(cell.Planned.ToString("0.###", CultureInfo.InvariantCulture)).Append(',')
                    .Append(cell.Fault.ToString("0.###", CultureInfo.InvariantCulture)).Append(';');
            }
            foreach (var ct in recentCt) sb.Append(ct.ToString("0.###", CultureInfo.InvariantCulture)).Append(',');
            return sb.ToString();
        }

        // ── 列表 ───────────────────────────────────────────────────────────

        private void FillList()
        {
            FillShift(gridDay, 0);
            FillShift(gridNight, 12);
            FillCt();
            FitRows();
        }

        /// <summary>一张班次表：12 个整点格子 + 合计 + 时间移动，和文档 P16 的行结构一致。</summary>
        private void FillShift(DataGridView grid, int start)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            double run = 0, idle = 0, planned = 0, fault = 0, span = 0;
            for (var i = start; i < start + 12; i++)
            {
                var cell = report.Hours[i];
                var valid = cell.Span > 0.0001;
                grid.Rows.Add(HourRange(cell.Hour),
                    Minutes(cell.Run, valid), Minutes(cell.Idle, valid),
                    Minutes(cell.Planned, valid), Minutes(cell.Fault, valid));
                run += cell.Run;
                idle += cell.Idle;
                planned += cell.Planned;
                fault += cell.Fault;
                span += cell.Span;
            }
            var hasSpan = span > 0.0001;
            MarkSummary(grid.Rows[grid.Rows.Add("合计",
                Minutes(run, hasSpan), Minutes(idle, hasSpan),
                Minutes(planned, hasSpan), Minutes(fault, hasSpan))]);
            MarkSummary(grid.Rows[grid.Rows.Add("时间移动", MovementText(run, span), string.Empty, string.Empty, string.Empty)]);
            grid.ClearSelection();
            grid.ResumeLayout();
        }

        /// <summary>右侧 CT 面板：最近 10 片，按先后顺序；不足 10 片时剩下的行填 "—"。</summary>
        private void FillCt()
        {
            gridCt.SuspendLayout();
            gridCt.Rows.Clear();
            for (var i = 0; i < 10; i++)
            {
                var value = i < recentCt.Length
                    ? recentCt[i].ToString("0.000", CultureInfo.InvariantCulture)
                    : "—";
                gridCt.Rows.Add("第" + (i + 1) + "片物料CT", value);
            }
            MarkSummary(gridCt.Rows[gridCt.Rows.Add("平均CT", AverageCtText())]);
            gridCt.ClearSelection();
            gridCt.ResumeLayout();
        }

        private string AverageCtText()
        {
            if (recentCt.Length == 0) return "—";
            double sum = 0;
            foreach (var ct in recentCt) sum += ct;
            return (sum / recentCt.Length).ToString("0.000", CultureInfo.InvariantCulture);
        }

        private static string Minutes(double minutes, bool valid)
        {
            return valid ? minutes.ToString("0.00", CultureInfo.InvariantCulture) : "—";
        }

        private static string MovementText(double run, double span)
        {
            if (span <= 0.0001) return "—";
            return (run * 100D / span).ToString("0.00", CultureInfo.InvariantCulture) + "%";
        }

        private static DataGridViewRow MarkSummary(DataGridViewRow row)
        {
            row.DefaultCellStyle.BackColor = SummaryBack;
            row.DefaultCellStyle.Font = SummaryFont;
            return row;
        }

        private static string HourRange(int hour)
        {
            return hour.ToString("00", CultureInfo.InvariantCulture) + ":00-"
                + ((hour + 1) % 24).ToString("00", CultureInfo.InvariantCulture) + ":00";
        }

        private void grid_Resize(object sender, EventArgs e)
        {
            FitRows();
        }

        /// <summary>两张班次表 14 行、CT 表 11 行，各自按可用高度均分，铺满不留滚动条。</summary>
        private void FitRows()
        {
            if (report == null) return;
            FitRows(gridDay);
            FitRows(gridNight);
            FitRows(gridCt);
        }

        private static void FitRows(DataGridView grid)
        {
            if (grid.Rows.Count == 0) return;
            var header = grid.ColumnHeadersVisible ? grid.ColumnHeadersHeight : 0;
            var height = Math.Max(22, (grid.ClientSize.Height - header - 2) / grid.Rows.Count);
            if (grid.Rows[0].Height == height) return;
            foreach (DataGridViewRow row in grid.Rows) row.Height = height;
        }

        // ── 图形 ───────────────────────────────────────────────────────────

        private void PaintChart()
        {
            if (report == null) return;
            if (report.TotalSpan <= 0.0001)
            {
                ChartKit.Empty(plotTime, "所选区间还没有时间记录");
                return;
            }

            var labels = new string[report.Hours.Count];
            var run = new double[labels.Length];
            var idle = new double[labels.Length];
            var planned = new double[labels.Length];
            var fault = new double[labels.Length];
            for (var i = 0; i < labels.Length; i++)
            {
                var cell = report.Hours[i];
                labels[i] = HourRange(cell.Hour);
                run[i] = cell.Run;
                idle[i] = cell.Idle;
                planned[i] = cell.Planned;
                fault[i] = cell.Fault;
            }
            // 前四个是图例占位序列（无数据点），后四个才是柱子；堆叠顺序仍是 运行→待机→计划→异常。
            ChartKit.Fill(plotTime, labels, new double[][] { null, null, null, null, run, idle, planned, fault }, 1);
            var area = plotTime.ChartAreas[0];
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 60;
            area.AxisY.Interval = 2;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (station == null) return;
            var list = radioList.Checked;
            listPanel.Visible = list;
            chartPanel.Visible = !list;
            if (!list) PaintChart();
        }

        // ── 查询条 ─────────────────────────────────────────────────────────

        private void fromPicker_ValueChanged(object sender, EventArgs e)
        {
            if (syncing || station == null) return;
            Query();
        }

        private void toPicker_ValueChanged(object sender, EventArgs e)
        {
            if (syncing || station == null) return;
            Query();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {
            if (syncing || station == null) return;
            var day = dateStart.Value.Date;
            var last = dateEnd.Value.Date;
            if (last < day) last = day;
            syncing = true;
            fromPicker.Value = day.AddHours(8);
            toPicker.Value = last.AddDays(1).AddHours(8);
            syncing = false;
            Query();
        }

        // ── 导出 ───────────────────────────────────────────────────────────

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (station == null || report == null) return;
            var sb = new StringBuilder();
            sb.AppendLine("时间统计");
            sb.AppendLine("开始," + fromPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine("结束," + toPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine();
            sb.AppendLine("班次,时间段,运行时间,待机时间,计划停机,异常时间");
            ExportShift(sb, "白班", 0);
            ExportShift(sb, "晚班", 12);
            sb.AppendLine();
            sb.AppendLine("最近10片物料CT");
            for (var i = 0; i < 10; i++)
            {
                var value = i < recentCt.Length
                    ? recentCt[i].ToString("0.000", CultureInfo.InvariantCulture)
                    : "—";
                sb.AppendLine("第" + (i + 1) + "片物料CT," + value);
            }
            sb.AppendLine("平均CT," + AverageCtText());

            var path = Path.Combine(station.RecordFolder, "导出",
                "时间统计 " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".csv");
            if (!TextFile.WriteAllText(path, sb.ToString(), CodePages.Utf8WithBom()))
            {
                station.Say("导出失败：" + path);
                return;
            }
            station.Log.Write(station.User, "导出时间统计", report.TotalSpan.ToString("0", CultureInfo.InvariantCulture), string.Empty, path);
            station.Say("已导出时间统计到 " + path);
        }

        private void ExportShift(StringBuilder sb, string shift, int start)
        {
            double run = 0, idle = 0, planned = 0, fault = 0, span = 0;
            for (var i = start; i < start + 12; i++)
            {
                var cell = report.Hours[i];
                var valid = cell.Span > 0.0001;
                sb.AppendLine(shift + "," + HourRange(cell.Hour) + ","
                    + Minutes(cell.Run, valid) + "," + Minutes(cell.Idle, valid) + ","
                    + Minutes(cell.Planned, valid) + "," + Minutes(cell.Fault, valid));
                run += cell.Run;
                idle += cell.Idle;
                planned += cell.Planned;
                fault += cell.Fault;
                span += cell.Span;
            }
            var hasSpan = span > 0.0001;
            sb.AppendLine(shift + ",合计," + Minutes(run, hasSpan) + "," + Minutes(idle, hasSpan) + ","
                + Minutes(planned, hasSpan) + "," + Minutes(fault, hasSpan));
            sb.AppendLine(shift + ",时间移动," + MovementText(run, span) + ",,,");
        }
    }
}
