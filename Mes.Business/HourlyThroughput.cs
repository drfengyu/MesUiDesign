namespace Mes.Business
{
    /// <summary>一个小时格子的产能。表里的行序按 ThroughputReport.HourOrder 排，不是按小时数字大小。</summary>
    public class HourlyThroughput
    {
        /// <summary>小时号（0~23）</summary>
        public int Hour;

        /// <summary>投入（报站进机台的片数）</summary>
        public int Input;

        /// <summary>完成（流程结束时间非空）</summary>
        public int Completed;

        /// <summary>合格（结果 = OK）</summary>
        public int Passed;

        /// <summary>NG（结果以 NG 结尾）</summary>
        public int Ng;

        public double UphRate;

        /// <summary>
        /// 良率。分母只算"有结论的"（合格 + NG），不含还在机台上的那一片（结果还是空的）。
        /// 口径照主项目 @1967 的直通率 `OK / (OK + NG)`，别顺手改成除以投入总数——
        /// 机台上正在焊的那片会被算成不良，夜班收尾时那几分钟的良率会莫名其妙掉一截。
        /// </summary>
        public double YieldRate
        {
            get { return Passed + Ng == 0 ? 0 : Passed * 100D / (Passed + Ng); }
        }
    }
}
