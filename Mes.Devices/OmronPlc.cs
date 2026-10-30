using HslCommunication;
using HslCommunication.Profinet.Omron;
using Mes.Common;
using System;

namespace Mes.Devices
{
    /// <summary>
    /// 欧姆龙 Fins（OmronFinsNet）驱动。字地址前缀是 D，与汇川的 MW 不通用，
    /// 所以 Read(int) 里拼的是 "D" + 号。
    ///
    /// 两条规矩：
    /// 1) 类库里不许 MessageBox。触摸屏上弹模态框会把界面线程整个卡住，而机台还在跑——
    ///    没人点确定就没人能停机，报警页也刷不出来。连接失败只记日志、返回 false。
    /// 2) 构造函数里不要挂写死文件名的 LogNetSingle：每读一个地址追加一行且永不滚动，
    ///    跑一天能把盘写满。要排查时由调用方自己挂 LogNet。
    /// </summary>
    public class OmronPlc : PlcBase
    {
        private readonly OmronFinsNet client;

        public OmronPlc(string plcIp, string plcPort) : base(plcIp, plcPort)
        {
            client = new OmronFinsNet(plcIp, Convert.ToInt32(plcPort));
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
            return Trace("D" + address, client.ReadInt16("D" + address).Content, true);
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

        // ── 下面这几路本机还没接现场需求，先明确"没做"而不是硬凑一个假实现 ──────
        // 位读、浮点、MB 位在 Fins 里的地址写法（CIO/W/%X）和汇川完全不同，
        // 照抄 MW 的拆位算法会读出相邻位的值，宁可不实现。要做时按 Fins 地址格式补 client 调用。

        public override OperateResult<bool> ReadBool(string address)
        {
            throw new NotImplementedException("欧姆龙位地址（%X/CIO）换算未实现");
        }

        public override float ReadFloat(string address)
        {
            throw new NotImplementedException("欧姆龙浮点（4 字）读取未实现");
        }

        public override double[] ReadFloatArray(string address, ushort length = 2)
        {
            throw new NotImplementedException("欧姆龙浮点块读未实现");
        }

        public override short ReadMB(string address, ushort length = 1)
        {
            throw new NotImplementedException("欧姆龙没有 MW 拆位这一说，位地址用 %X");
        }

        public override OperateResult WriteFloat(string address, double value)
        {
            throw new NotImplementedException("欧姆龙浮点写入未实现");
        }

        public override OperateResult WriteMB(string address, byte value)
        {
            throw new NotImplementedException("欧姆龙位写入未实现");
        }
    }
}
