using Mes.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 治具管控（《Automation UI V3.11》P8）：保养黑名单、IQC 白名单、卡控记录、治具总览。
    /// 双击小/大保养计数或时间即可登记保养，计数从 0 重算，并落 记录\治具保养.csv。
    /// </summary>
    public partial class PageFixtureLife : UserControl
    {
        private static readonly Color RowWarn = Color.FromArgb(255, 244, 214);
        private static readonly Color RowNg = Color.FromArgb(250, 216, 216);

        private readonly StationContext station;
        private string gridKey = string.Empty;

        public PageFixtureLife()
        {
            InitializeComponent();
        }

        public PageFixtureLife(StationContext station) : this()
        {
            this.station = station;
            refresh.Enabled = true;
            Fill();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            FillIfChanged();
        }

        private void FillIfChanged()
        {
            var key = station.FixtureBlocks.Count + "|";
            foreach (var fixture in station.Ledger.Fixtures)
            {
                key += fixture.FixtureCode + "|" + station.Ledger.MinorUses(fixture.FixtureCode) + "|"
                    + station.Ledger.MajorUses(fixture.FixtureCode) + "|" + fixture.MinorAt + "|"
                    + fixture.MajorAt + "|" + station.Ledger.State(fixture) + "\n";
            }
            if (key == gridKey) return;
            gridKey = key;
            Fill();
        }

        private void Fill()
        {
            FillLists();
            FillBlocks();
            FillGrid();
        }

        private void FillLists()
        {
            blackList.BeginUpdate();
            whiteList.BeginUpdate();
            blackList.Items.Clear();
            whiteList.Items.Clear();
            foreach (var fixture in station.Ledger.Fixtures)
            {
                var state = station.Ledger.State(fixture);
                if (state == "在用")
                {
                    whiteList.Items.Add(string.Format("{0}　小保养 {1}/{2}　大保养 {3}/{4}",
                        fixture.FixtureCode,
                        station.Ledger.MinorUses(fixture.FixtureCode), fixture.MinorLimit,
                        station.Ledger.MajorUses(fixture.FixtureCode), fixture.MajorLimit));
                }
                else
                {
                    var reason = station.Ledger.OverdueReason(fixture.FixtureCode);
                    blackList.Items.Add(fixture.FixtureCode + "　" + state + "　"
                        + (reason ?? "码表状态：" + fixture.Status));
                }
            }
            if (blackList.Items.Count == 0) blackList.Items.Add("没有待保养或停用的治具");
            if (whiteList.Items.Count == 0) whiteList.Items.Add("没有可上线的治具");
            blackList.EndUpdate();
            whiteList.EndUpdate();
        }

        private void FillBlocks()
        {
            var rows = station.FixtureBlocks.All();
            blockGrid.SuspendLayout();
            blockGrid.Rows.Clear();
            for (var i = rows.Count - 1; i >= 0 && blockGrid.Rows.Count < 30; i--)
            {
                var row = rows[i];
                var index = blockGrid.Rows.Add(row.Get("时间"), row.Get("治具码"), row.Get("原因"),
                    row.Get("产品码"), row.Get("结果"));
                if (row.Get("结果") == "NG") blockGrid.Rows[index].DefaultCellStyle.BackColor = RowNg;
            }
            blockGrid.ResumeLayout();
        }

        private void FillGrid()
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            for (var i = 0; i < station.Ledger.Fixtures.Count; i++)
            {
                var fixture = station.Ledger.Fixtures[i];
                var state = station.Ledger.State(fixture);
                var index = grid.Rows.Add(i + 1, fixture.FixtureCode,
                    station.Ledger.MinorUses(fixture.FixtureCode) + " / " + fixture.MinorLimit,
                    station.Ledger.MajorUses(fixture.FixtureCode) + " / " + fixture.MajorLimit,
                    fixture.MinorAt, fixture.MajorAt, state);
                grid.Rows[index].Tag = fixture;
                if (state == "待保养") grid.Rows[index].DefaultCellStyle.BackColor = RowWarn;
                else if (state == "停用") grid.Rows[index].DefaultCellStyle.BackColor = RowNg;
            }
            grid.ResumeLayout();
        }

        private void grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var fixture = grid.Rows[e.RowIndex].Tag as FixtureLifeRow;
            if (fixture == null) return;
            string kind;
            if (e.ColumnIndex == colMinor.Index || e.ColumnIndex == colMinorAt.Index) kind = "小保养";
            else if (e.ColumnIndex == colMajor.Index || e.ColumnIndex == colMajorAt.Index) kind = "大保养";
            else return;

            var answer = MessageBox.Show(fixture.FixtureCode + " 登记" + kind + "？\r\n登记后该项计数归零。",
                "保养确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (answer != DialogResult.OK) return;
            station.Ledger.Care(fixture, kind, station.User);
            station.Log.Write(station.User, kind, fixture.FixtureCode, string.Empty, kind);
            station.Say(fixture.FixtureCode + " " + kind + " 已登记");
            Fill();
        }
    }
}
