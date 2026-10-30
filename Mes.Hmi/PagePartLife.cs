using Mes.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 配件管控（《Automation UI V3.11》P7）：配件清单、已用寿命、剩余百分比和更换入口。
    /// 计数由过站线程累加，这里只显示；更换走 记录\配件更换.csv 留痕。
    /// </summary>
    public partial class PagePartLife : UserControl
    {
        private static readonly Color RowWarn = Color.FromArgb(255, 244, 214);
        private static readonly Color RowNg = Color.FromArgb(250, 216, 216);

        private readonly StationContext station;
        private string gridKey = string.Empty;

        public PagePartLife()
        {
            InitializeComponent();
        }

        public PagePartLife(StationContext station) : this()
        {
            this.station = station;
            refresh.Enabled = true;
            FillGrid();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            FillGridIfChanged();
        }

        private void FillGridIfChanged()
        {
            var key = string.Empty;
            foreach (var part in station.Ledger.Parts)
            {
                key += part.ProductName + "|" + part.Barcode + "|" + part.ReplacedAt + "|" + part.CurrentLife + "\n";
            }
            if (key == gridKey) return;
            gridKey = key;
            FillGrid();
        }

        private void FillGrid()
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            foreach (var part in station.Ledger.Parts)
            {
                var index = grid.Rows.Add(part.ProductName, part.Model, part.RatedLife.ToString(),
                    part.Barcode, part.ReplacedAt, part.CurrentLife.ToString(), RemainingText(part));
                grid.Rows[index].Tag = part;
                var percent = RemainingPercent(part);
                if (percent <= 0) grid.Rows[index].DefaultCellStyle.BackColor = RowNg;
                else if (percent <= 10) grid.Rows[index].DefaultCellStyle.BackColor = RowWarn;
            }
            grid.ResumeLayout();
        }

        public static double RemainingPercent(PartLifeRow part)
        {
            if (part == null || part.RatedLife <= 0) return 100;
            var remain = part.RatedLife - part.CurrentLife;
            if (remain < 0) remain = 0;
            return remain * 100D / part.RatedLife;
        }

        public static string RemainingText(PartLifeRow part)
        {
            return RemainingPercent(part).ToString("0.00") + "%";
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colChange.Index) return;
            var part = grid.Rows[e.RowIndex].Tag as PartLifeRow;
            if (part == null) return;
            using (var dialog = new PartChangeDialog(part))
            {
                if (dialog.ShowDialog(this) != DialogResult.OK) return;
                station.Ledger.ReplacePart(part, dialog.NewBarcode, dialog.Reason, station.User);
                station.Log.Write(station.User, "更换配件", part.ProductName, part.Barcode, dialog.NewBarcode);
                station.Say(part.ProductName + " 已更换：" + dialog.NewBarcode);
            }
            FillGrid();
        }
    }
}
