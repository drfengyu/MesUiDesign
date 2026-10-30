namespace Mes.Business
{
    /// <summary>权限矩阵的一行：某个页面要求的最低等级。</summary>
    public class AccessRule
    {
        /// <summary>页面键，取 StationPage 里的常量，不在这里现拼字符串。</summary>
        public string Page;

        public LoginLevel Minimum;
    }
}
