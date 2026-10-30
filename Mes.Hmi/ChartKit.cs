using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mes.Hmi
{
    /// <summary>
    /// 原生 Chart 控件的数据填充与仪表盘注解定位。控件本身就是工具箱里的 Chart，
    /// 这里不继承控件、不画像素，只改它的 Series 点和 Annotation 位置。
    /// </summary>
    internal static class ChartKit
    {
        public static readonly Font AxisFont = new Font("微软雅黑", 9F);
        public static readonly Font TitleFont = new Font("微软雅黑", 10F, FontStyle.Bold);
        public static readonly Font EmptyFont = new Font("微软雅黑", 10F);
        private static readonly Font GaugeValueFont = new Font("微软雅黑", 16F, FontStyle.Bold);
        private static readonly Font GaugeUnitFont = new Font("微软雅黑", 8F);
        private static readonly Font GaugeTickFont = new Font("微软雅黑", 8F);

        private static readonly Color GridColor = Color.FromArgb(232, 235, 239);
        private static readonly Color AxisColor = Color.FromArgb(150, 156, 164);
        private static readonly Color TitleColor = Color.FromArgb(45, 50, 55);
        private static readonly Color EmptyColor = Color.FromArgb(150, 156, 164);
        private static readonly Color GaugeValueColor = Color.FromArgb(35, 40, 45);
        private static readonly Color GaugeQuietColor = Color.FromArgb(120, 126, 134);

        public static void StylePlot(Chart chart)
        {
            StyleFrame(chart);
            foreach (var area in chart.ChartAreas)
            {
                area.BackColor = Color.White;
                area.AxisX.MajorGrid.LineColor = GridColor;
                area.AxisY.MajorGrid.LineColor = GridColor;
                area.AxisX.LineColor = AxisColor;
                area.AxisY.LineColor = AxisColor;
                area.AxisX.LabelStyle.ForeColor = AxisColor;
                area.AxisY.LabelStyle.ForeColor = AxisColor;
                area.AxisX.LabelStyle.Font = AxisFont;
                area.AxisY.LabelStyle.Font = AxisFont;
                area.AxisX.LabelStyle.TruncatedLabels = false;
                area.AxisX.MajorTickMark.Enabled = false;
                area.AxisY.MajorTickMark.Enabled = false;
                area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
                area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            }
            foreach (var series in chart.Series)
            {
                series.BorderWidth = 2;
                series.Font = AxisFont;
            }
            foreach (var legend in chart.Legends)
            {
                legend.BackColor = Color.Transparent;
                legend.Font = AxisFont;
                legend.ForeColor = TitleColor;
                legend.BorderColor = Color.FromArgb(210, 215, 222);
                legend.IsTextAutoFit = false;
            }
            foreach (var title in chart.Titles)
            {
                title.Font = TitleFont;
                title.ForeColor = TitleColor;
            }
        }

        public static void StyleGauge(Chart chart)
        {
            StyleFrame(chart);
            foreach (var area in chart.ChartAreas) area.BackColor = Color.White;
            foreach (var series in chart.Series)
            {
                series.BorderColor = Color.White;
                series.BorderWidth = 1;
                series.Font = AxisFont;
            }
            var valueText = chart.Annotations.FindByName("value") as TextAnnotation;
            if (valueText != null)
            {
                valueText.Font = GaugeValueFont;
                valueText.ForeColor = GaugeValueColor;
            }
            var unitText = chart.Annotations.FindByName("unit") as TextAnnotation;
            if (unitText != null)
            {
                unitText.Font = GaugeUnitFont;
                unitText.ForeColor = GaugeQuietColor;
            }
            LayoutGauge(chart);
        }

        private static void StyleFrame(Chart chart)
        {
            chart.BackColor = Color.White;
            chart.AntiAliasing = AntiAliasingStyles.All;
            chart.TextAntiAliasingQuality = TextAntiAliasingQuality.High;
            chart.IsSoftShadows = false;
            chart.BorderlineColor = Color.FromArgb(230, 233, 238);
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
        }

        public static void Fill(Chart chart, string[] labels, params double[][] values)
        {
            Fill(chart, labels, values, 0);
        }

        public static void Fill(Chart chart, string[] labels, double[][] values, int labelInterval)
        {
            var text = labels ?? new string[0];
            var count = 0;
            if (values != null)
            {
                foreach (var item in values)
                {
                    if (item != null && item.Length > count) count = item.Length;
                }
            }
            if (count == 0 || chart.Series.Count == 0)
            {
                Empty(chart, "暂无数据");
                return;
            }

            RemoveEmptyNote(chart);
            var area = chart.ChartAreas[0];
            var pie = IsPie(chart.Series[0].ChartType);
            area.AxisX.Enabled = pie ? AxisEnabled.False : AxisEnabled.Auto;
            area.AxisY.Enabled = pie ? AxisEnabled.False : AxisEnabled.Auto;
            area.AxisX.IsStartedFromZero = false;
            area.AxisY.IsStartedFromZero = chart.Series[0].ChartType != SeriesChartType.Line;
            area.AxisX.IsMarginVisible = chart.Series[0].ChartType != SeriesChartType.Line;
            area.AxisX.LabelStyle.Interval = labelInterval > 0
                ? labelInterval
                : (count <= 10 ? 1 : Math.Ceiling(count / 8.0));

            for (var s = 0; s < chart.Series.Count; s++)
            {
                var series = chart.Series[s];
                series.Points.Clear();
                var data = s < values.Length ? values[s] : null;
                if (data == null) continue;
                var offset = pie || series.ChartType == SeriesChartType.Column
                    || series.ChartType == SeriesChartType.StackedColumn ? 1 : 0;
                for (var i = 0; i < data.Length; i++)
                {
                    var value = data[i];
                    if (double.IsNaN(value) || double.IsInfinity(value)) continue;
                    var point = new DataPoint(i + offset, value);
                    if (text.Length > i)
                    {
                        point.AxisLabel = text[i];
                        if (pie) point.LegendText = text[i];
                    }
                    series.Points.Add(point);
                }
            }
        }

        public static void Empty(Chart chart, string message)
        {
            foreach (var series in chart.Series) series.Points.Clear();
            if (chart.ChartAreas.Count > 0)
            {
                var area = chart.ChartAreas[0];
                area.AxisX.Enabled = AxisEnabled.False;
                area.AxisY.Enabled = AxisEnabled.False;
            }
            var note = chart.Annotations.FindByName("emptyNote") as TextAnnotation;
            if (note == null)
            {
                note = new TextAnnotation
                {
                    Name = "emptyNote",
                    IsSizeAlwaysRelative = true,
                    Alignment = ContentAlignment.MiddleCenter,
                    X = 50,
                    Y = 50,
                    Font = EmptyFont,
                    ForeColor = EmptyColor,
                };
                chart.Annotations.Add(note);
            }
            note.Text = message;
        }

        private static void RemoveEmptyNote(Chart chart)
        {
            var note = chart.Annotations.FindByName("emptyNote");
            if (note != null) chart.Annotations.Remove(note);
        }

        private static bool IsPie(SeriesChartType type)
        {
            return type == SeriesChartType.Pie || type == SeriesChartType.Doughnut;
        }

        public static void SetGaugeValue(Chart chart, double value)
        {
            var valueText = chart.Annotations.FindByName("value") as TextAnnotation;
            if (valueText == null) return;
            valueText.Tag = value;
            LayoutGauge(chart);
        }

        public static void LayoutGauge(Chart chart)
        {
            if (chart.ChartAreas.Count == 0) return;
            var area = chart.ChartAreas[0];
            var min = area.AxisY.Minimum;
            var max = area.AxisY.Maximum;
            var span = max - min;
            if (double.IsNaN(span) || span <= 0) span = 1;

            var w = Math.Max(1, chart.Width);
            var h = Math.Max(1, chart.Height);
            var valueText = chart.Annotations.FindByName("value") as TextAnnotation;
            var needle = chart.Annotations.FindByName("needle") as LineAnnotation;
            if (valueText != null)
            {
                valueText.Y = 80;
                var value = valueText.Tag is double ? (double)valueText.Tag : double.NaN;
                var valid = !double.IsNaN(value) && !double.IsInfinity(value);
                valueText.Text = valid ? value.ToString(area.AxisY.LabelStyle.Format) : "--";
                if (needle != null)
                {
                    needle.Visible = valid;
                    if (valid)
                    {
                        var ratio = Math.Max(0, Math.Min(1, (value - min) / span));
                        var rad = (150 + 240 * ratio) * Math.PI / 180.0;
                        var length = 0.34 * Math.Min(w, h);
                        needle.X = 50;
                        needle.Y = 50;
                        needle.Width = Math.Cos(rad) * length / w * 100;
                        needle.Height = Math.Sin(rad) * length / h * 100;
                    }
                }
            }
            var unitText = chart.Annotations.FindByName("unit") as TextAnnotation;
            if (unitText != null) unitText.Y = 62;

            if (needle != null) needle.LineWidth = Math.Max(2, Math.Min(5, (int)(h * 0.022)));
            var hub = chart.Annotations.FindByName("hub") as EllipseAnnotation;
            if (hub != null)
            {
                var dot = Math.Max(5, h * 0.055);
                hub.Width = dot / w * 100;
                hub.Height = dot / h * 100;
                hub.X = 50 - hub.Width / 2;
                hub.Y = 50 - hub.Height / 2;
            }

            BuildTicks(chart, area, min, span, w, h);
        }

        private static void BuildTicks(Chart chart, ChartArea area, double min, double span, int w, int h)
        {
            var key = w + "x" + h + "/" + min + "/" + (min + span) + "/" + area.AxisY.LabelStyle.Format;
            if (Equals(area.Tag, key)) return;
            area.Tag = key;

            var old = new List<Annotation>();
            foreach (var annotation in chart.Annotations)
            {
                if (annotation.Name != null && annotation.Name.StartsWith("tick", StringComparison.Ordinal))
                    old.Add(annotation);
            }
            foreach (var annotation in old) chart.Annotations.Remove(annotation);

            var radius = 0.39 * Math.Min(w, h);
            var target = Math.Max(4, Math.Min(10, (int)Math.Round(h / 20.0)));
            var step = NiceStep(span / target);
            var index = 0;
            for (var v = min; v <= min + span + step * 0.001 && index < 12; v += step, index++)
            {
                var rad = (150 + 240 * (v - min) / span) * Math.PI / 180.0;
                chart.Annotations.Add(new TextAnnotation
                {
                    Name = "tick" + index,
                    IsSizeAlwaysRelative = true,
                    Alignment = ContentAlignment.MiddleCenter,
                    ForeColor = GaugeValueColor,
                    Font = GaugeTickFont,
                    Text = v.ToString("0.#"),
                    X = 50 + Math.Cos(rad) * radius / w * 100,
                    Y = 50 + Math.Sin(rad) * radius / h * 100,
                });
            }
        }

        private static double NiceStep(double raw)
        {
            if (raw <= 0 || double.IsNaN(raw) || double.IsInfinity(raw)) return 1;
            var exponent = Math.Floor(Math.Log10(raw));
            var baseValue = Math.Pow(10, exponent);
            var fraction = raw / baseValue;
            var nice = fraction <= 1 ? 1 : fraction <= 2 ? 2 : fraction <= 4 ? 4 : fraction <= 5 ? 5 : 10;
            return nice * baseValue;
        }
    }
}
