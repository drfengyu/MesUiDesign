namespace Mes.Data
{
    /// <summary>治具保养履历：小保养/大保养各一行，用来回放"上次保养时间"。</summary>
    public class FixtureCareTable : RecordTable
    {
        public static readonly string[] Columns = { "时间", "治具码", "类型", "操作人" };

        public FixtureCareTable(string folder) : base(folder, "治具保养", Columns)
        {
        }

        public void Append(string at, string fixtureCode, string kind, string user)
        {
            Insert(new Record
            {
                ["时间"] = at,
                ["治具码"] = fixtureCode,
                ["类型"] = kind,
                ["操作人"] = user,
            });
        }
    }
}
