using Mes.Data;
using Mes.Devices;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mes.Business
{
    /// <summary>
    /// 一台"过站机"的全部家当：PLC（真驱动或模拟）、机台模型、几张真码表、追溯表、操作日志、当前登录人。
    /// 页面构造函数收一个 StationContext，依赖关系就写在签名上。
    ///
    /// 为什么做成一个上下文对象而不是散落的全局静态：主项目用的是 Global 静态类
    /// （Global.plc1 / Global.ed / Global.Name …），单看一行代码不知道它依赖什么，
    /// 也没法同时开两台机器做对比。所有依赖收进一个实例之后，接第二台机台就是再 Create 一个。
    /// </summary>
    public class StationContext
    {
        /// <summary>
        /// 机台名称：状态条上那行绿底字、操作日志（P35）的机台筛选都用这一个值。
        /// 一处定义，避免标题写一个、筛选条件写另一个，查日志时"机台名称"永远对不上。
        /// </summary>
        public const string MachineName = "MES 数据上传追溯";

        public SimulatedPlc Plc { get; private set; }
        public MachineSimulator Machine { get; private set; }
        public AlarmCatalog Alarms { get; private set; }
        public IoCatalog Io { get; private set; }
        public LifeLedger Ledger { get; private set; }
        public ParamCatalog Params { get; private set; }
        public QualityCatalog Limits { get; private set; }
        public PasswordStore Passwords { get; private set; }

        /// <summary>轴卡表（位置速度页 P27 那一排轴）</summary>
        public AxisCatalog Axes { get; private set; }

        /// <summary>上传设置（P30 的 Trace/PDCA/OEE 键值），改完写回 数据\上传设置.csv</summary>
        public UploadSettings Upload { get; private set; }
        public AlarmBoard ActiveAlarms { get; private set; }
        public BatchSummary Batch { get; private set; }

        /// <summary>Uptime / DT 计时，计划停机、首件、切线、故障都落 记录\Uptime.csv</summary>
        public UptimeTracker Uptime { get; private set; }

        /// <summary>时间明细采样，过站线程往里写，页面只读</summary>
        public TimingBoard Timing { get; private set; }

        /// <summary>能耗采样线程与今日累计</summary>
        public EnergyMeter Energy { get; private set; }

        /// <summary>能耗日统计（能耗页的"历史数据"读这张表）</summary>
        public EnergyDailyTable EnergyDaily { get; private set; }

        /// <summary>产能目标（目标 UPH 等，数据\产能目标.csv）</summary>
        public ProductionTargets Targets { get; private set; }

        /// <summary>气缸动作/故障次数，机台线程按阀位计数</summary>
        public CylinderCounter Cylinders { get; private set; }

        /// <summary>治具保养超期仍上机时的卡控记录</summary>
        public FixtureBlockTable FixtureBlocks { get; private set; }

        /// <summary>整机视图的部位表（当前报警 P31 / 异常分析 P34 右边那张图）</summary>
        public ZoneCatalog Zones { get; private set; }

        /// <summary>过站链路（报站/送码/判定）的轮询线程，界面只读它的结果。</summary>
        public StationFlow Flow { get; private set; }

        public ProductLogTable ProductLog { get; private set; }
        public OperationLog Log { get; private set; }

        /// <summary>
        /// MW62071 的最近读数：0 = MES 已启用、1 = 未启用（反逻辑，见 PlcAddresses）。
        /// 由过站线程定期刷新，状态条读这个缓存——界面线程上一次 PLC 往返都没有。
        /// </summary>
        public volatile int MesDisabled = 1;

        /// <summary>当前登录人；未登录时是 NULL，和主项目 Global.Name 的初值一致</summary>
        public string User = "NULL";

        public LoginLevel Level = LoginLevel.Operator;

        /// <summary>码表目录（报警目录/参数名称/IO 表…，从 数据\ 拷到输出目录）</summary>
        public string DataFolder { get; private set; }

        /// <summary>记录落盘目录（ProductLog 一张 csv + 操作日志按天一个文件）</summary>
        public string RecordFolder { get; private set; }

        /// <summary>一条活动流水，"模拟机台"面板和状态条都订阅它</summary>
        public event Action<string> Activity;

        /// <summary>
        /// 建一台机器。roundTripMs 是模拟的单次 PLC 往返耗时：
        /// 现场用实测台量过是 2~10ms，这里默认 4ms；调到 40ms 就能当场看到轮询变慢、界面发顿。
        /// 接真机时把这里的 SimulatedPlc 换成 InovanceAmTcpPlc(ip, port)，其余不动。
        /// </summary>
        public static StationContext Create(int roundTripMs = 4)
        {
            var baseDir = AppDomain.CurrentDomain.BaseDirectory;
            var context = new StationContext
            {
                DataFolder = Path.Combine(baseDir, "数据"),
                RecordFolder = Path.Combine(baseDir, "记录"),
            };

            context.Plc = new SimulatedPlc { RoundTripMs = roundTripMs };
            context.Plc.ConnectPlc();
            context.Alarms = AlarmCatalog.Load(Path.Combine(context.DataFolder, "报警目录.csv"));
            context.Io = IoCatalog.Load(Path.Combine(context.DataFolder, "IO输入输出表.csv"));
            context.Ledger = LifeLedger.Load(context.DataFolder, context.RecordFolder);
            context.Params = new ParamCatalog();
            context.Params.Load(Path.Combine(context.DataFolder, "参数名称.csv"));
            context.Limits = new QualityCatalog();
            context.Limits.Load(Path.Combine(context.DataFolder, "判定上下限.csv"));
            context.Axes = new AxisCatalog();
            context.Axes.Load(Path.Combine(context.DataFolder, "轴卡分组.csv"));
            context.Upload = new UploadSettings();
            context.Upload.Load(Path.Combine(context.DataFolder, "上传设置.csv"));
            context.Zones = new ZoneCatalog();
            context.Zones.Load(Path.Combine(context.DataFolder, "机台区域.csv"));
            context.ActiveAlarms = new AlarmBoard();
            // 登录要用的密码表。现场这五个值在 setting.ini 的 [PassWord] 段（主项目 MainFrm.cs:386
            // 开机读进 Global），那是现场配置不外拷，本机另存一张 csv。
            context.Passwords = new PasswordStore();
            context.Passwords.Load(Path.Combine(context.DataFolder, "权限密码.csv"));

            context.ProductLog = new ProductLogTable(context.RecordFolder);
            context.Log = new OperationLog(context.RecordFolder);
            context.Targets = ProductionTargets.Load(Path.Combine(context.DataFolder, "产能目标.csv"));
            context.FixtureBlocks = new FixtureBlockTable(context.RecordFolder);
            context.Cylinders = new CylinderCounter(
                new CylinderCountTable(context.RecordFolder), context.Plc, context.Io);
            context.Uptime = new UptimeTracker(new UptimeTable(context.RecordFolder), context.Alarms);
            context.Timing = new TimingBoard(context.DataFolder);
            context.EnergyDaily = new EnergyDailyTable(context.RecordFolder);
            context.Energy = new EnergyMeter(context.Plc, context.EnergyDaily);
            context.Ledger.LoadUsage(context.ProductLog);

            context.Machine = new MachineSimulator(context.Plc, context.Alarms, context.Cylinders, context.Axes);
            // 模拟机按当天 0001 起的流水排产品码，ProductLog 却是跨进程留着的：
            // 同一天重启一次，新一轮的码全撞"同码重复投产"被拦在报站，界面上像整条线都 NG 了。
            // 把当天已用掉的最大流水接给机台，重启后接着排——真机是 PLC 里的计数器掉电保持，效果一样。
            var stamp = "MPG" + DateTime.Now.ToString("yyMMdd");
            var usedSerial = 0;
            context.ProductLog.Scan(row =>
            {
                var code = row.Get("产品码");
                if (code.Length != stamp.Length + 4 || !code.StartsWith(stamp, StringComparison.Ordinal)) return;
                int serial;
                if (int.TryParse(code.Substring(stamp.Length), out serial) && serial > usedSerial) usedSerial = serial;
            });
            context.Machine.SerialBase = usedSerial;
            var codes = new List<string>();
            foreach (var fixture in context.Ledger.Fixtures)
            {
                codes.Add(fixture.FixtureCode);
            }
            context.Machine.SetFixtures(codes);
            context.Machine.OnEvent += context.Say;
            context.Batch = new BatchSummary(context.ProductLog);
            context.Flow = new StationFlow(context);
            context.Flow.Start();
            context.Energy.Start();
            return context;
        }

        public void Say(string text)
        {
            var handler = Activity;
            if (handler != null) handler(text);
        }

        /// <summary>登录/登出后统一走这里：状态条、权限、页签都要跟着变。</summary>
        public void Login(string user, LoginLevel level)
        {
            User = user;
            Level = level;
            Log.Write(user, "登录", AccessPolicy.Title(level), string.Empty, string.Empty);
            Say(user + " 以 " + AccessPolicy.Title(level) + " 登录");
        }

        public void Logout()
        {
            Log.Write(User, "登出", AccessPolicy.Title(Level), string.Empty, string.Empty);
            Say(User + " 登出");
            User = "NULL";
            Level = LoginLevel.Operator;
        }

        /// <summary>
        /// 主项目 ImportCsv 读不到表就直接 Environment.Exit(1)：码表缺失时程序不能"猜"着跑。
        /// 这里同样只给结论，退不退由界面决定（触摸屏上至少要把"缺哪张表"显示出来）。
        /// </summary>
        public bool CatalogsReady
        {
            get
            {
                return Alarms != null && Alarms.Count > 0
                    && Params != null && Params.Items.Count > 0
                    && Limits != null && Limits.Count > 0;
            }
        }
    }
}
