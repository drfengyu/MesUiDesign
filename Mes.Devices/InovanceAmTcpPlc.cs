using HslCommunication;
using HslCommunication.Profinet.Inovance;
using Mes.Common;
using System;

namespace Mes.Devices
{
    /// <summary>
    /// 汇川 AC 系列（InovanceAMTcp）驱动，现场 PLC1 走的就是这一路。
    ///
    /// 现场常见调用（对着主项目 Global.plc1 的写法）：
    ///   ReadInt16("MW500", 1) 读一段字；ReadBool("IX1000.5") 读一个输入位；
    ///   Write("MW50000", ConvertFloatToInt16Array(100.2)) 写一个浮点（拆成两个字）。
    /// 这些换算现在统一在 WordCodec 里，不用再手工拼。
    /// </summary>
    public class InovanceAmTcpPlc : PlcBase
    {
        private readonly InovanceAMTcp client;

        public InovanceAmTcpPlc(string plcIp, string plcPort) : base(plcIp, plcPort)
        {
            client = new InovanceAMTcp(plcIp, Convert.ToInt32(plcPort));
        }

        public override bool ConnectPlc()
        {
            return Connect(() => client.ConnectServer());
        }

        public override bool DisconnectPlc()
        {
            return Disconnect(() => client.ConnectClose());
        }

        public override short Read(int address)
        {
            return Trace(Mw(address), client.ReadInt16(Mw(address)).Content, true);
        }

        public override short[] Read(string address, ushort length = 1)
        {
            return Trace(address, client.ReadInt16(address, length).Content, true);
        }

        public override int ReadInt32(string address)
        {
            return Trace(address, client.ReadInt32(address).Content, true);
        }

        public override int[] ReadInt32(string address, ushort length = 1)
        {
            return Trace(address, client.ReadInt32(address, length).Content, true);
        }

        public override float ReadFloat(string address)
        {
            return Trace(address, WordsToFloat(client.ReadInt16(address, 2).Content), true);
        }

        public override double[] ReadFloatArray(string address, ushort length = 2)
        {
            return Trace(address, WordsToFloats(client.ReadInt16(address, length).Content), true);
        }

        public override OperateResult<bool> ReadBool(string address)
        {
            var result = client.ReadBool(address);
            Trace(address, result.Content, true);
            return result;
        }

        public override short ReadMB(string address, ushort length = 1)
        {
            return ReadBitByte(address, length);
        }

        public override OperateResult Write(string address, short value)
        {
            Trace(address, value, false);
            return client.Write(address, value);
        }

        public override OperateResult Write(string address, short[] values)
        {
            Trace(address, values, false);
            return client.Write(address, values);
        }

        public override OperateResult WriteFloat(string address, double value)
        {
            var words = WordCodec.FloatToWords(value);
            Trace(address, words, false);
            return client.Write(address, words);
        }

        public override OperateResult WriteMB(string address, byte value)
        {
            Trace(address, value, false);
            return WriteBitByte(address, value);
        }
    }
}
