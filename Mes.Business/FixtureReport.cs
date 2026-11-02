using Mes.Data;
using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>治具数量统计的一个小时格子：去重口径填 Distinct，不去重口径填 Count。</summary>
    public class HourlyFixture
    {
        public int Hour;
        public int Count;
        public int Distinct;

        /// <summary>该格出现过的治具码，供"全天去重"汇总用。</summary>
        public readonly HashSet<string> Codes = new HashSet<string>(StringComparer.Ordinal);
    }

    /// <summary>一个治具码的异常次数（治具异常统计 TOP5）。</summary>
    public class FixtureNg
    {
        public string Code;
        public int Count;
    }

    /// <summary>
    /// 治具统计（UI 文档 P19/P20）。只认追溯表里的"治具号"：
    /// 数量统计按生产时间归小时，异常统计按 NG/超期结论累加到治具码。
    /// </summary>
    public class FixtureReport
    {
        public static List<HourlyFixture> Quantity(List<Record> records, DateTime from, DateTime to)
        {
            var hours = new List<HourlyFixture>();
            var byHour = new Dictionary<int, HourlyFixture>();
            foreach (var hour in ThroughputReport.HourOrder)
            {
                var cell = new HourlyFixture { Hour = hour };
                hours.Add(cell);
                byHour[hour] = cell;
            }
            foreach (var row in records)
            {
                var code = row.Get("治具号");
                if (code.Length == 0) continue;
                DateTime at;
                if (!DateTime.TryParse(row.Get("生产时间"), out at)) continue;
                if (at < from || at > to) continue;
                var cell = byHour[at.Hour];
                cell.Count++;
                if (cell.Codes.Add(code)) cell.Distinct++;
            }
            return hours;
        }

        /// <summary>全天去重计数（P19 右上角"治具数量 xx pcs"）。</summary>
        public static int DistinctCount(List<HourlyFixture> hours)
        {
            var codes = new HashSet<string>(StringComparer.Ordinal);
            foreach (var cell in hours) codes.UnionWith(cell.Codes);
            return codes.Count;
        }

        /// <summary>按治具码统计异常次数，取前 top 名；同次数按治具码排序，榜单不会每次刷新换行。</summary>
        public static List<FixtureNg> NgTop(List<Record> records, DateTime from, DateTime to, int top)
        {
            var counts = new Dictionary<string, int>(StringComparer.Ordinal);
            foreach (var row in records)
            {
                var code = row.Get("治具号");
                if (code.Length == 0) continue;
                var verdict = row.Get("结果");
                if (verdict.Length == 0 || verdict == "OK") continue;
                DateTime at;
                if (!DateTime.TryParse(row.Get("生产时间"), out at)) continue;
                if (at < from || at > to) continue;
                int seen;
                counts.TryGetValue(code, out seen);
                counts[code] = seen + 1;
            }
            var list = new List<FixtureNg>();
            foreach (var pair in counts) list.Add(new FixtureNg { Code = pair.Key, Count = pair.Value });
            list.Sort((a, b) => a.Count != b.Count ? b.Count.CompareTo(a.Count) : string.CompareOrdinal(a.Code, b.Code));
            if (list.Count > top) list.RemoveRange(top, list.Count - top);
            return list;
        }
    }
}
