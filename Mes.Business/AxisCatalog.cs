using Mes.Common;
using System.Collections.Generic;
using System.Text;

namespace Mes.Business
{
    /// <summary>一根轴：位置、状态、速度三个 MW 字区，加正/负两个点动脉冲位。</summary>
    public class AxisDefinition
    {
        public string Group;
        public string Name;
        public int PositionAddress;
        public int StatusAddress;
        public int SpeedAddress;
        public string JogForwardBit;
        public string JogBackwardBit;
    }

    /// <summary>
    /// 轴卡表（数据\轴卡分组.csv），位置速度页（UI 文档 P27）那一排轴的来源。
    ///
    /// 为什么放表里：现场换一块轴卡就是换一份轴序，改表不重编译，和其他码表一致。
    /// 但要记住 MW17000 起这一段是本机和仿真机台之间的约定，不在现场对表里——
    /// 现场的主项目点位表只有气缸和 IO，一个轴都没有，接真机前这一段必须换成轴卡
    /// 驱动实际给的寄存器，页面和仿真代码都不用动。
    /// </summary>
    public class AxisCatalog
    {
        /// <summary>状态字里六颗灯的名字，顺序和 UI 文档 P27 那六列一致，也是 bit0~bit5。</summary>
        public static readonly string[] StatusNames = { "异常", "正限", "负限", "原点", "激磁", "回原" };

        public readonly List<AxisDefinition> Items = new List<AxisDefinition>();
        private readonly List<string> groups = new List<string>();

        public IReadOnlyList<string> Groups { get { return groups; } }

        public void Load(string file, Encoding encoding = null)
        {
            Items.Clear();
            groups.Clear();
            foreach (var line in TextFile.ReadAllLines(file, encoding ?? CodePages.Utf8WithBom()))
            {
                var cols = line.Split(',');
                if (cols.Length < 7) continue;
                var name = cols[1].Trim();
                if (name.Length == 0 || name == "轴名称") continue;
                var group = cols[0].Trim();
                var axis = new AxisDefinition
                {
                    Group = group,
                    Name = name,
                    PositionAddress = Word(cols[2]),
                    StatusAddress = Word(cols[3]),
                    SpeedAddress = Word(cols[4]),
                    JogForwardBit = cols[5].Trim(),
                    JogBackwardBit = cols[6].Trim(),
                };
                if (axis.PositionAddress < 0 || axis.SpeedAddress < 0) continue;
                Items.Add(axis);
                if (!groups.Contains(group)) groups.Add(group);
            }
        }

        public List<AxisDefinition> OfGroup(string group)
        {
            var rows = new List<AxisDefinition>();
            foreach (var axis in Items)
            {
                if (axis.Group == group) rows.Add(axis);
            }
            return rows;
        }

        private static int Word(string text)
        {
            int value;
            return int.TryParse(text.Trim().Replace("MW", string.Empty), out value) ? value : -1;
        }
    }
}
