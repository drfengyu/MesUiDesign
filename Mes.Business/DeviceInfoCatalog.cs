using Mes.Common;
using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>设备信息的一行（分组,名称,值），对应 UI 文档 P41 的三块卡片。</summary>
    public class DeviceInfo
    {
        public string Group;
        public string Name;
        public string Value;
    }

    /// <summary>
    /// 设备信息表（数据\设备信息.csv）。
    ///
    /// 表里现在这几行硬件型号是照 UI 文档 P41 截图抄的示例值：这台样机没有实物可查，
    /// 空着比编一个更像真的强，现场接手时按设备铭牌逐行改掉就行。
    /// "软件框架版本"不写在这张表里——那是程序集版本，改了表也和实际跑的版本对不上，
    /// 设备信息页直接从 AssemblyInfo 读。
    /// </summary>
    public class DeviceInfoCatalog
    {
        public readonly List<DeviceInfo> Items = new List<DeviceInfo>();

        public void Load(string file)
        {
            Items.Clear();
            foreach (var line in TextFile.ReadAllLines(file, CodePages.Utf8WithBom()))
            {
                var cols = line.Split(',');
                if (cols.Length < 3) continue;
                var name = cols[1].Trim();
                if (name.Length == 0 || name == "名称") continue;
                Items.Add(new DeviceInfo { Group = cols[0].Trim(), Name = name, Value = cols[2].Trim() });
            }
        }

        public List<DeviceInfo> Of(string group)
        {
            var rows = new List<DeviceInfo>();
            foreach (var item in Items)
            {
                if (string.Equals(item.Group, group, StringComparison.Ordinal)) rows.Add(item);
            }
            return rows;
        }

        /// <summary>按名称取值；没这一行返回空串，界面自己决定显示"未登记"还是留白。</summary>
        public string Value(string name)
        {
            foreach (var item in Items)
            {
                if (string.Equals(item.Name, name, StringComparison.Ordinal)) return item.Value;
            }
            return string.Empty;
        }
    }
}
