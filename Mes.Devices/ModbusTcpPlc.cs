using HslCommunication;
using HslCommunication.ModBus;
using System;
using System.Linq;

namespace Mes.Devices
{
    /// <summary>
    /// Modbus TCP 从站（仪表、温控、第三方小 PLC 走这一路）。
    ///
    /// 与汇川那路的差别：Modbus 的地址就是纯数字（"40001" 这种寄存器号），
    /// 没有 MW/MB 前缀，所以 Read(int) 直接把号当字符串发出去；
    /// 位读走线圈 ReadCoil，不是从字里拆位。混用这两个约定是接第三方设备最常踩的坑。
    /// </summary>
    public class ModbusTcpPlc : PlcBase
    {
        private readonly ModbusTcpNet client;

        public ModbusTcpPlc(string plcIp, string plcPort) : base(plcIp, plcPort)
        {
            client = new ModbusTcpNet(plcIp, Convert.ToInt32(plcPort)) { ConnectTimeOut = 3000 };
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
            return Trace(address.ToString(), client.ReadInt16(address.ToString()).Content, true);
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
            return Trace(address, client.ReadFloat(address).Content, true);
        }

        /// <summary>Modbus 的 ReadFloat(address, n) 直接给 n 个浮点，不用自己拼字。</summary>
        public override double[] ReadFloatArray(string address, ushort length = 2)
        {
            var result = client.ReadFloat(address, length);
            return Trace(address, result.IsSuccess ? result.Content.Select(x => (double)x).ToArray()
                : new double[0], true);
        }

        public override OperateResult<bool> ReadBool(string address)
        {
            var result = client.ReadCoil(address);
            Trace(address, result.Content, true);
            return result;
        }

        /// <summary>Modbus 没有"从 MW 字里拆位"这一说，位地址原样当寄存器号读。</summary>
        public override short ReadMB(string address, ushort length = 1)
        {
            return Trace(address, client.ReadInt16(address, length).Content[0], true);
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
            Trace(address, value, false);
            return client.Write(address, (float)value);
        }

        public override OperateResult WriteMB(string address, byte value)
        {
            Trace(address, value, false);
            return client.Write(address, (short)value);
        }
    }
}
