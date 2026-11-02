using Mes.Business;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 异常分析（《Automation UI V3.11》P34）：左边按时间段+故障类型把 DT 汇总成一张表，
    /// 右边整机视图把选中故障所在的部位闪红灯，点表格行或点红灯都刷新下面的处理对策。
    ///
    /// 文档第 4 条要"可能原因与处理对策"，现场报警目录里只有 中文描述 和 处理对策 两列，
    /// 这里就摆这两列——不另起一列"原因"，编出来的原因现场对不上号，审核时反成问题。
    /// </summary>
    public partial class PageFaultAnalysis : UserControl
    {
        private readonly StationContext station;
        private readonly CheckBox[] typeBoxes = new CheckBox[4];

        private List<AlarmRecord> records = new List<AlarmRecord>();
        private List<AlarmStat> stats = new List<AlarmStat>();
        private List<string> litModules = new List<string>();
        private string selectedModule;
        private bool blink;
        private bool syncingChecks;

        public PageFaultAnalysis()
        {
            InitializeComponent();
        }

        public PageFaultAnalysis(StationContext station) : this()
        {
            this.station = station;
            typeBoxes[0] = chkType0;
            typeBoxes[1] = chkType1;
            typeBoxes[2] = chkType2;
            typeBoxes[3] = chkType3;
            for (var i = 0; i < typeBoxes.Length; i++)
            {
                typeBoxes[i].Text = AlarmReport.TypeNames[i];
                typeBoxes[i].CheckedChanged += typeBox_CheckedChanged;
            }

            MachineMap.Build(map, station.Zones);
            map.Resize += (s, e) => MachineMap.Layout(map);
            foreach (Control control in map.Controls) control.Click += zone_Click;

            var now = DateTime.Now;
            fromPicker.Value = now.AddDays(-1);
            toPicker.Value = now;
            blinkTimer.Enabled = true;
            Query();
        }

        // ── 查询条件 ──────────────────────────────────────────────────────

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void sort_CheckedChanged(object sender, EventArgs e)
        {
            Query();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (syncingChecks) return;
            syncingChecks = true;
            foreach (var box in typeBoxes) box.Checked = chkAll.Checked;
            syncingChecks = false;
            Query();
        }

        private void typeBox_CheckedChanged(object sender, EventArgs e)
        {
            if (syncingChecks) return;
            var all = true;
            foreach (var box in typeBoxes) all = all && box.Checked;
            syncingChecks = true;
            chkAll.Checked = all;
            syncingChecks = false;
            Query();
        }

        /// <summary>勾了哪几类；一个都没勾返回空数组，调用方据此给出提示而不是显示全表。</summary>
        private List<int> CheckedTypes()
        {
            var types = new List<int>();
            for (var i = 0; i < typeBoxes.Length; i++)
            {
                if (typeBoxes[i].Checked) types.Add(i);
            }
            return types;
        }

        // ── 查询 ──────────────────────────────────────────────────────────

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
            var types = CheckedTypes();
            if (types.Count == 0)
            {
                records = new List<AlarmRecord>();
                stats = new List<AlarmStat>();
                FillGrid();
                ShowDetail(-1);
                station.Say("至少勾选一种故障类型");
                return;
            }

            var all = AlarmReport.FromUptime(station.Uptime.All(), station.Alarms, from, to);
            records = new List<AlarmRecord>();
            foreach (var record in all)
            {
                foreach (var type in types)
                {
                    if (AlarmReport.MatchesType(record, type))
                    {
                        records.Add(record);
                        break;
                    }
                }
            }
            stats = radioCount.Checked
                ? AlarmReport.TopByCount(records, 0)
                : AlarmReport.TopByMinutes(records, 0);
            FillGrid();
            if (stats.Count > 0) gridFault.Rows[0].Selected = true;
            else ShowDetail(-1);
        }

        private void FillGrid()
        {
            gridFault.SuspendLayout();
            gridFault.Rows.Clear();
            foreach (var stat in stats)
            {
                gridFault.Rows.Add(stat.Code,
                    stat.Minutes.ToString("0.###", CultureInfo.InvariantCulture),
                    stat.Count.ToString(CultureInfo.InvariantCulture),
                    stat.Text);
            }
            gridFault.ClearSelection();
            gridFault.ResumeLayout();
        }

        // ── 选中行 → 整机视图 + 处理对策 ──────────────────────────────────

        private void gridFault_SelectionChanged(object sender, EventArgs e)
        {
            if (gridFault.CurrentRow == null) return;
            ShowDetail(gridFault.CurrentRow.Index);
        }

        private void zone_Click(object sender, EventArgs e)
        {
            var zone = (sender as Control).Tag as MachineZone;
            if (zone == null) return;
            for (var i = 0; i < stats.Count; i++)
            {
                if (ModuleOf(stats[i].Code) != zone.Module) continue;
                gridFault.ClearSelection();
                gridFault.Rows[i].Selected = true;
                ShowDetail(i);
                return;
            }
        }

        private void ShowDetail(int index)
        {
            if (index < 0 || index >= stats.Count)
            {
                litModules = new List<string>();
                selectedModule = null;
                zoneValue.Text = "—";
                descValue.Text = "—";
                solutionValue.Text = string.Empty;
                PaintMap();
                return;
            }
            var code = stats[index].Code;
            var info = station.Alarms.Find(code);
            selectedModule = ModuleOf(code);
            litModules = new List<string>();
            foreach (var record in records)
            {
                if (record.Code != code || string.IsNullOrEmpty(record.Module)) continue;
                if (!litModules.Contains(record.Module)) litModules.Add(record.Module);
            }
            var zone = station.Zones.Find(selectedModule);
            var missing = info == null;
            zoneValue.Text = zone == null
                ? (string.IsNullOrEmpty(selectedModule) ? "报警目录未标注部位" : selectedModule)
                : zone.Name + "（" + zone.Module + "）";
            descValue.Text = missing ? "报警目录里没有这条代码" : info.Title;
            solutionValue.Text = missing ? "代码没登记在 数据\\报警目录.csv，处理对策无从显示" : info.Solution;
            PaintMap();
        }

        /// <summary>这条代码挂在哪个部位——取履历里第一条带模组代码的记录。</summary>
        private string ModuleOf(string code)
        {
            foreach (var record in records)
            {
                if (record.Code == code && !string.IsNullOrEmpty(record.Module)) return record.Module;
            }
            return string.Empty;
        }

        private void blinkTimer_Tick(object sender, EventArgs e)
        {
            blink = !blink;
            PaintMap();
        }

        private void PaintMap()
        {
            MachineMap.Paint(map, litModules, selectedModule, blink);
        }
    }
}
