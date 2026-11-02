using Mes.Common;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>一条保养项（UI 文档 P40）。</summary>
    public class MaintenanceItem
    {
        /// <summary>大类：日保 / 周保 / 月保 / 年度，界面按它分组显示。</summary>
        public string Group;
        public string Item;

        /// <summary>周期文案，现场写"每 500 小时"这种，不做数值换算。</summary>
        public string Cycle;
        public string Content;
    }

    /// <summary>
    /// 维护保养表（数据\维护保养.csv）。
    ///
    /// 文档 P40 那一页是设备保养手册的截图（带图），仓库里没有原图，也不该拿别的设备图凑。
    /// 这里改成一张表：现场把保养手册按行抄进 csv，页面照分组显示，改内容不用重新编译。
    /// </summary>
    public class MaintenanceCatalog
    {
        public readonly List<MaintenanceItem> Items = new List<MaintenanceItem>();

        public void Load(string file)
        {
            Items.Clear();
            foreach (var line in TextFile.ReadAllLines(file, CodePages.Utf8WithBom()))
            {
                var cols = line.Split(',');
                if (cols.Length < 4) continue;
                var item = cols[1].Trim();
                if (item.Length == 0 || item == "保养项目") continue;
                Items.Add(new MaintenanceItem
                {
                    Group = cols[0].Trim(),
                    Item = item,
                    Cycle = cols[2].Trim(),
                    Content = cols[3].Trim(),
                });
            }
        }

        /// <summary>表里出现过的分组，按第一次出现的顺序。</summary>
        public List<string> Groups()
        {
            var groups = new List<string>();
            foreach (var item in Items)
            {
                if (!groups.Contains(item.Group)) groups.Add(item.Group);
            }
            return groups;
        }
    }
}
