using Mes.Data;
using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>
    /// 产能统计的算法。
    ///
    /// 为什么单独放在业务层：主项目这块的算法整个写在
    /// `DataStatisticsFrm.btn_SelectEfficiency_Click`（@1900）里，
    /// 四个 DateTimePicker、拼 SQL、算比率、生成 html、WebBrowser 刷新全搅在一起，
    /// 想单独验一下"某一个小时算得对不对"都无从下手。
    /// 这里只吃记录数组 + 时间区间，页面负责把结果画出来。
    /// </summary>
    public class ThroughputReport
    {
        /// <summary>
        /// 小时格子的行序，抄主项目 Mes.Global/Global.cs:108 的 time_index：
        /// 从 8 点起、到次日 7 点止。现场一天是按 08:00 切班的，
        /// 所以表格第一行是 08 而不是 00——照数字大小排会把一个班劈成两段。
        /// </summary>
        public static readonly int[] HourOrder =
        {
            8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
            20, 21, 22, 23, 0, 1, 2, 3, 4, 5, 6, 7
        };

        public DateTime From;
        public DateTime To;
        public double TargetUph;

        public readonly List<HourlyThroughput> Hours = new List<HourlyThroughput>();

        public int TotalInput;
        public int TotalCompleted;
        public int TotalPassed;
        public int TotalNg;

        /// <summary>直通率：口径同 HourlyThroughput.YieldRate，只算有结论的。</summary>
        public double FirstPassYield
        {
            get { return TotalPassed + TotalNg == 0 ? 0 : TotalPassed * 100D / (TotalPassed + TotalNg); }
        }

        /// <summary>理论产量 = 区间分钟数 / 60 × 目标 UPH（主项目 @1946 同一条式子）。</summary>
        public double TheoreticalOutput
        {
            get { return TargetUph <= 0 ? 0 : (To - From).TotalMinutes / 60D * TargetUph; }
        }

        public double UphRate
        {
            get { return TheoreticalOutput <= 0 ? 0 : TotalPassed * 100D / TheoreticalOutput; }
        }

        /// <summary>
        /// 稼动率要的是"这段时间里机器运行了多久"，那份账在 OEE_DT 里
        /// （主项目 @1919 就是 select RunStatus, TimeSpan from OEE_DT 累加的）。
        /// 到目前为止还没有任何流程往 OEE_DT 写记录，所以这里不假装算得出来，
        /// 直接把"没接"写在脸上——等做报警与 DT 那块功能，它会换成真数字。
        /// </summary>
        public string AvailabilityText = "未接：OEE_DT 无记录";

        /// <summary>
        /// 这一段区间落在哪个班。判断照主项目 @1094~1116 的三段：
        /// 08:00~20:00 是白班，20:00~次日 08:00 是夜班，跨 20:00 的它要拆成两条 SQL 分别查。
        /// </summary>
        public string Shift
        {
            get
            {
                var dayShiftStart = From.Date.AddHours(8);
                var handover = From.Date.AddHours(20);
                var nightShiftEnd = From.Date.AddDays(1).AddHours(8);
                if (From >= dayShiftStart && To <= handover) return "白班 08:00~20:00";
                if (From >= handover && To <= nightShiftEnd) return "夜班 20:00~次日08:00";
                if (To <= handover) return "白班之内（不满一个班）";
                return "跨班：白 + 夜";
            }
        }

        /// <summary>
        /// 把 ProductLog 的记录按小时归格子。
        /// 用"生产时间"（报站那一刻）归小时，不是"流程结束时间"——
        /// 现场问的是"8 点这一小时投了多少片进去"，按结束时间算会把跨点的那片挪到下一格里。
        /// </summary>
        public static ThroughputReport Build(List<Record> records, DateTime from, DateTime to, double targetUph)
        {
            var report = new ThroughputReport { From = from, To = to, TargetUph = targetUph };
            var cells = new Dictionary<int, HourlyThroughput>();
            foreach (var hour in HourOrder)
            {
                var cell = new HourlyThroughput { Hour = hour };
                report.Hours.Add(cell);
                cells[hour] = cell;
            }

            foreach (var row in records)
            {
                DateTime at;
                if (!DateTime.TryParse(row.Get("生产时间"), out at)) continue;
                if (at < from || at > to) continue;
                var cell = cells[at.Hour];
                cell.Input++;
                if (!string.IsNullOrEmpty(row.Get("流程结束时间"))) cell.Completed++;
                var verdict = row.Get("结果");
                if (verdict == "OK") cell.Passed++;
                else if (verdict.EndsWith("NG")) cell.Ng++;
            }

            foreach (var cell in report.Hours)
            {
                // 一个小时的理论产量就是目标 UPH 本身，所以达成率 = 合格 / 目标UPH
                cell.UphRate = targetUph <= 0 ? 0 : cell.Passed * 100D / targetUph;
                report.TotalInput += cell.Input;
                report.TotalCompleted += cell.Completed;
                report.TotalPassed += cell.Passed;
                report.TotalNg += cell.Ng;
            }
            return report;
        }
    }
}
