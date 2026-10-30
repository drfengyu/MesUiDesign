using System;

namespace Mes.Devices
{
    /// <summary>
    /// 写寄存器的"只管写完"写法。
    ///
    /// 为什么不直接用 PlcBase.Write：它返回 HSL 的 OperateResult，业务层不引 Communication.dll
    /// 就接不住这个返回类型（CS0012）。但写失败在过站链路里等于机台一直等结果字，
    /// 不能悄悄丢掉，所以这里查一下、失败就抛，由轮询线程那层的 try/catch 落崩溃日志。
    ///
    /// 顺带把驱动里"写完就返回 new OperateResult()"这种写法照出来一次：
    /// HSL 的无参构造是**失败**结果（ErrorCode=-1、Message="Unknown Error"），
    /// 成功要用 OperateResult.CreateSuccessResult()。以前没人查返回值，这个错一直藏着。
    /// </summary>
    public static class PlcWrites
    {
        public static void WriteChecked(this PlcBase plc, string address, short value)
        {
            var result = plc.Write(address, value);
            if (!result.IsSuccess)
            {
                throw new InvalidOperationException("写 " + address + " = " + value + " 失败：" + result.Message);
            }
        }

        /// <summary>
        /// 写一个 I/Q 位（手动操作页点动气缸）。
        ///
        /// 只挂在 SimulatedPlc 上：真驱动层没有 WriteBool，现场写位走的是 WriteMB("MX…")，
        /// 两套地址页不是一回事。接真机时补一个真驱动的 WriteBool，再把这个扩展改成 PlcBase 即可。
        /// 界面层不引 Communication.dll，所以这个返回 OperateResult 的方法不能直接给页面调。
        /// </summary>
        public static void WriteBitChecked(this SimulatedPlc plc, string address, bool value)
        {
            var result = plc.WriteBool(address, value);
            if (!result.IsSuccess)
            {
                throw new InvalidOperationException("写位 " + address + " = " + value + " 失败：" + result.Message);
            }
        }
    }
}
