namespace Mes.Business
{
    /// <summary>治具一行，列与真"治具管控.csv"一致：治具码,小保养,大保养,小保养时间,大保养时间,状态。</summary>
    public class FixtureLifeRow
    {
        public string FixtureCode;

        /// <summary>小保养次数上限</summary>
        public int MinorLimit;

        /// <summary>大保养次数上限</summary>
        public int MajorLimit;

        public string MinorAt;
        public string MajorAt;
        public string Status;
    }
}
