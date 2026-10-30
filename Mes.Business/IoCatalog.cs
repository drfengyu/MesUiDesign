using Mes.Common;
using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>
    /// IO 表：真文件 369 行，三列 IO地址,IO信号名称,类型。
    /// 注意地址是 "I 1000.0" 这种带空格、带字节.位的写法，和 PLC 的 MW 号不是一套体系：
    /// MW 是字寄存器，IO 是位地址，触摸屏上只是显示，不参与浮点换算。
    /// </summary>
    public class IoCatalog
    {
        public readonly List<IoPoint> Inputs = new List<IoPoint>();
        public readonly List<IoPoint> Outputs = new List<IoPoint>();
        private readonly Dictionary<string, IoPoint> byAddress = new Dictionary<string, IoPoint>();

        public static IoCatalog Load(string file)
        {
            var catalog = new IoCatalog();
            var lines = TextFile.ReadAllLines(file, CodePages.Gbk());
            for (var i = 1; i < lines.Length; i++)
            {
                var cols = lines[i].Split(',');
                if (cols.Length < 3) continue;
                var kind = cols[2].Trim();
                var point = new IoPoint
                {
                    Address = cols[0].Trim(),
                    Name = cols[1].Trim(),
                    Kind = kind.Length > 0 ? kind[0] : 'I',
                };
                if (point.Kind == 'Q') catalog.Outputs.Add(point);
                else catalog.Inputs.Add(point);
                catalog.byAddress[point.Address] = point;
            }
            return catalog;
        }

        /// <summary>
        /// 按表里的写法查一个点（"Q 1004.0"）。手动操作页那一列名字就是从这儿取的：
        /// 界面上不另抄一遍信号名，抄了就有两份、迟早对不上；查不到就当场显示"表里没有这个地址"。
        /// </summary>
        public IoPoint Find(string address)
        {
            IoPoint point;
            return byAddress.TryGetValue((address ?? string.Empty).Trim(), out point) ? point : null;
        }

        /// <summary>
        /// 按信号名查点（主界面那几个功能按钮用这个：按钮对应哪个 IO 由表说了算）。
        /// 表里一共四十来行，线性扫不用建第二本字典；查不到就返回 null，
        /// 让界面把那颗按钮置灰而不是硬编一个本机没有的地址。
        /// </summary>
        public IoPoint ByName(string nameContains)
        {
            foreach (var point in Outputs)
            {
                if (point.Name.Contains(nameContains)) return point;
            }
            foreach (var point in Inputs)
            {
                if (point.Name.Contains(nameContains)) return point;
            }
            return null;
        }
    }
}
