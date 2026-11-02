using Mes.Data;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Mes.Business
{
    /// <summary>抛料表里的一行：统计项目 + 数量 + 占投入的百分比。</summary>
    public class ScrapItem
    {
        public string Name;
        public int Count;

        /// <summary>占本班投入数量的百分比；投入为 0 时是 0。</summary>
        public double Percent;
    }

    /// <summary>一个班次的抛料账。分组名照 UI 文档 P14 的两段（1st Pass Yield / PF）。</summary>
    public class ScrapShift
    {
        public string Shift;

        /// <summary>投入数量 = 本班有生产时间的记录数。</summary>
        public int Input;

        public int Passed;
        public int Ng;

        public readonly List<ScrapItem> YieldItems = new List<ScrapItem>();
        public readonly List<ScrapItem> PfItems = new List<ScrapItem>();

        public double YieldRate
        {
            get { return Passed + Ng == 0 ? 0 : Passed * 100D / (Passed + Ng); }
        }

        public int CountedNg
        {
            get
            {
                var count = 0;
                foreach (var item in YieldItems) count += item.Count;
                foreach (var item in PfItems) count += item.Count;
                return count;
            }
        }
    }

    /// <summary>一个小时格子的抛料数据；ByItem 供下方"该时段抛料项目"柱图用。</summary>
    public class HourlyScrap
    {
        public int Hour;
        public int Input;
        public int Passed;
        public int Ng;
        public double NgRate;
        public readonly Dictionary<string, int> ByItem = new Dictionary<string, int>(StringComparer.Ordinal);
    }

    /// <summary>
    /// 抛料统计（UI 文档 P14/P15）的归类。
    ///
    /// 归类依据不是另记一份"NG 原因"：追溯表只写"左焊后过站NG"这种工序结论，
    /// 真正的超窗项在八列测量值里，所以这里拿判定上下限重算一遍，落在哪一组就记哪一组。
    /// 治具保养超期单列到 Trace 卡控——它是过站卡控，不是焊接不良。
    /// </summary>
    public class ScrapReport
    {
        public const string PassYieldGroup = "1st Pass Yield";
        public const string PfGroup = "PF";

        public static readonly string[] YieldNgNames =
        {
            "BG Overtime NG", "BG定位NG", "BG纠偏NG", "BG压力NG", "Trace卡控NG",
        };

        public static readonly string[] PfNgNames =
        {
            "RFID NG", "Trace上传NG", "MES上传NG", "BG来料NG",
        };

        public readonly ScrapShift Day = new ScrapShift { Shift = "白班" };
        public readonly ScrapShift Night = new ScrapShift { Shift = "晚班" };
        public readonly List<HourlyScrap> Hours = new List<HourlyScrap>();

        /// <summary>白班 08:00~20:00、晚班 20:00~次日 08:00，和 ThroughputReport 的班次口径一致。</summary>
        public static string ShiftOf(DateTime at)
        {
            return at.Hour >= 8 && at.Hour < 20 ? "白班" : "晚班";
        }

        public static ScrapReport Build(List<Record> records, QualityCatalog limits, DateTime from, DateTime to)
        {
            var report = new ScrapReport();
            var cells = Init(report);
            foreach (var row in records) Count(report, cells, row, limits, from, to);
            Finish(report);
            return report;
        }

        /// <summary>
        /// 直接从追溯表扫，给每几秒自动刷新的页面用。归类要读八列测量值，
        /// 但没必要先把全天记录复制成字典再归类——数完就扔的活别分配内存。
        /// </summary>
        public static ScrapReport Build(ProductLogTable log, QualityCatalog limits, DateTime from, DateTime to)
        {
            var report = new ScrapReport();
            var cells = Init(report);
            log.ScanBetween(from, to, row => Count(report, cells, row, limits, from, to));
            Finish(report);
            return report;
        }

        private static Dictionary<int, HourlyScrap> Init(ScrapReport report)
        {
            var cells = new Dictionary<int, HourlyScrap>();
            foreach (var hour in ThroughputReport.HourOrder)
            {
                var cell = new HourlyScrap { Hour = hour };
                report.Hours.Add(cell);
                cells[hour] = cell;
            }
            foreach (var shift in new[] { report.Day, report.Night })
            {
                foreach (var name in YieldNgNames) shift.YieldItems.Add(new ScrapItem { Name = name });
                foreach (var name in PfNgNames) shift.PfItems.Add(new ScrapItem { Name = name });
            }
            return cells;
        }

        private static void Count(ScrapReport report, Dictionary<int, HourlyScrap> cells,
            Record row, QualityCatalog limits, DateTime from, DateTime to)
        {
            DateTime at;
            if (!DateTime.TryParse(row.Get("生产时间"), out at)) return;
            if (at < from || at > to) return;
            var shift = ShiftOf(at) == "白班" ? report.Day : report.Night;
            var cell = cells[at.Hour];
            shift.Input++;
            cell.Input++;

            var verdict = row.Get("结果");
            if (verdict.Length == 0) return;
            if (verdict == "OK")
            {
                shift.Passed++;
                cell.Passed++;
                return;
            }

            shift.Ng++;
            cell.Ng++;
            var category = Classify(row, limits);
            Add(shift, category);
            int seen;
            cell.ByItem.TryGetValue(category, out seen);
            cell.ByItem[category] = seen + 1;
        }

        private static void Finish(ScrapReport report)
        {
            foreach (var shift in new[] { report.Day, report.Night })
            {
                foreach (var item in shift.YieldItems) item.Percent = Percent(item.Count, shift.Input);
                foreach (var item in shift.PfItems) item.Percent = Percent(item.Count, shift.Input);
            }
            foreach (var cell in report.Hours)
            {
                cell.NgRate = cell.Input == 0 ? 0 : cell.Ng * 100D / cell.Input;
            }
        }

        /// <summary>
        /// 一条 NG 记录落到文档那张表的哪一行。测量项和列的对应：
        /// MC纠偏 → BG定位，贴合纠偏 → BG纠偏，微动补偿 → BG压力；
        /// 一项都没超（或八列还没回填）的按 Trace 卡控，宁可归到卡控也不要丢一条 NG。
        /// </summary>
        private static string Classify(Record row, QualityCatalog limits)
        {
            if (row.Get("结果").Contains("治具")) return "Trace卡控NG";
            if (Violates(row, limits, "MC纠偏")) return "BG定位NG";
            if (Violates(row, limits, "贴合纠偏")) return "BG纠偏NG";
            if (Violates(row, limits, "微动补偿")) return "BG压力NG";
            return "Trace卡控NG";
        }

        private static bool Violates(Record row, QualityCatalog limits, string prefix)
        {
            foreach (var limit in limits.Items)
            {
                if (!limit.Name.StartsWith(prefix, StringComparison.Ordinal)) continue;
                double value;
                if (!double.TryParse(row.Get(limit.Name), NumberStyles.Float, CultureInfo.InvariantCulture, out value)) continue;
                if (!limit.InWindow(value)) return true;
            }
            return false;
        }

        private static void Add(ScrapShift shift, string name)
        {
            var items = IsPf(name) ? shift.PfItems : shift.YieldItems;
            foreach (var item in items)
            {
                if (item.Name != name) continue;
                item.Count++;
                return;
            }
            // 不在文档列的那几行的 NG（比如以后加的扫码NG）另起一行，不并进别的分类。
            items.Add(new ScrapItem { Name = name, Count = 1 });
        }

        private static bool IsPf(string name)
        {
            foreach (var known in PfNgNames)
            {
                if (known == name) return true;
            }
            return false;
        }

        private static double Percent(int count, int input)
        {
            return input == 0 ? 0 : count * 100D / input;
        }
    }
}
