using Mes.Business;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 气缸次数统计（《Automation UI V3.11》P21）：白班/晚班各一张表，
    /// 动作次数与故障次数来自机台线程的阀位计数；换缸后用行尾"清零"按钮清掉该气缸的计数。
    /// 两个班次共用一个页码，按手动操作页的气缸顺序翻页。
    /// </summary>
    public partial class PageCylinderStatistics : UserControl
    {
        private const int PageSize = 10;

        private readonly StationContext station;
        private List<CylinderCount> day;
        private List<CylinderCount> night;
        private int pageIndex;
        private string viewKey = string.Empty;

        public PageCylinderStatistics()
        {
            InitializeComponent();
        }

        public PageCylinderStatistics(StationContext station) : this()
        {
            this.station = station;
            refresh.Enabled = true;
            Query();
            gridDay.Resize += (s, e) => Fill();
            gridNight.Resize += (s, e) => Fill();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            if (station == null) return;
            Query();
        }

        private void Query()
        {
            if (station == null) return;
            day = station.Cylinders.Snapshot(CylinderCounter.Day);
            night = station.Cylinders.Snapshot(CylinderCounter.Night);
            var key = ViewKey();
            if (key == viewKey) return;
            viewKey = key;
            FitPage();
            Fill();
        }

        private string ViewKey()
        {
            if (day == null || night == null) return string.Empty;
            var sb = new StringBuilder();
            Append(sb, day);
            Append(sb, night);
            return sb.ToString();
        }

        private static void Append(StringBuilder sb, List<CylinderCount> rows)
        {
            foreach (var row in rows)
            {
                sb.Append(row.Name).Append(',').Append(row.Actions).Append(',').Append(row.Faults).Append('|');
            }
        }

        private void FitPage()
        {
            var count = Math.Max(day == null ? 0 : day.Count, night == null ? 0 : night.Count);
            var pages = Math.Max(1, (count + PageSize - 1) / PageSize);
            if (pageIndex >= pages) pageIndex = pages - 1;
            if (pageIndex < 0) pageIndex = 0;
            btnPrev.Enabled = pageIndex > 0;
            btnNext.Enabled = pageIndex < pages - 1;
        }

        private void Fill()
        {
            FillGrid(gridDay, day);
            FillGrid(gridNight, night);
        }

        private void FillGrid(DataGridView grid, List<CylinderCount> rows)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            if (rows != null)
            {
                var start = pageIndex * PageSize;
                for (var i = start; i < rows.Count && i < start + PageSize; i++)
                {
                    grid.Rows.Add(rows[i].Name,
                        rows[i].Actions.ToString(CultureInfo.InvariantCulture),
                        rows[i].Faults.ToString(CultureInfo.InvariantCulture),
                        "清零");
                }
            }
            // 空行铺满表格高度，和文档里的整页表格一致；点了也没有气缸名，不会误清零。
            var rowHeight = Math.Max(1, grid.RowTemplate.Height);
            var fill = Math.Max(0, (grid.ClientSize.Height - grid.ColumnHeadersHeight - 2) / rowHeight);
            while (grid.Rows.Count < fill) grid.Rows.Add(string.Empty, string.Empty, string.Empty, string.Empty);
            grid.ClearSelection();
            grid.ResumeLayout();
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (station == null || e.RowIndex < 0) return;
            var grid = (DataGridView)sender;
            var isDay = grid == gridDay;
            var clearColumn = isDay ? colDayClear.Index : colNightClear.Index;
            if (e.ColumnIndex != clearColumn) return;

            var name = Convert.ToString(grid.Rows[e.RowIndex].Cells[0].Value);
            if (string.IsNullOrEmpty(name)) return;
            var shift = isDay ? CylinderCounter.Day : CylinderCounter.Night;
            var confirm = MessageBox.Show(FindForm(),
                "确认清零“" + shift + " " + name + "”的动作次数和故障次数？",
                "清零", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            station.Cylinders.Clear(shift, name);
            station.Log.Write(station.User, "气缸清零", shift + " " + name, string.Empty, string.Empty);
            station.Say(shift + " " + name + " 计数已清零");
            viewKey = string.Empty;
            Query();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (pageIndex <= 0) return;
            pageIndex--;
            FitPage();
            Fill();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            pageIndex++;
            FitPage();
            Fill();
        }
    }
}
