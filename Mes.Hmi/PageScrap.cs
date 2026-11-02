using Mes.Business;
using Mes.Common;
using Mes.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mes.Hmi
{
    /// <summary>
    /// 抛料统计（《Automation UI V3.11》P14/P15）：主件/辅料两个页签，各自一张白班 + 一张晚班表；
    /// 图形页是 24 小时堆积柱（OK 青 + NG 橙）配次轴的抛料率折线，点某一根柱子，
    /// 下面两张图就切成那个小时的抛料项目和分类占比。
    ///
    /// 表里的分组照文档：1st Pass Yield（焊接过程 NG）和 PF（来料/上传类）。
    /// 归类不另记原因，拿八列测量值和判定上下限重算（见 ScrapReport），
    /// PF 那几项现场没有独立的计数来源，所以数量就是 0，不编数字。
    /// </summary>
    public partial class PageScrap : UserControl
    {
        private const string NonProductionNote = "非生产模式（调机/空跑）没有记录来源，无法统计";
        private const string AuxNote = "辅料抛料计数来源未接入，表中数量为 0";

        private static readonly Color GroupBack = Color.FromArgb(25, 118, 210);
        private static readonly Color GroupFore = Color.White;
        private static readonly Color SummaryBack = Color.FromArgb(240, 242, 245);
        private static readonly Color TabBack = Color.FromArgb(240, 242, 245);
        private static readonly Color TabFore = Color.FromArgb(90, 96, 105);
        private static readonly Color TabActiveFore = Color.FromArgb(0, 120, 60);
        private static readonly Font SummaryFont = new Font("微软雅黑", 9.5F, FontStyle.Bold);
        private static readonly Color[] Palette =
        {
            Color.FromArgb(220, 60, 60),
            Color.FromArgb(0, 160, 80),
            Color.FromArgb(30, 120, 210),
            Color.FromArgb(240, 160, 30),
            Color.FromArgb(130, 90, 200),
            Color.FromArgb(0, 170, 170),
            Color.FromArgb(150, 156, 164),
        };

        private readonly StationContext station;
        private ScrapReport report;
        private bool syncing;
        private bool nonProduction;
        private bool mainPart = true;
        private int selectedHour;
        private string viewKey = string.Empty;

        public PageScrap()
        {
            InitializeComponent();
        }

        public PageScrap(StationContext station) : this()
        {
            this.station = station;
            ChartKit.StylePlot(plotTrend);
            ChartKit.StylePlot(plotItem);
            ChartKit.StylePlot(plotPie);
            ChartKit.Empty(plotTrend, "暂无数据");
            ChartKit.Empty(plotItem, "暂无数据");
            ChartKit.Empty(plotPie, "暂无数据");
            UpdateTabs();

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

        private void refresh_Tick(object sender, EventArgs e)
        {
            if (station == null || !autoRefresh.Checked) return;
            Query();
        }

        /// <summary>
        /// 统计直接从追溯表扫（ScanBetween 不复制行），3 秒一次；
        /// 只有时间、模式、页签或数字变了才重填，避免整表每 3 秒闪一下。
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

            nonProduction = modeCombo.SelectedIndex == 1;
            report = ScrapReport.Build(station.ProductLog, station.Limits, from, to);
            if (selectedHour < 0 || selectedHour >= report.Hours.Count) selectedHour = DefaultHour();

            var key = ViewKey();
            if (key == viewKey) return;
            viewKey = key;
            UpdateNote();
            FillList();
            PaintTrend();
            PaintDetail();
        }

        private string ViewKey()
        {
            if (report == null) return string.Empty;
            var sb = new StringBuilder();
            sb.Append(fromPicker.Value.Ticks).Append('|').Append(toPicker.Value.Ticks)
                .Append('|').Append(modeCombo.SelectedIndex).Append('|').Append(mainPart ? 1 : 0).Append('|');
            foreach (var shift in new[] { report.Day, report.Night })
            {
                sb.Append(shift.Input).Append(',').Append(shift.Passed).Append(',').Append(shift.Ng).Append(',');
                foreach (var item in shift.YieldItems) sb.Append(item.Count).Append(',');
                foreach (var item in shift.PfItems) sb.Append(item.Count).Append(',');
            }
            foreach (var cell in report.Hours)
            {
                sb.Append(cell.Input).Append(',').Append(cell.Passed).Append(',').Append(cell.Ng).Append(',');
                foreach (var pair in cell.ByItem) sb.Append(pair.Key).Append('=').Append(pair.Value).Append(',');
            }
            return sb.ToString();
        }

        /// <summary>默认选中抛料最多的那一小时，和文档里点 09:00-10:00 的样子一致。</summary>
        private int DefaultHour()
        {
            var best = 0;
            var bestCount = -1;
            for (var i = 0; i < report.Hours.Count; i++)
            {
                var count = GroupCount(report.Hours[i], mainPart);
                if (count > bestCount)
                {
                    bestCount = count;
                    best = i;
                }
            }
            return best;
        }

        /// <summary>该小时里属于当前页签的 NG 数。归属规则和 ScrapReport.Add 一致：未知项算主件。</summary>
        private static int GroupCount(HourlyScrap cell, bool mainPart)
        {
            var sum = 0;
            foreach (var pair in cell.ByItem)
            {
                if (InGroup(pair.Key, mainPart)) sum += pair.Value;
            }
            return sum;
        }

        private static bool InGroup(string name, bool mainPart)
        {
            if (!mainPart) return IsKnown(ScrapReport.PfNgNames, name);
            if (IsKnown(ScrapReport.PfNgNames, name)) return false;
            return true;
        }

        private static bool IsKnown(string[] names, string name)
        {
            foreach (var known in names)
            {
                if (known == name) return true;
            }
            return false;
        }

        // ── 列表 ───────────────────────────────────────────────────────────

        private void FillList()
        {
            FillShift(gridDay, report.Day);
            FillShift(gridNight, report.Night);
            FitRows();
        }

        /// <summary>
        /// 两个页签保持同一张表的结构（投入数量 + 两个分组），
        /// 页签只决定哪一组带数字；另一组照文档填 0，不把两边的账混在一起。
        /// </summary>
        private void FillShift(DataGridView grid, ScrapShift shift)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            grid.Rows.Add("投入数量", nonProduction ? "—" : shift.Input.ToString(CultureInfo.InvariantCulture),
                nonProduction ? "—" : string.Empty);
            MarkSummary(grid.Rows[0]);

            MarkGroup(grid.Rows[grid.Rows.Add(ScrapReport.PassYieldGroup, string.Empty, string.Empty)]);
            foreach (var item in shift.YieldItems)
            {
                AddItem(grid, item, shift, mainPart);
            }

            MarkGroup(grid.Rows[grid.Rows.Add(ScrapReport.PfGroup, string.Empty, string.Empty)]);
            foreach (var item in shift.PfItems)
            {
                AddItem(grid, item, shift, !mainPart);
            }
            grid.ClearSelection();
            grid.ResumeLayout();
        }

        private void AddItem(DataGridView grid, ScrapItem item, ScrapShift shift, bool counted)
        {
            if (nonProduction)
            {
                grid.Rows.Add(item.Name, "—", "—");
                return;
            }
            var count = counted ? item.Count : 0;
            grid.Rows.Add(item.Name, count.ToString(CultureInfo.InvariantCulture), PercentText(count, shift.Input));
        }

        private static DataGridViewRow MarkSummary(DataGridViewRow row)
        {
            row.DefaultCellStyle.BackColor = SummaryBack;
            row.DefaultCellStyle.Font = SummaryFont;
            return row;
        }

        private static DataGridViewRow MarkGroup(DataGridViewRow row)
        {
            row.DefaultCellStyle.BackColor = GroupBack;
            row.DefaultCellStyle.ForeColor = GroupFore;
            row.DefaultCellStyle.Font = SummaryFont;
            return row;
        }

        private static string PercentText(int count, int input)
        {
            return (input == 0 ? 0 : count * 100D / input).ToString("0.00", CultureInfo.InvariantCulture) + "%";
        }

        private void grid_Resize(object sender, EventArgs e)
        {
            FitRows();
        }

        /// <summary>12 行（投入数量 + 两个分组头 + 9 项）按可用高度均分，铺满不留滚动条。</summary>
        private void FitRows()
        {
            if (report == null || gridDay.Rows.Count == 0) return;
            var height = Math.Max(24, (gridDay.ClientSize.Height - gridDay.ColumnHeadersHeight - 2) / gridDay.Rows.Count);
            if (gridDay.Rows[0].Height == height) return;
            foreach (DataGridViewRow row in gridDay.Rows) row.Height = height;
            foreach (DataGridViewRow row in gridNight.Rows) row.Height = height;
        }

        private static string HourRange(int hour)
        {
            return hour.ToString("00", CultureInfo.InvariantCulture) + ":00-"
                + ((hour + 1) % 24).ToString("00", CultureInfo.InvariantCulture) + ":00";
        }

        // ── 图形 ───────────────────────────────────────────────────────────

        private void PaintTrend()
        {
            if (report == null) return;
            if (nonProduction)
            {
                ChartKit.Empty(plotTrend, NonProductionNote);
                return;
            }

            var labels = new string[report.Hours.Count];
            var ok = new double[labels.Length];
            var ng = new double[labels.Length];
            var rate = new double[labels.Length];
            var top = 0D;
            var maxRate = 0D;
            for (var i = 0; i < labels.Length; i++)
            {
                var cell = report.Hours[i];
                labels[i] = HourRange(cell.Hour);
                ok[i] = cell.Passed;
                ng[i] = GroupCount(cell, mainPart);
                rate[i] = cell.Input == 0 ? 0 : ng[i] * 100D / cell.Input;
                top = Math.Max(top, ok[i] + ng[i]);
                maxRate = Math.Max(maxRate, rate[i]);
            }
            // 前三个是图例占位序列（无数据点，只负责图例文字和色块），后三个才是画出来的系列。
            ChartKit.Fill(plotTrend, labels, new double[][] { null, null, null, ok, ng, rate }, 1);

            var area = plotTrend.ChartAreas[0];
            area.AxisY.Maximum = Math.Max(160, Math.Ceiling(top / 40D) * 40D);
            area.AxisY.Interval = 10;
            area.AxisY2.Minimum = 0;
            var step = maxRate <= 3.6D ? 0.2D : maxRate <= 7.2D ? 0.4D : Math.Ceiling(maxRate / 8D * 10D) / 10D;
            area.AxisY2.Maximum = Math.Max(3.2D, Math.Ceiling(maxRate * 1.05D / step) * step);
            area.AxisY2.Interval = step;
        }

        /// <summary>点趋势图上的柱子/点，下面两张图切到那一小时；点空白处不响应。</summary>
        private void plotTrend_MouseClick(object sender, MouseEventArgs e)
        {
            if (report == null || nonProduction) return;
            var hit = plotTrend.HitTest(e.X, e.Y);
            if (hit.ChartElementType != ChartElementType.DataPoint
                && hit.ChartElementType != ChartElementType.DataPointLabel) return;
            if (hit.PointIndex < 0 || hit.PointIndex >= report.Hours.Count) return;
            if (hit.PointIndex == selectedHour) return;
            selectedHour = hit.PointIndex;
            PaintDetail();
        }

        private void PaintDetail()
        {
            if (report == null || report.Hours.Count == 0) return;
            var cell = report.Hours[Math.Max(0, Math.Min(report.Hours.Count - 1, selectedHour))];
            var range = HourRange(cell.Hour);
            plotItem.Titles[0].Text = range + "_Tossing Item";
            if (nonProduction)
            {
                ChartKit.Empty(plotItem, "非生产模式无抛料数据");
                ChartKit.Empty(plotPie, "非生产模式无抛料数据");
                return;
            }

            var items = mainPart ? report.Day.YieldItems : report.Day.PfItems;
            var names = new List<string>();
            var counts = new List<double>();
            var colors = new List<Color>();
            for (var i = 0; i < items.Count; i++)
            {
                int count;
                cell.ByItem.TryGetValue(items[i].Name, out count);
                if (count <= 0) continue;
                names.Add(items[i].Name);
                counts.Add(count);
                colors.Add(Palette[i % Palette.Length]);
            }

            if (names.Count == 0)
            {
                ChartKit.Empty(plotItem, range + " 无抛料");
                ChartKit.Empty(plotPie, range + " 无抛料");
                return;
            }

            ChartKit.Fill(plotItem, names.ToArray(), new[] { counts.ToArray() }, 1);
            var barArea = plotItem.ChartAreas[0];
            var peak = 0D;
            foreach (var count in counts) peak = Math.Max(peak, count);
            barArea.AxisY.Minimum = 0;
            barArea.AxisY.Maximum = Math.Max(3D, peak + 1D);
            barArea.AxisY.Interval = Math.Max(1D, Math.Ceiling(barArea.AxisY.Maximum / 6D));
            var bar = plotItem.Series[0];
            for (var i = 0; i < bar.Points.Count && i < colors.Count; i++) bar.Points[i].Color = colors[i];

            var pieLabels = new string[names.Count];
            for (var i = 0; i < names.Count; i++)
            {
                pieLabels[i] = names[i] + " " + counts[i].ToString("0", CultureInfo.InvariantCulture);
            }
            ChartKit.Fill(plotPie, pieLabels, new[] { counts.ToArray() }, 1);
            var pie = plotPie.Series[0];
            for (var i = 0; i < pie.Points.Count && i < colors.Count; i++) pie.Points[i].Color = colors[i];
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (station == null) return;
            var list = radioList.Checked;
            listPanel.Visible = list;
            chartPanel.Visible = !list;
            if (list) return;
            PaintTrend();
            PaintDetail();
        }

        // ── 主件 / 辅料 ────────────────────────────────────────────────────

        private void btnMain_Click(object sender, EventArgs e)
        {
            SetPart(true);
        }

        private void btnAux_Click(object sender, EventArgs e)
        {
            SetPart(false);
        }

        private void SetPart(bool part)
        {
            if (mainPart == part) return;
            mainPart = part;
            UpdateTabs();
            UpdateNote();
            if (station == null || report == null) return;
            selectedHour = DefaultHour();
            FillList();
            PaintTrend();
            PaintDetail();
            viewKey = ViewKey();
        }

        private void UpdateNote()
        {
            tabNote.Text = nonProduction ? NonProductionNote : (mainPart ? string.Empty : AuxNote);
        }

        private void UpdateTabs()
        {
            btnMain.BackColor = mainPart ? Color.White : TabBack;
            btnMain.ForeColor = mainPart ? TabActiveFore : TabFore;
            btnAux.BackColor = mainPart ? TabBack : Color.White;
            btnAux.ForeColor = mainPart ? TabFore : TabActiveFore;
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
            sb.AppendLine("抛料统计");
            sb.AppendLine("页签," + (mainPart ? "主件" : "辅料"));
            sb.AppendLine("模式," + (nonProduction ? "非生产模式" : "生产模式"));
            sb.AppendLine("开始," + fromPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine("结束," + toPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine();
            sb.AppendLine("统计项目,白班数量,白班百分比,晚班数量,晚班百分比");
            if (nonProduction)
            {
                sb.AppendLine("投入数量,—,—,—,—");
            }
            else
            {
                sb.AppendLine("投入数量,"
                    + report.Day.Input.ToString(CultureInfo.InvariantCulture) + ",,"
                    + report.Night.Input.ToString(CultureInfo.InvariantCulture) + ",");
            }
            sb.AppendLine(ScrapReport.PassYieldGroup);
            ExportItems(sb, report.Day.YieldItems, mainPart);
            sb.AppendLine(ScrapReport.PfGroup);
            ExportItems(sb, report.Day.PfItems, !mainPart);

            var path = Path.Combine(station.RecordFolder, "导出",
                "抛料统计 " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".csv");
            if (!TextFile.WriteAllText(path, sb.ToString(), CodePages.Utf8WithBom()))
            {
                station.Say("导出失败：" + path);
                return;
            }
            station.Log.Write(station.User, "导出抛料统计", mainPart ? "主件" : "辅料", string.Empty, path);
            station.Say("已导出抛料统计到 " + path);
        }

        private void ExportItems(StringBuilder sb, List<ScrapItem> items, bool counted)
        {
            if (nonProduction)
            {
                foreach (var item in items) sb.AppendLine(item.Name + ",—,—,—,—");
                return;
            }
            foreach (var item in items)
            {
                var day = counted ? item.Count : 0;
                var night = counted ? NightCount(item.Name, report.Night) : 0;
                sb.AppendLine(item.Name + ","
                    + day.ToString(CultureInfo.InvariantCulture) + "," + PercentText(day, report.Day.Input) + ","
                    + night.ToString(CultureInfo.InvariantCulture) + "," + PercentText(night, report.Night.Input));
            }
        }

        private static int NightCount(string name, ScrapShift shift)
        {
            foreach (var item in shift.YieldItems)
            {
                if (item.Name == name) return item.Count;
            }
            foreach (var item in shift.PfItems)
            {
                if (item.Name == name) return item.Count;
            }
            return 0;
        }
    }
}
