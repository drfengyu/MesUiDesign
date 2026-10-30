using Mes.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 能耗监控（《Automation UI V3.11》P11）：左侧电压/电流仪表与今日累计，右侧按电、气、水分三页，
    /// 每页切实时曲线和历史柱状图。采样在 EnergyMeter 的后台线程里跑，这里只读快照和日统计表。
    /// </summary>
    public partial class PageEnergy : UserControl
    {
        private static readonly Color Green = Color.FromArgb(0, 160, 70);
        private static readonly Color Active = Color.FromArgb(40, 120, 200);
        private static readonly Color Yellow = Color.FromArgb(235, 175, 20);
        private static readonly Color Red = Color.FromArgb(200, 55, 55);
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

            gaugeVoltage.SetZones(
                new GaugeZone(0, 190, Red),
                new GaugeZone(190, 205, Yellow),
                new GaugeZone(205, 240, Green),
                new GaugeZone(240, 260, Yellow),
                new GaugeZone(260, 400, Red));
            gaugeCurrent.SetZones(
                new GaugeZone(0, 40, Green),
                new GaugeZone(40, 60, Yellow),
                new GaugeZone(60, 100, Red));
            airGaugePressure.SetZones(
                new GaugeZone(0, 600, Green),
                new GaugeZone(600, 700, Yellow),
                new GaugeZone(700, 800, Red));
            airGaugeFlow.SetZones(
                new GaugeZone(0, 60, Green),
                new GaugeZone(60, 80, Yellow),
                new GaugeZone(80, 100, Red));
            waterGaugePressure.SetZones(
                new GaugeZone(0, 500, Green),
                new GaugeZone(500, 650, Yellow),
                new GaugeZone(650, 800, Red));
            waterGaugeFlow.SetZones(
                new GaugeZone(0, 60, Green),
                new GaugeZone(60, 80, Yellow),
                new GaugeZone(80, 100, Red));
            airGaugePressure.SetValue(double.NaN);
            waterGaugePressure.SetValue(double.NaN);

            plotHistoryPower.Kind = PlotKind.Bars;
            plotHistoryAir.Kind = PlotKind.Bars;
            plotHistoryWater.Kind = PlotKind.Bars;

            plotVoltage.SetEmpty("等待采样");
            plotCurrent.SetEmpty("等待采样");
            plotPower.SetEmpty("等待采样");
            plotAirFlow.SetEmpty("等待采样");
            plotWaterFlow.SetEmpty("等待采样");
            plotAirPressure.SetEmpty("未接气路压力仪表，只有流量数据");
            plotWaterPressure.SetEmpty("未接供水压力仪表，只有流量数据");
            plotHistoryPower.SetEmpty("还没有日统计");
            plotHistoryAir.SetEmpty("还没有日统计");
            plotHistoryWater.SetEmpty("还没有日统计");

            RefreshModeButtons();
            refresh.Enabled = true;
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
                gaugeVoltage.SetValue(snapshot.Voltage);
                gaugeCurrent.SetValue(snapshot.Current);
                airGaugeFlow.SetValue(snapshot.AirFlow);
                waterGaugeFlow.SetValue(snapshot.WaterFlow);
                energyBox.Text = snapshot.Power.ToString("0.00") + " kW";
                voltageValue.Text = "实时电压  " + snapshot.Voltage.ToString("0.0") + " V";
                currentValue.Text = "实时电流  " + snapshot.Current.ToString("0.0") + " A";
                airFlowValue.Text = "实时流量  " + snapshot.AirFlow.ToString("0.00") + " L/min";
                waterFlowValue.Text = "实时流量  " + snapshot.WaterFlow.ToString("0.00") + " L/min";
            }
            else
            {
                gaugeVoltage.SetValue(double.NaN);
                gaugeCurrent.SetValue(double.NaN);
                airGaugeFlow.SetValue(double.NaN);
                waterGaugeFlow.SetValue(double.NaN);
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
                if (powerHistory) DrawHistory(plotHistoryPower, "耗电量", Color.FromArgb(40, 120, 200));
                else DrawLivePower(snapshot);
            }
            else if (tabs.SelectedIndex == 1)
            {
                if (airHistory) DrawHistory(plotHistoryAir, "耗气量", Color.FromArgb(0, 150, 170));
                else DrawLiveAir(snapshot);
            }
            else
            {
                if (waterHistory) DrawHistory(plotHistoryWater, "耗水量", Color.FromArgb(70, 130, 200));
                else DrawLiveWater(snapshot);
            }
        }

        private void DrawLivePower(EnergySnapshot snapshot)
        {
            var points = Tail(snapshot.Points, LivePoints);
            if (points.Length == 0)
            {
                plotVoltage.SetEmpty("等待采样");
                plotCurrent.SetEmpty("等待采样");
                plotPower.SetEmpty("等待采样");
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
            plotVoltage.SetSeries(new[] { Series("电压", voltage, Color.FromArgb(40, 120, 200)) }, labels);
            plotCurrent.SetSeries(new[] { Series("电流", current, Color.FromArgb(230, 150, 30)) }, labels);
            plotPower.SetSeries(new[] { Series("功率", power, Green) }, labels);
        }

        private void DrawLiveAir(EnergySnapshot snapshot)
        {
            var points = Tail(snapshot.Points, LivePoints);
            if (points.Length == 0)
            {
                plotAirFlow.SetEmpty("等待采样");
                return;
            }
            var labels = new string[points.Length];
            var flow = new double[points.Length];
            for (var i = 0; i < points.Length; i++)
            {
                labels[i] = i.ToString();
                flow[i] = points[i].AirFlow;
            }
            plotAirFlow.SetSeries(new[] { Series("流量", flow, Color.FromArgb(0, 150, 170)) }, labels);
        }

        private void DrawLiveWater(EnergySnapshot snapshot)
        {
            var points = Tail(snapshot.Points, LivePoints);
            if (points.Length == 0)
            {
                plotWaterFlow.SetEmpty("等待采样");
                return;
            }
            var labels = new string[points.Length];
            var flow = new double[points.Length];
            for (var i = 0; i < points.Length; i++)
            {
                labels[i] = i.ToString();
                flow[i] = points[i].WaterFlow;
            }
            plotWaterFlow.SetSeries(new[] { Series("流量", flow, Color.FromArgb(70, 130, 200)) }, labels);
        }

        private void DrawHistory(PlotBox plot, string column, Color color)
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
                plot.SetEmpty("还没有日统计；采样每 30 秒回写一次");
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
            plot.SetSeries(new[] { Series("每日", values, color) }, labels);
        }

        private static EnergyPoint[] Tail(EnergyPoint[] source, int count)
        {
            if (source == null || source.Length == 0) return new EnergyPoint[0];
            if (source.Length <= count) return source;
            var result = new EnergyPoint[count];
            Array.Copy(source, source.Length - count, result, 0, count);
            return result;
        }

        private static PlotSeries Series(string name, double[] values, Color color)
        {
            return new PlotSeries { Name = name, Values = values, Color = color };
        }
    }
}
