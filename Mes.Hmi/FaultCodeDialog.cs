using Mes.Business;
using System;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 手动登记故障时选代码。PLC 报警线程自己会报，这个框是给
    /// "设备没报但确实停着"的情况补一笔 DT，所以列的是整张报警目录。
    /// </summary>
    public partial class FaultCodeDialog : Form
    {
        private readonly AlarmCatalog catalog;

        public FaultCodeDialog() : this(null)
        {
        }

        public FaultCodeDialog(AlarmCatalog catalog)
        {
            InitializeComponent();
            this.catalog = catalog;
            Fill(string.Empty);
        }

        public AlarmInfo SelectedAlarm { get; private set; }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            Fill(searchBox.Text.Trim());
        }

        private void Fill(string filter)
        {
            list.BeginUpdate();
            list.Items.Clear();
            if (catalog != null)
            {
                foreach (var info in catalog.Items)
                {
                    if (filter.Length > 0
                        && info.Code.IndexOf(filter, StringComparison.OrdinalIgnoreCase) < 0
                        && info.Title.IndexOf(filter, StringComparison.OrdinalIgnoreCase) < 0) continue;
                    var item = new ListViewItem(info.Index.ToString());
                    item.SubItems.Add(info.Code);
                    item.SubItems.Add(info.Title);
                    item.SubItems.Add(info.DtClass);
                    item.Tag = info;
                    list.Items.Add(item);
                }
            }
            list.EndUpdate();
            if (list.Items.Count > 0) list.Items[0].Selected = true;
        }

        private void list_DoubleClick(object sender, EventArgs e)
        {
            if (list.SelectedItems.Count == 0) return;
            DialogResult = DialogResult.OK;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                SelectedAlarm = list.SelectedItems.Count == 0
                    ? null
                    : list.SelectedItems[0].Tag as AlarmInfo;
                if (SelectedAlarm == null) e.Cancel = true;
            }
            base.OnFormClosing(e);
        }
    }
}
