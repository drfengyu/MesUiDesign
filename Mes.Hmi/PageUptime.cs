using Mes.Business;
using Mes.Common;
using Mes.Data;
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
    /// Uptime 记录（《Automation UI V3.11》P5）：计划停机、首件、切线三组手动计时，
    /// 故障由报警线程自动登记、也可手动补一笔；下面是记录表和按 DT 分类的停机饼图。
    /// </summary>
    public partial class PageUptime : UserControl
    {
        private static readonly Color RunningText = Color.FromArgb(0, 140, 60);
        private static readonly Color IdleText = Color.FromArgb(120, 126, 134);
        private static readonly Color FaultText = Color.FromArgb(200, 40, 40);
        private static readonly Color OpenRow = Color.FromArgb(255, 248, 220);

        private readonly StationContext station;
        private string gridKey = string.Empty;
        private int tick;

        public PageUptime()
        {
            InitializeComponent();
        }

        public PageUptime(StationContext station) : this()
        {
            this.station = station;
            fromPicker.Value = DateTime.Today.AddDays(-7);
            toPicker.Value = DateTime.Now;
            refresh.Enabled = true;
            RefreshTimers();
            RefreshFault();
            Query();
            PaintPie();
        }

        // ── 计时 ───────────────────────────────────────────────────────────

        private void refresh_Tick(object sender, EventArgs e)
        {
            tick++;
            RefreshTimers();
            RefreshFault();
            if (tick % 3 == 0) AutoRefreshGrid();
            if (tick % 5 == 0) PaintPie();
        }

        private void RefreshTimers()
        {
            ShowKind(UptimeTracker.PlannedStop, plannedElapsed, btnPlannedStart, btnPlannedEnd);
            ShowKind(UptimeTracker.FirstArticle, firstElapsed, btnFirstStart, btnFirstEnd);
            ShowKind(UptimeTracker.Changeover, changeElapsed, btnChangeStart, btnChangeEnd);
        }

        private void ShowKind(string kind, Label elapsed, Button start, Button end)
        {
            var running = station.Uptime.IsRunning(kind);
            start.Enabled = !running;
            end.Enabled = running;
            var at = station.Uptime.StartedAt(kind);
            if (!running || !at.HasValue)
            {
                SetText(elapsed, "未计时");
                elapsed.ForeColor = IdleText;
                return;
            }
            var span = DateTime.Now - at.Value;
            SetText(elapsed, string.Format("计时中 {0:00}:{1:00}:{2:00}　开始 {3:HH:mm:ss}",
                (int)span.TotalHours, span.Minutes, span.Seconds, at.Value));
            elapsed.ForeColor = RunningText;
        }

        private void RefreshFault()
        {
            var fault = station.Uptime.CurrentFault;
            btnEndFault.Enabled = fault != null;
            if (fault == null)
            {
                SetText(faultLabel, "当前无故障");
                SetText(faultCodeBox, string.Empty);
                SetText(faultStartLabel, string.Empty);
                faultLabel.ForeColor = IdleText;
                return;
            }
            var at = station.Uptime.StartedAt(UptimeTracker.Fault);
            var span = at.HasValue ? DateTime.Now - at.Value : TimeSpan.Zero;
            SetText(faultCodeBox, fault.Get("代码"));
            SetText(faultStartLabel, fault.Get("开始时间"));
            SetText(faultLabel, fault.Get("描述")
                + "　已停 " + string.Format("{0:00}:{1:00}:{2:00}", (int)span.TotalHours, span.Minutes, span.Seconds));
            faultLabel.ForeColor = FaultText;
        }

        private void btnPlannedStart_Click(object sender, EventArgs e) { StartKind(UptimeTracker.PlannedStop); }
        private void btnPlannedEnd_Click(object sender, EventArgs e) { EndKind(UptimeTracker.PlannedStop); }
        private void btnFirstStart_Click(object sender, EventArgs e) { StartKind(UptimeTracker.FirstArticle); }
        private void btnFirstEnd_Click(object sender, EventArgs e) { EndKind(UptimeTracker.FirstArticle); }
        private void btnChangeStart_Click(object sender, EventArgs e) { StartKind(UptimeTracker.Changeover); }
        private void btnChangeEnd_Click(object sender, EventArgs e) { EndKind(UptimeTracker.Changeover); }

        private void StartKind(string kind)
        {
            if (station.Uptime.IsRunning(kind)) return;
            station.Uptime.Start(kind, station.User);
            station.Log.Write(station.User, "开始" + kind, "Uptime", string.Empty, string.Empty);
            station.Say(kind + " 开始计时");
            RefreshTimers();
            AutoRefreshGrid();
        }

        private void EndKind(string kind)
        {
            if (!station.Uptime.IsRunning(kind)) return;
            station.Uptime.End(kind);
            station.Log.Write(station.User, "结束" + kind, "Uptime", string.Empty, string.Empty);
            station.Say(kind + " 已结束");
            RefreshTimers();
            AutoRefreshGrid();
            PaintPie();
        }

        private void btnManualFault_Click(object sender, EventArgs e)
        {
            using (var dialog = new FaultCodeDialog(station.Alarms))
            {
                if (dialog.ShowDialog(this) != DialogResult.OK || dialog.SelectedAlarm == null) return;
                var info = dialog.SelectedAlarm;
                station.Uptime.FaultStarted(info, station.User);
                station.Log.Write(station.User, "手动登记故障", info.Code, string.Empty, info.Title);
                station.Say("已登记故障 " + info.Code + " " + info.Title);
            }
            RefreshFault();
            AutoRefreshGrid();
        }

        private void btnEndFault_Click(object sender, EventArgs e)
        {
            if (station.Uptime.CurrentFault == null) return;
            station.Uptime.FaultEnded();
            station.Log.Write(station.User, "结束故障", "Uptime", string.Empty, string.Empty);
            station.Say("故障计时已结束");
            RefreshFault();
            AutoRefreshGrid();
            PaintPie();
        }

        // ── 记录表 ─────────────────────────────────────────────────────────

        private List<Record> Rows()
        {
            var from = fromPicker.Value;
            var to = toPicker.Value;
            var result = new List<Record>();
            foreach (var row in station.Uptime.Recent(2000))
            {
                DateTime at;
                if (!DateTime.TryParse(row.Get("开始时间"), out at)) continue;
                if (at < from || at > to) continue;
                result.Add(row);
            }
            return result;
        }

        /// <summary>一秒一次整表重画会闪；只有记录真的变了才重填。</summary>
        private void AutoRefreshGrid()
        {
            var rows = Rows();
            var key = rows.Count + "|"
                + (rows.Count > 0 ? rows[0].Get("开始时间") + rows[0].Get("结束时间") + rows[0].Get("分钟") : string.Empty);
            if (key == gridKey) return;
            gridKey = key;
            FillGrid(rows);
        }

        private void FillGrid(List<Record> rows)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            for (var i = 0; i < rows.Count; i++)
            {
                var row = rows[i];
                var code = row.Get("代码");
                var text = row.Get("描述");
                if (code.Length == 0) code = row.Get("类型");
                if (text.Length == 0) text = row.Get("类型");
                var index = grid.Rows.Add(i + 1, row.Get("开始时间"), code, row.Get("分钟"), text);
                if (row.Get("结束时间").Length == 0) grid.Rows[index].DefaultCellStyle.BackColor = OpenRow;
            }
            grid.ResumeLayout();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (toPicker.Value < fromPicker.Value)
            {
                station.Say("结束时间早于开始时间，请重新选择");
                return;
            }
            Query();
            PaintPie();
        }

        private void Query()
        {
            gridKey = string.Empty;
            AutoRefreshGrid();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var rows = Rows();
            var sb = new StringBuilder();
            sb.AppendLine("类型,开始时间,结束时间,分钟,代码,描述,操作人");
            foreach (var row in rows)
            {
                sb.AppendLine(string.Join(",", Csv.Escape(row.Get("类型")), Csv.Escape(row.Get("开始时间")),
                    Csv.Escape(row.Get("结束时间")), Csv.Escape(row.Get("分钟")), Csv.Escape(row.Get("代码")),
                    Csv.Escape(row.Get("描述")), Csv.Escape(row.Get("操作人"))));
            }
            var path = Path.Combine(station.RecordFolder, "导出",
                "Uptime " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".csv");
            if (!TextFile.WriteAllText(path, sb.ToString(), CodePages.Utf8WithBom()))
            {
                station.Say("导出失败：" + path);
                return;
            }
            station.Log.Write(station.User, "导出Uptime", rows.Count.ToString(CultureInfo.InvariantCulture), string.Empty, path);
            station.Say("已导出 " + rows.Count + " 条到 " + path);
        }

        // ── 饼图 ───────────────────────────────────────────────────────────

        private void PaintPie()
        {
            var stats = station.Uptime.DowntimeByClass(fromPicker.Value, toPicker.Value);
            var names = new List<string>();
            var values = new List<double>();
            foreach (var pair in stats)
            {
                if (pair.Value <= 0) continue;
                names.Add(pair.Key);
                values.Add(pair.Value);
            }
            if (values.Count == 0)
            {
                plotPie.SetEmpty("所选范围内没有已结束的故障");
                return;
            }
            var labels = new string[names.Count];
            for (var i = 0; i < names.Count; i++)
            {
                labels[i] = string.Format("{0} {1:00}:{2:00}", names[i],
                    (int)(values[i] / 60), (int)values[i] % 60);
            }
            plotPie.SetSeries(new[]
            {
                new PlotSeries { Name = "停机分钟", Values = values.ToArray() },
            }, labels);
        }

        private static void SetText(TextBox box, string text)
        {
            if (box.Text != text) box.Text = text;
        }

        private static void SetText(Label label, string text)
        {
            if (label.Text != text) label.Text = text;
        }
    }
}
