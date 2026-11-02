using Mes.Data;
using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>一条报警流水。数据源是 Uptime 台账里 类型=故障 的那些行——机台报一次警就是一条 DT。</summary>
    public class AlarmRecord
    {
        public DateTime Start;
        public DateTime End;
        public double Minutes;
        public string Code;
        public string Text;

        /// <summary>报警目录里的模组代码（SCN-01 之类），整机视图靠它定位到部位。</summary>
        public string Module;
    }

    /// <summary>按代码汇总出来的一行，报警TOP5 和异常分析都用它。</summary>
    public class AlarmStat
    {
        public string Code;
        public string Text;
        public int Count;
        public double Minutes;
    }

    /// <summary>
    /// 报警履历的查询与汇总（UI 文档 P32/P33/P34）。
    ///
    /// 为什么不再单独存一张"报警历史.csv"：报警落 Uptime 台账时已经带了
    /// 开始/结束/分钟/代码/描述，再存一份就是两处对不上，TOP5 到底信谁说不清。
    /// </summary>
    public static class AlarmReport
    {
        /// <summary>文档 P34 那四个类型勾选框，对应报警代码去掉首位 6 之后的前三位。</summary>
        public static readonly string[] TypeNames = { "机构(600)", "气动(601)", "电控(602)", "视觉(603)" };

        public static List<AlarmRecord> FromUptime(List<Record> rows, AlarmCatalog catalog, DateTime from, DateTime to)
        {
            var records = new List<AlarmRecord>();
            foreach (var row in rows)
            {
                if (row.Get("类型") != "故障") continue;
                DateTime start, end;
                if (!DateTime.TryParse(row.Get("开始时间"), out start)) continue;
                if (start < from || start > to) continue;
                DateTime.TryParse(row.Get("结束时间"), out end);
                var code = row.Get("代码");
                var info = catalog == null ? null : catalog.Find(code);
                double minutes;
                if (!double.TryParse(row.Get("分钟"), out minutes)) minutes = 0;
                records.Add(new AlarmRecord
                {
                    Start = start,
                    End = end,
                    Minutes = minutes,
                    Code = code,
                    Text = info != null ? info.Title : row.Get("描述"),
                    Module = info != null ? info.ModuleCode : string.Empty,
                });
            }
            records.Sort((a, b) => a.Start.CompareTo(b.Start));
            return records;
        }

        /// <summary>全部传 -1；否则传 TypeNames 的下标，按代码前三位筛。</summary>
        public static bool MatchesType(AlarmRecord record, int typeIndex)
        {
            if (typeIndex < 0) return true;
            var code = record.Code ?? string.Empty;
            if (code.Length < 4) return false;
            return code.StartsWith(TypeNames[typeIndex].Substring(3, 3), StringComparison.Ordinal);
        }

        public static List<AlarmStat> TopByCount(List<AlarmRecord> records, int top)
        {
            var stats = Summarize(records);
            stats.Sort((a, b) => b.Count.CompareTo(a.Count));
            return Trim(stats, top);
        }

        public static List<AlarmStat> TopByMinutes(List<AlarmRecord> records, int top)
        {
            var stats = Summarize(records);
            stats.Sort((a, b) => b.Minutes.CompareTo(a.Minutes));
            return Trim(stats, top);
        }

        private static List<AlarmStat> Summarize(List<AlarmRecord> records)
        {
            var byCode = new Dictionary<string, AlarmStat>(StringComparer.Ordinal);
            var order = new List<AlarmStat>();
            foreach (var record in records)
            {
                AlarmStat stat;
                if (!byCode.TryGetValue(record.Code, out stat))
                {
                    stat = new AlarmStat { Code = record.Code, Text = record.Text };
                    byCode[record.Code] = stat;
                    order.Add(stat);
                }
                stat.Count++;
                stat.Minutes += record.Minutes;
            }
            return order;
        }

        private static List<AlarmStat> Trim(List<AlarmStat> stats, int top)
        {
            if (top > 0 && stats.Count > top) stats.RemoveRange(top, stats.Count - top);
            return stats;
        }
    }
}
