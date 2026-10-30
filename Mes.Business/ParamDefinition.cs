namespace Mes.Business
{
    /// <summary>
    /// 一条参数定义：来自"参数名称.csv"的一行。对应主项目的 Mes.Models/PLCData_Control.cs
    /// （字段少了类型，先够用）。
    /// </summary>
    public class ParamDefinition
    {
        public string Name;
        public int Address;
        public double Lower;
        public double Upper;

        /// <summary>
        /// 在整块读回来的数组里的下标。主项目里这条公式是 index = (地址 - 50000) / 2，
        /// 两层含义要拆开：减块首地址是因为程序一次性把 MW50000 起的一大段读回来（块读省往返）；
        /// 除以 2 是因为一个浮点占两个 16 位字。
        /// </summary>
        public int Index(int blockStart)
        {
            return (Address - blockStart) / 2;
        }
    }
}
