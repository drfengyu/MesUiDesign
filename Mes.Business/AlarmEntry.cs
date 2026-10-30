using System;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>一条报警流水（区域8 那一行）。</summary>
    public class AlarmEntry
    {
        public DateTime At;
        public string Code;
        public string Text;

        /// <summary>照 RFP 主界面那张图的写法：[13:53:35]6009001,点胶X轴正极限异常</summary>
        public override string ToString()
        {
            return "[" + At.ToString("HH:mm:ss") + "]" + Code + "," + Text;
        }
    }
}
