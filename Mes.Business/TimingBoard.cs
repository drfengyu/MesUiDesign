using Mes.Common;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mes.Business
{
    /// <summary>
    /// 时间明细的采样，两层：分组（一个工位/一类动作的节拍）和组内细项（动作单元、一次通讯操作）。
    /// 谁测的谁写进来：过站线程写工位节拍和该工位的软件步骤，气缸线程写每只气缸的通断时长，
    /// 轮询线程写各类 PLC 操作。每组每细项只留最近 20 个样本，界面看均值，不落盘。
    /// </summary>
    public class TimingBoard
    {
        public const string Flow1 = "流动工位1";
        public const string Flow2 = "流动工位2";
        public const string Flow3 = "流动工位3";
        public const string Return = "回流工位";
        public const string Fit2 = "2#贴合工位";
        public const string Fit3 = "3#贴合工位";
        public const string Cylinder = "气缸计时";
        public const string Communication = "通讯计时";

        public static readonly string[] Groups =
        {
            Flow1, Flow2, Flow3, Return, Fit2, Fit3, Cylinder, Communication,
        };

        private const int Keep = 20;
        private static readonly char KeySep = '\u0001';

        private readonly object gate = new object();
        private readonly Dictionary<string, List<double>> samples = new Dictionary<string, List<double>>(StringComparer.Ordinal);
        private readonly Dictionary<string, double> standards = new Dictionary<string, double>(StringComparer.Ordinal);
        private readonly Dictionary<string, List<double>> itemSamples = new Dictionary<string, List<double>>(StringComparer.Ordinal);
        private readonly Dictionary<string, double> itemStandards = new Dictionary<string, double>(StringComparer.Ordinal);

        /// <summary>每组要显示的细项，顺序就是码表里的登记顺序。</summary>
        private readonly Dictionary<string, List<string>> itemNames = new Dictionary<string, List<string>>(StringComparer.Ordinal);

        public TimingBoard(string dataFolder)
        {
            LoadStandards(Path.Combine(dataFolder, "时间明细标准.csv"));
        }

        public void Add(string group, double milliseconds)
        {
            if (milliseconds < 0) return;
            lock (gate) Push(samples, group, milliseconds);
        }

        /// <summary>记一次细项耗时；细项没在码表登记过也会显示出来。</summary>
        public void Add(string group, string item, double milliseconds)
        {
            if (milliseconds < 0 || string.IsNullOrEmpty(item)) return;
            lock (gate)
            {
                Push(itemSamples, Key(group, item), milliseconds);
                var list = Listed(group);
                if (!list.Contains(item)) list.Add(item);
            }
        }

        public double Average(string group)
        {
            lock (gate)
            {
                return AverageOf(samples, group);
            }
        }

        public double ItemAverage(string group, string item)
        {
            lock (gate)
            {
                return AverageOf(itemSamples, Key(group, item));
            }
        }

        /// <summary>这一组要列出的细项：码表登记的顺序在前，运行中新出现的追加在后。</summary>
        public List<string> ItemNames(string group)
        {
            lock (gate)
            {
                List<string> list;
                return itemNames.TryGetValue(group, out list) ? new List<string>(list) : new List<string>();
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

        public double ItemStandard(string group, string item)
        {
            lock (gate)
            {
                double value;
                return itemStandards.TryGetValue(Key(group, item), out value) ? value : 0D;
            }
        }

        private static double AverageOf(Dictionary<string, List<double>> source, string key)
        {
            List<double> list;
            if (!source.TryGetValue(key, out list) || list.Count == 0) return double.NaN;
            var sum = 0D;
            foreach (var value in list) sum += value;
            return sum / list.Count;
        }

        private static void Push(Dictionary<string, List<double>> source, string key, double milliseconds)
        {
            List<double> list;
            if (!source.TryGetValue(key, out list))
            {
                list = new List<double>();
                source[key] = list;
            }
            list.Add(milliseconds);
            if (list.Count > Keep) list.RemoveAt(0);
        }

        private List<string> Listed(string group)
        {
            List<string> list;
            if (!itemNames.TryGetValue(group, out list))
            {
                list = new List<string>();
                itemNames[group] = list;
            }
            return list;
        }

        private static string Key(string group, string item)
        {
            return group + KeySep + item;
        }

        private void LoadStandards(string file)
        {
            var lines = TextFile.ReadAllLines(file, CodePages.Utf8WithBom());
            for (var i = 1; i < lines.Length; i++)
            {
                var cols = lines[i].Split(',');
                if (cols.Length < 3) continue;
                double value;
                if (!double.TryParse(cols[2].Trim(), out value)) continue;
                var group = cols[0].Trim();
                var item = cols[1].Trim();
                if (item.Length == 0)
                {
                    standards[group] = value;
                    continue;
                }
                itemStandards[Key(group, item)] = value;
                Listed(group).Add(item);
            }
        }
    }
}
