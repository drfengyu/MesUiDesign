using Mes.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mes.Hmi
{
    /// <summary>
    /// CPK（《Automation UI V3.11》P22）：右边选分组/测量项、规格上下限、样本数和时间段，
    /// 左边四张原生 Chart 分别画正态分布曲线、样品数据分布、分段计数和最近 8 组 CPK。
    ///
    /// 分组对应追溯表里的测量列：MC纠偏 X/Y/R、贴合纠偏 X/Y/R、微动补偿 X/Y。
    /// 规格上下限和标准值默认取 数据\判定上下限.csv，允许在界面上改；取最近 N 片算当前 CPK。
    /// </summary>
    public partial class PageCpk : UserControl
    {
        private const double MinCpk = 1.33;

        private static readonly string[][] Groups =
        {
            new[] { "MC纠偏", "MC纠偏X", "MC纠偏Y", "MC纠偏R" },
            new[] { "贴合纠偏", "贴合纠偏X", "贴合纠偏Y", "贴合纠偏R" },
            new[] { "微动补偿", "微动补偿X", "微动补偿Y" },
        };

        private readonly StationContext station;
        private CpkResult result;
        private List<double> samples = new List<double>();
        private List<CpkResult> recent = new List<CpkResult>();
        private double target;
        private double lower;
        private double upper;

        public PageCpk()
        {
            InitializeComponent();
        }

        public PageCpk(StationContext station) : this()
        {
            this.station = station;
            ChartKit.StylePlot(plotNormal);
            ChartKit.StylePlot(plotSample);
            ChartKit.StylePlot(plotRecent);
            ChartKit.Empty(plotNormal, "暂无数据");
            ChartKit.Empty(plotSample, "暂无数据");
            ChartKit.Empty(plotHist, "暂无数据");
            ChartKit.Empty(plotRecent, "暂无数据");

            foreach (var group in Groups) comboGroup.Items.Add(group[0]);
            pickFrom.Value = DateTime.Today;
            pickTo.Value = DateTime.Now;
            comboGroup.SelectedIndex = 0;
            Query();
        }

        // ── 参数面板 ───────────────────────────────────────────────────────

        private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (station == null || comboGroup.SelectedIndex < 0) return;
            var group = Groups[comboGroup.SelectedIndex];
            comboItem.Items.Clear();
            for (var i = 1; i < group.Length; i++) comboItem.Items.Add(group[i]);
            comboItem.SelectedIndex = 0;
        }

        private void comboItem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (station == null || comboItem.SelectedItem == null) return;
            var name = Convert.ToString(comboItem.SelectedItem);
            foreach (var limit in station.Limits.Items)
            {
                if (limit.Name != name) continue;
                textTarget.Text = FormatValue((limit.Lower + limit.Upper) / 2D);
                textUpper.Text = FormatValue(limit.Upper);
                textLower.Text = FormatValue(limit.Lower);
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void check_CheckedChanged(object sender, EventArgs e)
        {
            if (station == null) return;
            SetSeriesVisible(plotSample, "当前值", checkNow.Checked);
            SetSeriesVisible(plotSample, "标准值", checkTarget.Checked);
            SetSeriesVisible(plotSample, "最大值", checkMax.Checked);
            SetSeriesVisible(plotSample, "最小值", checkMin.Checked);
        }

        private static void SetSeriesVisible(Chart chart, string name, bool visible)
        {
            var series = chart.Series.FindByName(name);
            if (series != null) series.Enabled = visible;
        }

        private void checkAuto_CheckedChanged(object sender, EventArgs e)
        {
            var on = checkAuto.Checked;
            checkAuto.Text = "自动补偿：" + (on ? "开" : "关");
            checkAuto.BackColor = on
                ? Color.FromArgb(0, 150, 80)
                : Color.FromArgb(110, 116, 124);
            if (station == null) return;
            station.Log.Write(station.User, "自动补偿", on ? "开" : "关", string.Empty, string.Empty);
            station.Say("自动补偿已" + (on ? "开启" : "关闭"));
        }

        // ── 查询与计算 ─────────────────────────────────────────────────────

        private void Query()
        {
            if (station == null) return;
            var from = pickFrom.Value;
            var to = pickTo.Value;
            if (to <= from)
            {
                station.Say("结束时间必须晚于开始时间，请重新选择");
                return;
            }
            int count;
            if (!int.TryParse(textCount.Text.Trim(), out count) || count < 2 || count > 500)
            {
                station.Say("选取产品数量应为 2~500，请重新输入");
                return;
            }
            if (!TryValue(textTarget.Text, out target) || !TryValue(textUpper.Text, out upper)
                || !TryValue(textLower.Text, out lower))
            {
                station.Say("目标值/上限值/下限值必须是数字");
                return;
            }
            if (upper <= lower)
            {
                station.Say("上限值必须大于下限值");
                return;
            }

            var name = Convert.ToString(comboItem.SelectedItem);
            samples = ReadSamples(name, from, to);
            if (samples.Count == 0)
            {
                result = null;
                recent.Clear();
                cpkValue.Text = "--";
                deviationValue.Text = "--";
                ChartKit.Empty(plotNormal, "所选区间没有 " + name + " 的测量数据");
                ChartKit.Empty(plotSample, "所选区间没有 " + name + " 的测量数据");
                ChartKit.Empty(plotHist, "所选区间没有 " + name + " 的测量数据");
                ChartKit.Empty(plotRecent, "所选区间没有 " + name + " 的测量数据");
                station.Say("所选区间没有 " + name + " 的测量数据");
                return;
            }

            var start = Math.Max(0, samples.Count - count);
            result = CpkResult.Compute(samples.GetRange(start, samples.Count - start), target, lower, upper);
            recent = RecentGroups(samples, count, target, lower, upper);
            // 样品图只画参与本次计算的那 N 片，和"选取产品数量"对齐。
            samples = samples.GetRange(start, samples.Count - start);

            cpkValue.Text = result.Valid ? result.Cpk.ToString("0.000", CultureInfo.InvariantCulture) : "--";
            deviationValue.Text = result.Valid
                ? result.Deviation.ToString("+0.000;-0.000;0.000", CultureInfo.InvariantCulture)
                : "--";

            PaintNormal();
            PaintSample();
            PaintHistogram();
            PaintRecent();
        }

        private List<double> ReadSamples(string column, DateTime from, DateTime to)
        {
            var values = new List<double>();
            var rows = station.ProductLog.Between(from, to);
            foreach (var row in rows)
            {
                double value;
                if (!TryValue(row.Get(column), out value)) continue;
                values.Add(value);
            }
            return values;
        }

        /// <summary>从最新一组往回按样本数分组，最新一组永远取满；最多回看 8 组。</summary>
        private static List<CpkResult> RecentGroups(List<double> values, int count, double target, double lower, double upper)
        {
            var groups = new List<CpkResult>();
            var end = values.Count;
            while (end > 0 && groups.Count < 8)
            {
                var start = Math.Max(0, end - count);
                groups.Add(CpkResult.Compute(values.GetRange(start, end - start), target, lower, upper));
                end = start;
            }
            groups.Reverse();
            return groups;
        }

        private static bool TryValue(string text, out double value)
        {
            if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value)) return true;
            return double.TryParse(text, NumberStyles.Float, CultureInfo.CurrentCulture, out value);
        }

        // ── 四张图 ─────────────────────────────────────────────────────────

        private void PaintNormal()
        {
            var series = plotNormal.Series[0];
            series.Points.Clear();
            if (result == null || !result.Valid)
            {
                ChartKit.Empty(plotNormal, "样本不足或全部相同，无法绘制正态分布");
                return;
            }
            var area = plotNormal.ChartAreas[0];
            area.AxisX.Enabled = AxisEnabled.Auto;
            area.AxisY.Enabled = AxisEnabled.Auto;
            ClearNote(plotNormal);
            var start = result.Mean - 4D * result.Sigma;
            var end = result.Mean + 4D * result.Sigma;
            var peak = 0D;
            for (var i = 0; i <= 80; i++)
            {
                var x = start + (end - start) * i / 80D;
                var y = result.Normal(x);
                series.Points.AddXY(x, y);
                if (y > peak) peak = y;
            }
            var top = peak <= 0 ? 1D : peak * 1.15D;
            area.AxisX.Minimum = start;
            area.AxisX.Maximum = end;
            area.AxisX.Interval = (end - start) / 5D;
            area.AxisX.IsMarginVisible = false;
            area.AxisX.LabelStyle.Format = "0.###";
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = top;
            area.AxisY.Interval = NiceStep(top / 4D);
            area.AxisY.LabelStyle.Format = "0.###";
        }

        private void PaintSample()
        {
            foreach (var series in plotSample.Series) series.Points.Clear();
            if (samples.Count == 0)
            {
                ChartKit.Empty(plotSample, "暂无数据");
                return;
            }
            var area = plotSample.ChartAreas[0];
            area.AxisX.Enabled = AxisEnabled.Auto;
            area.AxisY.Enabled = AxisEnabled.Auto;
            ClearNote(plotSample);

            var dataMin = double.MaxValue;
            var dataMax = double.MinValue;
            var nowSeries = plotSample.Series["当前值"];
            for (var i = 0; i < samples.Count; i++)
            {
                nowSeries.Points.AddXY(i + 1, samples[i]);
                dataMin = Math.Min(dataMin, samples[i]);
                dataMax = Math.Max(dataMax, samples[i]);
            }
            var low = Math.Min(dataMin, target);
            var high = Math.Max(dataMax, target);
            var span = high - low;
            var pad = span > 1e-9 ? span * 0.12D : Math.Max(0.01D, Math.Abs(high) * 0.01D);
            var last = Math.Max(2, samples.Count);
            AddFlatLine(plotSample.Series["标准值"], 1, last, target);
            AddFlatLine(plotSample.Series["最大值"], 1, last, dataMax);
            AddFlatLine(plotSample.Series["最小值"], 1, last, dataMin);

            area.AxisX.Minimum = 1;
            area.AxisX.Maximum = last;
            area.AxisX.Interval = Math.Max(1D, Math.Ceiling(last / 8D));
            area.AxisX.IsMarginVisible = false;
            area.AxisX.LabelStyle.Format = "0";
            area.AxisY.Minimum = low - pad;
            area.AxisY.Maximum = high + pad;
            area.AxisY.Interval = NiceStep((high - low + pad * 2D) / 5D);
            area.AxisY.LabelStyle.Format = "0.###";
        }

        private void PaintHistogram()
        {
            var series = plotHist.Series[0];
            series.Points.Clear();
            if (result == null || result.Values.Count == 0)
            {
                ChartKit.Empty(plotHist, "暂无数据");
                return;
            }
            var area = plotHist.ChartAreas[0];
            area.AxisX.Enabled = AxisEnabled.Auto;
            area.AxisY.Enabled = AxisEnabled.Auto;
            ClearNote(plotHist);

            var bins = Math.Min(10, Math.Max(1, result.Values.Count));
            var counts = result.Histogram(bins);
            var width = counts.Length > 1 ? (result.Max - result.Min) / counts.Length : 0D;
            var peak = 0;
            for (var i = 0; i < counts.Length; i++)
            {
                var point = new DataPoint(i + 1, counts[i]);
                if (counts.Length == 1)
                {
                    point.AxisLabel = FormatValue(result.Min);
                }
                else
                {
                    var low = result.Min + width * i;
                    point.AxisLabel = FormatValue(low) + "~" + FormatValue(low + width);
                }
                series.Points.Add(point);
                if (counts[i] > peak) peak = counts[i];
            }
            area.AxisX.IsMarginVisible = false;
            area.AxisX.LabelStyle.Interval = 1;
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = Math.Max(1, Math.Ceiling(peak * 1.15D));
            area.AxisY.Interval = Math.Max(1D, Math.Ceiling(area.AxisY.Maximum / 5D));
        }

        private void PaintRecent()
        {
            if (recent.Count == 0)
            {
                ChartKit.Empty(plotRecent, "样本不足，无法计算分组 CPK");
                return;
            }
            var labels = new string[recent.Count];
            var cpk = new double[recent.Count];
            var goal = new double[recent.Count];
            var counts = new double[recent.Count];
            var top = MinCpk;
            var any = false;
            for (var i = 0; i < recent.Count; i++)
            {
                labels[i] = (i + 1).ToString(CultureInfo.InvariantCulture);
                cpk[i] = recent[i].Valid ? recent[i].Cpk : double.NaN;
                goal[i] = MinCpk;
                counts[i] = recent[i].Values.Count;
                if (!double.IsNaN(cpk[i]))
                {
                    any = true;
                    top = Math.Max(top, cpk[i]);
                }
            }
            if (!any)
            {
                ChartKit.Empty(plotRecent, "样本不足，无法计算分组 CPK");
                return;
            }
            // 前三个是图例占位序列，后三个才是画出来的系列。
            ChartKit.Fill(plotRecent, labels,
                new double[][] { null, null, null, cpk, goal, counts }, 1);

            var area = plotRecent.ChartAreas[0];
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = Math.Max(2D, Math.Ceiling(top * 1.2D * 2D) / 2D);
            area.AxisY.Interval = area.AxisY.Maximum <= 3D ? 0.5D : 1D;
            var maxCount = 0D;
            foreach (var value in counts) maxCount = Math.Max(maxCount, value);
            area.AxisY2.Maximum = Math.Max(5D, Math.Ceiling(maxCount * 1.4D));
            area.AxisY2.Interval = Math.Max(1D, Math.Ceiling(area.AxisY2.Maximum / 4D));
        }

        // ── 补偿 ───────────────────────────────────────────────────────────

        private void btnCompensate_Click(object sender, EventArgs e)
        {
            if (station == null) return;
            if (result == null || !result.Valid)
            {
                station.Say("样本不足，无法计算补偿偏差");
                return;
            }
            if (!result.InSpec)
            {
                station.Say("CPK " + result.Cpk.ToString("0.000", CultureInfo.InvariantCulture)
                    + " 不在规格范围内（≥" + MinCpk.ToString("0.00", CultureInfo.InvariantCulture) + "），不允许补偿");
                return;
            }
            var offset = result.Deviation;
            var name = Convert.ToString(comboItem.SelectedItem);
            station.Log.Write(station.User, "确认补偿偏差", name,
                "偏差 " + offset.ToString("+0.000;-0.000;0.000", CultureInfo.InvariantCulture),
                "CPK " + result.Cpk.ToString("0.000", CultureInfo.InvariantCulture));
            station.Say("已确认 " + name + " 补偿偏差 "
                + offset.ToString("+0.000;-0.000;0.000", CultureInfo.InvariantCulture));
        }

        // ── 数值显示 ───────────────────────────────────────────────────────

        private static string FormatValue(double value)
        {
            var magnitude = Math.Abs(value);
            return magnitude >= 100D
                ? value.ToString("0.#", CultureInfo.InvariantCulture)
                : magnitude >= 1D
                    ? value.ToString("0.###", CultureInfo.InvariantCulture)
                    : value.ToString("0.######", CultureInfo.InvariantCulture);
        }

        private static void ClearNote(Chart chart)
        {
            var note = chart.Annotations.FindByName("emptyNote");
            if (note != null) chart.Annotations.Remove(note);
        }

        private static void AddFlatLine(Series series, double from, double to, double value)
        {
            series.Points.AddXY(from, value);
            series.Points.AddXY(to, value);
        }

        private static double NiceStep(double raw)
        {
            if (raw <= 0 || double.IsNaN(raw) || double.IsInfinity(raw)) return 1;
            var exponent = Math.Floor(Math.Log10(raw));
            var power = Math.Pow(10, exponent);
            var fraction = raw / power;
            var nice = fraction <= 1 ? 1 : fraction <= 2 ? 2 : fraction <= 5 ? 5 : 10;
            return nice * power;
        }
    }
}
