using Mes.Data;
using Mes.Devices;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Mes.Business
{
    /// <summary>
    /// 能耗采样：电压/电流/功率/气/水五个浮点一次块读，1 秒一帧。
    /// 地址是本机约定（MW16000 起），接真表时只改 PlcAddresses 里的常量。
    /// </summary>
    public class EnergyMeter
    {
        private const int PollMs = 1000;
        private const int KeepPoints = 180;
        private const int SaveEvery = 30;

        private readonly SimulatedPlc plc;
        private readonly EnergyDailyTable daily;
        private readonly object gate = new object();
        private readonly List<EnergyPoint> history = new List<EnergyPoint>();
        private EnergySnapshot snapshot = new EnergySnapshot();
        private Thread loop;
        private volatile bool alive;
        private DateTime day = DateTime.Today;
        private double kwh;
        private double air;
        private double water;
        private int sinceSave;

        public EnergyMeter(SimulatedPlc plc, EnergyDailyTable daily)
        {
            this.plc = plc;
            this.daily = daily;
        }

        public void Start()
        {
            if (loop != null) return;
            alive = true;
            loop = new Thread(Run);
            loop.IsBackground = true;
            loop.Name = "能耗采样";
            loop.Start();
        }

        public void Stop()
        {
            alive = false;
            Save();
        }

        public EnergySnapshot Snapshot()
        {
            lock (gate)
            {
                var copy = snapshot.Clone();
                copy.Points = history.ToArray();
                return copy;
            }
        }

        public void ResetToday()
        {
            lock (gate)
            {
                day = DateTime.Today;
                kwh = 0;
                air = 0;
                water = 0;
                history.Clear();
            }
            Save();
        }

        private void Run()
        {
            var last = DateTime.Now;
            while (alive)
            {
                Thread.Sleep(PollMs);
                var now = DateTime.Now;
                var seconds = Math.Max(0.2, (now - last).TotalSeconds);
                last = now;
                try
                {
                    var words = plc.Read(PlcAddresses.Mw(PlcAddresses.EnergyArea), PlcAddresses.EnergyWords);
                    var values = WordCodec.WordsToFloats(words);
                    var voltage = values.Length > 0 ? values[0] : 0;
                    var current = values.Length > 1 ? values[1] : 0;
                    var power = values.Length > 2 ? values[2] : 0;
                    var airFlow = values.Length > 3 ? values[3] : 0;
                    var waterFlow = values.Length > 4 ? values[4] : 0;
                    lock (gate)
                    {
                        if (now.Date != day)
                        {
                            day = now.Date;
                            kwh = 0;
                            air = 0;
                            water = 0;
                            history.Clear();
                        }
                        kwh += Math.Max(0, power) * seconds / 3600D;
                        air += Math.Max(0, airFlow) * seconds / 60D / 1000D;
                        water += Math.Max(0, waterFlow) * seconds / 60D / 1000D;
                        snapshot = new EnergySnapshot
                        {
                            Voltage = voltage,
                            Current = current,
                            Power = power,
                            AirFlow = airFlow,
                            WaterFlow = waterFlow,
                            TodayKwh = kwh,
                            TodayAir = air,
                            TodayWater = water,
                            HasData = voltage > 1,
                            At = now,
                        };
                        history.Add(new EnergyPoint
                        {
                            Time = now,
                            Voltage = voltage,
                            Current = current,
                            Power = power,
                            AirFlow = airFlow,
                            WaterFlow = waterFlow,
                        });
                        if (history.Count > KeepPoints) history.RemoveAt(0);
                    }
                    if (++sinceSave >= SaveEvery)
                    {
                        sinceSave = 0;
                        Save();
                    }
                }
                catch (Exception ex)
                {
                    lock (gate)
                    {
                        var copy = snapshot.Clone();
                        copy.Error = ex.Message;
                        snapshot = copy;
                    }
                }
            }
        }

        private void Save()
        {
            double k, a, w;
            DateTime d;
            lock (gate)
            {
                k = kwh;
                a = air;
                w = water;
                d = day;
            }
            try
            {
                daily.Save(d, k, a, w);
            }
            catch (Exception)
            {
                // 能耗统计写不进盘不该影响生产
            }
        }
    }

    public class EnergySnapshot
    {
        public double Voltage;
        public double Current;
        public double Power;
        public double AirFlow;
        public double WaterFlow;
        public double TodayKwh;
        public double TodayAir;
        public double TodayWater;
        public bool HasData;
        public DateTime At;
        public string Error;
        public EnergyPoint[] Points = new EnergyPoint[0];

        public EnergySnapshot Clone()
        {
            return (EnergySnapshot)MemberwiseClone();
        }
    }

    public class EnergyPoint
    {
        public DateTime Time;
        public double Voltage;
        public double Current;
        public double Power;
        public double AirFlow;
        public double WaterFlow;
    }
}
