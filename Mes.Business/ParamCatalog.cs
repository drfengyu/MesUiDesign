using Mes.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mes.Business
{
    /// <summary>
    /// 参数表加载（参数名称.csv）。对应主项目 MainFrm.ImportCsv 里那段 FileStream + StreamReader。
    /// 它和 AlarmCatalog、IoCatalog 是同一类东西——读一张码表，不含界面代码，所以放业务层不放 UI 工程。
    ///
    /// 这里有一个必须记住的坑：现场导出的 CSV 是 GBK（ANSI）编码，
    /// 用默认 UTF-8 读，中文参数名全变乱码，而且不报错——
    /// 界面上一排问号，要等操作员第二天才告诉你。
    /// 所以读表必须显式指定编码；看到"名字乱码、数值正常"先怀疑编码，别怀疑 PLC。
    /// </summary>
    public class ParamCatalog
    {
        public readonly List<ParamDefinition> Items = new List<ParamDefinition>();

        /// <summary>encoding 不传就按现场的 GBK 读；显式传是为了单测和换编码时不用改代码。</summary>
        public void Load(string file, Encoding encoding = null)
        {
            Items.Clear();
            var lines = TextFile.ReadAllLines(file, encoding ?? CodePages.Gbk());
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var cols = line.Split(',');
                if (cols.Length < 5 || string.IsNullOrWhiteSpace(cols[1])) continue;
                var address = cols[2].Replace("MW", string.Empty).Trim();
                double lower, upper;
                double.TryParse(cols[3], out lower);
                double.TryParse(cols[4], out upper);
                int parsed;
                if (!int.TryParse(address, out parsed)) continue;   // 表头行、脏行都从这里跳过
                Items.Add(new ParamDefinition
                {
                    Name = cols[1].Trim(),
                    Address = parsed,
                    Lower = lower,
                    Upper = upper,
                });
            }
        }
    }
}
