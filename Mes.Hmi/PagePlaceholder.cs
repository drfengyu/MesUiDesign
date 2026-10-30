using Mes.Business;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 还没做的页面占位。导航先跑通、页面一块一块补，
    /// 避免出现"点下去什么都没有"这种分不清是没接上还是没做的状态。
    /// </summary>
    public partial class PagePlaceholder : UserControl
    {
        public PagePlaceholder()
        {
            InitializeComponent();
        }

        public PagePlaceholder(string title, string note) : this()
        {
            titleLabel.Text = title;
            noteLabel.Text = note;
        }

        public PagePlaceholder(string title, LoginLevel required, LoginLevel current)
            : this(title, "该页面尚未实现\r\n\r\n需要等级：" + AccessPolicy.Title(required)
                + "　当前等级：" + AccessPolicy.Title(current))
        {
        }
    }
}
