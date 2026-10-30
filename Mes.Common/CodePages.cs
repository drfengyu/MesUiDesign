using System;
using System.Text;

namespace Mes.Common
{
    /// <summary>
    /// 代码页。现场导出的码表全是 GBK（ANSI），而落盘的记录要 UTF-8 带 BOM，
    /// 两套编码不能一把梭用 Encoding.Default：换语言包或代码页缺失时
    /// Encoding.Default 就不是 936 了，中文参数名变乱码而且一句错都不报。
    /// </summary>
    public static class CodePages
    {
        public const int GbkCodePage = 936;

        /// <summary>精简版系统上 936 要额外注册才可用，取不到就退回系统默认，不能让程序起不来。</summary>
        public static Encoding Gbk()
        {
            try
            {
                return Encoding.GetEncoding(GbkCodePage);
            }
            catch (ArgumentException)
            {
                return Encoding.Default;
            }
        }

        /// <summary>写文件用：带 BOM 的 UTF-8。没有 BOM 时 Excel 双击打开是乱码。</summary>
        public static Encoding Utf8WithBom()
        {
            return new UTF8Encoding(true);
        }

        /// <summary>追加用：不带 BOM，否则 BOM 会出现在文件中间。</summary>
        public static Encoding Utf8NoBom()
        {
            return new UTF8Encoding(false);
        }
    }
}
