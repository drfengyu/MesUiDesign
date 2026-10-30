using System;

namespace Mes.Data
{
    /// <summary>能耗日统计：一天一行，电量 kWh、气/水按 m³ 记，采样线程定期回写。</summary>
    public class EnergyDailyTable : RecordTable
    {
        public static readonly string[] Columns = { "日期", "耗电量", "耗气量", "耗水量", "更新时间" };

        public EnergyDailyTable(string folder) : base(folder, "能耗日统计", Columns)
        {
        }

        public void Save(DateTime day, double kwh, double air, double water)
        {
            var key = day.ToString("yyyy-MM-dd");
            var hit = Update(row => row.Get("日期") == key, row =>
            {
                row["耗电量"] = kwh.ToString("0.000");
                row["耗气量"] = air.ToString("0.000");
                row["耗水量"] = water.ToString("0.000");
                row["更新时间"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            });
            if (hit > 0) return;
            Insert(new Record
            {
                ["日期"] = key,
                ["耗电量"] = kwh.ToString("0.000"),
                ["耗气量"] = air.ToString("0.000"),
                ["耗水量"] = water.ToString("0.000"),
                ["更新时间"] = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),
            });
        }
    }
}
