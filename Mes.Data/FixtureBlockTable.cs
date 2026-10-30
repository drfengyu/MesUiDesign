namespace Mes.Data
{
    /// <summary>治具卡控记录：保养超期仍上机时，过站判定拦下并在这里留痕。</summary>
    public class FixtureBlockTable : RecordTable
    {
        public static readonly string[] Columns = { "时间", "治具码", "原因", "产品码", "结果" };

        public FixtureBlockTable(string folder) : base(folder, "治具卡控", Columns)
        {
        }

        public void Append(string at, string fixtureCode, string reason, string productCode, string result)
        {
            Insert(new Record
            {
                ["时间"] = at,
                ["治具码"] = fixtureCode,
                ["原因"] = reason,
                ["产品码"] = productCode,
                ["结果"] = result,
            });
        }
    }
}
