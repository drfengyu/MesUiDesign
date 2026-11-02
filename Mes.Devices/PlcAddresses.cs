namespace Mes.Devices
{
    /// <summary>
    /// 与 PLC 程序约定死的地址表。每个数字都从主项目 Mes数据追溯系统/MainFrm.cs 里抄出来，
    /// 注释保留它所在的线程方法名，现场排查时可以直接对着源码看。
    ///
    /// 为什么强调"抄真的"：上位机最难自学的部分是地址之间的配合关系——谁置位、谁清零、谁等谁。
    /// 用假地址（MW100/MW101）写示例，看完还是不知道真机上 63000 和 63050 为什么要隔 50。
    ///
    /// 这张表属于设备层：它是和 PLC 程序之间的约定，不是业务规则，
    /// 业务层只通过 PlcBase 的读写方法访问 PLC。
    ///
    /// 主项目里读写有两种写法混用：Read(63000) 传 MW 号，Write("MW63000", 0) 传字符串。
    /// 这里统一用 int，显示或下发时用 Mw() 冠回前缀。
    /// </summary>
    public static class PlcAddresses
    {
        // ── 心跳与机台身份 ───────────────────────────────────────────────
        /// <summary>PLC_Pant：写 1 再写 0，让 PLC 知道上位机还活着。方向是上位机 → PLC。</summary>
        public const int Heartbeat = 65000;

        /// <summary>PLC_Model：机台型号</summary>
        public const int MachineType = 62070;

        /// <summary>
        /// PLC_Model @780 读回来的 IfMES，**反逻辑**：0 = MES 已启用（报站/过站走 checkIn/checkOut 接口），
        /// 1 = MES 未启用（直接放行，只落 ProductLog）。@784 的 ShowStatus 就是按这个方向显示的。
        /// 现场调机时"界面不查 MES"十有八九是这一位是 1，别去找程序开关。
        /// </summary>
        public const int MesDisabled = 62071;

        /// <summary>
        /// PLC_Model @782 读回来的 IfSaoMa。它的含义不是"本工站要扫码"，而是"调试用假码"：
        /// 置 1 时报站/送码分支会把读到的条码整个换成 TEST1234567890ABC1（MainFrm @2057、@2159），
        /// 用来在没接扫码枪时空跑。别按字面意思理解这个位。
        /// </summary>
        public const int DebugFakeBarcode = 62094;

        // ── 报站（产品进机台，扫码枪把码送进来）PLC_CheckIn1 / PLC_CheckIn2 ──
        /// <summary>左滑台报站触发：PLC 置 1，程序读走后必须写 0 认领</summary>
        public const int LeftCheckInTrigger = 63000;

        /// <summary>左滑台报站结果：1=放行，2=拦截</summary>
        public const int LeftCheckInResult = 63001;

        /// <summary>左滑台条码区：20 个字，每字低字节一个 ASCII 字符</summary>
        public const int LeftBarcodeArea = 63050;

        public const int BarcodeWords = 20;
        public const int RightCheckInTrigger = 63002;
        public const int RightCheckInResult = 63003;
        public const int RightBarcodeArea = 63075;

        // ── 送 SN 到各工位 PLC_SendSN ────────────────────────────────────
        /// <summary>
        /// 4 个工位各自的送码触发：63010 / 63011 / 63012 / 63013。
        /// 主项目 PLC_SendSN @2138 是一次 Read("MW63010", 4) 块读回来按位判断，
        /// 命中哪个就把哪一个单独写 0 认领（@2151/2178/2204/2230）。
        /// 注意这四个字全是"触发"，没有跟着的结果字，别顺手排成 触发/结果 交替。
        /// 第 n 个工位的送码触发 = SendBarcodeTrigger + n - 1。
        /// </summary>
        public const int SendBarcodeTrigger = 63010;

        public const int SendBarcodeTriggerWords = 4;

        /// <summary>4 个工位各自的条码区（每个 20 字）</summary>
        public static readonly int[] StationBarcodeAreas = { 63100, 63125, 63150, 63175 };

        /// <summary>4 个工位各自的治具号（单字，值是治具台账里的序号）</summary>
        public static readonly int[] StationFixtureIndexes = { 63124, 63149, 63174, 63199 };

        /// <summary>4 个工位的贴合压力区，各 20 字（PLC_SendSN @2170 读回来存进 Global.FixtureYL1）</summary>
        public static readonly int[] StationPressureAreas = { 9100, 9120, 9140, 9160 };

        // ── 过站（焊完出机台）PLC_CheckOut1..4 ─────────────────────────────
        /// <summary>第 n 个工位的过站触发（n 从 1 起）：63020 / 63022 / 63024 / 63026</summary>
        public static int CheckOutTrigger(int station)
        {
            return 63020 + (station - 1) * 2;
        }

        /// <summary>第 n 个工位的过站结果：63021 / 63023 / 63025 / 63027</summary>
        public static int CheckOutResult(int station)
        {
            return 63021 + (station - 1) * 2;
        }

        /// <summary>MC 尺寸测量区：工位 1/2 从 15030 起、工位 3/4 从 15130 起，各 6 个浮点</summary>
        public static int McArea(int station)
        {
            return station <= 2 ? 15030 + (station - 1) * 6 : 15130 + (station - 3) * 6;
        }

        /// <summary>BOSS 柱高度测量区：15058 / 15064 / 15158 / 15164，各 6 个浮点</summary>
        public static int BossArea(int station)
        {
            return station <= 2 ? 15058 + (station - 1) * 6 : 15158 + (station - 3) * 6;
        }

        /// <summary>WD 焊接参数区：15900 / 15904 / 15908 / 15912，各 4 个浮点</summary>
        public static int WdArea(int station)
        {
            return 15900 + (station - 1) * 4;
        }

        /// <summary>本工位 CT：工位 1/2 读 MW4024，工位 3/4 读 MW4028（浮点，单位 0.5s，程序里除以 2）</summary>
        public static int CtArea(int station)
        {
            return station <= 2 ? 4024 : 4028;
        }

        // ── 参数区 PLCData_Modi ──────────────────────────────────────────
        /// <summary>参数块首地址：一次块读 2230 个字，index = (地址 - 50000) / 2</summary>
        public const int ParamBlockStart = 50000;

        public const int ParamBlockWords = 2230;

        /// <summary>PLC_ParaModfi：参数被改前/改后触发，程序读走后各自清零</summary>
        public const int ParamBeforeChangeTrigger = 32101;

        public const int ParamAfterChangeTrigger = 32102;

        // ── 抛料 PLC_ProductLog ──────────────────────────────────────────
        public const int ScrapTrigger = 62050;
        public const int ScrapTriggerWords = 21;
        public const int FixtureScrapTrigger = 62090;
        public const int FixtureScrapTriggerWords = 10;

        // ── 绑定条码 Read_Barcode ────────────────────────────────────────
        public const int BindBarcodeTrigger = 62100;
        public const int BindBarcodeTriggerWords = 4;

        // ── 运行状态 OEE ────────────────────────────────────────────────
        /// <summary>LoadOEE：机台当前状态码</summary>
        public const int OeeStatus = 62000;

        /// <summary>四路 OEE 触发寄存器：62001 / 62002 / 62003 / 62005（注意没有 62004）</summary>
        public static readonly int[] OeeTriggers = { 62001, 62002, 62003, 62005 };

        /// <summary>
        /// 状态值 → 该看哪一路触发寄存器。这是主项目 OEE_DT @1921-1936 原样抄下来的交叉关系：
        /// status==1 读 62003、status==2 读 62005、status==3 读 62001、status==4 读 62002。
        ///
        /// 别按 1→62001 去"顺手改对"：这是和 PLC 程序约定死的，界面单方面改就变成
        /// 机台报 A 报警、屏幕显示 B 报警，而且只在特定状态下出现，最难复现。
        /// 现场遇到"报警对不上"，先对着这张表核一遍。
        /// </summary>
        public static int OeeTriggerRegister(int status)
        {
            switch (status)
            {
                case 1: return 62003;
                case 2: return 62005;
                case 3: return 62001;
                case 4: return 62002;
                default: return 62001;
            }
        }

        /// <summary>十模 CT 区：ReadData 里 ReadFloatArray("MW4040", 22)</summary>
        public const int TenMoldCtArea = 4040;

        public const int TenMoldCtWords = 22;

        // ── 能耗（本机约定，不在现场地址表里）─────────────────────────────
        /// <summary>
        /// MW16000 起五个浮点：电压 V、电流 A、有功功率 kW、气流量 L/min、冷却水流量 L/min，各占两个字。
        /// 现场这块表走的是独立电表/流量计，地址要按实际仪表对；本机先用这一段把页面接通。
        /// </summary>
        public const int EnergyArea = 16000;

        public const int EnergyWords = 10;

        /// <summary>四个腔体温度的本机约定区：MW16100 起四个浮点。现场有独立温控表后换成真实地址。</summary>
        public const int TemperatureArea = 16100;

        /// <summary>
        /// 时间设定区（本机约定）：MW17100 起 20 个浮点，单位秒，对应 UI 文档 P28 的 时间设定(0)~(19)。
        /// 现场这几项在 PLC 的哪个块没对过表，接真机前换成实际地址即可，页面只认这一段。
        /// </summary>
        public const int TimeSettingArea = 17100;

        /// <summary>通讯设定区（本机约定）：MW17200 起 20 个浮点，对应 P29 的 通讯设定(0)~(19)。</summary>
        public const int CommSettingArea = 17200;

        /// <summary>设定区都是 20 个浮点 = 40 个字。</summary>
        public const int SettingWords = 40;

        // ── 设备连接状态（本机约定，不在现场地址表里）──────────────────────
        /// <summary>
        /// 主界面区域5 那四颗连接灯的字地址起点：MW62080 起四个字，1=连接OK、0=NG。
        ///
        /// 这四个字是上位机自己定的显示约定，不是电气给的对表地址——接真机前必须换成
        /// 真寄存器（或改成从上位机自己的心跳/握手结果推），否则这一栏永远是模拟值。
        /// </summary>
        public const int DeviceLinkBase = 62080;

        public static readonly string[] DeviceLinkNames = { "定位相机", "纠偏相机", "扫码枪", "机械手" };

        public static string DeviceLink(int slot)
        {
            return Mw(DeviceLinkBase + slot);
        }

        /// <summary>
        /// 转成带前缀的字符串地址。主项目里 Read(63000) 传数字、Write("MW63000", 0) 传字符串，
        /// 因为老 PlcBase 上 Read 有 int 重载、Write 只有 string 重载；这里不"顺手统一"，照原样最贴近现场。
        /// </summary>
        public static string Mw(int address)
        {
            return "MW" + address;
        }
    }
}
