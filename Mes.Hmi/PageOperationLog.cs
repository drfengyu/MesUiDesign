using Mes.Business;
using Mes.Common;
using Mes.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 操作日志（《Automation UI V3.11》P35）：一张表看机台相关的三类流水，
    /// 类型下拉切换数据源——DT 记录来自 Uptime 台账，参数修改来自操作日志，生产记录来自 ProductLog。
    ///
    /// 表格固定四列（文档就是四列），换类型时只改列名，不重排版面。
    /// 机台名称这一台上位机只连一台机器：选到别的名字就是查不到，不假装能跨机台查。
    /// </summary>
    public partial class PageOperationLog : UserControl
    {
        private static readonly string[] KindNames = { "DT记录", "参数修改", "生产记录" };

        /// <summary>算"参数修改"的动作名，和各界面向 记录\操作日志 里写的那些字串一一对应。</summary>
        private static readonly string[] ParamActions = { "设定下发", "参数下发", "上传设置修改", "确认补偿偏差" };

        private readonly StationContext station;
        private List<string[]> rows = new List<string[]>();
        private string[] headers = { "开始时间", "结束时间", "故障代码", "故障描述" };

        public PageOperationLog()
        {
            InitializeComponent();
        }

        public PageOperationLog(StationContext station) : this()
        {
            this.station = station;
            machineCombo.Items.Add("全部");
            machineCombo.Items.Add(StationContext.MachineName);
            machineCombo.SelectedIndex = 0;
            foreach (var name in KindNames) typeCombo.Items.Add(name);
            typeCombo.SelectedIndex = 0;

            var now = DateTime.Now;
            fromPicker.Value = now.Date;
            toPicker.Value = now;
            Query();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void typeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            if (station == null) return;
            var from = fromPicker.Value;
            var to = toPicker.Value;
            if (to < from)
            {
                station.Say("结束时间不能早于起始时间，请重新选择");
                return;
            }
            rows = Build(from, to);
            if (MachineFilter()) rows = new List<string[]>();
            FillGrid();
        }

        /// <summary>选了别的机台名字时直接返回空表——本机只有一台设备的日志在本地。</summary>
        private bool MachineFilter()
        {
            var name = machineCombo.Text;
            return name.Length > 0 && name != "全部" && name != StationContext.MachineName;
        }

        private List<string[]> Build(DateTime from, DateTime to)
        {
            switch (typeCombo.SelectedIndex)
            {
                case 1:
                    headers = new[] { "时刻", "操作人", "对象", "改动" };
                    return BuildParam(from, to);
                case 2:
                    headers = new[] { "生产时间", "产品码", "结果", "治具号" };
                    return BuildProduction(from, to);
                default:
                    headers = new[] { "开始时间", "结束时间", "故障代码", "故障描述" };
                    return BuildDt(from, to);
            }
        }

        private List<string[]> BuildDt(DateTime from, DateTime to)
        {
            var result = new List<string[]>();
            foreach (var record in AlarmReport.FromUptime(station.Uptime.All(), station.Alarms, from, to))
            {
                result.Add(new[]
                {
                    record.Start.ToString("yyyy-MM-dd HH:mm:ss"),
                    record.End == DateTime.MinValue ? "进行中" : record.End.ToString("yyyy-MM-dd HH:mm:ss"),
                    record.Code,
                    record.Text,
                });
            }
            return result;
        }

        private List<string[]> BuildParam(DateTime from, DateTime to)
        {
            var result = new List<string[]>();
            foreach (var entry in station.Log.Read(from, to, null))
            {
                if (Array.IndexOf(ParamActions, entry.Action) < 0) continue;
                result.Add(new[]
                {
                    entry.At.ToString("yyyy-MM-dd HH:mm:ss"),
                    entry.Who,
                    entry.Target,
                    entry.Before + " → " + entry.After,
                });
            }
            return result;
        }

        private List<string[]> BuildProduction(DateTime from, DateTime to)
        {
            var key = barcodeBox.Text.Trim();
            var result = new List<string[]>();
            foreach (var row in station.ProductLog.Between(from, to))
            {
                var code = row.Get("产品码");
                if (key.Length > 0 && !code.Contains(key)) continue;
                result.Add(new[]
                {
                    row.Get("生产时间"),
                    code,
                    row.Get("结果"),
                    row.Get("治具号"),
                });
            }
            return result;
        }

        private void FillGrid()
        {
            colFirst.HeaderText = headers[0];
            colSecond.HeaderText = headers[1];
            colThird.HeaderText = headers[2];
            colFourth.HeaderText = headers[3];
            grid.SuspendLayout();
            grid.Rows.Clear();
            foreach (var row in rows)
            {
                grid.Rows.Add(row[0], row[1], row[2], row[3]);
            }
            grid.ClearSelection();
            grid.ResumeLayout();
        }

        // ── 导出 ──────────────────────────────────────────────────────────

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (station == null) return;
            if (rows.Count == 0)
            {
                station.Say("当前没有可导出的记录");
                return;
            }
            var sb = new StringBuilder();
            sb.AppendLine("机台名称," + StationContext.MachineName);
            sb.AppendLine("类型," + KindNames[typeCombo.SelectedIndex]);
            sb.AppendLine("起始," + fromPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine("结束," + toPicker.Value.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.AppendLine();
            sb.AppendLine(string.Join(",", headers));
            foreach (var row in rows)
            {
                var cells = new string[row.Length];
                for (var i = 0; i < row.Length; i++) cells[i] = Csv.Escape(row[i]);
                sb.AppendLine(string.Join(",", cells));
            }

            var path = Path.Combine(station.RecordFolder, "导出",
                "操作日志 " + DateTime.Now.ToString("yyyyMMdd HHmmss") + ".csv");
            if (!TextFile.WriteAllText(path, sb.ToString(), CodePages.Utf8WithBom()))
            {
                station.Say("导出失败：" + path);
                return;
            }
            station.Log.Write(station.User, "导出操作日志",
                KindNames[typeCombo.SelectedIndex], rows.Count.ToString(CultureInfo.InvariantCulture), path);
            station.Say("已导出 " + rows.Count + " 条到 " + path);
        }
    }
}
