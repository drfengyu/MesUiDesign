using Mes.Business;
using Mes.Devices;
using System;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 参数图表（《Automation UI V3.11》P6）：4 个腔体的压力、温度实时曲线，
    /// 500 ms 一个采样点、保留 50 点。和主界面一样，PLC 读在后台线程，界面只画快照。
    /// </summary>
    public partial class PageParamChart : UserControl
    {
        private const int SampleMs = 500;
        private const int Points = 50;
        private const string TabTitle = "页面0:穴1压力&温度(采样周期:500 ms)";

        private readonly StationContext station;
        private readonly object gate = new object();
        private readonly double[][] pressureBuffer = NewBuffer();
        private readonly double[][] temperatureBuffer = NewBuffer();
        private Snapshot snapshot;
        private volatile bool pumping;
        private int count;

        public PageParamChart()
        {
            InitializeComponent();
            Disposed += delegate { pumping = false; };
        }

        public PageParamChart(StationContext station) : this()
        {
            this.station = station;
            plotPressure.LabelInterval = 2;
            plotTemperature.LabelInterval = 2;
            plotPressure.SetEmpty("等待采样");
            plotTemperature.SetEmpty("等待采样");
            refresh.Enabled = true;
            pumping = true;
            var thread = new Thread(PumpLoop);
            thread.IsBackground = true;
            thread.Name = "参数图表采样";
            thread.Start();
        }

        private static double[][] NewBuffer()
        {
            var buffer = new double[4][];
            for (var i = 0; i < 4; i++) buffer[i] = new double[Points];
            return buffer;
        }

        private void PumpLoop()
        {
            while (pumping)
            {
                try
                {
                    // 贴合压力区每块 20 字（10 个浮点），4 块连续读 80 字、40 个浮点；
                    // 温度区每腔占 2 字（1 个浮点），读 8 字取回 4 个。
                    var p = station.Plc.ReadFloatArray(
                        PlcAddresses.Mw(PlcAddresses.StationPressureAreas[0]), 80);
                    var t = station.Plc.ReadFloatArray(
                        PlcAddresses.Mw(PlcAddresses.TemperatureArea), 8);
                    lock (gate)
                    {
                        var slot = count % Points;
                        for (var i = 0; i < 4; i++)
                        {
                            pressureBuffer[i][slot] = p[i * 10];
                            temperatureBuffer[i][slot] = t[i];
                        }
                        count++;
                        snapshot = new Snapshot
                        {
                            Revision = count,
                            Pressure = Ordered(pressureBuffer, count),
                            Temperature = Ordered(temperatureBuffer, count),
                        };
                    }
                }
                catch (Exception ex)
                {
                    lock (gate) { snapshot = new Snapshot { Revision = count, Error = ex.Message }; }
                }
                Thread.Sleep(SampleMs);
            }
        }

        private static double[][] Ordered(double[][] buffer, int total)
        {
            var n = Math.Min(total, Points);
            var start = total <= Points ? 0 : total % Points;
            var result = new double[4][];
            for (var i = 0; i < 4; i++)
            {
                result[i] = new double[n];
                for (var k = 0; k < n; k++) result[i][k] = buffer[i][(start + k) % Points];
            }
            return result;
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            Snapshot frame;
            lock (gate) { frame = snapshot; }
            if (frame == null) return;
            if (frame.Error != null)
            {
                tabPressure.Text = TabTitle + "　读取失败：" + frame.Error;
                return;
            }
            if (frame.Revision == shownRevision) return;
            shownRevision = frame.Revision;
            if (tabPressure.Text != TabTitle) tabPressure.Text = TabTitle;
            plotPressure.SetSeries(new[]
            {
                Series("穴1压力", frame.Pressure[0]),
                Series("穴2压力", frame.Pressure[1]),
                Series("穴3压力", frame.Pressure[2]),
                Series("穴4压力", frame.Pressure[3]),
            }, Labels(frame.Pressure[0].Length));
            plotTemperature.SetSeries(new[]
            {
                Series("穴1温度", frame.Temperature[0]),
                Series("穴2温度", frame.Temperature[1]),
                Series("穴3温度", frame.Temperature[2]),
                Series("穴4温度", frame.Temperature[3]),
            }, Labels(frame.Temperature[0].Length));
        }

        private int shownRevision = -1;

        private static PlotSeries Series(string name, double[] values)
        {
            return new PlotSeries { Name = name, Values = values };
        }

        private static string[] Labels(int count)
        {
            var labels = new string[count];
            for (var i = 0; i < count; i++) labels[i] = i.ToString(CultureInfo.InvariantCulture);
            return labels;
        }

        private sealed class Snapshot
        {
            public int Revision;
            public double[][] Pressure = new double[4][];
            public double[][] Temperature = new double[4][];
            public string Error;
        }
    }
}
