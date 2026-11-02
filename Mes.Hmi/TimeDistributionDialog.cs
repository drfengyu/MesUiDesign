using Mes.Business;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 性能仪表页的时间分布图（《Automation UI V3.11》P18 弹窗）：按报警目录的模组代码拆分，
    /// 左边四色平均时间、右边每模组明细，下面是各模组的堆叠条。
    /// </summary>
    public partial class TimeDistributionDialog : Form
    {
        public TimeDistributionDialog()
        {
            InitializeComponent();
        }

        public TimeDistributionDialog(StationContext station, DateTime from, DateTime to) : this()
        {
            Text = "时间分布图：" + from.ToString("yyyy-MM-dd HH:mm") + " ~ " + to.ToString("yyyy-MM-dd HH:mm");
            gridModule.Resize += (s, e) => FitGridRows();
            ChartKit.StylePlot(plotModule);
            plotModule.Titles[0].Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            plotModule.Titles[0].ForeColor = System.Drawing.Color.FromArgb(30, 70, 140);

            var report = TimeDistributionReport.Build(station.Uptime.All(), station.Alarms, from, to, DateTime.Now);
            runSummary.Text = "平均运行时间  " + Duration(report.AverageRun);
            idleSummary.Text = "平均待机时间  " + Duration(report.AverageIdle);
            planSummary.Text = "平均计划停机  " + Duration(report.AveragePlanned);
            faultSummary.Text = "平均异常时间  " + Duration(report.AverageFault);

            FillGrid(report);
            PaintChart(report);
        }

        private void FillGrid(TimeDistributionReport report)
        {
            gridModule.SuspendLayout();
            gridModule.Rows.Clear();
            for (var i = 0; i < report.Modules.Count; i++)
            {
                var module = report.Modules[i];
                gridModule.Rows.Add("#" + (i + 1) + "  " + module.Name,
                    Duration(module.Run), Duration(module.Idle), Duration(module.Planned), Duration(module.Fault));
            }
            if (gridModule.Rows.Count > 0) FitGridRows();
            gridModule.ClearSelection();
            gridModule.ResumeLayout();
        }

        private void FitGridRows()
        {
            if (gridModule.Rows.Count == 0) return;
            var height = Math.Max(24, (gridModule.ClientSize.Height - gridModule.ColumnHeadersHeight - 2) / gridModule.Rows.Count);
            foreach (DataGridViewRow row in gridModule.Rows) row.Height = height;
        }

        private void PaintChart(TimeDistributionReport report)
        {
            var labels = new string[report.Modules.Count];
            var run = new double[labels.Length];
            var idle = new double[labels.Length];
            var planned = new double[labels.Length];
            var fault = new double[labels.Length];
            for (var i = 0; i < labels.Length; i++)
            {
                labels[i] = "#" + (i + 1) + " " + report.Modules[i].Name;
                run[i] = report.Modules[i].Run;
                idle[i] = report.Modules[i].Idle;
                planned[i] = report.Modules[i].Planned;
                fault[i] = report.Modules[i].Fault;
            }
            // 前四个是图例占位（无点），后四个才是横条；堆叠顺序仍是 运行→待机→计划→异常。
            ChartKit.Fill(plotModule, labels, new double[][] { null, null, null, null, run, idle, planned, fault }, 1);
            var area = plotModule.ChartAreas[0];
            var top = Math.Max(1D, Math.Ceiling(report.Span));
            area.AxisY.Minimum = 0;
            area.AxisY.Maximum = top;
            area.AxisY.Interval = Math.Max(1D, Math.Ceiling(top / 6D));
        }

        private static string Duration(double minutes)
        {
            if (minutes <= 0) return "0:00.00";
            var totalSeconds = Math.Round(minutes * 60D, 2);
            var hours = (int)(totalSeconds / 3600D);
            var minutesPart = (int)(totalSeconds % 3600D / 60D);
            var secondsPart = (int)(totalSeconds % 60D);
            return hours.ToString(CultureInfo.InvariantCulture) + ":"
                + minutesPart.ToString("00", CultureInfo.InvariantCulture) + "."
                + secondsPart.ToString("00", CultureInfo.InvariantCulture);
        }
    }
}
