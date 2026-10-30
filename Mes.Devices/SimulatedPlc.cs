using HslCommunication;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Mes.Devices
{
    /// <summary>
    /// 模拟 PLC —— 直接继承 PlcBase，方法签名与 InovanceAmTcpPlc 完全一致。
    ///
    /// 为什么必须继承而不是自己写一套"像的"：在这里写熟的是 Read(62070)、
    /// Read("MW63050", 20)、ReadFloat("MW4024")、Write("MW63000", 0)，
    /// 换到真项目时把 new SimulatedPlc() 换成 new InovanceAmTcpPlc(ip, port) 就能跑，
    /// 业务代码一行都不用改。要是这里自创 ReadWord/WriteWord，换真机就得全重写。
    ///
    /// 它是设备层，不含一行界面代码，所以和真驱动放同一个工程里。
    ///
    /// 它同时是一台"会卡"的 PLC，这是模拟机唯一比真机多出来的价值：
    /// 1) connection 锁 = 那条 TCP 连接。所有 Read/Write 都要排队进这把锁，
    ///    锁内 Sleep(RoundTripMs) 就是在等 PLC 回话。线程开多了单次变慢、界面发顿，
    ///    在这台模拟机上能当场复现，不用等现场。
    /// 2) state 锁 = 寄存器真值。机台侧（Raise/Poke/Peek）只碰这把、不碰 connection，
    ///    因为真机上 PLC 改自己的寄存器不需要走那条 TCP。要是机台也去抢连接锁，
    ///    消费者线程会把它饿死，两组统计的分母就不一样了（实测台第一版真踩过：348 对 809）。
    /// </summary>
    public class SimulatedPlc : PlcBase
    {
        /// <summary>单次往返耗时（ms）。现场可以用主项目的轮询实测台量出来填进来，一般 2~10ms。</summary>
        public int RoundTripMs = 4;

        /// <summary>累计发出的请求次数，用来算"每秒多少个请求"。</summary>
        public long RequestCount;

        /// <summary>机台总共置位多少次（分母，用于算丢触发比例）。</summary>
        public long RaisedCount;

        /// <summary>置位时位已经是 1 且没人正在清它：只是排到了下一轮，不算丢。</summary>
        public long CoalescedCount;

        /// <summary>置位正好撞上"已读到 1、还没写回 0"的窗口：这次请求被清零抹掉了，是真丢。</summary>
        public long SwallowedCount;

        private readonly object connection = new object();
        private readonly object state = new object();
        private readonly Dictionary<int, short> registers = new Dictionary<int, short>();

        /// <summary>
        /// I/Q 两个位区。它们和 MW 那套字地址不是一回事，所以单独一张表，
        /// 键统一成 "IX1000.3" / "QX1001.2"。
        /// </summary>
        private readonly Dictionary<string, bool> bits = new Dictionary<string, bool>();

        private readonly HashSet<int> clearing = new HashSet<int>();

        /// <summary>ip/port 只是形参：真程序里这两个值来自 setting.ini，模拟机不连真地址也不报错。</summary>
        public SimulatedPlc(string plcIp = "127.0.0.1", string plcPort = "502") : base(plcIp, plcPort)
        {
        }

        // ── PlcBase 要求的实现 ───────────────────────────────────────────────

        public override bool ConnectPlc()
        {
            IsConnected = true;
            return true;
        }

        public override bool DisconnectPlc()
        {
            IsConnected = false;
            return true;
        }

        /// <summary>读一个字。主项目 PLC_Model 里就是这么写的：Global.plc1.Read(62070)。</summary>
        public override short Read(int address)
        {
            lock (connection)
            {
                Interlocked.Increment(ref RequestCount);
                Wait();
                return Take(address);
            }
        }

        /// <summary>
        /// 一次往返读回连续 length 个字（块读）。
        /// 主项目读条码是 Read("MW63050", 20)，一次拿 20 个字；
        /// 同样一件事写成 20 次 Read(int) 就是 20 次往返，轮询周期直接差二十倍。
        /// </summary>
        public override short[] Read(string address, ushort length = 1)
        {
            var start = Addr(address);
            var result = new short[length];
            lock (connection)
            {
                Interlocked.Increment(ref RequestCount);
                Wait();
                for (var i = 0; i < length; i++)
                {
                    result[i] = Take(start + i);
                }
            }
            return result;
        }

        public override int ReadInt32(string address)
        {
            return ReadInt32(address, 1)[0];
        }

        public override int[] ReadInt32(string address, ushort length = 1)
        {
            var words = Read(address, (ushort)(length * 2));
            var values = new int[length];
            for (var i = 0; i < length; i++)
            {
                values[i] = (words[i * 2] << 16) | (words[i * 2 + 1] & 0xFFFF);
            }
            return values;
        }

        /// <summary>
        /// 读一个位。现场 IO 点位表里写的是 "I 1000.3"，主项目转成 "IX1000.3" / "QX1001.2" 再读
        /// （Mes数据追溯系统/IOMonitorFrm.cs:102 的 ToBitAddress）。
        ///
        /// 原来这里写成 `Read(address, 1)[0] != 0`，把位地址当 MW 字去读，
        /// 一碰到 IX1000.3 就在 Addr() 里抛异常——I/Q 区和 MW 字区在 PLC 里根本是两套地址。
        /// 现在走单独的位表；**没登记过的点一律返回 0**，这正是现场的意思：本机没接的就是不亮。
        /// </summary>
        public override OperateResult<bool> ReadBool(string address)
        {
            var key = BitAddr(address);
            lock (connection)
            {
                Interlocked.Increment(ref RequestCount);
                Wait();
                bool on;
                lock (state) { bits.TryGetValue(key, out on); }
                return OperateResult.CreateSuccessResult(on);
            }
        }

        /// <summary>
        /// 一次块读一串位地址：只算一次往返耗时。
        ///
        /// IO 页原来是一个点一次 ReadBool，30 个点 × 4ms = 120ms，
        /// 而这 120ms 是卡在界面线程上等回来的（WinForms 的 Timer 就在界面线程跑），
        /// 半秒一轮里有四分之一的时间界面点不动——现场说的"卡"就是这么来的。
        /// 真机也一样：位是一个一个读的，但读之前要先想清楚"这一轮到底需要哪几个点"。
        /// </summary>
        public bool[] ReadBits(string[] addresses)
        {
            var keys = new string[addresses.Length];
            for (var i = 0; i < addresses.Length; i++)
            {
                keys[i] = BitAddr(addresses[i]);
            }
            var values = new bool[keys.Length];
            lock (connection)
            {
                Interlocked.Increment(ref RequestCount);
                Wait();
                lock (state)
                {
                    for (var i = 0; i < keys.Length; i++)
                    {
                        bool on;
                        bits.TryGetValue(keys[i], out on);
                        values[i] = on;
                    }
                }
            }
            return values;
        }

        /// <summary>
        /// 界面写一个输出位（手动操作点动气缸、点亮按钮灯）。
        ///
        /// 换真机时这一句要单独处理：真驱动层 Mes.Devices 里根本没有 WriteBool——
        /// 主项目只读 I/Q，从来没往位区写过东西；现场写位走的是 WriteMB("MX…") 那条路
        /// （MB/MX 是 MW 字里拆出来的位，和 I/Q 不是一套）。所以要么让电气在 MW 里给一个
        /// "手动脉冲字"，要么补一个真驱动的 WriteBool。界面代码不用动，改构造那一行之外就改这里。
        /// </summary>
        public OperateResult WriteBool(string address, bool value)
        {
            var key = BitAddr(address);
            lock (connection)
            {
                Interlocked.Increment(ref RequestCount);
                Wait();
                lock (state) { bits[key] = value; }
            }
            return OperateResult.CreateSuccessResult();
        }

        /// <summary>按 MB/MX 位地址读，换算与 InovanceAmTcpPlc 走的是同一份代码（PlcBase.ReadBitByte）。</summary>
        public override short ReadMB(string address, ushort length = 1)
        {
            return ReadBitByte(address, length);
        }

        public override float ReadFloat(string address)
        {
            return WordCodec.WordsToFloat(Read(address, 2));
        }

        /// <summary>
        /// 读一段浮点。length 传的是**字数**，读回来个数是它的一半：
        /// 主项目 PLCData_Modi 里 ReadFloatArray("MW50000", 2230) 拿回来是 1115 个浮点，
        /// 参数下标 = (地址 - 50000) / 2 里那个"除以 2"就是从这来的。
        /// </summary>
        public override double[] ReadFloatArray(string address, ushort length = 2)
        {
            return WordCodec.WordsToFloats(Read(address, length));
        }

        public override OperateResult Write(string address, short value)
        {
            var word = Addr(address);
            lock (connection)
            {
                Interlocked.Increment(ref RequestCount);
                Wait();
                lock (state)
                {
                    registers[word] = value;
                    if (value == 0)
                    {
                        clearing.Remove(word);
                    }
                }
            }
            return OperateResult.CreateSuccessResult();
        }

        public override OperateResult Write(string address, short[] values)
        {
            var start = Addr(address);
            lock (connection)
            {
                Interlocked.Increment(ref RequestCount);
                Wait();
                lock (state)
                {
                    for (var i = 0; i < values.Length; i++)
                    {
                        registers[start + i] = values[i];
                    }
                }
            }
            return OperateResult.CreateSuccessResult();
        }

        public override OperateResult WriteMB(string address, byte value)
        {
            return WriteBitByte(address, value);
        }

        public override OperateResult WriteFloat(string address, double value)
        {
            return Write(address, WordCodec.FloatToWords(value));
        }

        // ── 机台侧：只有扮演 PLC 的模拟机台会调，界面程序永远不调 ────────────────

        /// <summary>
        /// 机台把一个触发位置 1（= 请求界面处理）。这个协议里 1 就是"请求还没被处理完"，
        /// 界面读走之后必须写 0 认领——从"读到 1"到"写回 0"这段窗口就是丢触发的根源。
        /// </summary>
        public void Raise(string address)
        {
            var word = Addr(address);
            lock (state)
            {
                short current;
                registers.TryGetValue(word, out current);
                if (current == 1)
                {
                    if (clearing.Contains(word)) SwallowedCount++;
                    else CoalescedCount++;
                }
                RaisedCount++;
                registers[word] = 1;
            }
        }

        public void Poke(string address, short value)
        {
            var word = Addr(address);
            lock (state)
            {
                registers[word] = value;
            }
        }

        /// <summary>机台一次塞连续若干个字，用于条码区（MW63050 起 20 个字）。</summary>
        public void PokeWords(string address, short[] values)
        {
            var start = Addr(address);
            lock (state)
            {
                for (var i = 0; i < values.Length; i++)
                {
                    registers[start + i] = values[i];
                }
            }
        }

        public void PokeFloat(string address, double value)
        {
            var start = Addr(address);
            lock (state)
            {
                // 浮点怎么拆成两个字，用的是 WordCodec 里那一份（和 InovanceAmTcpPlc 同一个方法），
                // 模拟机不另写一份，免得两边对不上。
                var words = WordCodec.FloatToWords(value);
                registers[start] = words[0];
                registers[start + 1] = words[1];
            }
        }

        /// <summary>机台把一串 ASCII 塞进寄存器区，wordCount 不够会补 0。</summary>
        public void PokeAscii(string address, string text, int wordCount)
        {
            PokeWords(address, WordCodec.AsciiToWords(text, wordCount));
        }

        /// <summary>机台侧读寄存器：不占连接锁，界面线程抢锁不影响它等回写。</summary>
        public short Peek(string address)
        {
            var word = Addr(address);
            lock (state)
            {
                short value;
                registers.TryGetValue(word, out value);
                return value;
            }
        }

        public short[] PeekWords(string address, int count)
        {
            var start = Addr(address);
            var result = new short[count];
            lock (state)
            {
                short value;
                for (var i = 0; i < count; i++)
                {
                    registers.TryGetValue(start + i, out value);
                    result[i] = value;
                }
            }
            return result;
        }

        /// <summary>
        /// 机台侧写/看一个 I/O 位。方向要和真机一致：
        /// I 区是机台/按钮写给上位机看的，Q 区是上位机（手动操作页）写出去驱动气缸和灯的。
        /// </summary>
        public void PokeBit(string address, bool on)
        {
            lock (state) { bits[BitAddr(address)] = on; }
        }

        /// <summary>机台侧看一个位现在什么状态：仿真气缸要读界面刚写出去的阀。</summary>
        public bool PeekBit(string address)
        {
            var key = BitAddr(address);
            lock (state)
            {
                bool on;
                bits.TryGetValue(key, out on);
                return on;
            }
        }

        // ── 内部 ───────────────────────────────────────────────────────────

        /// <summary>
        /// 把 "MW63050" / "MW 50006" / "IX1000.5" / "63050" 解析成字地址。
        /// 真项目里 csv 写的地址带空格、代码里写的带前缀，所以前缀和空格都要吃掉；
        /// 小数点后面的位号在这里忽略（带 MB/MX 的位地址由 ReadMB/WriteMB 自己换算）。
        /// </summary>
        private static int Addr(string address)
        {
            if (string.IsNullOrEmpty(address))
            {
                throw new ArgumentException("地址不能为空");
            }
            var digits = new StringBuilder();
            foreach (var ch in address)
            {
                if (ch == '.') break;
                if (ch >= '0' && ch <= '9') digits.Append(ch);
            }
            int parsed;
            if (digits.Length == 0 || !int.TryParse(digits.ToString(), out parsed))
            {
                throw new ArgumentException("地址格式不正确: " + address);
            }
            return parsed;
        }

        /// <summary>"I 1000.3"、"IX1000.3"、"q1001.2" 都归成同一个键，省得两种写法各存一份对不上。</summary>
        private static string BitAddr(string address)
        {
            var text = (address ?? string.Empty).Replace(" ", "").ToUpperInvariant();
            if (text.Length < 3 || !text.Contains("."))
            {
                throw new ArgumentException("IO 位地址写错了，应该是 I1000.3 / QX1001.2 这种：" + address);
            }
            var area = text[0] == 'Q' ? "Q" : "I";
            return area + "X" + text.Substring(1).TrimStart('X');
        }

        private short Take(int address)
        {
            lock (state)
            {
                short current;
                registers.TryGetValue(address, out current);
                if (current == 1) clearing.Add(address);
                return current;
            }
        }

        /// <summary>占住连接锁睡一下：这就是"等 PLC 回话"。</summary>
        private void Wait()
        {
            if (RoundTripMs > 0) Thread.Sleep(RoundTripMs);
        }
    }
}
