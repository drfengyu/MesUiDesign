using Mes.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 刷卡登录（《Automation UI V3.11》P37）：读卡器把卡号当条码打进输入框，回车或点"刷卡登录"生效，
    /// 下面那张表是当天操作日志里的登录/登出行。
    ///
    /// 文档那句"使用刷卡登陆后此功能页面将被屏蔽"是现场二选一的配置（密码登录页 P36 括号里同一句），
    /// 本机两张页签都留着，屏蔽由现场在权限里关掉，不在代码里写死。
    /// </summary>
    public partial class PageCardLogin : UserControl
    {
        private readonly StationContext station;

        /// <summary>和登录页一样：刷卡改了登录态，外壳的入口灰不灰、页签列哪几页都要重算。</summary>
        public event Action AccessChanged;

        public PageCardLogin()
        {
            InitializeComponent();
        }

        public PageCardLogin(StationContext station) : this()
        {
            this.station = station;
            if (station != null && station.Cards.Count == 0)
            {
                statusLabel.ForeColor = Color.FromArgb(190, 40, 40);
                statusLabel.Text = "刷卡用户表没读到：检查 数据\\刷卡用户.csv";
            }
            RefreshRecords();
            refresh.Enabled = true;
        }

        private void cardBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;     // 回车别响提示音：刷卡时这一下每秒都来一次
            Login();
        }

        private void btnCardIn_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void btnCardOut_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Login()
        {
            if (station == null) return;
            var text = cardBox.Text.Trim();
            if (text.Length == 0)
            {
                Say("先刷卡或输入卡号", false);
                return;
            }
            var card = station.Cards.Find(text);
            if (card == null)
            {
                Say("卡号没登记：" + text, false);
                station.Log.Write(text, "刷卡失败", "卡号未登记", string.Empty, string.Empty);
                return;
            }
            if (!card.LevelKnown)
            {
                Say("卡面等级不认识：" + card.LevelTitle, false);
                return;
            }
            station.Login(card.User, card.Level, "刷卡登录");
            Say(card.User + " 以 " + AccessPolicy.Title(card.Level) + " 刷卡登录", true);
            cardBox.Clear();
            RefreshRecords();
            Raise();
        }

        private void Logout()
        {
            if (station == null) return;
            if (station.User == "NULL")
            {
                Say("当前没人登录", false);
                return;
            }
            station.Logout("刷卡登出");
            Say("已登出", true);
            RefreshRecords();
            Raise();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            RefreshRecords();
        }

        private void RefreshRecords()
        {
            if (station == null) return;
            var rows = station.Log.Read(DateTime.Today, DateTime.Now.AddDays(1), null);
            list.BeginUpdate();
            list.Items.Clear();
            foreach (var row in rows)
            {
                // 刷卡登录写的是"刷卡登录"、密码登录写的是"登录"，两边都要进这张表，所以用 Contains。
                if (!row.Action.Contains("登录") && !row.Action.Contains("登出")) continue;
                list.Items.Add(string.Format("{0:HH:mm:ss}  {1}  {2}  {3}",
                    row.At, row.Action, row.Who, row.Target));
            }
            list.EndUpdate();
            listCaption.Text = "登陆 / 登出记录：今天 " + list.Items.Count + " 条";
        }

        private void Say(string text, bool ok)
        {
            statusLabel.ForeColor = ok ? Color.FromArgb(0, 150, 60) : Color.FromArgb(190, 40, 40);
            statusLabel.Text = text;
        }

        private void Raise()
        {
            var handler = AccessChanged;
            if (handler != null) handler();
        }
    }
}
