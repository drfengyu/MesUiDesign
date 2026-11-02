using Mes.Common;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Mes.Business
{
    /// <summary>整机视图上的一个部位：报警目录的模组代码 + 摆在哪（百分比坐标）。</summary>
    public class MachineZone
    {
        public string Module;
        public string Name;
        public double X;
        public double Y;
    }

    /// <summary>
    /// 整机视图部位表（数据\机台区域.csv）。当前报警（P31）和异常分析（P34）右边那张
    /// "整机示意图"就是按这张表把报警点亮到部位上的。
    ///
    /// 为什么不画设备照片：文档里那张是机构 CAD 截图，仓库里没有原图，
    /// 拿别的图凑就是假图。这里只做分区标注，坐标写在表里，现场照设备改表即可。
    /// </summary>
    public class ZoneCatalog
    {
        public readonly List<MachineZone> Items = new List<MachineZone>();

        public void Load(string file, Encoding encoding = null)
        {
            Items.Clear();
            foreach (var line in TextFile.ReadAllLines(file, encoding ?? CodePages.Utf8WithBom()))
            {
                var cols = line.Split(',');
                if (cols.Length < 4) continue;
                var module = cols[0].Trim();
                if (module.Length == 0 || module == "模组代码") continue;
                double x, y;
                if (!double.TryParse(cols[2], NumberStyles.Float, CultureInfo.InvariantCulture, out x)) continue;
                if (!double.TryParse(cols[3], NumberStyles.Float, CultureInfo.InvariantCulture, out y)) continue;
                Items.Add(new MachineZone { Module = module, Name = cols[1].Trim(), X = x, Y = y });
            }
        }

        public MachineZone Find(string module)
        {
            if (string.IsNullOrEmpty(module)) return null;
            foreach (var zone in Items)
            {
                if (zone.Module == module) return zone;
            }
            return null;
        }
    }
}
