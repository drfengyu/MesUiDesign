using Mes.Common;
using Mes.Data;
using System.Globalization;

namespace Mes.Business
{
    /// <summary>
    /// 产能目标（数据\产能目标.csv）。目标 UPH 是工艺给的，不是代码常量：
    /// 主项目把它放在 setting.ini 的 productconfig 段，默认 658，
    /// 这里照码表的做法单独一张 csv，换产品只改这一行。
    /// </summary>
    public class ProductionTargets
    {
        /// <summary>和主项目 Global.UPH 的初值一致；表里没读到就按它跑。</summary>
        public const double DefaultUph = 658;

        public double TargetUph = DefaultUph;

        public static ProductionTargets Load(string file)
        {
            var targets = new ProductionTargets();
            foreach (var line in TextFile.ReadAllLines(file, CodePages.Utf8WithBom()))
            {
                var cols = Csv.Split(line);
                if (cols.Length < 2) continue;
                if (cols[0].Trim() != "目标UPH") continue;
                double value;
                if (double.TryParse(cols[1], NumberStyles.Float, CultureInfo.InvariantCulture, out value) && value > 0)
                {
                    targets.TargetUph = value;
                }
            }
            return targets;
        }
    }
}
