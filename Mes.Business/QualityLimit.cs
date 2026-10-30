namespace Mes.Business
{
    /// <summary>一个测量项的判定窗口（名称要和追溯表的列名一致）。</summary>
    public class QualityLimit
    {
        public string Name;
        public double Lower;
        public double Upper;

        public bool InWindow(double value)
        {
            return value >= Lower && value <= Upper;
        }
    }
}
