using Mes.Data;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Mes.Business
{
    /// <summary>
    /// Uptime / DT 的计时。计划停机、首件、切线各只有一条"正在计时"的记录；
    /// 故障由报警线程开始、复位时结束，也可以由操作员手动登记。
    /// </summary>
    public class UptimeTracker
    {
        public const string PlannedStop = "计划停机";
        public const string FirstArticle = "首件";
        public const string Changeover = "切线";
        public const string Fault = "故障";

        private readonly UptimeTable table;
        private readonly AlarmCatalog alarms;
        private readonly object gate = new object();
        private readonly Dictionary<string, Record> open = new Dictionary<string, Record>(StringComparer.Ordinal);
        private Record openFault;

        public UptimeTracker(UptimeTable table, AlarmCatalog alarms)
        {
            this.table = table;
            this.alarms = alarms;
            foreach (var row in table.All())
            {
                if (row.Get("结束时间").Length == 0) open[row.Get("类型")] = row;
            }
            open.TryGetValue(Fault, out openFault);
        }

        public void Start(string kind, string user)
        {
            lock (gate)
            {
                End(kind);
                var at = DateTime.Now;
                table.Insert(kind, at, string.Empty, kind, user);
                open[kind] = table.Last(r => r.Get("类型") == kind && r.Get("开始时间") == Stamp(at));
            }
        }

        public void End(string kind)
        {
            lock (gate)
            {
                Record row;
                if (!open.TryGetValue(kind, out row)) return;
                Close(row);
                open.Remove(kind);
                if (kind == Fault) openFault = null;
            }
        }

        public void FaultStarted(AlarmInfo info, string user)
        {
            if (info == null) return;
            lock (gate)
            {
                if (openFault != null) Close(openFault);
                var at = DateTime.Now;
                table.Insert(Fault, at, info.Code, info.Title, user);
                openFault = table.Last(r => r.Get("类型") == Fault && r.Get("开始时间") == Stamp(at));
                open[Fault] = openFault;
            }
        }

        public void FaultEnded()
        {
            lock (gate)
            {
                if (openFault == null) return;
                Close(openFault);
                openFault = null;
                open.Remove(Fault);
            }
        }

        public Record CurrentFault
        {
            get { lock (gate) return openFault == null ? null : new Record(openFault); }
        }

        public bool IsRunning(string kind)
        {
            lock (gate) return open.ContainsKey(kind);
        }

        public DateTime? StartedAt(string kind)
        {
            lock (gate)
            {
                Record row;
                if (!open.TryGetValue(kind, out row)) return null;
                DateTime at;
                return DateTime.TryParse(row.Get("开始时间"), out at) ? at : (DateTime?)null;
            }
        }

        public List<Record> Recent(int count)
        {
            return table.Tail(count);
        }

        /// <summary>按时长统计各 DT 分类，给饼图用；只统计已经结束的故障。</summary>
        public Dictionary<string, double> DowntimeByClass(DateTime from, DateTime to)
        {
            var result = new Dictionary<string, double>(StringComparer.Ordinal);
            foreach (var row in table.All())
            {
                if (row.Get("类型") != Fault) continue;
                DateTime at;
                if (!DateTime.TryParse(row.Get("开始时间"), out at) || at < from || at > to) continue;
                double minutes;
                if (!double.TryParse(row.Get("分钟"), NumberStyles.Float, CultureInfo.InvariantCulture, out minutes)) continue;
                var info = alarms.Find(row.Get("代码"));
                var key = info == null || info.DtClass.Length == 0 ? "未分类" : info.DtClass;
                double sum;
                result.TryGetValue(key, out sum);
                result[key] = sum + minutes;
            }
            return result;
        }

        private void Close(Record row)
        {
            DateTime started;
            if (!DateTime.TryParse(row.Get("开始时间"), out started)) return;
            var now = DateTime.Now;
            var minutes = Math.Max(0, (int)Math.Round((now - started).TotalMinutes));
            table.Close(row.Get("类型"), row.Get("开始时间"), now, minutes);
        }

        private static string Stamp(DateTime at)
        {
            return at.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
