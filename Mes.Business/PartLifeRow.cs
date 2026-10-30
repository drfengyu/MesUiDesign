namespace Mes.Business
{
    /// <summary>配件寿命一行，列名与真"配件管控.csv"一致：品名,型号,标准寿命,条码,更换时间,当前寿命。</summary>
    public class PartLifeRow
    {
        public string ProductName;
        public string Model;

        /// <summary>标准寿命（动作次数上限）</summary>
        public int RatedLife;

        public string Barcode;

        /// <summary>上次更换时间</summary>
        public string ReplacedAt;

        public int CurrentLife;
    }
}
