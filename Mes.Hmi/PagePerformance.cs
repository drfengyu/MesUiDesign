using Mes.Business;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 性能仪表（《Automation UI V3.11》P18）：Uptime 占比、UPH 达成率、一次良率三个仪表盘。
    /// Uptime 占比取时间统计的运行占比，UPH 达成率按"合格数 ÷ 理论产量"算，
    /// 一次良率 = 合格 ÷ (合格 + NG)。区间里没有记录时指针藏起来、数字显示 "--"，
    /// 不拿 0 冒充 0%。
    /// </summary>
    public partial class PagePerformance : UserControl
    {
        private readonly StationContext station;
        private string viewKey = string.Empty;
        private bool syncing;

        public PagePerformance()
        {
            InitializeComponent();
        }

        public PagePerformance(StationContext station) : this()
        {
            this.station = station;
            ChartKit.StyleGauge(gaugeUptime);
            ChartKit.StyleGauge(gaugeUph);
            ChartKit.StyleGauge(gaugeYield);

            var now = DateTime.Now;
            var shiftDay = now.Hour >= 8 ? now.Date : now.Date.AddDays(-1);
            syncing = true;
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

            var time = TimeStatisticsReport.Build(station.Uptime.All(), from, to, DateTime.Now);
            var throughput = ThroughputReport.Build(station.ProductLog, from, to, station.Targets.TargetUph);
            var uptimeRate = time.TotalSpan > 0 ? time.RunRate : double.NaN;
            var uphRate = throughput.TheoreticalOutput > 0 ? throughput.UphRate : double.NaN;
            var yieldRate = throughput.TotalPassed + throughput.TotalNg > 0 ? throughput.FirstPassYield : double.NaN;

            var key = from.Ticks + "|" + to.Ticks + "|" + KeyText(uptimeRate) + "|" + KeyText(uphRate) + "|" + KeyText(yieldRate);
            if (key == viewKey) return;
            viewKey = key;
            ChartKit.SetGaugeValue(gaugeUptime, uptimeRate);
            ChartKit.SetGaugeValue(gaugeUph, uphRate);
            ChartKit.SetGaugeValue(gaugeYield, yieldRate);
        }

        private static string KeyText(double value)
        {
            return double.IsNaN(value) ? "NA" : value.ToString("0.###", CultureInfo.InvariantCulture);
        }

        private void gauge_Resize(object sender, EventArgs e)
        {
            ChartKit.LayoutGauge((System.Windows.Forms.DataVisualization.Charting.Chart)sender);
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

        private void btnDistribution_Click(object sender, EventArgs e)
        {
            if (station == null) return;
            using (var dialog = new TimeDistributionDialog(station, fromPicker.Value, toPicker.Value))
            {
                dialog.ShowDialog(FindForm());
            }
        }
    }
}
