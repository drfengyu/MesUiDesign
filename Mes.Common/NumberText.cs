using System.Globalization;

namespace Mes.Common
{
    /// <summary>
    /// 数值显示。写进记录和显示在触摸屏上都要定死格式，
    /// 否则同一份 csv 在中文 Windows 上是 2.05、在英文区域设置下变成 2,05，
    /// 逗号还会把 csv 的列切坏。
    /// </summary>
    public static class NumberText
    {
        /// <summary>保留三位小数、不带千分位、固定用点做小数点。</summary>
        public static string Format(double value)
        {
            return value.ToString("0.000", CultureInfo.InvariantCulture);
        }
    }
}
