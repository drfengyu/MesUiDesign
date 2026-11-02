using Mes.Data;
using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>一个模组在查询区间里的时间账。</summary>
    public class ModuleTime
    {
        public string Name;
        public double Span;
        public double Run;
        public double Idle;
        public double Planned;
        public double Fault;
    }

    /// <summary>
    /// 性能仪表页的"时间分布图"（UI 文档 P18 弹窗）：按报警目录里的模组代码拆开，
    /// 每个模组的异常时间 = 该模组报警产生的故障记录时长。
    ///
    /// 计划停机是整机记录，落到每个模组头上；待机（待料/闲置）没有信号，恒为 0。
    /// 没匹配到报警代码的故障单独记在"未分类"，不硬塞进某个模组。
    /// </summary>
    public class TimeDistributionReport
    {
        public readonly List<ModuleTime> Modules = new List<ModuleTime>();
        public double Span;
        public double AverageRun;
        public double AverageIdle;
        public double AveragePlanned;
        public double AverageFault;

        public static TimeDistributionReport Build(List<Record> uptimeRows, AlarmCatalog alarms, DateTime from, DateTime to, DateTime now)
        {
            var report = new TimeDistributionReport();
            var end = to < now ? to : now;
            var span = Math.Max(0, (end - from).TotalMinutes);
            report.Span = span;

            var names = new List<string>();
            foreach (var info in alarms.Items)
            {
                var code = info.ModuleCode;
                if (code.Length == 0 || code == "-") continue;
                if (!names.Contains(code)) names.Add(code);
            }

            var planned = 0D;
            var faultByModule = new Dictionary<string, double>(StringComparer.Ordinal);
            foreach (var row in uptimeRows)
            {
                var kind = row.Get("类型");
                if (kind == UptimeTracker.PlannedStop)
                {
                    planned += Overlap(row, from, end);
                    continue;
                }
                if (kind != UptimeTracker.Fault) continue;
                var info = alarms.Find(row.Get("代码"));
                var name = info == null || info.ModuleCode.Length == 0 || info.ModuleCode == "-"
                    ? Unknown
                    : info.ModuleCode;
                if (!names.Contains(name)) names.Add(name);
                double sum;
                faultByModule.TryGetValue(name, out sum);
                faultByModule[name] = sum + Overlap(row, from, end);
            }
            planned = Math.Min(planned, span);

            foreach (var name in names)
            {
                double fault;
                faultByModule.TryGetValue(name, out fault);
                fault = Math.Min(fault, Math.Max(0, span - planned));
                report.Modules.Add(new ModuleTime
                {
                    Name = name,
                    Span = span,
                    Run = Math.Max(0, span - planned - fault),
                    Idle = 0,
                    Planned = planned,
                    Fault = fault,
                });
            }

            if (report.Modules.Count > 0)
            {
                foreach (var module in report.Modules)
                {
                    report.AverageRun += module.Run;
                    report.AverageIdle += module.Idle;
                    report.AveragePlanned += module.Planned;
                    report.AverageFault += module.Fault;
                }
                report.AverageRun /= report.Modules.Count;
                report.AverageIdle /= report.Modules.Count;
                report.AveragePlanned /= report.Modules.Count;
                report.AverageFault /= report.Modules.Count;
            }
            return report;
        }

        public const string Unknown = "未分类";

        /// <summary>一条 Uptime 记录落在查询区间里的分钟数；没结束的按查询终点算。</summary>
        private static double Overlap(Record row, DateTime from, DateTime end)
        {
            DateTime started;
            if (!DateTime.TryParse(row.Get("开始时间"), out started)) return 0;
            DateTime finished;
            if (!DateTime.TryParse(row.Get("结束时间"), out finished)) finished = end;
            var a = started > from ? started : from;
            var b = finished < end ? finished : end;
            return b > a ? (b - a).TotalMinutes : 0;
        }
    }
}
