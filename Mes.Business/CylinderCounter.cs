using Mes.Data;
using Mes.Devices;
using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>一个气缸在某个班次的计数。</summary>
    public class CylinderCount
    {
        public string Name;
        public int Actions;
        public int Faults;
    }

    /// <summary>
    /// 气缸次数统计（UI 文档 P21）。真机上这一颗是 PLC 的计数器，上位机只读；
    /// 这里没有那组寄存器，就在机台线程里看阀的输出位：阀从 0→1 记一次动作，
    /// 阀得电超过 1.5s 两侧到位开关都没亮记一次故障（手动页的超时判定是 5s，这里更早，给统计留时间）。
    ///
    /// 班次按 08:00/20:00 切；跨班时把进入的那个班次的行清零，另一个班次保留上一班的数据。
    /// </summary>
    public class CylinderCounter
    {
        public const string Day = "白班";
        public const string Night = "晚班";

        /// <summary>阀得电后多久没有到位信号算一次故障（毫秒）。</summary>
        private const int FaultAfterMs = 1500;

        private readonly CylinderCountTable table;
        private readonly SimulatedPlc plc;
        private readonly IoCatalog io;
        private readonly bool[] on;
        private readonly int[] onSince;
        private readonly bool[] faultCounted;
        private readonly object gate = new object();
        private string shift;

        public CylinderCounter(CylinderCountTable table, SimulatedPlc plc, IoCatalog io)
        {
            this.table = table;
            this.plc = plc;
            this.io = io;
            on = new bool[ManualOperations.Cylinders.Count];
            onSince = new int[on.Length];
            faultCounted = new bool[on.Length];
            shift = ShiftOf(DateTime.Now);
            ClearStale();
        }

        public static string ShiftOf(DateTime at)
        {
            return at.Hour >= 8 && at.Hour < 20 ? Day : Night;
        }

        /// <summary>"输出_压持1缸_原点侧阀" → "压持1缸"；表里没有这个地址就把地址显示出来，不编名字。</summary>
        public static string NameOf(IoCatalog io, Cylinder cylinder)
        {
            var point = io == null ? null : io.Find(cylinder.HomeValve);
            if (point == null || string.IsNullOrEmpty(point.Name)) return cylinder.HomeValve;
            var name = point.Name;
            if (name.StartsWith("输出_")) name = name.Substring(3);
            var cut = name.IndexOf('_');
            return cut > 0 ? name.Substring(0, cut) : name;
        }

        /// <summary>机台线程每 200ms 调一次。只读仿真 PLC 的位缓存，不产生往返。</summary>
        public void Poll()
        {
            var nowShift = ShiftOf(DateTime.Now);
            if (nowShift != shift)
            {
                lock (gate)
                {
                    shift = nowShift;
                    foreach (var cylinder in ManualOperations.Cylinders)
                    {
                        table.Clear(nowShift, NameOf(io, cylinder));
                    }
                }
            }

            for (var i = 0; i < ManualOperations.Cylinders.Count; i++)
            {
                var cylinder = ManualOperations.Cylinders[i];
                bool homeValve, workValve;
                try
                {
                    homeValve = plc.PeekBit(cylinder.HomeValve);
                    workValve = plc.PeekBit(cylinder.WorkValve);
                }
                catch (Exception)
                {
                    continue;
                }
                var active = homeValve || workValve;
                if (!active)
                {
                    on[i] = false;
                    continue;
                }
                if (!on[i])
                {
                    on[i] = true;
                    onSince[i] = Environment.TickCount;
                    faultCounted[i] = false;
                    Count(cylinder, false);
                    continue;
                }
                if (faultCounted[i] || Environment.TickCount - onSince[i] < FaultAfterMs) continue;
                bool homeSensor, workSensor;
                try
                {
                    homeSensor = plc.PeekBit(cylinder.HomeSensor);
                    workSensor = plc.PeekBit(cylinder.WorkSensor);
                }
                catch (Exception)
                {
                    continue;
                }
                if (homeSensor || workSensor) continue;
                faultCounted[i] = true;
                Count(cylinder, true);
            }
        }

        private void Count(Cylinder cylinder, bool fault)
        {
            lock (gate)
            {
                table.Add(shift, NameOf(io, cylinder), fault);
            }
        }

        /// <summary>某个班次的全部气缸，按手动操作页的顺序；没有记录的气缸补 0。</summary>
        public List<CylinderCount> Snapshot(string shiftName)
        {
            var rows = table.All();
            var result = new List<CylinderCount>();
            foreach (var cylinder in ManualOperations.Cylinders)
            {
                var name = NameOf(io, cylinder);
                var item = new CylinderCount { Name = name };
                foreach (var row in rows)
                {
                    if (row.Get("班次") != shiftName || row.Get("气缸") != name) continue;
                    item.Actions = Int(row.Get("动作次数"));
                    item.Faults = Int(row.Get("故障次数"));
                    break;
                }
                result.Add(item);
            }
            return result;
        }

        public void Clear(string shiftName, string name)
        {
            lock (gate)
            {
                table.Clear(shiftName, name);
            }
        }

        /// <summary>
        /// 启动时只清"当前班次里已经过期的行"：更新时间早于本班开始时刻，说明是昨天同一个班留下的。
        /// 另一个班次不动——早上 10 点打开程序，晚班表还要显示昨晚的数字。
        /// </summary>
        private void ClearStale()
        {
            var start = ShiftStart(DateTime.Now);
            foreach (var row in table.All())
            {
                if (row.Get("班次") != shift) continue;
                DateTime updated;
                if (!DateTime.TryParse(row.Get("更新时间"), out updated)) continue;
                if (updated < start) table.Clear(shift, row.Get("气缸"));
            }
        }

        private static DateTime ShiftStart(DateTime at)
        {
            if (at.Hour >= 20) return at.Date.AddHours(20);
            if (at.Hour >= 8) return at.Date.AddHours(8);
            return at.Date.AddDays(-1).AddHours(20);
        }

        private static int Int(string text)
        {
            int value;
            return int.TryParse(text, out value) ? value : 0;
        }
    }
}
