using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>
    /// 手动操作页要点的执行机构。
    ///
    /// 为什么只挑这几个：现场 112 个输出点里，"阀 + 两个到位开关"三件齐全、
    /// 而且 A/B 两个模组对称的，就是下面这些。表里另外那些（运送横移压持缸等）
    /// 地址在 csv 里有重复行（"I 2001.0" 既写着"振动盘平震驱动"又写着"压持1缸_原点"），
    /// 现场表本身就没理顺，本机不替它猜，直接不列。
    ///
    /// 也没有伺服：本机点位表里一个轴都没有，所以"模组规格 + JOG 速度"那种界面做不出来，
    /// 硬做就是编假轴。
    /// </summary>
    public static class ManualOperations
    {
        /// <summary>
        /// MA 旋钮（表里是"输入_BOSS柱焊接_主控_MA旋钮"）。
        ///
        /// 本机约定 1=自动、0=手动。这一路的常开/常闭现场由电气定，本机没有真旋钮可查，
        /// 所以这里只算约定，别当现场事实抄走；接真机时先量一下"打到自动"时它是 1 还是 0，
        /// 再改 MachineSimulator.AutoMode 与手动操作页里那一处判断。
        /// </summary>
        public const string AutoSelectorBit = "I 1000.0";

        public static readonly List<Cylinder> Cylinders = new List<Cylinder>
        {
            new Cylinder { HomeValve = "Q 2000.4", WorkValve = "Q 2000.5", HomeSensor = "I 2000.4", WorkSensor = "I 2000.5" },
            new Cylinder { HomeValve = "Q 2001.6", WorkValve = "Q 2001.7", HomeSensor = "I 2004.6", WorkSensor = "I 2004.7" },
            new Cylinder { HomeValve = "Q 2003.4", WorkValve = "Q 2003.5", HomeSensor = "I 2008.4", WorkSensor = "I 2008.5" },
            new Cylinder { HomeValve = "Q 1004.0", WorkValve = "Q 1004.1", HomeSensor = "I 2007.2", WorkSensor = "I 2007.3" },
            new Cylinder { HomeValve = "Q 1004.2", WorkValve = "Q 1004.3", HomeSensor = "I 2007.4", WorkSensor = "I 2007.5" },
            new Cylinder { HomeValve = "Q 2005.4", WorkValve = "Q 2005.5", HomeSensor = "I 3000.4", WorkSensor = "I 3000.5" },
            new Cylinder { HomeValve = "Q 2007.2", WorkValve = "Q 2007.3", HomeSensor = "I 3006.0", WorkSensor = "I 3006.1" },
            new Cylinder { HomeValve = "Q 2008.4", WorkValve = "Q 2008.5", HomeSensor = "I 3008.4", WorkSensor = "I 3008.5" },
            new Cylinder { HomeValve = "Q 1004.4", WorkValve = "Q 1004.5", HomeSensor = "I 3006.2", WorkSensor = "I 3006.3" },
        };
    }
}
