using Mes.Common;
using System.Collections.Generic;
using System.Text;

namespace Mes.Business
{
    /// <summary>
    /// 过站判定窗口（数据\判定上下限.csv）。列名和追溯表的列名一一对应，
    /// 所以判定结果能直接落到 ProductLog 的那八列上，不用再维护第二份名字。
    ///
    /// 为什么放表里不放代码里：上下限是工艺改的，不是程序员改的。
    /// 现场换产品就要换窗口，改 csv 不用重新编译，这条和其他码表一致。
    /// </summary>
    public class QualityCatalog
    {
        public readonly List<QualityLimit> Items = new List<QualityLimit>();
        private readonly Dictionary<string, QualityLimit> byName =
            new Dictionary<string, QualityLimit>(System.StringComparer.Ordinal);

        public int Count { get { return Items.Count; } }

        public void Load(string file, Encoding encoding = null)
        {
            Items.Clear();
            byName.Clear();
            foreach (var line in TextFile.ReadAllLines(file, encoding ?? CodePages.Utf8WithBom()))
            {
                var cols = line.Split(',');
                if (cols.Length < 3) continue;
                var name = cols[0].Trim();
                if (name.Length == 0 || name == "名称") continue;
                double lower, upper;
                if (!double.TryParse(cols[1], out lower) || !double.TryParse(cols[2], out upper)) continue;
                var limit = new QualityLimit { Name = name, Lower = lower, Upper = upper };
                Items.Add(limit);
                byName[name] = limit;
            }
        }

        /// <summary>
        /// 哪些项超窗。返回的是"MC纠偏X 0.562 超上限 0.550"这种人能读的句子，
        /// 过站判定页直接列出来，操作员的报修内容就照这一行抄。
        /// </summary>
        public List<string> Violations(IEnumerable<KeyValuePair<string, double>> measured)
        {
            var bad = new List<string>();
            foreach (var pair in measured)
            {
                QualityLimit limit;
                if (!byName.TryGetValue(pair.Key, out limit)) continue;     // 表里没登记的项不判，免得漏一行就全线 NG
                if (!limit.InWindow(pair.Value))
                {
                    bad.Add(pair.Key + " " + NumberText.Format(pair.Value)
                        + (pair.Value > limit.Upper ? " 超上限 " : " 低于下限 ")
                        + NumberText.Format(pair.Value > limit.Upper ? limit.Upper : limit.Lower));
                }
            }
            return bad;
        }
    }
}
