using System;

namespace Mes.Business
{
    /// <summary>一个 IO 点位。</summary>
    public class IoPoint
    {
        /// <summary>图纸写法，形如 "I 1000.0"</summary>
        public string Address;

        public string Name;

        /// <summary>I=输入 Q=输出</summary>
        public char Kind;

        public bool On;

        public DateTime? ChangedAt;
    }
}
