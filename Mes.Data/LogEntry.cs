using System;
using System.Collections.Generic;

namespace Mes.Data
{
    /// <summary>操作日志的一行（时刻、操作人、动作、对象、原值、新值）。</summary>
    public class LogEntry
    {
        public DateTime At;
        public string Who;
        public string Action;
        public string Target;
        public string Before;
        public string After;
    }
}
