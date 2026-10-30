using Mes.Common;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>
    /// 报警码表。真文件 155 行、GBK 编码、12 列：
    /// 序号,代码,中文描述,等级,模组代码,处理对策,DT分类EN,DT分类CN,类别EN,类别CN,英文描述,大类
    ///
    /// 三条只有看过真代码才知道的事实：
    /// 1) PLC 报上来的是**表内序号**（MW62001~62005 里的值），不是 7 位代码。
    ///    因为一个 16 位字最大 32767，装不下 6010044。所以主项目建了两本字典：
    ///    按序号查（给 PLC 用）、按代码查（给人搜索用）。这里两本都建了。
    /// 2) 代码列不能转 int —— 表里有 0000000（运行），转 int 再格式化就丢前导零。
    /// 3) 对策全文里只有全角逗号，所以敢直接 Split(',')；哪天有人补了半角逗号就会串列，
    ///    所以做了列数校验，列数不够的行直接跳过而不是硬取第 6 列。
    /// </summary>
    public class AlarmCatalog
    {
        public readonly List<AlarmInfo> Items = new List<AlarmInfo>();
        private readonly Dictionary<string, AlarmInfo> byCode = new Dictionary<string, AlarmInfo>();
        private readonly Dictionary<int, AlarmInfo> byIndex = new Dictionary<int, AlarmInfo>();

        public int Count { get { return Items.Count; } }

        public static AlarmCatalog Load(string file)
        {
            var catalog = new AlarmCatalog();
            foreach (var line in TextFile.ReadAllLines(file, CodePages.Gbk()))
            {
                var cols = line.Split(',');
                if (cols.Length < 12) continue;
                int index, level;
                if (!int.TryParse(cols[0], out index)) continue;
                int.TryParse(cols[3], out level);
                var info = new AlarmInfo
                {
                    Index = index,
                    Code = cols[1].Trim(),
                    Title = cols[2].Trim(),
                    Level = level,
                    ModuleCode = cols[4].Trim().Replace("|", string.Empty),
                    Solution = cols[5].Trim(),
                    DtClass = cols[7].Trim(),
                    Category = cols[9].Trim(),
                    TitleEn = cols[10].Trim(),
                };
                catalog.Items.Add(info);
                if (info.Code.Length > 0) catalog.byCode[info.Code] = info;
                if (!catalog.byIndex.ContainsKey(index)) catalog.byIndex[index] = info;
            }
            return catalog;
        }

        /// <summary>按 7 位代码查（对应主项目 Global.ED[code]）</summary>
        public AlarmInfo Find(string code)
        {
            AlarmInfo info;
            return byCode.TryGetValue(code ?? string.Empty, out info) ? info : null;
        }

        /// <summary>按表内序号查（MW62001~62005 里放的就是这个序号，对应主项目 Global.ed[index]）。</summary>
        public AlarmInfo FindByIndex(int index)
        {
            AlarmInfo info;
            return byIndex.TryGetValue(index, out info) ? info : null;
        }
    }
}
