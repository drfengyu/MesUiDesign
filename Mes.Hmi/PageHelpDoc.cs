using Mes.Business;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 帮助组的两张文档页（《Automation UI V3.11》P39 故障处理 / P40 维护保养）。
    ///
    /// 文档里这两页都是把手册截图贴在滚动区里：原图不在仓库里，拿别的设备图凑就是假图，
    /// 所以改成同一张四列表——列宽列数一样，只是数据来源和列名不同：
    /// 故障处理取 数据\报警目录.csv 的代码/等级/描述/处理对策，
    /// 维护保养取 数据\维护保养.csv 的分组/项目/周期/内容。现场改 csv 就能换文案，不用重新编译。
    /// </summary>
    public partial class PageHelpDoc : UserControl
    {
        public enum Kind { Trouble, Maintenance }

        public PageHelpDoc()
        {
            InitializeComponent();
        }

        public PageHelpDoc(StationContext station, Kind kind) : this()
        {
            Fill(kind == Kind.Trouble ? PrepareTrouble(station) : PrepareMaintenance(station));
        }

        private void Fill(string[][] rows)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            foreach (var row in rows) grid.Rows.Add(row[0], row[1], row[2], row[3]);
            grid.ClearSelection();
            grid.ResumeLayout();
        }

        // ── 故障处理 ──────────────────────────────────────────────────────

        private string[][] PrepareTrouble(StationContext station)
        {
            caption.Text = "故障处理";
            hintLabel.Text = "内容取自 数据\\报警目录.csv（现场同一张表），报警码、等级与处理对策一一对应。";
            colOne.HeaderText = "报警代码";
            colTwo.HeaderText = "等级";
            colThree.HeaderText = "故障描述";
            colFour.HeaderText = "处理对策";
            colOne.FillWeight = 14F;
            colTwo.FillWeight = 8F;
            colThree.FillWeight = 30F;
            colFour.FillWeight = 48F;

            var rows = new List<string[]>();
            if (station != null && station.Alarms != null)
            {
                foreach (var info in station.Alarms.Items)
                {
                    if (info.Code == "0000000") continue;     // 这一行是"运行"，不是故障
                    rows.Add(new[] { info.Code, info.Level.ToString(), info.Title, info.Solution });
                }
            }
            return rows.ToArray();
        }

        // ── 维护保养 ──────────────────────────────────────────────────────

        private string[][] PrepareMaintenance(StationContext station)
        {
            caption.Text = "维护保养";
            hintLabel.Text = "内容取自 数据\\维护保养.csv：现场按设备保养手册逐行维护，改表不用重新编译。";
            colOne.HeaderText = "分组";
            colTwo.HeaderText = "保养项目";
            colThree.HeaderText = "周期";
            colFour.HeaderText = "内容";
            colOne.FillWeight = 10F;
            colTwo.FillWeight = 20F;
            colThree.FillWeight = 10F;
            colFour.FillWeight = 60F;

            var items = station == null ? null : station.Maintenance.Items;
            var rows = new List<string[]>();
            if (items != null)
            {
                foreach (var item in items)
                {
                    rows.Add(new[] { item.Group, item.Item, item.Cycle, item.Content });
                }
            }
            return rows.ToArray();
        }
    }
}
