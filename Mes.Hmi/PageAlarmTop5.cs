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
    /// 报警TOP5（《Automation UI V3.11》P33）：左图按次数排、右图按停机时长排，
    /// 两张柱状图下面各配一张 代码/次数(分钟)/报警信息 的表。
    ///
    /// "读取报警履历"这一勾管的是要不要把没造成停机的瞬时报警也算进来：
    /// 不勾只看有停线时长的 DT，勾上就连分钟数为 0 的那此一起算次数。
    /// </summary>
    public partial class PageAlarmTop5 : UserControl
    {
        private static readonly Color[] Palette =
        {
            Color.FromArgb(225, 60, 60),
            Color.FromArgb(60, 170, 90),
            Color.FromArgb(245, 210, 60),
            Color.FromArgb(70, 110, 230),
            Color.FromArgb(235, 238, 242),
            Color.FromArgb(150, 90, 200),
            Color.FromArgb(240, 150, 40),
            Color.FromArgb(40, 170, 180),
            Color.FromArgb(170, 110, 80),
            Color.FromArgb(120, 126, 134),
        };

        private readonly StationContext station;

        public PageAlarmTop5()
        {
            InitializeComponent();
        }

        public PageAlarmTop5(StationContext station) : this()
        {
            this.station = station;
            ChartKit.StylePlot(plotCount);
            ChartKit.StylePlot(plotMinutes);
            ChartKit.Empty(plotCount, "暂无数据");
            ChartKit.Empty(plotMinutes, "暂无数据");
            var now = DateTime.Now;
            fromPicker.Value = now.AddHours(-24);
            toPicker.Value = now;
            Query();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void chkHistory_CheckedChanged(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            if (station == null) return;
            var from = fromPicker.Value;
            var to = toPicker.Value;
            if (to <= from)
            {
                station.Say("结束时间必须晚于起始时间，请重新选择");
                return;
            }
            var records = AlarmReport.FromUptime(station.Uptime.All(), station.Alarms, from, to);
            if (!chkHistory.Checked)
            {
                records.RemoveAll(r => r.Minutes <= 0);
            }
            if (records.Count == 0)
            {
                ChartKit.Empty(plotCount, "所选区间没有报警记录");
                ChartKit.Empty(plotMinutes, "所选区间没有报警记录");
                FillGrid(gridCount, new List<AlarmStat>(), false);
                FillGrid(gridMinutes, new List<AlarmStat>(), true);
                return;
            }
            var top = chkTop10.Checked ? 10 : 5;
            var byCount = AlarmReport.TopByCount(records, top);
            var byMinutes = AlarmReport.TopByMinutes(records, top);
            PaintPlot(plotCount, byCount, false);
            PaintPlot(plotMinutes, byMinutes, true);
            FillGrid(gridCount, byCount, false);
            FillGrid(gridMinutes, byMinutes, true);
        }

        private void PaintPlot(Chart chart, List<AlarmStat> stats, bool minutes)
        {
            var labels = new string[stats.Count];
            var values = new double[stats.Count];
            var peak = 0D;
            for (var i = 0; i < stats.Count; i++)
            {
                labels[i] = stats[i].Code;
                values[i] = minutes ? stats[i].Minutes : stats[i].Count;
                peak = Math.Max(peak, values[i]);
            }
            ChartKit.Fill(chart, labels, new[] { values }, 1);
            var series = chart.Series[0];
            for (var i = 0; i < series.Points.Count; i++)
            {
                series.Points[i].Color = Palette[i % Palette.Length];
            }
            var area = chart.ChartAreas[0];
            area.AxisY.Maximum = minutes
                ? Math.Max(1D, Math.Ceiling(peak * 1.2D))
                : Math.Max(1D, Math.Ceiling(peak * 1.25D));
            area.AxisY.Interval = Math.Max(1D, Math.Ceiling(area.AxisY.Maximum / 5D));
            area.AxisY.LabelStyle.Format = minutes ? "0.#" : "0";
        }

        private void FillGrid(DataGridView grid, List<AlarmStat> stats, bool minutes)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            foreach (var stat in stats)
            {
                grid.Rows.Add(stat.Code,
                    minutes ? stat.Minutes.ToString("0.###", CultureInfo.InvariantCulture)
                        : stat.Count.ToString(CultureInfo.InvariantCulture),
                    stat.Text);
            }
            grid.ClearSelection();
            grid.ResumeLayout();
        }
    }
}
