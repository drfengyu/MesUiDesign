using Mes.Business;
using Mes.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 治具统计（《Automation UI V3.11》P19/P20）：数量统计按时段统计治具流入，
    /// 可选去重/不去重；异常统计按治具码统计 NG 次数 TOP5。
    /// 两种口径都只认追溯表里的"治具号"，没有治具号的记录不计。
    /// </summary>
    public partial class PageFixtureStatistics : UserControl
    {
        private static readonly Color[] Palette =
        {
            Color.FromArgb(30, 120, 210),
            Color.FromArgb(240, 160, 30),
            Color.FromArgb(220, 60, 60),
            Color.FromArgb(0, 160, 80),
            Color.FromArgb(130, 90, 200),
        };

        private readonly StationContext station;
        private List<HourlyFixture> hours;
        private List<FixtureNg> top;
        private string viewKey = string.Empty;
        private bool syncing;

        public PageFixtureStatistics()
        {
            InitializeComponent();
        }

        public PageFixtureStatistics(StationContext station) : this()
        {
            this.station = station;
            ChartKit.StylePlot(plotQuantity);
            ChartKit.StylePlot(plotNg);
            ChartKit.Empty(plotQuantity, "暂无数据");
            ChartKit.Empty(plotNg, "暂无数据");

            var now = DateTime.Now;
            var shiftDay = now.Hour >= 8 ? now.Date : now.Date.AddDays(-1);
            syncing = true;
            dateStart.Value = shiftDay;
            dateEnd.Value = shiftDay;
            fromPicker.Value = shiftDay.AddHours(8);
            toPicker.Value = shiftDay.AddDays(1).AddHours(8);
            syncing = false;

            refresh.Enabled = true;
            Query();
        }

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

            var records = station.ProductLog.Between(from, to);
            hours = FixtureReport.Quantity(records, from, to);
            top = FixtureReport.NgTop(records, from, to, 5);

            var key = ViewKey();
            if (key == viewKey) return;
            viewKey = key;
            countCaption.Text = "治具分类数量：" + FixtureReport.DistinctCount(hours)
                .ToString(CultureInfo.InvariantCulture) + " pcs";
            if (radioQuantity.Checked) PaintQuantity();
            else PaintNg();
        }

        private string ViewKey()
        {
            if (hours == null) return string.Empty;
            var sb = new StringBuilder();
            sb.Append(fromPicker.Value.Ticks).Append('|').Append(toPicker.Value.Ticks)
                .Append('|').Append(radioDistinct.Checked ? 1 : 0).Append('|');
            foreach (var cell in hours) sb.Append(cell.Count).Append(',').Append(cell.Distinct).Append(',');
            foreach (var item in top) sb.Append(item.Code).Append('=').Append(item.Count).Append(',');
            return sb.ToString();
        }

        private void PaintQuantity()
        {
            if (hours == null || hours.Count == 0) return;
            var labels = new string[hours.Count];
            var values = new double[hours.Count];
            var peak = 0D;
            for (var i = 0; i < hours.Count; i++)
            {
                labels[i] = HourLabel(hours[i].Hour);
                values[i] = radioDistinct.Checked ? hours[i].Distinct : hours[i].Count;
                peak = Math.Max(peak, values[i]);
            }
            ChartKit.Fill(plotQuantity, labels, new[] { values }, 1);
            var area = plotQuantity.ChartAreas[0];
            var topValue = Math.Max(10D, Math.Ceiling(peak / 10D) * 10D);
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = topValue;
            area.AxisY.Interval = Math.Max(1D, Math.Ceiling(topValue / 5D));
        }

        private void PaintNg()
        {
            if (top == null) return;
            if (top.Count == 0)
            {
                ChartKit.Empty(plotNg, "所选区间没有治具异常记录");
                FillNgList();
                return;
            }
            var labels = new string[top.Count];
            var values = new double[top.Count];
            for (var i = 0; i < top.Count; i++)
            {
                labels[i] = top[i].Code;
                values[i] = top[i].Count;
            }
            ChartKit.Fill(plotNg, labels, new[] { values }, 1);
            var peak = 0D;
            foreach (var value in values) peak = Math.Max(peak, value);
            var area = plotNg.ChartAreas[0];
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = Math.Max(3D, peak + 1D);
            area.AxisY.Interval = Math.Max(1D, Math.Ceiling(area.AxisY.Maximum / 5D));
            var series = plotNg.Series[0];
            for (var i = 0; i < series.Points.Count && i < Palette.Length; i++)
            {
                series.Points[i].Color = Palette[i];
            }
            FillNgList();
        }

        private void FillNgList()
        {
            gridNg.SuspendLayout();
            gridNg.Rows.Clear();
            if (top != null)
            {
                foreach (var item in top) gridNg.Rows.Add(item.Code, item.Count.ToString(CultureInfo.InvariantCulture));
            }
            gridNg.ClearSelection();
            gridNg.ResumeLayout();
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (station == null) return;
            var quantity = radioQuantity.Checked;
            quantityPanel.Visible = quantity;
            ngPanel.Visible = !quantity;
            if (quantity) PaintQuantity();
            else PaintNg();
        }

        /// <summary>去重口径只影响数量图，异常统计的 NG 次数不分去重。</summary>
        private void measure_CheckedChanged(object sender, EventArgs e)
        {
            if (station == null) return;
            PaintQuantity();
        }

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

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (station == null || hours == null) return;
            var sb = new StringBuilder();
            var quantity = radioQuantity.Checked;
            sb.AppendLine(quantity ? "治具数量统计" : "治具异常统计");
            sb.AppendLine("开始," + fromPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine("结束," + toPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine();
            string name;
            if (quantity)
            {
                sb.AppendLine("口径," + (radioDistinct.Checked ? "去重" : "不去重"));
                sb.AppendLine("治具分类种数," + FixtureReport.DistinctCount(hours));
                sb.AppendLine();
                sb.AppendLine("时间段,数量");
                foreach (var cell in hours)
                {
                    var value = radioDistinct.Checked ? cell.Distinct : cell.Count;
                    sb.AppendLine(HourLabel(cell.Hour) + "," + value.ToString(CultureInfo.InvariantCulture));
                }
                name = "治具数量统计";
            }
            else
            {
                sb.AppendLine("排名,治具码,异常次数");
                for (var i = 0; i < top.Count; i++)
                {
                    sb.AppendLine((i + 1).ToString(CultureInfo.InvariantCulture) + ","
                        + top[i].Code + "," + top[i].Count.ToString(CultureInfo.InvariantCulture));
                }
                name = "治具异常统计";
            }

            var path = Path.Combine(station.RecordFolder, "导出",
                name + " " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".csv");
            if (!TextFile.WriteAllText(path, sb.ToString(), CodePages.Utf8WithBom()))
            {
                station.Say("导出失败：" + path);
                return;
            }
            station.Log.Write(station.User, "导出" + name, quantity ? "数量统计" : "异常统计", string.Empty, path);
            station.Say("已导出" + name + "到 " + path);
        }

        private static string HourLabel(int hour)
        {
            return hour.ToString("00", CultureInfo.InvariantCulture) + ":00-"
                + ((hour + 1) % 24).ToString("00", CultureInfo.InvariantCulture) + ":00";
        }
    }
}
