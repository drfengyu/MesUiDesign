using System;
using System.Collections.Generic;

namespace Mes.Data
{
    /// <summary>
    /// 一行记录，键就是列名（与数据库列名一字不差）。
    ///
    /// 继承 Dictionary 而不是包一层：一张表的行本来就是"列名→值"的开放结构，
    /// 列还会随现场加（MC 纠偏、贴合纠偏那八列就是这么来的），
    /// 写成固定属性的话每加一列都要改类、改读写两边。
    /// </summary>
    public class Record : Dictionary<string, string>
    {
        public Record() : base(StringComparer.Ordinal)
        {
        }

        public Record(IDictionary<string, string> source) : base(source, StringComparer.Ordinal)
        {
        }

        /// <summary>取不到就当空串：追溯表里"还没走到这一步"和"值是 0"是两回事，但都不该抛异常。</summary>
        public string Get(string column)
        {
            string value;
            return TryGetValue(column, out value) ? value : string.Empty;
        }
    }
}
