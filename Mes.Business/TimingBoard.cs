using Mes.Common;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mes.Business
{
    /// <summary>
    /// 时间明细的采样。谁测的谁写进来：过站线程写"流动工位N""过站判定"，状态轮询写"通讯耗时"。
    /// 每组只留最近 20 个样本，界面看的是均值/最近值，不落盘。
    /// </summary>
    public class TimingBoard
    {
        public const string Flow1 = "流动工位1";
        public const string Flow2 = "流动工位2";
        public const string Flow3 = "流动工位3";
        public const string Return = "回流工位";
        public const string Fit2 = "2#贴合工位";
        public const string Fit3 = "3#贴合工位";
        public const string Cylinder = "气缸耗时";
        public const string Communication = "通讯耗时";

        public static readonly string[] Groups =
        {
            Flow1, Flow2, Flow3, Return, Fit2, Fit3, Cylinder, Communication,
        };

        private const int Keep = 20;
        private readonly object gate = new object();
        private readonly Dictionary<string, List<double>> samples = new Dictionary<string, List<double>>(StringComparer.Ordinal);
        private readonly Dictionary<string, double> standards = new Dictionary<string, double>(StringComparer.Ordinal);

        public TimingBoard(string dataFolder)
        {
            LoadStandards(Path.Combine(dataFolder, "时间明细标准.csv"));
        }

        public void Add(string group, double milliseconds)
        {
            if (milliseconds < 0) return;
            lock (gate)
            {
                List<double> list;
                if (!samples.TryGetValue(group, out list))
                {
                    list = new List<double>();
                    samples[group] = list;
                }
                list.Add(milliseconds);
                if (list.Count > Keep) list.RemoveAt(0);
            }
        }

        public double Average(string group)
        {
            lock (gate)
            {
                List<double> list;
                if (!samples.TryGetValue(group, out list) || list.Count == 0) return double.NaN;
                var sum = 0D;
                foreach (var value in list) sum += value;
                return sum / list.Count;
            }
        }

        public double Last(string group)
        {
            lock (gate)
            {
                List<double> list;
                return samples.TryGetValue(group, out list) && list.Count > 0 ? list[list.Count - 1] : double.NaN;
            }
        }

        public double[] Snapshot(string group)
        {
            lock (gate)
            {
                List<double> list;
                return samples.TryGetValue(group, out list) ? list.ToArray() : new double[0];
            }
        }

        /// <summary>规划标准（秒）；码表里没登记的组返回 0，界面据此显示"未设标准"。</summary>
        public double Standard(string group)
        {
            lock (gate)
            {
                double value;
                return standards.TryGetValue(group, out value) ? value : 0D;
            }
        }

        private void LoadStandards(string file)
        {
            var lines = TextFile.ReadAllLines(file, CodePages.Utf8WithBom());
            for (var i = 1; i < lines.Length; i++)
            {
                var cols = lines[i].Split(',');
                if (cols.Length < 2) continue;
                double value;
                if (double.TryParse(cols[1], out value)) standards[cols[0].Trim()] = value;
            }
        }
    }
}
