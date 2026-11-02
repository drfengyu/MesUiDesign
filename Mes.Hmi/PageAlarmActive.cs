using Mes.Business;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 当前报警（《Automation UI V3.11》P31）：左边列机台此刻挂着的报警，
    /// 右边整机视图把报警所在的部位点亮。清除报警那颗按钮在左侧二级页签下面（ShellForm 里），
    /// 文档 P31~P35 五页共用同一颗，不在每页各摆一份。
    /// </summary>
    public partial class PageAlarmActive : UserControl
    {
        private readonly StationContext station;
        private bool blink;

        public PageAlarmActive()
        {
            InitializeComponent();
        }

        public PageAlarmActive(StationContext station) : this()
        {
            this.station = station;
            MachineMap.Build(map, station.Zones);
            map.Resize += (s, e) => MachineMap.Layout(map);
            refresh.Enabled = true;
            RefreshView();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void RefreshView()
        {
            if (station == null) return;
            var active = station.ActiveAlarms.Snapshot();
            var lit = new List<string>();
            list.BeginUpdate();
            list.Items.Clear();
            foreach (var entry in active)
            {
                list.Items.Add(entry.ToString());
                var info = station.Alarms.Find(entry.Code);
                if (info == null || string.IsNullOrEmpty(info.ModuleCode)) continue;
                if (!lit.Contains(info.ModuleCode)) lit.Add(info.ModuleCode);
            }
            list.EndUpdate();
            listCaption.Text = "当前报警：" + active.Count.ToString(CultureInfo.InvariantCulture) + " 条";
            blink = !blink;
            MachineMap.Paint(map, lit, null, blink);
        }
    }
}
