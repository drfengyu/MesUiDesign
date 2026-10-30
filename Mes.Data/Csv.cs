using System.Collections.Generic;
using System.Text;

namespace Mes.Data
{
    /// <summary>
    /// CSV 拆行/转义。
    ///
    /// 为什么不能用 Split(',')：报警目录里的"处理对策"整段带逗号（现场用全角逗号，
    /// 但只要有一个人补了半角逗号就会串列），条码字段里也可能出现引号。
    /// 所以按状态机拆，带引号的字段内部逗号不算分隔符。
    /// </summary>
    public static class Csv
    {
        /// <summary>带引号的 CSV 字段要按状态机拆，不能直接 Split(',')。</summary>
        public static string[] Split(string line)
        {
            var parts = new List<string>();
            var sb = new StringBuilder();
            bool quoted = false;
            for (var i = 0; i < line.Length; i++)
            {
                var ch = line[i];
                if (quoted)
                {
                    if (ch == '"' && i + 1 < line.Length && line[i + 1] == '"')
                    {
                        sb.Append('"');
                        i++;
                    }
                    else if (ch == '"') quoted = false;
                    else sb.Append(ch);
                }
                else if (ch == '"') quoted = true;
                else if (ch == ',')
                {
                    parts.Add(sb.ToString());
                    sb.Length = 0;
                }
                else sb.Append(ch);
            }
            parts.Add(sb.ToString());
            return parts.ToArray();
        }

        /// <summary>值里有逗号或引号才加引号，其余保持原样，方便现场直接打开 csv 看。</summary>
        public static string Escape(string value)
        {
            if (string.IsNullOrEmpty(value)) return string.Empty;
            if (value.IndexOf(',') < 0 && value.IndexOf('"') < 0) return value;
            return "\"" + value.Replace("\"", "\"\"") + "\"";
        }
    }
}
