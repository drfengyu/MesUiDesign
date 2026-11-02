using Mes.Data;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Mes.Business
{
    /// <summary>一个小时格子的运行/待机/计划停机/异常分钟数。</summary>
    public class HourlyTime
    {
        public int Hour;

        /// <summary>本格落进查询区间的分钟数：历史小时是 60，当前小时是已过分钟，未来小时是 0。</summary>
        public double Span;

        public double Run;

        /// <summary>待机（待料/闲置）本机没有信号，恒为 0；列留着是为了和文档的四个口径对齐。</summary>
        public double Idle;

        public double Planned;
        public double Fault;
    }

    /// <summary>
    /// 时间统计（UI 文档 P16/P17）。数据只来自 Uptime 台账：
    /// 计划停机记录记"计划停机"，故障记录记"异常"，运行 = 本格分钟 - 其余三项。
    /// 首件/切线是事件计时不是停机，不计入这四类。
    /// </summary>
    public class TimeStatisticsReport
    {
        public DateTime From;
        public DateTime To;
        public DateTime Now;

        public readonly List<HourlyTime> Hours = new List<HourlyTime>();

        public double TotalRun;
        public double TotalIdle;
        public double TotalPlanned;
        public double TotalFault;
        public double TotalSpan;

        /// <summary>时间移动 = 运行合计 / 区间分钟合计，文档 P16 的两行百分比就是这个。</summary>
        public double RunRate
        {
            get { return TotalSpan <= 0 ? 0 : TotalRun * 100D / TotalSpan; }
        }

        public static TimeStatisticsReport Build(List<Record> uptimeRows, DateTime from, DateTime to, DateTime now)
        {
            var report = new TimeStatisticsReport { From = from, To = to, Now = now };
            var end = to < now ? to : now;
            var cells = new Dictionary<int, HourlyTime>();
            foreach (var hour in ThroughputReport.HourOrder)
            {
                var cell = new HourlyTime { Hour = hour };
                report.Hours.Add(cell);
                cells[hour] = cell;
            }

            foreach (var cell in report.Hours)
            {
                for (var day = from.Date; day <= to.Date; day = day.AddDays(1))
                {
                    var hourStart = day.AddHours(cell.Hour);
                    var a = Max(hourStart, from);
                    var b = Min(Min(hourStart.AddHours(1), to), end);
                    if (b <= a) continue;
                    cell.Span += (b - a).TotalMinutes;
                    foreach (var row in uptimeRows)
                    {
                        var kind = row.Get("类型");
                        if (kind != UptimeTracker.PlannedStop && kind != UptimeTracker.Fault) continue;
                        DateTime started;
                        if (!DateTime.TryParse(row.Get("开始时间"), out started)) continue;
                        DateTime finished;
                        var open = !DateTime.TryParse(row.Get("结束时间"), out finished);
                        if (open) finished = end;
                        var x = Max(a, started);
                        var y = Min(b, finished);
                        if (y <= x) continue;
                        var minutes = (y - x).TotalMinutes;
                        if (kind == UptimeTracker.Fault) cell.Fault += minutes;
                        else cell.Planned += minutes;
                    }
                }
                cell.Run = Math.Max(0, cell.Span - cell.Idle - cell.Planned - cell.Fault);
                report.TotalSpan += cell.Span;
                report.TotalRun += cell.Run;
                report.TotalIdle += cell.Idle;
                report.TotalPlanned += cell.Planned;
                report.TotalFault += cell.Fault;
            }
            return report;
        }

        /// <summary>
        /// 区间内最近 N 片的 CT（秒），按追溯表顺序取尾部。
        /// CT 列就是机台量的两次下料间隔，不拿生产时间自己再算一遍。
        /// </summary>
        public static double[] RecentCt(ProductLogTable log, DateTime from, DateTime to, int count)
        {
            if (count <= 0) return new double[0];
            var ring = new double[count];
            var seen = 0;
            log.ScanBetween(from, to, row =>
            {
                double ct;
                if (!double.TryParse(row.Get("CT"), NumberStyles.Float, CultureInfo.InvariantCulture, out ct)) return;
                ring[seen % count] = ct;
                seen++;
            });
            var take = Math.Min(seen, count);
            var result = new double[take];
            for (var i = 0; i < take; i++)
            {
                result[i] = ring[(seen - take + i) % count];
            }
            return result;
        }

        private static DateTime Max(DateTime a, DateTime b)
        {
            return a > b ? a : b;
        }

        private static DateTime Min(DateTime a, DateTime b)
        {
            return a < b ? a : b;
        }
    }
}
