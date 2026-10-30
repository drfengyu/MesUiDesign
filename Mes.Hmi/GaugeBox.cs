using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mes.Hmi
{
    public class GaugeZone
    {
        public double From;
        public double To;
        public Color Color;

        public GaugeZone(double from, double to, Color color)
        {
            From = from;
            To = to;
            Color = color;
        }
    }

    /// <summary>
    /// 仪表盘全用 .NET 自带的 Chart 控件搭：240° 圆环画红黄绿分区，
    /// 指针是 LineAnnotation（饼图不能和圆环同区叠加，会整块画红叉），
    /// 读数和单位是 TextAnnotation。页面只给量程、分区和当前值。
    /// </summary>
    public class GaugeBox : Chart
    {
        private static readonly Color QuietColor = Color.FromArgb(120, 126, 134);
        private static readonly Color ValueColor = Color.FromArgb(35, 40, 45);
        private static readonly Color NeedleColor = Color.FromArgb(45, 50, 56);

        private readonly ChartArea area = new ChartArea("gauge");
        private readonly Series zones = new Series("zones");
        private readonly LineAnnotation needle = new LineAnnotation();
        private readonly EllipseAnnotation hub = new EllipseAnnotation();
        private readonly TextAnnotation valueText = new TextAnnotation();
        private readonly TextAnnotation unitText = new TextAnnotation();
        private readonly Title caption = new Title();
        private readonly List<GaugeZone> zoneList = new List<GaugeZone>();
        private readonly List<TextAnnotation> ticks = new List<TextAnnotation>();

        private string title;
        private string unit;
        private string format;
        private double min;
        private double max;
        private double value;
        private Font labelFont;
        private Font titleFont;
        private Font valueFont;
        private Font unitFont;
        private Font tickFont;

        public GaugeBox()
        {
            BackColor = Color.White;
            AntiAliasing = AntiAliasingStyles.All;
            TextAntiAliasingQuality = TextAntiAliasingQuality.High;
            IsSoftShadows = false;
            BorderlineColor = Color.FromArgb(230, 233, 238);
            BorderlineDashStyle = ChartDashStyle.Solid;

            area.BackColor = Color.White;
            area.AxisX.Enabled = AxisEnabled.False;
            area.AxisY.Enabled = AxisEnabled.False;
            ChartAreas.Add(area);

            zones.ChartType = SeriesChartType.Doughnut;
            zones.ChartArea = "gauge";
            zones["DoughnutRadius"] = "58";
            zones["PieStartAngle"] = "150";
            zones["PieLabelStyle"] = "Disabled";
            zones["PieLineColor"] = "200, 205, 212";
            zones.LabelForeColor = QuietColor;
            zones.IsVisibleInLegend = false;
            zones.BorderColor = Color.White;
            zones.BorderWidth = 1;
            Series.Add(zones);

            needle.IsSizeAlwaysRelative = true;
            needle.LineColor = NeedleColor;
            needle.StartCap = LineAnchorCapStyle.None;
            needle.EndCap = LineAnchorCapStyle.Arrow;
            Annotations.Add(needle);

            hub.IsSizeAlwaysRelative = true;
            hub.BackColor = NeedleColor;
            hub.LineColor = NeedleColor;
            Annotations.Add(hub);

            valueText.IsSizeAlwaysRelative = true;
            valueText.X = 50;
            valueText.Alignment = ContentAlignment.MiddleCenter;
            valueText.ForeColor = ValueColor;
            Annotations.Add(valueText);

            unitText.IsSizeAlwaysRelative = true;
            unitText.X = 50;
            unitText.Alignment = ContentAlignment.MiddleCenter;
            unitText.ForeColor = QuietColor;
            Annotations.Add(unitText);

            caption.ForeColor = QuietColor;
            caption.Docking = Docking.Top;
            caption.Alignment = ContentAlignment.MiddleLeft;
            caption.Visible = false;
            Titles.Add(caption);

            format = "0.0";
            min = 0;
            max = 100;
            value = double.NaN;
            SizeChanged += delegate
            {
                ApplyGeometry();
                Rebuild();
            };
            ApplyGeometry();
            Rebuild();
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
            set
            {
                unit = value;
                unitText.Text = value;
                unitText.Visible = !string.IsNullOrEmpty(value);
            }
        }

        public string Format
        {
            get { return format; }
            set { format = value; Rebuild(); }
        }

        public double Min
        {
            get { return min; }
            set { min = value; Rebuild(); }
        }

        public double Max
        {
            get { return max; }
            set { max = value; Rebuild(); }
        }

        public double Value
        {
            get { return value; }
            set { SetValue(value); }
        }

        public void SetZones(params GaugeZone[] items)
        {
            zoneList.Clear();
            if (items != null) zoneList.AddRange(items);
            Rebuild();
        }

        public void SetValue(double current)
        {
            value = current;
            Rebuild();
        }

        private void ApplyGeometry()
        {
            var h = Math.Max(1, Height);
            var w = Math.Max(1, Width);
            SetFont(ref labelFont, zones, (float)Math.Max(7.0, Math.Min(9.0, h * 0.024)), FontStyle.Regular);
            SetFont(ref titleFont, caption, (float)Math.Max(8.0, Math.Min(11.0, h * 0.05)), FontStyle.Bold);
            SetFont(ref valueFont, valueText, (float)Math.Max(9.0, Math.Min(20.0, h * 0.10)), FontStyle.Bold);
            SetFont(ref unitFont, unitText, (float)Math.Max(7.0, Math.Min(10.0, h * 0.04)), FontStyle.Regular);
            SetFont(ref tickFont, ticks, (float)Math.Max(7.0, Math.Min(9.0, h * 0.026)), FontStyle.Regular);
            valueText.Y = 80;
            unitText.Y = 62;
            needle.LineWidth = Math.Max(2, Math.Min(5, (int)(h * 0.022)));
            var dot = Math.Max(5, h * 0.055);
            hub.Width = dot / w * 100;
            hub.Height = dot / h * 100;
            hub.X = 50 - hub.Width / 2;
            hub.Y = 50 - hub.Height / 2;
        }

        private static void SetFont(ref Font field, Annotation target, float size, FontStyle style)
        {
            if (field != null && Math.Abs(field.Size - size) < 0.01f && field.Style == style) return;
            var old = field;
            field = new Font("微软雅黑", size, style);
            target.Font = field;
            if (old != null) old.Dispose();
        }

        private static void SetFont(ref Font field, Title target, float size, FontStyle style)
        {
            if (field != null && Math.Abs(field.Size - size) < 0.01f && field.Style == style) return;
            var old = field;
            field = new Font("微软雅黑", size, style);
            target.Font = field;
            if (old != null) old.Dispose();
        }

        private static void SetFont(ref Font field, Series target, float size, FontStyle style)
        {
            if (field != null && Math.Abs(field.Size - size) < 0.01f && field.Style == style) return;
            var old = field;
            field = new Font("微软雅黑", size, style);
            target.Font = field;
            if (old != null) old.Dispose();
        }

        private static void SetFont(ref Font field, List<TextAnnotation> target, float size, FontStyle style)
        {
            if (field != null && Math.Abs(field.Size - size) < 0.01f && field.Style == style) return;
            var old = field;
            field = new Font("微软雅黑", size, style);
            foreach (var item in target) item.Font = field;
            if (old != null) old.Dispose();
        }

        private void Rebuild()
        {
            zones.Points.Clear();

            var span = max - min;
            if (span <= 0) span = 1;
            if (zoneList.Count == 0)
            {
                zones.Points.Add(new DataPoint(0, 240) { Color = Color.FromArgb(0, 170, 70) });
            }
            else
            {
                foreach (var zone in zoneList)
                {
                    var from = Math.Max(min, Math.Min(max, zone.From));
                    var to = Math.Max(min, Math.Min(max, zone.To));
                    var sweep = 240 * (to - from) / span;
                    if (sweep <= 0) continue;
                    zones.Points.Add(new DataPoint(0, sweep) { Color = zone.Color });
                }
            }
            zones.Points.Add(new DataPoint(0, 120) { Color = Color.Transparent });

            BuildTicks(span);

            var valid = !double.IsNaN(value) && !double.IsInfinity(value);
            valueText.Text = valid ? value.ToString(format) : "--";
            needle.Visible = valid;
            if (valid)
            {
                var ratio = Math.Max(0, Math.Min(1, (value - min) / span));
                var angle = 150 + 240 * ratio;
                var rad = angle * Math.PI / 180.0;
                var length = 0.34 * Math.Min(Math.Max(1, Width), Math.Max(1, Height));
                needle.X = 50;
                needle.Y = 50;
                needle.Width = Math.Cos(rad) * length / Math.Max(1, Width) * 100;
                needle.Height = Math.Sin(rad) * length / Math.Max(1, Height) * 100;
            }
        }

        private void BuildTicks(double span)
        {
            foreach (var tick in ticks) Annotations.Remove(tick);
            ticks.Clear();

            var w = Math.Max(1, Width);
            var h = Math.Max(1, Height);
            var radius = 0.39 * Math.Min(w, h);
            var target = Math.Max(4, Math.Min(10, (int)Math.Round(h / 20.0)));
            var step = NiceStep(span / target);
            for (var v = min; v <= max + step * 0.001 && ticks.Count < 12; v += step)
            {
                var ratio = (v - min) / span;
                var rad = (150 + 240 * ratio) * Math.PI / 180.0;
                var tick = new TextAnnotation
                {
                    IsSizeAlwaysRelative = true,
                    Alignment = ContentAlignment.MiddleCenter,
                    ForeColor = ValueColor,
                    Font = tickFont,
                    Text = v.ToString("0.#"),
                    X = 50 + Math.Cos(rad) * radius / w * 100,
                    Y = 50 + Math.Sin(rad) * radius / h * 100,
                };
                ticks.Add(tick);
                Annotations.Add(tick);
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

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (labelFont != null) labelFont.Dispose();
                if (titleFont != null) titleFont.Dispose();
                if (valueFont != null) valueFont.Dispose();
                if (unitFont != null) unitFont.Dispose();
                if (tickFont != null) tickFont.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
