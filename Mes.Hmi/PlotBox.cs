using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mes.Hmi
{
    public enum PlotKind
    {
        Line,
        Bars,
        StackedBars,
        Pie,
        Histogram,
    }

    public class PlotSeries
    {
        public string Name;
        public Color Color;
        public double[] Values = new double[0];
    }

    /// <summary>
    /// 页面图表统一用 .NET 自带的 Chart 控件渲染（折线/柱状/饼图）。
    /// 页面只描述几条线、颜色和 X 轴标签，不再自己画像素。
    /// </summary>
    public class PlotBox : Chart
    {
        private static readonly Color GridColor = Color.FromArgb(232, 235, 239);
        private static readonly Color AxisColor = Color.FromArgb(150, 156, 164);
        private static readonly Color TitleColor = Color.FromArgb(45, 50, 55);
        private static readonly Color EmptyColor = Color.FromArgb(150, 156, 164);
        private static readonly Color TargetColor = Color.FromArgb(40, 120, 200);

        private static readonly Color[] SeriesPalette =
        {
            Color.FromArgb(0, 160, 120), Color.FromArgb(40, 120, 200), Color.FromArgb(230, 150, 30),
            Color.FromArgb(200, 60, 70), Color.FromArgb(120, 90, 190), Color.FromArgb(90, 170, 70),
            Color.FromArgb(210, 110, 160), Color.FromArgb(110, 110, 110),
        };

        private readonly ChartArea area = new ChartArea("main");
        private readonly Legend legend = new Legend("legend");
        private readonly Title caption = new Title();
        private readonly Font axisFont = new Font("微软雅黑", 9F);
        private readonly Font titleFont = new Font("微软雅黑", 10F, FontStyle.Bold);
        private readonly Font emptyFont = new Font("微软雅黑", 10F);
        private readonly TextAnnotation emptyNote = new TextAnnotation();
        private StripLine targetLine;

        private PlotKind kind;
        private bool showLegend = true;
        private string emptyText = "暂无数据";
        private string title;
        private string unit;
        private bool autoScale = true;
        private double minValue;
        private double maxValue;
        private bool hasTarget;
        private double targetValue;
        private string targetLabel;
        private int labelInterval;

        public PlotBox()
        {
            BackColor = Color.White;
            AntiAliasing = AntiAliasingStyles.All;
            TextAntiAliasingQuality = TextAntiAliasingQuality.High;
            IsSoftShadows = false;
            BorderlineColor = Color.FromArgb(230, 233, 238);
            BorderlineDashStyle = ChartDashStyle.Solid;

            area.BackColor = Color.White;
            area.AxisX.MajorGrid.LineColor = GridColor;
            area.AxisY.MajorGrid.LineColor = GridColor;
            area.AxisX.LineColor = AxisColor;
            area.AxisY.LineColor = AxisColor;
            area.AxisX.LabelStyle.ForeColor = AxisColor;
            area.AxisY.LabelStyle.ForeColor = AxisColor;
            area.AxisX.LabelStyle.Font = axisFont;
            area.AxisY.LabelStyle.Font = axisFont;
            area.AxisX.MajorTickMark.Enabled = false;
            area.AxisY.MajorTickMark.Enabled = false;
            area.AxisX.LabelStyle.TruncatedLabels = false;
            area.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            area.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dot;
            ChartAreas.Add(area);

            legend.BackColor = Color.Transparent;
            legend.Font = axisFont;
            legend.ForeColor = TitleColor;
            legend.BorderColor = Color.FromArgb(210, 215, 222);
            legend.Docking = Docking.Right;
            legend.Alignment = StringAlignment.Center;
            legend.IsTextAutoFit = false;
            Legends.Add(legend);

            caption.Font = titleFont;
            caption.ForeColor = TitleColor;
            caption.Docking = Docking.Top;
            caption.Alignment = ContentAlignment.MiddleLeft;
            Titles.Add(caption);

            emptyNote.Font = emptyFont;
            emptyNote.ForeColor = EmptyColor;
            emptyNote.Alignment = ContentAlignment.MiddleCenter;
            emptyNote.X = 50;
            emptyNote.Y = 50;

            kind = PlotKind.Line;
        }

        public PlotKind Kind
        {
            get { return kind; }
            set { kind = value; }
        }

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                caption.Text = value;
                caption.Visible = !string.IsNullOrEmpty(value);
            }
        }

        public string Unit
        {
            get { return unit; }
            set { unit = value; }
        }

        public bool ShowLegend
        {
            get { return showLegend; }
            set
            {
                showLegend = value;
                legend.Enabled = value;
            }
        }

        public bool HasTarget
        {
            get { return hasTarget; }
            set { hasTarget = value; }
        }

        public double TargetValue
        {
            get { return targetValue; }
            set { targetValue = value; }
        }

        public string TargetLabel
        {
            get { return targetLabel; }
            set { targetLabel = value; }
        }

        public string EmptyText
        {
            get { return emptyText; }
            set { emptyText = value; }
        }

        public bool AutoScale
        {
            get { return autoScale; }
            set { autoScale = value; }
        }

        public int LabelInterval
        {
            get { return labelInterval; }
            set { labelInterval = value; }
        }

        public double MinValue
        {
            get { return minValue; }
            set { minValue = value; }
        }

        public double MaxValue
        {
            get { return maxValue; }
            set { maxValue = value; }
        }

        public void SetSeries(IList<PlotSeries> items, string[] xLabels = null)
        {
            Series.Clear();
            Annotations.Remove(emptyNote);
            if (targetLine != null)
            {
                area.AxisY.StripLines.Remove(targetLine);
                targetLine = null;
            }

            var labels = xLabels ?? new string[0];
            var count = 0;
            if (items != null)
            {
                foreach (var item in items)
                {
                    if (item.Values != null && item.Values.Length > count) count = item.Values.Length;
                }
            }
            if (items == null || items.Count == 0 || count == 0)
            {
                ShowEmpty();
                return;
            }

            area.AxisX.Enabled = kind == PlotKind.Pie ? AxisEnabled.False : AxisEnabled.Auto;
            area.AxisY.Enabled = kind == PlotKind.Pie ? AxisEnabled.False : AxisEnabled.Auto;
            area.AxisX.IsStartedFromZero = false;
            area.AxisY.IsStartedFromZero = kind != PlotKind.Line;
            if (!autoScale && maxValue > minValue)
            {
                area.AxisY.Minimum = minValue;
                area.AxisY.Maximum = maxValue;
            }
            else
            {
                area.AxisY.Minimum = double.NaN;
                area.AxisY.Maximum = double.NaN;
            }
            area.AxisX.LabelStyle.Interval = labelInterval > 0
                ? labelInterval
                : (count <= 10 ? 1 : Math.Ceiling(count / 8.0));
            area.AxisX.LabelStyle.Format = string.Empty;

            var type = ChartTypeOf(kind);
            var index = 0;
            foreach (var item in items)
            {
                var series = new Series("s" + index)
                {
                    ChartType = type,
                    ChartArea = "main",
                    Color = item.Color.IsEmpty ? SeriesPalette[index % SeriesPalette.Length] : item.Color,
                    BorderWidth = 2,
                    Font = axisFont,
                    IsVisibleInLegend = showLegend,
                    LegendText = item.Name ?? ("系列" + (index + 1)),
                    XValueType = ChartValueType.Double,
                };
                if (kind == PlotKind.Pie)
                {
                    series["PieLabelStyle"] = "Disabled";
                    series["DoughnutRadius"] = "45";
                    series["PieDrawingStyle"] = "SoftEdge";
                    series.IsVisibleInLegend = showLegend;
                    series.LegendText = item.Name ?? "统计";
                }
                for (var i = 0; i < item.Values.Length; i++)
                {
                    var value = item.Values[i];
                    if (double.IsNaN(value) || double.IsInfinity(value)) continue;
                    var point = new DataPoint(kind == PlotKind.Line ? i : i + 1, value);
                    if (labels.Length > i)
                    {
                        if (kind == PlotKind.Pie)
                        {
                            point.LegendText = labels[i];
                            point.AxisLabel = labels[i];
                        }
                        else
                        {
                            point.AxisLabel = labels[i];
                        }
                    }
                    series.Points.Add(point);
                }
                Series.Add(series);
                index++;
            }

            if (hasTarget)
            {
                targetLine = new StripLine
                {
                    IntervalOffset = targetValue,
                    StripWidth = 0,
                    BorderColor = TargetColor,
                    BorderDashStyle = ChartDashStyle.Dash,
                    BorderWidth = 1,
                };
                area.AxisY.StripLines.Add(targetLine);
            }
        }

        public void SetEmpty(string text)
        {
            emptyText = text;
            ShowEmpty();
        }

        private void ShowEmpty()
        {
            Series.Clear();
            area.AxisX.Enabled = AxisEnabled.False;
            area.AxisY.Enabled = AxisEnabled.False;
            area.AxisX.Minimum = 0;
            area.AxisX.Maximum = 100;
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = 100;
            emptyNote.Text = emptyText;
            if (!Annotations.Contains(emptyNote)) Annotations.Add(emptyNote);
        }

        private static SeriesChartType ChartTypeOf(PlotKind value)
        {
            switch (value)
            {
                case PlotKind.Bars:
                case PlotKind.Histogram:
                    return SeriesChartType.Column;
                case PlotKind.StackedBars:
                    return SeriesChartType.StackedColumn;
                case PlotKind.Pie:
                    return SeriesChartType.Doughnut;
                default:
                    return SeriesChartType.Line;
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                axisFont.Dispose();
                titleFont.Dispose();
                emptyFont.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
