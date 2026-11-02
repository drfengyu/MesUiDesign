using System;

namespace Mes.Data
{
    /// <summary>
    /// 气缸动作/故障次数（记录\气缸次数.csv）。一行一个"班次 + 气缸"，
    /// 不是一次动作一行：动作可能很频繁，按行追加会让文件一天长到几万行；
    /// 这里只在次数变化时整表重写，表本身最多十几行。
    /// </summary>
    public class CylinderCountTable : RecordTable
    {
        public static readonly string[] Columns =
        {
            "班次", "气缸", "动作次数", "故障次数", "更新时间",
        };

        public CylinderCountTable(string folder) : base(folder, "气缸次数", Columns)
        {
        }

        public void Add(string shift, string name, bool fault)
        {
            var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var hit = Update(row => row.Get("班次") == shift && row.Get("气缸") == name, row =>
            {
                var actions = Int(row.Get("动作次数"));
                var faults = Int(row.Get("故障次数"));
                row["动作次数"] = (fault ? actions : actions + 1).ToString();
                row["故障次数"] = (fault ? faults + 1 : faults).ToString();
                row["更新时间"] = now;
            });
            if (hit > 0) return;
            Insert(new Record
            {
                ["班次"] = shift,
                ["气缸"] = name,
                ["动作次数"] = fault ? "0" : "1",
                ["故障次数"] = fault ? "1" : "0",
                ["更新时间"] = now,
            });
        }

        public void Clear(string shift, string name)
        {
            var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            Update(row => row.Get("班次") == shift && row.Get("气缸") == name, row =>
            {
                row["动作次数"] = "0";
                row["故障次数"] = "0";
                row["更新时间"] = now;
            });
        }

        private static int Int(string text)
        {
            int value;
            return int.TryParse(text, out value) ? value : 0;
        }
    }
}
