using Mes.Devices;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Mes.Business
{
    /// <summary>
    /// 模拟机台：扮演 PLC 那一侧，把真机的一整套握手按时序演出来。
    ///
    /// 为什么单独一个类：界面程序只读只写寄存器，"谁先谁后"是 PLC 程序定的。
    /// 如果让操作者自己手动点按钮置位，他点快了、点慢了都会以为是界面代码错了。
    /// 这里把时序固定下来，界面写得对就一路绿灯，写得不对就当场卡住——
    /// 卡在哪一步，就是哪一步的握手没做对。接真机时这个类整个删掉，界面代码不用动。
    ///
    /// 一片料的完整时序（对着主项目 MainFrm 的线程抄的）：
    ///   1 扫码枪读到码 → 塞进 MW63050（左）/ MW63075（右），置 MW63000 / MW63002 = 1
    ///   2 界面读到 1 → 写 0 认领 → 读条码 → 判放行 → 写 MW63001 / MW63003 = 1(放行) 或 2(拦截)
    ///   3 放行进到工位 → 塞工位条码区 MW63100/63125/63150/63175 + 治具号 MW63124…
    ///      → 置 MW63010 那一路 = 1
    ///   4 焊完 → 塞测量浮点 MW15030…(MC) / MW15058…(BOSS) / MW15900…(WD) + CT(MW4024/4028)
    ///      → 置 MW63020 / 63022 / 63024 / 63026 = 1
    ///   5 界面判完 → 写 MW63021 / 63023 / 63025 / 63027 = 1(OK) 或 2(NG)，机台据此放行或抛料
    /// </summary>
    public class MachineSimulator
    {
        private readonly SimulatedPlc plc;
        private readonly AlarmCatalog alarms;
        private readonly List<string> fixtureCodes = new List<string>();
        private readonly Random random = new Random(20261019);
        private readonly List<short[]> lastParamWords = new List<short[]>();
        private Thread loop;
        private int sequence;
        private int fixtureCursor;

        // ── IO 点位（IO 监控页要看的那几个）─────────────────────────────────
        // 地址都是现场 IO输入输出表.csv 里真有的行，只挑本机这一圈动作对得上的：
        // 自动按钮、双启动 1/2（焊接时两只手同时按下才启焊）、双启动灯 1/2（灯就在同一颗按钮里）、
        // 三色蜂鸣驱动（报警时响）。表里另外 360 个点本机没接，读回来一律 0——
        // 这一页要看的就是"该亮的亮、没接的别乱亮"。
        private const string AutoButtonBit = "I 1000.1";
        private const string DualStart1Bit = "I 1001.3";
        private const string DualStart2Bit = "I 1001.4";
        private const string DualStartLamp1Bit = "Q 1001.2";
        private const string DualStartLamp2Bit = "Q 1001.3";
        private const string BuzzerBit = "Q 1000.7";

        /// <summary>气缸从一个位置走到另一个位置要多久（ms）。真机看缸径和气压，这里 300ms 够用。</summary>
        private const int CylinderStrokeMs = 300;

        /// <summary>阀刚开始按下时的时刻：满 CylinderStrokeMs 才把到位开关置上，模拟"缸在走"。</summary>
        private readonly Dictionary<string, int> valvePressedAt = new Dictionary<string, int>();

        public MachineSimulator(SimulatedPlc plc, AlarmCatalog alarms)
        {
            this.plc = plc;
            this.alarms = alarms;
            // 开机时旋钮就在自动档：线程没启动之前，手动操作页读这一位也要和 AutoMode 一致，
            // 否则会出现"页面显示自动、点动却被放行"的窗口。
            plc.PokeBit(ManualOperations.AutoSelectorBit, AutoMode);
        }

        /// <summary>是否在出料。暂停时线程还活着，只是不再往前推流程——
        /// 真机的"暂停"就是这个语义：程序没退出，只是不生产。</summary>
        public volatile bool Running;

        /// <summary>
        /// MA 旋钮打到哪一档。这一位是**机台侧**的：真机上它是面板上的物理旋钮，
        /// 上位机只能读不能写，所以模拟机把它放在这里，由"模拟机台"那一页去拨。
        /// 手动时自动流程一步都不走，但气缸照样能点动——现场就是这个互锁。
        /// </summary>
        public volatile bool AutoMode = true;

        private volatile bool threadAlive;

        /// <summary>两片料之间的间隔毫秒数。真机 CT 约 5~6s，本机调小一点好出数据。</summary>
        public int CycleMs = 5000;

        /// <summary>大约多少片出一次报警（0=不注入）</summary>
        public int AlarmEvery = 12;

        /// <summary>注入报警时往 MW62000 写的通道号（1~4 对应 MW62001/62003/62001…）</summary>
        public int AlarmChannel = 3;

        /// <summary>当天已经用掉的产品流水号；由 StationContext 按 ProductLog 里的最大号接上，重启不重码。</summary>
        public int SerialBase;

        public event Action<string> OnEvent;

        public void Start()
        {
            // 停止过一次就重建线程：只判 loop != null 的话"停止→启动"点下去没反应，
            // 因为老线程早已按 threadAlive 退出了。
            if (loop != null && threadAlive) return;
            // 机台身份先声明好：这三个值是 PLC 侧的配置，界面只负责读
            plc.Poke(PlcAddresses.Mw(PlcAddresses.MachineType), 1);
            // 1 = MES 未启用：没有真 MES 时默认按离线跑（报站直接放行）。
            // 报站送码页上勾"启用 MES 报站"会把它写成 0，就切到走接口那条分支。
            plc.Poke(PlcAddresses.Mw(PlcAddresses.MesDisabled), 1);
            plc.Poke(PlcAddresses.Mw(PlcAddresses.DebugFakeBarcode), 0);   // 0=扫码枪已接，用真码；置 1 就变成"调试用假码"
            // 开机时所有气缸停在原点侧（现场通上气就是这个状态）。
            // 不置这一份的话手动操作页第一屏两个到位灯都是灭的，看不出"点动有没有到位"。
            foreach (var cylinder in ManualOperations.Cylinders)
            {
                plc.PokeBit(cylinder.HomeSensor, true);
                plc.PokeBit(cylinder.WorkSensor, false);
            }
            // 主界面区域5 的四颗连接灯：本机全给"已连接"，要看不连接的样子就在"模拟机台"页清某一位。
            for (var i = 0; i < PlcAddresses.DeviceLinkNames.Length; i++)
            {
                plc.Poke(PlcAddresses.DeviceLink(i), 1);
            }
            Running = true;
            threadAlive = true;
            loop = new Thread(Run);
            loop.IsBackground = true;
            loop.Name = "模拟机台";
            loop.Start();
        }

        public void Stop()
        {
            threadAlive = false;
            Running = false;
        }

        /// <summary>用真治具码表喂治具池，过站时按顺序取，这样治具管控页的计数才会动。</summary>
        public void SetFixtures(IEnumerable<string> codes)
        {
            fixtureCodes.Clear();
            fixtureCodes.AddRange(codes);
        }

        private void Run()
        {
            var nextAlarmAt = AlarmEvery > 0 ? AlarmEvery : int.MaxValue;
            while (threadAlive)
            {
                Thread.Sleep(200);
                WatchParamChange();
                plc.PokeBit(ManualOperations.AutoSelectorBit, AutoMode);
                // 气缸不跟着"暂停/手动"停：手动操作页就是要在这种状态下点动，
                // 所以这一句放在下面的 continue 之前。
                SimulateCylinders();
                plc.PokeBit(AutoButtonBit, Running && AutoMode);
                // 上一片"双手按下"到这一轮开头收掉：焊接那几秒它是亮着的（见 SendToStation）
                plc.PokeBit(DualStart1Bit, false);
                plc.PokeBit(DualStart2Bit, false);
                plc.PokeBit(DualStartLamp1Bit, false);
                plc.PokeBit(DualStartLamp2Bit, false);
                if (!Running || !AutoMode) continue;
                var slide = sequence % 2 == 0 ? 0 : 1;
                // 工位号原来也取 sequence % 2，和 slide 用的是同一个奇偶，
                // 于是左滑台永远落在工位 2、右滑台永远落在工位 3——工位 1/4 的触发字没人读过，
                // 过站判定页四行只有两行有数，看着像界面坏了。改取 sequence/2 的奇偶，四路才轮得满。
                var within = sequence / 2 % 2 == 0 ? 0 : 1;
                var station = slide == 0 ? 1 + within : 3 + within;
                var sn = NextSn();
                sequence++;
                if (!CheckIn(slide, sn)) continue;
                if (sequence % nextAlarmAt == 0 && AlarmEvery > 0)
                {
                    InjectAlarmNow();
                    continue;
                }
                var fixtureIndex = NextFixtureIndex();
                SendToStation(station, sn, fixtureIndex);
                CheckOut(station, sn);
            }
        }

        // 心跳不在这里发：主项目 PLC_Pant 是"上位机写给 PLC 看"的，方向是从界面到 PLC，
        // 所以由状态轮询那边去 Write，模拟机台只负责读。

        private bool CheckIn(int slide, string sn)
        {
            int trgNum = slide == 0 ? PlcAddresses.LeftCheckInTrigger : PlcAddresses.RightCheckInTrigger;
            string barcodeArea = PlcAddresses.Mw(slide == 0 ? PlcAddresses.LeftBarcodeArea : PlcAddresses.RightBarcodeArea);
            int resultNum = slide == 0 ? PlcAddresses.LeftCheckInResult : PlcAddresses.RightCheckInResult;
            plc.PokeAscii(barcodeArea, sn, PlcAddresses.BarcodeWords);
            var result = PlcAddresses.Mw(resultNum);
            var trg = PlcAddresses.Mw(trgNum);
            plc.Poke(result, 0);
            plc.Raise(trg);
            Raise("扫码枪(" + (slide == 0 ? "左" : "右") + ") 送入 " + sn);
            if (!WaitFor(() => plc.Peek(result) != 0, 6000))
            {
                Raise("报站超时：" + trg + " 一直是 1，界面没认领");
                plc.Poke(trg, 0);
                return false;
            }
            var verdict = plc.Peek(result);
            Raise("报站结果 " + (verdict == 1 ? "放行" : "拦截"));
            return verdict == 1;
        }

        private void SendToStation(int station, string sn, int fixtureIndex)
        {
            plc.PokeAscii(PlcAddresses.Mw(PlcAddresses.StationBarcodeAreas[station - 1]), sn, PlcAddresses.BarcodeWords);
            // 治具号是一个"表内序号"，界面读回来再去治具台账里查码——真机就是这么传的
            plc.Poke(PlcAddresses.Mw(PlcAddresses.StationFixtureIndexes[station - 1]), (short)fixtureIndex);
            plc.Raise(PlcAddresses.Mw(PlcAddresses.SendBarcodeTrigger + station - 1));
            Raise("送码到工位 " + station + "，治具序号 " + fixtureIndex);
            // 焊开始了：两只手的启动按钮同时按下（安全回路要求双手一起），按钮里的灯跟着亮
            plc.PokeBit(DualStart1Bit, true);
            plc.PokeBit(DualStart2Bit, true);
            plc.PokeBit(DualStartLamp1Bit, true);
            plc.PokeBit(DualStartLamp2Bit, true);
        }

        private void CheckOut(int station, string sn)
        {
            Thread.Sleep(Math.Max(300, CycleMs / 3));
            PokeMeasurements(station);
            var trg = PlcAddresses.Mw(PlcAddresses.CheckOutTrigger(station));
            var result = PlcAddresses.Mw(PlcAddresses.CheckOutResult(station));
            plc.Poke(result, 0);
            plc.Raise(trg);
            Raise("工位 " + station + " 焊完，请求过站");
            if (!WaitFor(() => plc.Peek(result) != 0, 6000))
            {
                Raise("过站超时：" + trg + " 没人认领");
                plc.Poke(trg, 0);
                return;
            }
            var verdict = plc.Peek(result);
            Raise("工位 " + station + " " + sn + " 过站 " + (verdict == 1 ? "OK" : "NG，抛料"));
            plc.Poke(trg, 0);
        }

        /// <summary>
        /// 塞测量值。三块区域都是浮点，每个占两个字，所以 MC 区 6 个浮点要 12 个字。
        /// 数值故意做成"大部分合格、偶尔超上限"，这样过站判定页才有 NG 可看。
        /// </summary>
        private void PokeMeasurements(int station)
        {
            for (var i = 0; i < 6; i++)
            {
                plc.PokeFloat(PlcAddresses.Mw(PlcAddresses.McArea(station) + i * 2), 0.5 + random.NextDouble() * 0.08);
            }
            for (var i = 0; i < 6; i++)
            {
                plc.PokeFloat(PlcAddresses.Mw(PlcAddresses.BossArea(station) + i * 2), 2.0 + random.NextDouble() * 0.12);
            }
            for (var i = 0; i < 4; i++)
            {
                plc.PokeFloat(PlcAddresses.Mw(PlcAddresses.WdArea(station) + i * 2), 30 + random.NextDouble() * 6);
            }
            // CT：主项目里读回来还要除以 2（PLC 存的是 0.5s 一个单位）
            plc.PokeFloat(PlcAddresses.Mw(PlcAddresses.CtArea(station)), CycleMs / 1000D * 2);
        }

        /// <summary>
        /// 注入一条报警：往 MW62000 写通道号、往该通道的触发寄存器写**报警表序号**。
        /// 这就是真机报报警的唯一通路，界面靠 OEE_DT 线程轮询发现它变了。
        ///
        /// 公开出来给"帮助/模拟机台"页的"立即注入报警"用；没注入成功返回 false
        /// （报警表为空、序号越界或没有非计划类），界面据此提示而不是假装按下去了。
        /// </summary>
        public bool InjectAlarmNow()
        {
            if (alarms == null || alarms.Count == 0) return false;
            var candidates = new List<AlarmInfo>();
            foreach (var item in alarms.Items)
            {
                if (item.Index > 0 && item.Index <= short.MaxValue && item.DtClass.Contains("非计划"))
                {
                    candidates.Add(item);
                }
            }
            if (candidates.Count == 0) return false;
            var pick = candidates[random.Next(candidates.Count)];
            plc.Poke(PlcAddresses.Mw(PlcAddresses.OeeStatus), (short)AlarmChannel);
            plc.Poke(PlcAddresses.Mw(PlcAddresses.OeeTriggerRegister(AlarmChannel)), (short)pick.Index);
            // 三色灯蜂鸣响起来，一直响到下一片料开始焊为止（本机没做"消音"按钮这一路），
            // 不是一闪就没了——现场蜂鸣就是必须有人去按消音才停。
            plc.PokeBit(BuzzerBit, true);
            Raise("机台报警 " + pick.Code + " " + pick.Title);
            return true;
        }

        /// <summary>
        /// 气缸仿真：界面把某个阀写成 1，这边过 CylinderStrokeMs 就把它的到位开关置上、另一侧清掉。
        ///
        /// 为什么由机台侧来演：到位信号是**磁感应开关**给的，不是界面算出来的。
        /// 最容易犯的错就是"点了按钮直接把界面上的灯点亮"——那样永远测不出
        /// 阀没电、气管没接、感应头坏了这三种情况，现场联调时才发现。
        /// 这里故意做成：写阀 → 过一会儿 → 到位灯才亮，中间那段时间就是"缸在走"。
        /// </summary>
        private void SimulateCylinders()
        {
            foreach (var cylinder in ManualOperations.Cylinders)
            {
                AdvanceCylinder(cylinder.HomeValve, cylinder.HomeSensor, cylinder.WorkSensor);
                AdvanceCylinder(cylinder.WorkValve, cylinder.WorkSensor, cylinder.HomeSensor);
            }
        }

        private void AdvanceCylinder(string valve, string thisSideSensor, string otherSideSensor)
        {
            if (!plc.PeekBit(valve))
            {
                valvePressedAt.Remove(valve);     // 松开了：下次再按要重新计时（点动就是走一点停一点）
                return;
            }
            int pressedAt;
            if (!valvePressedAt.TryGetValue(valve, out pressedAt))
            {
                valvePressedAt[valve] = Environment.TickCount;
                return;
            }
            if (Environment.TickCount - pressedAt < CylinderStrokeMs) return;
            plc.PokeBit(thisSideSensor, true);
            plc.PokeBit(otherSideSensor, false);
        }

        /// <summary>机台侧盯着参数区，发现有人改了值就把"修改前/修改后"两个触发置 1。</summary>
        private void WatchParamChange()
        {
            if (lastParamWords.Count == 0)
            {
                for (var offset = 0; offset < PlcAddresses.ParamBlockWords; offset += 200)
                {
                    lastParamWords.Add(plc.PeekWords(
                        PlcAddresses.Mw(PlcAddresses.ParamBlockStart + offset),
                        Math.Min(200, PlcAddresses.ParamBlockWords - offset)));
                }
                return;
            }
            for (var b = 0; b < lastParamWords.Count; b++)
            {
                var now = plc.PeekWords(
                    PlcAddresses.Mw(PlcAddresses.ParamBlockStart + b * 200), lastParamWords[b].Length);
                if (!SameWords(now, lastParamWords[b]))
                {
                    lastParamWords[b] = now;
                    plc.Poke(PlcAddresses.Mw(PlcAddresses.ParamBeforeChangeTrigger), 1);
                    plc.Poke(PlcAddresses.Mw(PlcAddresses.ParamAfterChangeTrigger), 1);
                    Raise("检测到参数区被改写，置 " + PlcAddresses.Mw(PlcAddresses.ParamBeforeChangeTrigger)
                        + " / " + PlcAddresses.Mw(PlcAddresses.ParamAfterChangeTrigger));
                }
            }
        }

        private static bool SameWords(short[] a, short[] b)
        {
            if (a.Length != b.Length) return false;
            for (var i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i]) return false;
            }
            return true;
        }

        private string NextSn()
        {
            // 现场产品码形如 MPG + 日期 + 流水，这里同构，不冒充真码
            return "MPG" + DateTime.Now.ToString("yyMMdd") + (SerialBase + sequence + 1).ToString("0000");
        }

        /// <summary>返回治具在台账里的序号（0 起）；界面那边用 序号+1 去查治具码。</summary>
        private int NextFixtureIndex()
        {
            if (fixtureCodes.Count == 0) return 0;
            var index = fixtureCursor % fixtureCodes.Count;
            fixtureCursor++;
            return index;
        }

        private static bool WaitFor(Func<bool> condition, int timeoutMs)
        {
            var deadline = Environment.TickCount + timeoutMs;
            while (Environment.TickCount < deadline)
            {
                if (condition()) return true;
                Thread.Sleep(50);
            }
            return false;
        }

        private void Raise(string text)
        {
            var handler = OnEvent;
            if (handler != null) handler(text);
        }
    }
}
