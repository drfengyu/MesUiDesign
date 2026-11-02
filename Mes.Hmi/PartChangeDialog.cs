using Mes.Business;
using Mes.Hmi.Home;
using System;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 配件更换窗口（《Automation UI V3.11》P7）：上半是原配件信息，下半填新条码和更换原因。
    /// 配件管控页在 Home\ 下，这里只是把"剩余寿命"那行文案复用过来。
    /// </summary>
    public partial class PartChangeDialog : Form
    {
        public PartChangeDialog() : this(null)
        {
        }

        public PartChangeDialog(PartLifeRow part)
        {
            InitializeComponent();
            reasonBox.SelectedIndex = 0;
            if (part == null) return;
            nameValue.Text = part.ProductName;
            modelValue.Text = part.Model;
            ratedValue.Text = part.RatedLife.ToString();
            oldCodeValue.Text = part.Barcode;
            replacedValue.Text = part.ReplacedAt;
            currentValue.Text = part.CurrentLife.ToString();
            remainValue.Text = PagePartLife.RemainingText(part);
        }

        public string NewBarcode { get; private set; }

        public string Reason { get; private set; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            var code = newCodeBox.Text.Trim();
            if (code.Length == 0)
            {
                newCodeBox.Focus();
                return;
            }
            NewBarcode = code;
            Reason = reasonBox.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
