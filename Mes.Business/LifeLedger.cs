using Mes.Common;
using Mes.Data;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mes.Business
{
    /// <summary>
    /// 两张管控台账（配件寿命、治具保养）的加载。它们都是"机台自己维护的台账"，
    /// 真项目里落在 SQL，这里落 csv。
    /// 本机只用它们两件事：设备信息页报个条数、过站时拿治具序号反查治具码
    /// （过站传的是序号，见 PlcAddresses.StationFixtureIndexes）。
    ///
    /// 编码不统一是个真实的坑：配件管控.csv 是 UTF-8 带 BOM，治具管控.csv 是 GBK，
    /// 所以每张表都要显式传编码，不能一把梭用 Encoding.Default。
    /// "按动作次数算寿命、到限锁机"是后续功能，这里不预先摆样子。
    /// </summary>
    public class LifeLedger
    {
        public readonly List<PartLifeRow> Parts = new List<PartLifeRow>();
        public readonly List<FixtureLifeRow> Fixtures = new List<FixtureLifeRow>();

        public static LifeLedger Load(string folder)
        {
            var ledger = new LifeLedger();
            ledger.LoadParts(Path.Combine(folder, "配件管控.csv"));
            ledger.LoadFixtures(Path.Combine(folder, "治具管控.csv"));
            return ledger;
        }

        private void LoadParts(string file)
        {
            var lines = TextFile.ReadAllLines(file, CodePages.Utf8WithBom());
            for (var i = 1; i < lines.Length; i++)
            {
                var cols = Csv.Split(lines[i]);
                if (cols.Length < 6) continue;
                Parts.Add(new PartLifeRow
                {
                    ProductName = cols[0],
                    Model = cols[1],
                    RatedLife = Int(cols[2]),
                    Barcode = cols[3],
                    ReplacedAt = cols[4],
                    CurrentLife = Int(cols[5]),
                });
            }
        }

        private void LoadFixtures(string file)
        {
            var lines = TextFile.ReadAllLines(file, CodePages.Gbk());
            for (var i = 1; i < lines.Length; i++)
            {
                var cols = Csv.Split(lines[i]);
                if (cols.Length < 6) continue;
                Fixtures.Add(new FixtureLifeRow
                {
                    FixtureCode = cols[0],
                    MinorLimit = Int(cols[1]),
                    MajorLimit = Int(cols[2]),
                    MinorAt = cols[3],
                    MajorAt = cols[4],
                    Status = cols[5],
                });
            }
        }

        private static int Int(string text)
        {
            int value;
            return int.TryParse(text, out value) ? value : 0;
        }
    }
}
