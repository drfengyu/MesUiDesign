using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>
    /// 权限矩阵：所有"谁能进哪页"的判定集中在这一个类里，页面和入口都来问它，
    /// 不在各自的 Click 事件里写 if (level >= 2)。
    ///
    /// 为什么集中：真项目早期权限判断散在每个按钮里，加一级"超级管理员"时改了 30 多处，
    /// 漏掉的那几处就是审核时的不符合项。
    /// </summary>
    public static class AccessPolicy
    {
        /// <summary>
        /// 等级在界面上的显示文案，下标就是 LoginLevel 的数值。
        /// 这也是现场对表的顺序（操作员 &lt; 技术员 &lt; 工程师 &lt; 管理员 &lt; 超级管理员）。
        /// </summary>
        public static readonly string[] LevelTitles =
        {
            "操作员", "技术员", "工程师", "管理员", "超级管理员",
        };

        /// <summary>
        /// 用 List 而不是 Dictionary：字典不保证枚举顺序，而权限说明页要"按登记的顺序
        /// 一行一行显示"，同一份表在界面上每次排法可能不一样。换成 List、查找一条一条比：
        /// 一共三十来条，线性扫慢不出感觉，却少了一个"顺序从哪来"的坑。
        /// 有些页还没实现（后面的功能块），列在这儿是为了说明这件事集中在一个地方管。
        /// </summary>
        public static readonly List<AccessRule> Rules = new List<AccessRule>
        {
            new AccessRule { Page = StationPage.Home, Minimum = LoginLevel.Operator },
            // 顺序照 RFP P4 主界面那一列：Uptime记录 → 参数图表 → 配件管控 → 治具管控 → 参数管控 → 时间明细 → 能耗监控。
            new AccessRule { Page = StationPage.UptimeLog, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.ParamChart, Minimum = LoginLevel.Technician },
            new AccessRule { Page = StationPage.PartLife, Minimum = LoginLevel.Technician },
            new AccessRule { Page = StationPage.FixtureLife, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.ParamControl, Minimum = LoginLevel.Engineer },
            new AccessRule { Page = StationPage.TimeDetail, Minimum = LoginLevel.Technician },
            new AccessRule { Page = StationPage.EnergyMonitor, Minimum = LoginLevel.Operator },

            new AccessRule { Page = StationPage.Throughput, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.ScrapStatistics, Minimum = LoginLevel.Technician },
            new AccessRule { Page = StationPage.TimeStatistics, Minimum = LoginLevel.Technician },
            new AccessRule { Page = StationPage.Performance, Minimum = LoginLevel.Operator },

            new AccessRule { Page = StationPage.IoInput, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.IoOutput, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.ManualSpec, Minimum = LoginLevel.Engineer },
            new AccessRule { Page = StationPage.ManualOperation, Minimum = LoginLevel.Engineer },

            new AccessRule { Page = StationPage.PositionSpeed, Minimum = LoginLevel.Engineer },
            new AccessRule { Page = StationPage.TimeSetting, Minimum = LoginLevel.Engineer },
            new AccessRule { Page = StationPage.CommunicationSetting, Minimum = LoginLevel.Administrator },
            new AccessRule { Page = StationPage.UploadSetting, Minimum = LoginLevel.Administrator },

            new AccessRule { Page = StationPage.ActiveAlarm, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.AlarmHistory, Minimum = LoginLevel.Technician },
            new AccessRule { Page = StationPage.AlarmTop5, Minimum = LoginLevel.Technician },
            new AccessRule { Page = StationPage.FaultAnalysis, Minimum = LoginLevel.Engineer },
            new AccessRule { Page = StationPage.OperationLogPage, Minimum = LoginLevel.Engineer },

            new AccessRule { Page = StationPage.Login, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.UserPermission, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.Troubleshooting, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.Maintenance, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.MachineInfo, Minimum = LoginLevel.Operator },
            new AccessRule { Page = StationPage.SimulatedMachine, Minimum = LoginLevel.Engineer },
        };

        /// <summary>这一页要求的最低等级；null 表示还没登记（界面上不显示）。</summary>
        public static LoginLevel? MinimumFor(string page)
        {
            foreach (var rule in Rules)
            {
                if (rule.Page == page) return rule.Minimum;
            }
            return null;
        }

        /// <summary>
        /// 页面注册时直接来要等级，别在每个页面里写死一个数字。
        /// 没登记的页面按"操作员可见"兜底——宁可先让人看见，也不要出现
        /// "页面注册了但因为漏登记谁都进不去"这种查半天的事。
        /// </summary>
        public static int MinimumValue(string page)
        {
            var minimum = MinimumFor(page);
            return (int)(minimum.HasValue ? minimum.Value : LoginLevel.Operator);
        }

        /// <summary>等级显示文案。</summary>
        public static string Title(LoginLevel level)
        {
            return LevelTitles[(int)level];
        }

        /// <summary>当前等级能不能进这一页。</summary>
        public static bool Allowed(LoginLevel current, string page)
        {
            return (int)current >= MinimumValue(page);
        }
    }
}
