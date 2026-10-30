namespace Mes.Data
{
    /// <summary>配件当前状态（条码/更换时间/当前寿命）。配件管控.csv 是码表，不随生产改，改动的部分落这张表。</summary>
    public class PartStateTable : RecordTable
    {
        public static readonly string[] Columns = { "品名", "条码", "更换时间", "当前寿命" };

        public PartStateTable(string folder) : base(folder, "配件状态", Columns)
        {
        }

        public void Save(string productName, string barcode, string replacedAt, int currentLife)
        {
            var hit = Update(row => row.Get("品名") == productName, row =>
            {
                row["条码"] = barcode;
                row["更换时间"] = replacedAt;
                row["当前寿命"] = currentLife.ToString();
            });
            if (hit > 0) return;
            Insert(new Record
            {
                ["品名"] = productName,
                ["条码"] = barcode,
                ["更换时间"] = replacedAt,
                ["当前寿命"] = currentLife.ToString(),
            });
        }
    }
}
