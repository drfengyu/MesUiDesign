using Mes.Business;
using Mes.Common;
using Mes.Data;
using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 产能统计（《Automation UI V3.11》P12/P13）：上排是查询条（列表/图形、起止时间、生产模式、自动刷新），
    /// 下面是 24 个整点格子按白班/晚班拆成两张表，或用 UPH 堆积柱 + 目标线看分布。
    ///
    /// 口径照文档：产出 = OK + NG（还在机台上的那片不算产出），良率 = (产出 - NG) ÷ 产出；
    /// 产能移动 = 本班产出相对前一日的同班产出。
    /// 非生产模式（调机/空跑）在追溯表里没有记录来源，所以表格填 "—"、产能移动固定 NA，
    /// 不拿生产记录去冒充。
    /// </summary>
    public partial class PageThroughput : UserControl
    {
        private static readonly Color NgText = Color.FromArgb(200, 40, 40);
        private static readonly Color SummaryBack = Color.FromArgb(240, 242, 245);
        private static readonly Font SummaryFont = new Font("微软雅黑", 9.5F, FontStyle.Bold);

        private readonly StationContext station;
        private ThroughputReport report;
        private string gridKey = string.Empty;
        private bool syncing;
        private bool nonProduction;
        private int dayOutput;
        private int nightOutput;
        private string dayMove = "NA";
        private string nightMove = "NA";

        public PageThroughput()
        {
            InitializeComponent();
        }

        public PageThroughput(StationContext station) : this()
        {
            this.station = station;
            ChartKit.StylePlot(plotUph);
            ChartKit.Empty(plotUph, "暂无数据");

            var now = DateTime.Now;
            var shiftDay = now.Hour >= 8 ? now.Date : now.Date.AddDays(-1);
            syncing = true;
            dateStart.Value = shiftDay;
            dateEnd.Value = shiftDay;
            fromPicker.Value = shiftDay.AddHours(8);
            toPicker.Value = shiftDay.AddDays(1).AddHours(8);
            syncing = false;

            modeCombo.SelectedIndex = 0;
            gridDay.Resize += grid_Resize;
            gridNight.Resize += grid_Resize;
            refresh.Enabled = true;
            Query();
        }

        // ── 查询与计算 ─────────────────────────────────────────────────────

        /// <summary>
        /// 每 3 秒自动刷一次。统计直接从追溯表扫（ScanBetween 不复制行），
        /// 只有数字真的变了才重填表格和重画图，避免整表闪。
        /// </summary>
        private void refresh_Tick(object sender, EventArgs e)
        {
            if (station == null || !autoRefresh.Checked) return;
            Query();
        }

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

            nonProduction = modeCombo.SelectedIndex == 1;
            report = ThroughputReport.Build(station.ProductLog, from, to, station.Targets.TargetUph);
            dayOutput = ShiftOutput(0);
            nightOutput = ShiftOutput(12);
            if (nonProduction)
            {
                dayMove = "NA";
                nightMove = "NA";
            }
            else
            {
                int prevDay, prevNight;
                PreviousOutput(from, to, out prevDay, out prevNight);
                dayMove = MoveText(dayOutput, prevDay);
                nightMove = MoveText(nightOutput, prevNight);
            }

            var key = from.Ticks + "|" + to.Ticks + "|" + modeCombo.SelectedIndex + "|"
                + report.TotalInput + "|" + report.TotalCompleted + "|" + report.TotalPassed + "|" + report.TotalNg
                + "|" + dayMove + "|" + nightMove;
            if (key == gridKey) return;
            gridKey = key;
            noteLabel.Visible = nonProduction;
            listHost.RowStyles[0].Height = nonProduction ? 30F : 0F;
            FillList();
            PaintChart();
        }

        /// <summary>12 个格子的产出合计；start=0 是白班（08~19），12 是晚班（20~07）。</summary>
        private int ShiftOutput(int start)
        {
            var sum = 0;
            for (var i = start; i < start + 12; i++)
            {
                sum += report.Hours[i].Passed + report.Hours[i].Ng;
            }
            return sum;
        }

        /// <summary>
        /// 前一日同时段的白/晚班产出，给"产能移动"做分母。
        /// 一次扫完两个班，别为了两个数把前一天的表扫两遍。
        /// </summary>
        private void PreviousOutput(DateTime from, DateTime to, out int day, out int night)
        {
            var dayCount = 0;
            var nightCount = 0;
            station.ProductLog.ScanBetween(from.AddDays(-1), to.AddDays(-1), row =>
            {
                DateTime at;
                if (!DateTime.TryParse(row.Get("生产时间"), out at)) return;
                var verdict = row.Get("结果");
                if (verdict != "OK" && !verdict.EndsWith("NG")) return;
                if (at.Hour >= 8 && at.Hour < 20) dayCount++;
                else nightCount++;
            });
            day = dayCount;
            night = nightCount;
        }

        private static string MoveText(int current, int previous)
        {
            if (previous <= 0) return "NA";
            var move = (current - previous) * 100D / previous;
            return move.ToString("0.00", CultureInfo.InvariantCulture) + "%";
        }

        // ── 列表 ───────────────────────────────────────────────────────────

        private void FillList()
        {
            FillShift(gridDay, 0, "白班产能", "产能移动", dayMove);
            FillShift(gridNight, 12, "晚班产能", "产能移动", nightMove);
            FitRows();
        }

        private void FillShift(DataGridView grid, int start, string totalLabel, string moveLabel, string movement)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            var output = 0;
            var ng = 0;
            for (var i = start; i < start + 12; i++)
            {
                var cell = report.Hours[i];
                var label = HourLabel(cell.Hour);
                if (nonProduction)
                {
                    grid.Rows.Add(label, "—", "—", "—");
                    continue;
                }
                var produced = cell.Passed + cell.Ng;
                output += produced;
                ng += cell.Ng;
                var index = grid.Rows.Add(label,
                    produced.ToString(CultureInfo.InvariantCulture),
                    cell.Ng.ToString(CultureInfo.InvariantCulture),
                    RateText(produced, cell.Ng));
                if (cell.Ng > 0) grid.Rows[index].Cells[2].Style.ForeColor = NgText;
            }

            if (nonProduction)
            {
                MarkSummary(grid.Rows[grid.Rows.Add(totalLabel, "—", "—", "—")]);
                MarkSummary(grid.Rows[grid.Rows.Add(moveLabel, movement, string.Empty, string.Empty)]);
            }
            else
            {
                var total = MarkSummary(grid.Rows[grid.Rows.Add(totalLabel,
                    output.ToString(CultureInfo.InvariantCulture),
                    ng.ToString(CultureInfo.InvariantCulture),
                    RateText(output, ng))]);
                if (ng > 0) total.Cells[2].Style.ForeColor = NgText;
                MarkSummary(grid.Rows[grid.Rows.Add(moveLabel, movement, string.Empty, string.Empty)]);
            }
            grid.ClearSelection();
            grid.ResumeLayout();
        }

        private static DataGridViewRow MarkSummary(DataGridViewRow row)
        {
            row.DefaultCellStyle.BackColor = SummaryBack;
            row.DefaultCellStyle.Font = SummaryFont;
            return row;
        }

        /// <summary>行高按可用高度均分，14 行正好铺满，不留一条空白也不出滚动条。</summary>
        private void grid_Resize(object sender, EventArgs e)
        {
            FitRows();
        }

        private void FitRows()
        {
            if (report == null || gridDay.Rows.Count == 0) return;
            var height = Math.Max(24, (gridDay.ClientSize.Height - gridDay.ColumnHeadersHeight - 2) / gridDay.Rows.Count);
            if (gridDay.Rows[0].Height == height) return;
            foreach (DataGridViewRow row in gridDay.Rows) row.Height = height;
            foreach (DataGridViewRow row in gridNight.Rows) row.Height = height;
        }

        private static string HourLabel(int hour)
        {
            return hour.ToString("00", CultureInfo.InvariantCulture) + ":00-"
                + ((hour + 1) % 24).ToString("00", CultureInfo.InvariantCulture) + ":00";
        }

        private static string RateText(int produced, int ng)
        {
            var rate = produced == 0 ? 100D : (produced - ng) * 100D / produced;
            return rate.ToString("0.00", CultureInfo.InvariantCulture) + "%";
        }

        // ── 图形 ───────────────────────────────────────────────────────────

        private void PaintChart()
        {
            if (report == null) return;
            if (nonProduction)
            {
                ChartKit.Empty(plotUph, "非生产模式（调机/空跑）没有记录来源，无法统计");
                return;
            }
            var labels = new string[report.Hours.Count];
            var ok = new double[labels.Length];
            var ng = new double[labels.Length];
            var target = new double[labels.Length];
            for (var i = 0; i < labels.Length; i++)
            {
                labels[i] = HourLabel(report.Hours[i].Hour);
                ok[i] = report.Hours[i].Passed;
                ng[i] = report.Hours[i].Ng;
                target[i] = report.TargetUph;
            }
            ChartKit.Fill(plotUph, labels, new[] { target, ng, ok }, 1);
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (station == null) return;
            var list = radioList.Checked;
            listHost.Visible = list;
            plotUph.Visible = !list;
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

        private void modeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (station == null) return;
            Query();
        }

        // ── 导出 ───────────────────────────────────────────────────────────

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (station == null || report == null) return;
            var sb = new StringBuilder();
            sb.AppendLine("产能统计");
            sb.AppendLine("模式," + (nonProduction ? "非生产模式" : "生产模式"));
            sb.AppendLine("开始," + fromPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine("结束," + toPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine("目标UPH," + station.Targets.TargetUph.ToString("0.#", CultureInfo.InvariantCulture));
            sb.AppendLine();
            sb.AppendLine("班次,时段,产出,NG数量,良率");
            ExportShift(sb, "白班", 0, "白班产能", dayMove);
            ExportShift(sb, "晚班", 12, "晚班产能", nightMove);

            var path = Path.Combine(station.RecordFolder, "导出",
                "产能统计 " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".csv");
            if (!TextFile.WriteAllText(path, sb.ToString(), CodePages.Utf8WithBom()))
            {
                station.Say("导出失败：" + path);
                return;
            }
            station.Log.Write(station.User, "导出产能统计",
                (dayOutput + nightOutput).ToString(CultureInfo.InvariantCulture), string.Empty, path);
            station.Say("已导出产能统计到 " + path);
        }

        private void ExportShift(StringBuilder sb, string shift, int start, string totalLabel, string movement)
        {
            var output = 0;
            var ng = 0;
            for (var i = start; i < start + 12; i++)
            {
                var cell = report.Hours[i];
                if (nonProduction)
                {
                    sb.AppendLine(shift + "," + HourLabel(cell.Hour) + ",—,—,—");
                    continue;
                }
                var produced = cell.Passed + cell.Ng;
                output += produced;
                ng += cell.Ng;
                sb.AppendLine(shift + "," + HourLabel(cell.Hour) + ","
                    + produced.ToString(CultureInfo.InvariantCulture) + ","
                    + cell.Ng.ToString(CultureInfo.InvariantCulture) + "," + RateText(produced, cell.Ng));
            }
            if (nonProduction)
            {
                sb.AppendLine(totalLabel + ",合计,—,—,—");
            }
            else
            {
                sb.AppendLine(totalLabel + ",合计," + output.ToString(CultureInfo.InvariantCulture) + ","
                    + ng.ToString(CultureInfo.InvariantCulture) + "," + RateText(output, ng));
            }
            sb.AppendLine("产能移动,," + movement);
        }
    }
}
