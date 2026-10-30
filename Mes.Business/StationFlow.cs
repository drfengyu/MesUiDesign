using Mes.Devices;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Mes.Business
{
    /// <summary>
    /// 过站链路的上位机这一半：轮询报站/送码/过站三组触发字，认领、读写寄存器、落追溯表。
    ///
    /// 机台那一半在 MachineSimulator（模拟 PLC），这一半才是真项目里 PLC_CheckIn1 /
    /// PLC_SendSN / PLC_CheckOut1 那几个线程做的事。两边只靠寄存器说话，互不引用。
    ///
    /// 三条只有对着真代码才知道的规矩：
    /// 1) 触发字读到 1 要**先写 0 认领**再去取值。反过来先取值，机台以为没人处理会再报一次，
    ///    一片料就落两条记录。
    /// 2) 结果字写 1=放行/OK、2=拦截/NG，写 0 等于没判完，机台会一直等。
    /// 3) 判定用的上下限来自 数据\判定上下限.csv，不写死在代码里。
    /// </summary>
    public class StationFlow
    {
        private readonly StationContext owner;
        private readonly SimulatedPlc plc;
        private readonly DateTime[] sendAt = new DateTime[4];
        private readonly DateTime[] lastCheckout = new DateTime[4];
        private Thread loop;
        private volatile bool alive;

        /// <summary>
        /// 报站是否走 MES 接口。默认 false：本机没有 MES 服务端，走离线放行（写 MW62071=1）。
        /// 勾上之后没有接口就只能拦，所以这里明确拦并提示，不做"假装放行"。
        /// </summary>
        public volatile bool MesReport;

        public StationFlow(StationContext owner)
        {
            this.owner = owner;
            this.plc = owner.Plc;
        }

        public void Start()
        {
            if (loop != null) return;
            alive = true;
            loop = new Thread(Run);
            loop.IsBackground = true;
            loop.Name = "过站轮询";
            loop.Start();
        }

        public void Stop()
        {
            alive = false;
        }

        private void Run()
        {
            var cycle = 0;
            while (alive)
            {
                Thread.Sleep(150);
                try
                {
                    PollCheckIn();
                    PollSendBarcode();
                    PollCheckOut();
                    PollAlarm();
                    if (cycle++ % 10 == 0) PollStatus();
                }
                catch (Exception ex)
                {
                    // 轮询线程里抛出去就是整个链路停摆，而且没人看得见：
                    // 现场表现为"界面还在，但不再记录"，最难查，所以兜住并落崩溃日志。
                    owner.Log.WriteCrash("过站轮询", ex);
                    owner.Say("过站轮询异常：" + ex.Message);
                }
            }
        }

        // ── 报站（左/右滑台扫码进机） ──────────────────────────────────────

        private void PollCheckIn()
        {
            CheckInOnce(0);
            CheckInOnce(1);
        }

        private void CheckInOnce(int slide)
        {
            var side = slide == 0 ? "左" : "右";
            var trigger = PlcAddresses.Mw(slide == 0
                ? PlcAddresses.LeftCheckInTrigger : PlcAddresses.RightCheckInTrigger);
            if (plc.Read(trigger, 1)[0] != 1) return;
            plc.WriteChecked(trigger, 0);

            var area = PlcAddresses.Mw(slide == 0
                ? PlcAddresses.LeftBarcodeArea : PlcAddresses.RightBarcodeArea);
            var code = Clean(WordCodec.WordsToAscii(plc.Read(area, PlcAddresses.BarcodeWords)));
            var result = PlcAddresses.Mw(slide == 0
                ? PlcAddresses.LeftCheckInResult : PlcAddresses.RightCheckInResult);

            var reason = Admit(code);
            if (reason == null)
            {
                owner.ProductLog.ReportArrival(code);
                plc.WriteChecked(result, 1);
                owner.Say(side + " 报站放行 " + code);
            }
            else
            {
                plc.WriteChecked(result, 2);
                owner.Log.Write("系统", "报站拦截", code, reason, string.Empty);
                owner.Say(side + " 报站拦截 " + code + "：" + reason);
            }
        }

        /// <summary>null 表示放行，否则是不放行的原因。</summary>
        private string Admit(string code)
        {
            if (code.Length == 0) return "条码为空（扫码枪没送到码）";
            if (MesReport) return "勾了 MES 报站但本机没有 MES 接口";
            if (owner.ProductLog.FindByProductCode(code).Count > 0) return "同码重复投产";
            return null;
        }

        // ── 送码到工位 ────────────────────────────────────────────────────

        private void PollSendBarcode()
        {
            for (var station = 1; station <= 4; station++)
            {
                var trigger = PlcAddresses.Mw(PlcAddresses.SendBarcodeTrigger + station - 1);
                if (plc.Read(trigger, 1)[0] != 1) continue;
                plc.WriteChecked(trigger, 0);
                var code = Clean(WordCodec.WordsToAscii(plc.Read(
                    PlcAddresses.Mw(PlcAddresses.StationBarcodeAreas[station - 1]),
                    PlcAddresses.BarcodeWords)));
                var index = plc.Read(PlcAddresses.Mw(PlcAddresses.StationFixtureIndexes[station - 1]), 1)[0];
                var fixture = index >= 0 && index < owner.Ledger.Fixtures.Count
                    ? owner.Ledger.Fixtures[index].FixtureCode
                    : string.Empty;
                owner.ProductLog.AttachFixture(code, fixture);
                owner.Ledger.OnFixtureUsed(fixture);
                sendAt[station - 1] = DateTime.Now;
                owner.Say("工位 " + station + " 取料 " + code + " 治具 " + (fixture.Length == 0 ? "无" : fixture));
            }
        }

        // ── 过站判定 ──────────────────────────────────────────────────────

        private void PollCheckOut()
        {
            for (var station = 1; station <= 4; station++)
            {
                CheckOutOnce(station);
            }
        }

        private void CheckOutOnce(int station)
        {
            var trigger = PlcAddresses.Mw(PlcAddresses.CheckOutTrigger(station));
            if (plc.Read(trigger, 1)[0] != 1) return;
            plc.WriteChecked(trigger, 0);

            var code = Clean(WordCodec.WordsToAscii(plc.Read(
                PlcAddresses.Mw(PlcAddresses.StationBarcodeAreas[station - 1]),
                PlcAddresses.BarcodeWords)));
            var fixtureIndex = plc.Read(PlcAddresses.Mw(PlcAddresses.StationFixtureIndexes[station - 1]), 1)[0];
            var fixtureCode = fixtureIndex >= 0 && fixtureIndex < owner.Ledger.Fixtures.Count
                ? owner.Ledger.Fixtures[fixtureIndex].FixtureCode
                : string.Empty;
            var mc = plc.ReadFloatArray(PlcAddresses.Mw(PlcAddresses.McArea(station)), 12);
            var boss = plc.ReadFloatArray(PlcAddresses.Mw(PlcAddresses.BossArea(station)), 12);
            var wd = plc.ReadFloatArray(PlcAddresses.Mw(PlcAddresses.WdArea(station)), 8);
            // 主项目读回来要除以 2：PLC 存的是 0.5s 一个单位。
            var ct = plc.ReadFloatArray(PlcAddresses.Mw(PlcAddresses.CtArea(station)), 2)[0] / 2D;

            var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var measured = new List<KeyValuePair<string, double>>
            {
                Pair("MC纠偏X", mc, 0), Pair("MC纠偏Y", mc, 1), Pair("MC纠偏R", mc, 2),
                Pair("贴合纠偏X", boss, 0), Pair("贴合纠偏Y", boss, 1), Pair("贴合纠偏R", boss, 2),
                Pair("微动补偿X", wd, 0), Pair("微动补偿Y", wd, 1),
            };
            owner.ProductLog.WriteDimensions(code, mc, boss, wd);
            owner.ProductLog.WriteWelding(code, now, now, ct);

            var bad = owner.Limits.Violations(measured);
            var overdue = fixtureCode.Length == 0 ? null : owner.Ledger.OverdueReason(fixtureCode);
            var verdict = overdue != null
                ? "治具保养超期"
                : bad.Count == 0 ? "OK" : (station <= 2 ? "左" : "右") + "焊后过站NG";
            var failed = overdue != null || bad.Count > 0;
            if (overdue != null)
            {
                owner.FixtureBlocks.Append(now, fixtureCode, overdue, code, "NG");
                owner.Log.Write("系统", "治具卡控", fixtureCode, overdue, code);
            }
            owner.ProductLog.Complete(code, verdict);
            owner.Ledger.OnProductCompleted();
            plc.WriteChecked(PlcAddresses.Mw(PlcAddresses.CheckOutResult(station)), (short)(failed ? 2 : 1));
            owner.Say("工位 " + station + " " + code + " 过站 " + verdict
                + (bad.Count == 0 ? string.Empty : "：" + string.Join("、", bad.ToArray()))
                + (overdue == null ? string.Empty : "：" + overdue));

            var at = DateTime.Now;
            if (lastCheckout[station - 1] != default(DateTime) && station <= 3)
            {
                owner.Timing.Add(FlowGroup(station),
                    (at - lastCheckout[station - 1]).TotalMilliseconds);
            }
            lastCheckout[station - 1] = at;
            if (sendAt[station - 1] != default(DateTime) && (station == 2 || station == 3))
            {
                owner.Timing.Add(station == 2 ? TimingBoard.Fit2 : TimingBoard.Fit3,
                    (at - sendAt[station - 1]).TotalMilliseconds);
            }
        }

        private static string FlowGroup(int station)
        {
            return station == 1 ? TimingBoard.Flow1
                : station == 2 ? TimingBoard.Flow2 : TimingBoard.Flow3;
        }

        private static KeyValuePair<string, double> Pair(string name, double[] values, int at)
        {
            return new KeyValuePair<string, double>(name, at < values.Length ? values[at] : 0D);
        }

        // ── 状态位 ────────────────────────────────────────────────────────

        /// <summary>
        /// MES 开关（MW62071）是调试开关，几秒内不会变，不用每轮都读；
        /// 每 10 轮（约 2 秒）读一次存进上下文，状态条直接取缓存。
        /// </summary>
        private void PollStatus()
        {
            var watch = Stopwatch.StartNew();
            owner.MesDisabled = plc.Read(PlcAddresses.Mw(PlcAddresses.MesDisabled), 1)[0];
            owner.Timing.Add(TimingBoard.Communication, watch.Elapsed.TotalMilliseconds);
        }

        // ── 报警 ──────────────────────────────────────────────────────────

        private void PollAlarm()
        {
            var status = plc.Read(PlcAddresses.Mw(PlcAddresses.OeeStatus), 1)[0];
            if (status == 0) return;
            var index = plc.Read(PlcAddresses.Mw(PlcAddresses.OeeTriggerRegister(status)), 1)[0];
            if (index == 0) return;
            var info = owner.Alarms.FindByIndex(index);
            if (info == null) return;
            if (owner.ActiveAlarms.Raise(info))
            {
                owner.Uptime.FaultStarted(info, "系统");
                owner.Log.Write("系统", "机台报警", info.Code, info.Title, string.Empty);
            }
        }

        /// <summary>
        /// 复位：把四路报警触发字和状态字清 0，同时清掉界面上挂着的报警。
        /// 真机上这一颗只在故障确实消失后才允许按——故障还在就复位，报警会被机台重新报上来。
        /// </summary>
        public void ResetAlarms()
        {
            plc.WriteChecked(PlcAddresses.Mw(PlcAddresses.OeeStatus), 0);
            foreach (var register in PlcAddresses.OeeTriggers)
            {
                plc.WriteChecked(PlcAddresses.Mw(register), 0);
            }
            owner.ActiveAlarms.Clear();
            owner.Uptime.FaultEnded();
            owner.Say("报警已复位");
        }

        /// <summary>屏蔽蜂鸣：表里没有"蜂鸣"这一点就返回 false，界面据此把按钮置灰。</summary>
        public bool SilenceBuzzer()
        {
            var point = owner.Io.ByName("蜂鸣");
            if (point == null) return false;
            plc.PokeBit(point.Address, false);
            owner.Log.Write(owner.User, "屏蔽蜂鸣", point.Address, string.Empty, string.Empty);
            owner.Say("蜂鸣已屏蔽（" + point.Address + "）");
            return true;
        }

        /// <summary>
        /// 屏幕上的"急停"只让上位机停止推进并留痕；真机的急停是硬件安全回路，
        /// 不能指望一个触摸屏按钮——这颗按钮在安全评估里不算急停手段。
        /// </summary>
        public void EmergencyStop()
        {
            owner.Machine.Running = false;
            owner.Log.Write(owner.User, "急停请求", "机台", string.Empty, string.Empty);
            owner.Say("急停请求已发出：机台停止推进（硬件安全回路另算）");
        }

        private static string Clean(string raw)
        {
            return (raw ?? string.Empty).Trim().TrimEnd('\0').Trim();
        }
    }
}
