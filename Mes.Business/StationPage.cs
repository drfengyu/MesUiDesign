namespace Mes.Business
{
    /// <summary>
    /// 功能页的编号键，值就是触摸屏上"入口/页名"那行中文。
    ///
    /// 为什么收成常量：页面和权限矩阵两边各手打一遍同一个中文串，改一个字不会编译报错，
    /// 只会变成"这一页谁都进不去"或者"这一页不受控"，查起来最费时间。
    /// 引用同一个符号之后，改一处两边一起变。
    /// </summary>
    public static class StationPage
    {
        // 主界面
        public const string Home = "主界面/主界面";
        public const string UptimeLog = "主界面/Uptime记录";
        public const string ParamChart = "主界面/参数图表";
        public const string PartLife = "主界面/配件管控";
        public const string FixtureLife = "主界面/治具管控";
        public const string ParamControl = "主界面/参数管控";
        public const string TimeDetail = "主界面/时间明细";
        public const string EnergyMonitor = "主界面/能耗监控";

        // 数据统计（顺序照 UI 文档 P12~P22 的页签）
        public const string Throughput = "数据统计/产能统计";
        public const string ScrapStatistics = "数据统计/抛料统计";
        public const string TimeStatistics = "数据统计/时间统计";
        public const string Performance = "数据统计/性能仪表";
        public const string FixtureStatistics = "数据统计/治具统计";
        public const string CylinderStatistics = "数据统计/气缸统计";
        public const string Cpk = "数据统计/CPK";

        // 监视与手动
        public const string IoInput = "IO监视/输入监控";
        public const string IoOutput = "IO监视/输出监控";
        public const string ManualSpec = "手动操作/模组规格";
        public const string ManualOperation = "手动操作/模组操作";

        // 参数设置
        public const string PositionSpeed = "参数设置/位置速度";
        public const string TimeSetting = "参数设置/时间设置";
        public const string CommunicationSetting = "参数设置/通讯设置";
        public const string UploadSetting = "参数设置/上传设置";

        // 报警
        public const string AlarmPrefix = "报警/";
        public const string ActiveAlarm = AlarmPrefix + "当前报警";
        public const string AlarmHistory = AlarmPrefix + "报警历史";
        public const string AlarmTop5 = AlarmPrefix + "报警TOP5";
        public const string FaultAnalysis = AlarmPrefix + "异常分析";
        public const string OperationLogPage = AlarmPrefix + "操作日志";

        // 用户与帮助
        public const string UserPrefix = "用户登录/";
        public const string Login = UserPrefix + "密码登录";
        public const string CardLogin = UserPrefix + "刷卡登录";
        public const string UserPermission = UserPrefix + "权限说明";
        public const string Troubleshooting = "帮助/故障处理";
        public const string Maintenance = "帮助/维护保养";
        public const string MachineInfo = "帮助/设备信息";

        /// <summary>模拟机台面板：本机自测用，只给维护人员看。</summary>
        public const string SimulatedMachine = "帮助/模拟机台";
    }
}
