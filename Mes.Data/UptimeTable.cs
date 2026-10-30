using System;

namespace Mes.Data
{
    /// <summary>
    /// Uptime / DT 台账：计划停机、首件、切线、故障各占一行，结束时回填"结束时间"和分钟数。
    /// 列名与主项目 OEE_DT 的口径对齐（RunStatus、TimeSpan），换成 SQL 时只改这一层。
    /// </summary>
    public class UptimeTable : RecordTable
    {
        public static readonly string[] Columns =
        {
            "类型", "开始时间", "结束时间", "分钟", "代码", "描述", "操作人",
        };

        public UptimeTable(string folder) : base(folder, "Uptime", Columns)
        {
        }

        public void Insert(string kind, DateTime at, string code, string text, string user)
        {
            Insert(new Record
            {
                ["类型"] = kind,
                ["开始时间"] = at.ToString("yyyy-MM-dd HH:mm:ss"),
                ["结束时间"] = string.Empty,
                ["分钟"] = string.Empty,
                ["代码"] = code,
                ["描述"] = text,
                ["操作人"] = user,
            });
        }

        public void Close(string kind, string startAt, DateTime at, int minutes)
        {
            Update(row => row.Get("类型") == kind && row.Get("开始时间") == startAt, row =>
            {
                row["结束时间"] = at.ToString("yyyy-MM-dd HH:mm:ss");
                row["分钟"] = minutes.ToString();
            });
        }
    }
}
