namespace Mes.Business
{
    /// <summary>
    /// 登录等级，下标即等级数值，与主项目 Global.LoginLevel 同序。
    /// 界面上显示的是中文（"操作员/技术员/…"），那份文案在 AccessPolicy.LevelTitles 里，
    /// 代码里判断等级一律用这里的英文名，不拿中文字符串比。
    /// </summary>
    public enum LoginLevel
    {
        Operator = 0,
        Technician = 1,
        Engineer = 2,
        Administrator = 3,
        SuperAdministrator = 4,
    }
}
