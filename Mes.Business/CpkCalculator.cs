using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>
    /// 一组样本的 CPK。文档 P22 的四个图都从这一个对象出：
    /// 正态曲线用 Mean/Sigma，样品分布用逐点值，分段计数用 Histogram，最近 8 组各算一次。
    ///
    /// Cpk = min((上限-均值)/3σ, (均值-下限)/3σ)，σ 用样本标准差（n-1）；
    /// 样本不足 2 片或全部相同（σ=0）时 CPK 无意义，Valid=false，界面显示 "--"。
    /// </summary>
    public class CpkResult
    {
        public readonly List<double> Values = new List<double>();

        public int Count { get { return Values.Count; } }
        public double Mean;
        public double Sigma;
        public double Min;
        public double Max;
        public double Target;
        public double Lower;
        public double Upper;
        public double Cpk = double.NaN;

        /// <summary>数据组偏差 = 平均值 - 标准值；文档的补偿值就是它。</summary>
        public double Deviation { get { return Mean - Target; } }

        public bool Valid
        {
            get { return Values.Count >= 2 && Sigma > 1e-12; }
        }

        /// <summary>CPK 位于规格范围内才允许补偿：1.33 是常用的最低可接受能力。</summary>
        public bool InSpec
        {
            get { return Valid && !double.IsNaN(Cpk) && Cpk >= 1.33; }
        }

        public static CpkResult Compute(IEnumerable<double> values, double target, double lower, double upper)
        {
            var result = new CpkResult { Target = target, Lower = lower, Upper = upper };
            foreach (var value in values)
            {
                if (double.IsNaN(value) || double.IsInfinity(value)) continue;
                result.Values.Add(value);
            }
            if (result.Values.Count == 0) return result;

            result.Min = double.MaxValue;
            result.Max = double.MinValue;
            var sum = 0D;
            foreach (var value in result.Values)
            {
                sum += value;
                if (value < result.Min) result.Min = value;
                if (value > result.Max) result.Max = value;
            }
            result.Mean = sum / result.Values.Count;
            if (result.Values.Count > 1)
            {
                var squares = 0D;
                foreach (var value in result.Values) squares += (value - result.Mean) * (value - result.Mean);
                result.Sigma = Math.Sqrt(squares / (result.Values.Count - 1));
            }
            if (result.Sigma > 1e-12)
            {
                var above = (upper - result.Mean) / (3D * result.Sigma);
                var below = (result.Mean - lower) / (3D * result.Sigma);
                result.Cpk = Math.Min(above, below);
            }
            return result;
        }

        /// <summary>正态概率密度，曲线用固定横向范围（均值 ± 4σ）画。</summary>
        public double Normal(double x)
        {
            if (!Valid) return 0;
            var z = (x - Mean) / Sigma;
            return Math.Exp(-0.5 * z * z) / (Sigma * Math.Sqrt(2 * Math.PI));
        }

        /// <summary>按样本最小/最大值等分成 bins 格，返回每格计数；min=max 时只有一格。</summary>
        public int[] Histogram(int bins)
        {
            if (Values.Count == 0) return new int[0];
            if (bins < 1) bins = 1;
            if (Max - Min < 1e-12) return new[] { Values.Count };
            var counts = new int[bins];
            var width = (Max - Min) / bins;
            foreach (var value in Values)
            {
                var index = (int)((value - Min) / width);
                if (index >= bins) index = bins - 1;
                if (index < 0) index = 0;
                counts[index]++;
            }
            return counts;
        }
    }
}
