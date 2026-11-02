using Mes.Common;
using System.Collections.Generic;
using System.Text;

namespace Mes.Business
{
    /// <summary>上传设置里的一行（一个键和它当前的值）。</summary>
    public class UploadSettingItem
    {
        public string Project;
        public string Group;
        public string Key;
        public string Value;
    }

    /// <summary>
    /// 上传设置（UI 文档 P30）。文档里这份配置写在 Config\ParamPage.ini，本机没有那个 ini，
    /// 改成一张同结构的 csv（数据\上传设置.csv：专案,分组,键,值），页面按 专案 + Trace/PDCA/OEE
    /// 分组显示，改完写回同一张表。
    ///
    /// 为什么整表重写而不是追加：这一共十几行，追加会变成"同一个键十条历史"，
    /// 读的时候还得挑最后一条，不如一次写平。
    /// </summary>
    public class UploadSettings
    {
        public readonly List<UploadSettingItem> Items = new List<UploadSettingItem>();
        private readonly List<string> projects = new List<string>();
        private readonly List<string> groups = new List<string>();

        public IReadOnlyList<string> Projects { get { return projects; } }
        public IReadOnlyList<string> Groups { get { return groups; } }

        public void Load(string file, Encoding encoding = null)
        {
            Items.Clear();
            projects.Clear();
            groups.Clear();
            foreach (var line in TextFile.ReadAllLines(file, encoding ?? CodePages.Utf8WithBom()))
            {
                var cols = line.Split(',');
                if (cols.Length < 4) continue;
                var key = cols[2].Trim();
                if (key.Length == 0 || key == "键") continue;
                var item = new UploadSettingItem
                {
                    Project = cols[0].Trim(),
                    Group = cols[1].Trim(),
                    Key = key,
                    Value = cols[3].Trim(),
                };
                Items.Add(item);
                if (!projects.Contains(item.Project)) projects.Add(item.Project);
                if (!groups.Contains(item.Group)) groups.Add(item.Group);
            }
        }

        public List<UploadSettingItem> Of(string project, string group)
        {
            var rows = new List<UploadSettingItem>();
            foreach (var item in Items)
            {
                if (item.Project == project && item.Group == group) rows.Add(item);
            }
            return rows;
        }

        /// <summary>改一个键的值；键不存在时追加一行。返回是否真的改动了。</summary>
        public bool SetValue(string project, string group, string key, string value)
        {
            foreach (var item in Items)
            {
                if (item.Project != project || item.Group != group || item.Key != key) continue;
                if (item.Value == value) return false;
                item.Value = value;
                return true;
            }
            Items.Add(new UploadSettingItem { Project = project, Group = group, Key = key, Value = value });
            if (!projects.Contains(project)) projects.Add(project);
            if (!groups.Contains(group)) groups.Add(group);
            return true;
        }

        public bool Save(string file)
        {
            var sb = new StringBuilder();
            sb.AppendLine("专案,分组,键,值");
            foreach (var item in Items)
            {
                sb.AppendLine(item.Project + "," + item.Group + "," + item.Key + "," + item.Value);
            }
            return TextFile.WriteAllText(file, sb.ToString(), CodePages.Utf8WithBom());
        }
    }
}
