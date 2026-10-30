using HslCommunication;
using Mes.Common;
using System;

namespace Mes.Devices
{
    /// <summary>
    /// 所有 PLC 驱动的共同抽象：一个地址（"MW63050" / "IX1000.3"）进出，字、双字、浮点、位四种粒度。
    ///
    /// 为什么方法名保持 ConnectPlc / Read / Write / ReadFloat 这套写法：
    /// 真项目（Mes数据追溯系统）的 Global.plc1 就是这个签名，界面和业务代码从这里迁过去时
    /// 只需要把 new SimulatedPlc() 换成 new InovanceAmTcpPlc(ip, port)，调用处一行不动。
    /// 自创一套 ReadWord/WriteWord 好看是好看，换真机就是全重写。
    ///
    /// 抽象只有一份。不要再加一个和这个类并存的接口：曾经有过一个 IPlcService，
    /// 签名和抽象类互相矛盾（接口有 ReadPlcData(string)、抽象类有 Read(string,ushort)），
    /// 还没有任何实现者，两边各改各的最后没人知道该信谁。
    ///
    /// 地址前缀约定：MW=字寄存器、MB/MX=从字里拆出的位、IX/QX=现场 I/O 点位，
    /// 三套编号体系互不相通，混用是现场"读得到却写不进去"的头号原因。
    /// </summary>
    public abstract class PlcBase
    {
        protected PlcBase(string plcIp, string plcPort)
        {
            PlcIp = plcIp;
            PlcPort = plcPort;
        }

        public string PlcIp { get; protected set; }

        public string PlcPort { get; protected set; }

        /// <summary>
        /// 连接状态由基类统一记账：界面问"到底连上没有"时，换哪个驱动都有同一个答案。
        /// </summary>
        public bool IsConnected { get; protected set; }

        /// <summary>
        /// 通讯流水开关，默认关。轮询一轮就是上百个地址，一打开日志盘很快被写满，
        /// 而且每个请求多一次字符串拼接会拖慢周期。只有现场排查"这个地址到底发没发出去"时才开，
        /// 不要把它做成注释掉的调用——要排查时得改代码重新编译。
        /// </summary>
        public bool TraceAddresses { get; set; }

        public abstract bool ConnectPlc();

        public abstract bool DisconnectPlc();

        /// <summary>读一个字。传的是 MW 号本身（Read(63000)），不带前缀。</summary>
        public abstract short Read(int address);

        public abstract short[] Read(string address, ushort length = 1);

        public abstract int ReadInt32(string address);

        public abstract int[] ReadInt32(string address, ushort length = 1);

        public abstract float ReadFloat(string address);

        /// <summary>块读浮点。length 传的是**字数**，返回个数是它的一半。</summary>
        public abstract double[] ReadFloatArray(string address, ushort length = 2);

        public abstract OperateResult<bool> ReadBool(string address);

        /// <summary>按 MB/MX 位地址读所在字里的一个字节。</summary>
        public abstract short ReadMB(string address, ushort length = 1);

        public abstract OperateResult Write(string address, short value);

        public abstract OperateResult Write(string address, short[] values);

        public abstract OperateResult WriteFloat(string address, double value);

        public abstract OperateResult WriteMB(string address, byte value);

        /// <summary>地址写成 "MW" + 号，日志和界面显示统一用它。</summary>
        protected static string Mw(int address)
        {
            return PlcAddresses.Mw(address);
        }

        /// <summary>顺路记一条通讯流水，然后把值原样返回——所以能直接包在读/写的返回值上。</summary>
        protected T Trace<T>(string address, T value, bool isRead)
        {
            if (TraceAddresses) this.PlcTrace(address, value, isRead);
            return value;
        }

        /// <summary>字 → 浮点，走的是 WordCodec 里那一份换算，模拟机和真驱动不会各算一套。</summary>
        protected static float WordsToFloat(short[] words)
        {
            return WordCodec.WordsToFloat(words);
        }

        protected static double[] WordsToFloats(short[] words)
        {
            return WordCodec.WordsToFloats(words);
        }

        /// <summary>
        /// 读一个 MB/MX 位地址对应的字节：拆地址 → 块读所在字 → 取字内下标。
        /// 三个驱动里这段换算一模一样，收在一处免得各改各的。
        /// </summary>
        protected short ReadBitByte(string address, ushort length)
        {
            int wordAddress, byteIndex;
            if (!WordCodec.TrySplitBitByte(address, out wordAddress, out byteIndex))
            {
                throw new ArgumentException("位地址格式不正确，应该像 MB62050 / MX1000.0：" + address, "address");
            }
            return WordCodec.WordsToBytes(Read(Mw(wordAddress), length))[byteIndex];
        }

        /// <summary>
        /// 写一个 MB/MX 位：先读回所在字（改位必须整字改，直接写会抹掉同一字里的另外 7 位），
        /// 改完那一个字节再写回去。
        /// </summary>
        protected OperateResult WriteBitByte(string address, byte value)
        {
            int wordAddress, byteIndex;
            if (!WordCodec.TrySplitBitByte(address, out wordAddress, out byteIndex))
            {
                throw new ArgumentException("位地址格式不正确，应该像 MB62050 / MX1000.0：" + address, "address");
            }
            var bytes = WordCodec.WordsToBytes(Read(Mw(wordAddress), 1));
            bytes[byteIndex] = value == 0 ? (byte)0 : (byte)1;
            return Write(Mw(wordAddress), WordCodec.BytesToWords(bytes));
        }

        /// <summary>
        /// 连接动作的公共壳子：驱动只负责"怎么连"，异常兜住、状态记账、日志留痕统一在这里做，
        /// 免得每个驱动各抄一遍 try/catch、还抄得不完全一样。
        /// </summary>
        protected bool Connect(Func<OperateResult> connect)
        {
            try
            {
                IsConnected = connect().IsSuccess;
            }
            catch (Exception ex)
            {
                this.Error(ex.Message);
                IsConnected = false;
            }
            return IsConnected;
        }

        protected bool Disconnect(Func<OperateResult> disconnect)
        {
            try
            {
                var ok = disconnect().IsSuccess;
                // 关不成功就保持原状态：把"关失败"记成"已断开"，界面就再也没人提醒去重连了。
                if (ok) IsConnected = false;
                return ok;
            }
            catch (Exception ex)
            {
                this.Error(ex.Message);
                return false;
            }
        }
    }
}
