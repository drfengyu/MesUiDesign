using Mes.Common;
using Mes.Data;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace Mes.Business
{
    /// <summary>
    /// 两张管控台账（配件寿命、治具保养）的加载与变更。
    ///
    /// 数据\*.csv 是码表，不改；生产过程中变化的条码、寿命计数、保养时间落 记录\ 下的三张表，
    /// 启动时回放到码表上。这样换机台只替换 数据\ 里的码表，履历仍然保留。
    /// </summary>
    public class LifeLedger
    {
        public readonly List<PartLifeRow> Parts = new List<PartLifeRow>();
        public readonly List<FixtureLifeRow> Fixtures = new List<FixtureLifeRow>();

        public readonly PartStateTable PartStates;
        public readonly PartChangeTable PartChanges;
        public readonly FixtureCareTable CareRecords;

        private readonly Dictionary<string, int> minorUses = new Dictionary<string, int>(StringComparer.Ordinal);
        private readonly Dictionary<string, int> majorUses = new Dictionary<string, int>(StringComparer.Ordinal);
        private int productsSinceSave;

        public LifeLedger(string recordFolder)
        {
            PartStates = new PartStateTable(recordFolder);
            PartChanges = new PartChangeTable(recordFolder);
            CareRecords = new FixtureCareTable(recordFolder);
        }

        public static LifeLedger Load(string folder, string recordFolder)
        {
            var ledger = new LifeLedger(recordFolder);
            ledger.LoadParts(Path.Combine(folder, "配件管控.csv"));
            ledger.LoadFixtures(Path.Combine(folder, "治具管控.csv"));
            ledger.ApplyPartStates();
            ledger.ApplyCareRecords();
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

        private void ApplyPartStates()
        {
            foreach (var state in PartStates.All())
            {
                var part = Part(state.Get("品名"));
                if (part == null) continue;
                part.Barcode = state.Get("条码");
                part.ReplacedAt = state.Get("更换时间");
                part.CurrentLife = Int(state.Get("当前寿命"));
            }
        }

        private void ApplyCareRecords()
        {
            foreach (var row in CareRecords.All())
            {
                var fixture = Fixture(row.Get("治具码"));
                if (fixture == null) continue;
                if (row.Get("类型") == "小保养") fixture.MinorAt = row.Get("时间");
                else fixture.MajorAt = row.Get("时间");
            }
        }

        /// <summary>按追溯表把已经用掉的次数接上，重启后计数不会从 0 再来。</summary>
        public void LoadUsage(ProductLogTable log)
        {
            log.Scan(row =>
            {
                var code = row.Get("治具号");
                if (code.Length == 0) return;
                var fixture = Fixture(code);
                if (fixture == null) return;
                DateTime at;
                if (!DateTime.TryParse(row.Get("焊接开始时间"), out at)) return;
                DateTime since;
                if (DateTime.TryParse(fixture.MinorAt, out since) && at > since) Add(minorUses, code, 1);
                if (DateTime.TryParse(fixture.MajorAt, out since) && at > since) Add(majorUses, code, 1);
            });
        }

        public PartLifeRow Part(string name)
        {
            foreach (var part in Parts)
            {
                if (part.ProductName == name) return part;
            }
            return null;
        }

        public FixtureLifeRow Fixture(string code)
        {
            foreach (var fixture in Fixtures)
            {
                if (fixture.FixtureCode == code) return fixture;
            }
            return null;
        }

        public int MinorUses(string code)
        {
            int value;
            return minorUses.TryGetValue(code, out value) ? value : 0;
        }

        public int MajorUses(string code)
        {
            int value;
            return majorUses.TryGetValue(code, out value) ? value : 0;
        }

        /// <summary>停用/待保养按码表；超限按当前计数；其余在用。</summary>
        public string State(FixtureLifeRow fixture)
        {
            if (fixture.Status == "停用") return "停用";
            if (fixture.Status == "待保养") return "待保养";
            if (MinorUses(fixture.FixtureCode) >= fixture.MinorLimit
                || MajorUses(fixture.FixtureCode) >= fixture.MajorLimit) return "待保养";
            return "在用";
        }

        /// <summary>保养超期的原因；没超返回 null。过站判定拿它决定卡不卡。</summary>
        public string OverdueReason(string code)
        {
            var fixture = Fixture(code);
            if (fixture == null) return null;
            if (minorUses.TryGetValue(code, out var minor) && minor >= fixture.MinorLimit)
                return "小保养超期 " + minor + "/" + fixture.MinorLimit;
            if (majorUses.TryGetValue(code, out var major) && major >= fixture.MajorLimit)
                return "大保养超期 " + major + "/" + fixture.MajorLimit;
            return null;
        }

        public void OnFixtureUsed(string code)
        {
            if (Fixture(code) == null) return;
            Add(minorUses, code, 1);
            Add(majorUses, code, 1);
        }

        /// <summary>每片焊完累加所有配件。本机没有各配件的动作信号，按"每片一次"先接通。</summary>
        public void OnProductCompleted()
        {
            foreach (var part in Parts) part.CurrentLife++;
            productsSinceSave++;
            if (productsSinceSave < 10) return;
            productsSinceSave = 0;
            SavePartStates();
        }

        public void ReplacePart(PartLifeRow part, string newBarcode, string reason, string user)
        {
            if (part == null) return;
            var oldBarcode = part.Barcode;
            var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            part.Barcode = string.IsNullOrWhiteSpace(newBarcode) ? part.Barcode : newBarcode.Trim();
            part.ReplacedAt = now;
            part.CurrentLife = 0;
            PartStates.Save(part.ProductName, part.Barcode, part.ReplacedAt, part.CurrentLife);
            PartChanges.Append(now, part.ProductName, oldBarcode, part.Barcode, reason, user);
        }

        /// <summary>小保养/大保养：把对应计时归零，当前时间落到台账。</summary>
        public void Care(FixtureLifeRow fixture, string kind, string user)
        {
            if (fixture == null) return;
            var now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            if (kind == "小保养")
            {
                fixture.MinorAt = now;
                minorUses.Remove(fixture.FixtureCode);
            }
            else
            {
                fixture.MajorAt = now;
                majorUses.Remove(fixture.FixtureCode);
            }
            CareRecords.Append(now, fixture.FixtureCode, kind, user);
        }

        public void SavePartStates()
        {
            foreach (var part in Parts)
            {
                PartStates.Save(part.ProductName, part.Barcode, part.ReplacedAt, part.CurrentLife);
            }
        }

        private static void Add(Dictionary<string, int> map, string key, int delta)
        {
            int value;
            map.TryGetValue(key, out value);
            map[key] = value + delta;
        }

        private static int Int(string text)
        {
            int value;
            return int.TryParse(text, out value) ? value : 0;
        }
    }
}
