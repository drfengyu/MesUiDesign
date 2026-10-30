using Mes.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Mes.Hmi
{
    /// <summary>
    /// 能耗监控（《Automation UI V3.11》P11）：左侧电压/电流仪表与今日累计，右侧按电、气、水分三页，
    /// 每页切实时曲线和历史柱状图。采样在 EnergyMeter 的后台线程里跑，这里只读快照和日统计表。
    /// </summary>
    public partial class PageEnergy : UserControl
    {
        private static readonly Color Active = Color.FromArgb(40, 120, 200);
        private static readonly Color Quiet = Color.FromArgb(90, 96, 105);
        private static readonly Color Idle = Color.FromArgb(238, 241, 244);
        private static readonly Color Border = Color.FromArgb(200, 205, 212);

        private const int LivePoints = 30;
        private const int HistoryDays = 7;

        private readonly StationContext station;
        private bool powerHistory;
        private bool airHistory;
        private bool waterHistory;
        private bool sizingTabs;
        private string shownKey = string.Empty;

        public PageEnergy()
        {
            InitializeComponent();
        }

        public PageEnergy(StationContext station) : this()
        {
            this.station = station;

            ChartKit.StyleGauge(gaugeVoltage);
            ChartKit.StyleGauge(gaugeCurrent);
            ChartKit.StyleGauge(airGaugePressure);
            ChartKit.StyleGauge(airGaugeFlow);
            ChartKit.StyleGauge(waterGaugePressure);
            ChartKit.StyleGauge(waterGaugeFlow);

            ChartKit.StylePlot(plotVoltage);
            ChartKit.StylePlot(plotCurrent);
            ChartKit.StylePlot(plotPower);
            ChartKit.StylePlot(plotHistoryPower);
            ChartKit.StylePlot(plotAirPressure);
            ChartKit.StylePlot(plotAirFlow);
            ChartKit.StylePlot(plotHistoryAir);
            ChartKit.StylePlot(plotWaterPressure);
            ChartKit.StylePlot(plotWaterFlow);
            ChartKit.StylePlot(plotHistoryWater);

            ChartKit.Empty(plotVoltage, "等待采样");
            ChartKit.Empty(plotCurrent, "等待采样");
            ChartKit.Empty(plotPower, "等待采样");
            ChartKit.Empty(plotAirFlow, "等待采样");
            ChartKit.Empty(plotWaterFlow, "等待采样");
            ChartKit.Empty(plotAirPressure, "未接气路压力仪表，只有流量数据");
            ChartKit.Empty(plotWaterPressure, "未接供水压力仪表，只有流量数据");
            ChartKit.Empty(plotHistoryPower, "还没有日统计");
            ChartKit.Empty(plotHistoryAir, "还没有日统计");
            ChartKit.Empty(plotHistoryWater, "还没有日统计");

            RefreshModeButtons();
            refresh.Enabled = true;
        }

        private void gauge_Resize(object sender, EventArgs e)
        {
            ChartKit.LayoutGauge((Chart)sender);
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            var snapshot = station.Energy.Snapshot();
            RefreshSummary(snapshot);

            var key = tabs.SelectedIndex
                + (powerHistory ? "H" : "L")
                + (airHistory ? "H" : "L")
                + (waterHistory ? "H" : "L")
                + "|" + (snapshot.Points.Length == 0
                    ? "-"
                    : snapshot.Points[snapshot.Points.Length - 1].Time.Ticks.ToString());
            if (key == shownKey) return;
            shownKey = key;
            DrawTab(snapshot);
        }

        private void RefreshSummary(EnergySnapshot snapshot)
        {
            if (snapshot.HasData)
            {
                ChartKit.SetGaugeValue(gaugeVoltage, snapshot.Voltage);
                ChartKit.SetGaugeValue(gaugeCurrent, snapshot.Current);
                ChartKit.SetGaugeValue(airGaugeFlow, snapshot.AirFlow);
                ChartKit.SetGaugeValue(waterGaugeFlow, snapshot.WaterFlow);
                energyBox.Text = snapshot.Power.ToString("0.00") + " kW";
                voltageValue.Text = "实时电压  " + snapshot.Voltage.ToString("0.0") + " V";
                currentValue.Text = "实时电流  " + snapshot.Current.ToString("0.0") + " A";
                airFlowValue.Text = "实时流量  " + snapshot.AirFlow.ToString("0.00") + " L/min";
                waterFlowValue.Text = "实时流量  " + snapshot.WaterFlow.ToString("0.00") + " L/min";
            }
            else
            {
                ChartKit.SetGaugeValue(gaugeVoltage, double.NaN);
                ChartKit.SetGaugeValue(gaugeCurrent, double.NaN);
                ChartKit.SetGaugeValue(airGaugeFlow, double.NaN);
                ChartKit.SetGaugeValue(waterGaugeFlow, double.NaN);
                energyBox.Text = "--";
                voltageValue.Text = "实时电压  --";
                currentValue.Text = "实时电流  --";
                airFlowValue.Text = "实时流量  --";
                waterFlowValue.Text = "实时流量  --";
            }
            airPressureValue.Text = "实时气压  --";
            waterPressureValue.Text = "实时水压  --";

            todayValue.Text = snapshot.TodayKwh.ToString("0.000") + " kWh";
            airEnergyBox.Text = snapshot.TodayAir.ToString("0.000") + " m³";
            waterEnergyBox.Text = snapshot.TodayWater.ToString("0.000") + " m³";
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTab();
        }

        private void tabs_Resize(object sender, EventArgs e)
        {
            if (sizingTabs) return;
            var count = tabs.TabCount;
            if (count == 0) return;
            var width = Math.Max(60, (tabs.ClientSize.Width - 4) / count);
            if (tabs.ItemSize.Width == width) return;
            sizingTabs = true;
            try
            {
                tabs.ItemSize = new Size(width, tabs.ItemSize.Height);
            }
            finally
            {
                sizingTabs = false;
            }
        }

        private void btnPowerLive_Click(object sender, EventArgs e)
        {
            powerHistory = false;
            RefreshTab();
        }

        private void btnPowerHistory_Click(object sender, EventArgs e)
        {
            powerHistory = true;
            RefreshTab();
        }

        private void btnAirLive_Click(object sender, EventArgs e)
        {
            airHistory = false;
            RefreshTab();
        }

        private void btnAirHistory_Click(object sender, EventArgs e)
        {
            airHistory = true;
            RefreshTab();
        }

        private void btnWaterLive_Click(object sender, EventArgs e)
        {
            waterHistory = false;
            RefreshTab();
        }

        private void btnWaterHistory_Click(object sender, EventArgs e)
        {
            waterHistory = true;
            RefreshTab();
        }

        private void RefreshTab()
        {
            RefreshModeButtons();
            shownKey = string.Empty;
            DrawTab(station.Energy.Snapshot());
        }

        private void RefreshModeButtons()
        {
            PaintMode(btnPowerLive, !powerHistory);
            PaintMode(btnPowerHistory, powerHistory);
            PaintMode(btnAirLive, !airHistory);
            PaintMode(btnAirHistory, airHistory);
            PaintMode(btnWaterLive, !waterHistory);
            PaintMode(btnWaterHistory, waterHistory);
            realPower.Visible = !powerHistory;
            plotHistoryPower.Visible = powerHistory;
            realAir.Visible = !airHistory;
            plotHistoryAir.Visible = airHistory;
            realWater.Visible = !waterHistory;
            plotHistoryWater.Visible = waterHistory;
        }

        private static void PaintMode(Button button, bool active)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.UseVisualStyleBackColor = false;
            button.BackColor = active ? Active : Idle;
            button.ForeColor = active ? Color.White : Quiet;
            button.FlatAppearance.BorderSize = active ? 0 : 1;
            button.FlatAppearance.BorderColor = Border;
        }

        private void DrawTab(EnergySnapshot snapshot)
        {
            if (tabs.SelectedIndex == 0)
            {
                if (powerHistory) DrawHistory(plotHistoryPower, "耗电量");
                else DrawLivePower(snapshot);
            }
            else if (tabs.SelectedIndex == 1)
            {
                if (airHistory) DrawHistory(plotHistoryAir, "耗气量");
                else DrawLiveAir(snapshot);
            }
            else
            {
                if (waterHistory) DrawHistory(plotHistoryWater, "耗水量");
                else DrawLiveWater(snapshot);
            }
        }

        private void DrawLivePower(EnergySnapshot snapshot)
        {
            var points = Tail(snapshot.Points, LivePoints);
            if (points.Length == 0)
            {
                ChartKit.Empty(plotVoltage, "等待采样");
                ChartKit.Empty(plotCurrent, "等待采样");
                ChartKit.Empty(plotPower, "等待采样");
                return;
            }
            var labels = new string[points.Length];
            var voltage = new double[points.Length];
            var current = new double[points.Length];
            var power = new double[points.Length];
            for (var i = 0; i < points.Length; i++)
            {
                labels[i] = i.ToString();
                voltage[i] = points[i].Voltage;
                current[i] = points[i].Current;
                power[i] = points[i].Power;
            }
            ChartKit.Fill(plotVoltage, labels, new[] { voltage });
            ChartKit.Fill(plotCurrent, labels, new[] { current });
            ChartKit.Fill(plotPower, labels, new[] { power });
        }

        private void DrawLiveAir(EnergySnapshot snapshot)
        {
            var points = Tail(snapshot.Points, LivePoints);
            if (points.Length == 0)
            {
                ChartKit.Empty(plotAirFlow, "等待采样");
                return;
            }
            var labels = new string[points.Length];
            var flow = new double[points.Length];
            for (var i = 0; i < points.Length; i++)
            {
                labels[i] = i.ToString();
                flow[i] = points[i].AirFlow;
            }
            ChartKit.Fill(plotAirFlow, labels, new[] { flow });
        }

        private void DrawLiveWater(EnergySnapshot snapshot)
        {
            var points = Tail(snapshot.Points, LivePoints);
            if (points.Length == 0)
            {
                ChartKit.Empty(plotWaterFlow, "等待采样");
                return;
            }
            var labels = new string[points.Length];
            var flow = new double[points.Length];
            for (var i = 0; i < points.Length; i++)
            {
                labels[i] = i.ToString();
                flow[i] = points[i].WaterFlow;
            }
            ChartKit.Fill(plotWaterFlow, labels, new[] { flow });
        }

        private void DrawHistory(Chart plot, string column)
        {
            var entries = new List<KeyValuePair<string, double>>();
            foreach (var row in station.EnergyDaily.All())
            {
                var day = row.Get("日期");
                double value;
                if (string.IsNullOrEmpty(day) || !double.TryParse(row.Get(column), out value)) continue;
                entries.Add(new KeyValuePair<string, double>(day, value));
            }
            if (entries.Count == 0)
            {
                ChartKit.Empty(plot, "还没有日统计；采样每 30 秒回写一次");
                return;
            }
            entries.Sort((a, b) => string.CompareOrdinal(a.Key, b.Key));
            var start = Math.Max(0, entries.Count - HistoryDays);
            var count = entries.Count - start;
            var values = new double[count];
            var labels = new string[count];
            for (var i = 0; i < count; i++)
            {
                values[i] = entries[start + i].Value;
                var day = entries[start + i].Key;
                labels[i] = day.Length >= 5 ? day.Substring(5) : day;
            }
            ChartKit.Fill(plot, labels, new[] { values });
        }

        private static EnergyPoint[] Tail(EnergyPoint[] source, int count)
        {
            if (source == null || source.Length == 0) return new EnergyPoint[0];
            if (source.Length <= count) return source;
            var result = new EnergyPoint[count];
            Array.Copy(source, source.Length - count, result, 0, count);
            return result;
        }
    }
}
