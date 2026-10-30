namespace Mes.Data
{
    /// <summary>配件更换履历。</summary>
    public class PartChangeTable : RecordTable
    {
        public static readonly string[] Columns = { "时间", "品名", "原条码", "新条码", "原因", "操作人" };

        public PartChangeTable(string folder) : base(folder, "配件更换", Columns)
        {
        }

        public void Append(string at, string productName, string oldBarcode, string newBarcode, string reason, string user)
        {
            Insert(new Record
            {
                ["时间"] = at,
                ["品名"] = productName,
                ["原条码"] = oldBarcode,
                ["新条码"] = newBarcode,
                ["原因"] = reason,
                ["操作人"] = user,
            });
        }
    }
}
