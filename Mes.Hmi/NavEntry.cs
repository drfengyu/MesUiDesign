using System.Collections.Generic;

namespace Mes.Hmi
{
    /// <summary>
    /// 顶部图标按钮代表的一级入口，顺序与《Automation UI V3.11》P4 那张标准图一致：
    /// 主界面、数据统计、IO监视、手动操作、参数设置、异常报警、用户登陆、帮助信息。
    /// 图标取自现场在用的 VC 数据追溯系统，操作员换程序不用重新认图标。
    /// </summary>
    public class NavEntry
    {
        public NavEntry(string title, string prefix, string iconKey)
        {
            Title = title;
            Prefix = prefix;
            IconKey = iconKey;
        }

        /// <summary>按钮提示与页签标题用的中文名。</summary>
        public string Title { get; private set; }

        /// <summary>StationPage 里这一入口的页面前缀，如"主界面/"。</summary>
        public string Prefix { get; private set; }

        /// <summary>ShellForm.resx 里的图标键前缀：{iconKey}.Image 是常态，{iconKey}On.Image 是按下态。</summary>
        public string IconKey { get; private set; }

        public static readonly IList<NavEntry> Entries = new List<NavEntry>
        {
            new NavEntry("主界面", "主界面/", "home"),
            new NavEntry("数据统计", "数据统计/", "statistics"),
            new NavEntry("IO监视", "IO监视/", "io"),
            new NavEntry("手动操作", "手动操作/", "manual"),
            new NavEntry("参数设置", "参数设置/", "setting"),
            new NavEntry("异常报警", "报警/", "alarm"),
            new NavEntry("用户登陆", "用户登录/", "user"),
            new NavEntry("帮助信息", "帮助/", "help"),
        };
    }
}
