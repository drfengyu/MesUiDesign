using Mes.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 用户登录页（RFP P4 区域 6：登陆用户信息）。
    /// 等级从权限矩阵取，密码从 数据\权限密码.csv 取，都不写在代码里。
    /// </summary>
    public partial class PageLogin : UserControl
    {
        private readonly StationContext station;
        private bool ready;

        /// <summary>登录态变了，外壳要重算入口灰不灰、页签列哪几页。</summary>
        public event Action AccessChanged;

        public PageLogin()
        {
            InitializeComponent();
            buttonLogout.Enabled = false;
        }

        public PageLogin(StationContext station) : this()
        {
            this.station = station;
            for (var i = 0; i < AccessPolicy.LevelTitles.Length; i++)
            {
                comboLevel.Items.Add(AccessPolicy.LevelTitles[i]);
            }
            comboLevel.SelectedIndex = (int)LoginLevel.Operator;
            ready = true;
            if (station != null && station.Passwords.Count == 0)
            {
                resultLabel.ForeColor = Color.Firebrick;
                resultLabel.Text = "密码表没读到：检查输出目录下的 数据\\权限密码.csv";
            }
            ShowCurrent();
        }

        private LoginLevel SelectedLevel
        {
            get { return (LoginLevel)Math.Max(0, comboLevel.SelectedIndex); }
        }

        private void comboLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 初始 SelectedIndex 赋值时不要写提示：那一行还没到用户手上，
            // 页面上会凭空多出一句"密码取自…行"。
            if (station == null || !ready) return;
            resultLabel.ForeColor = SystemColors.ControlText;
            resultLabel.Text = "该等级密码取自 权限密码.csv 的「" + comboLevel.Text + "」行";
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (station == null) return;
            var level = SelectedLevel;
            var user = textUser.Text.Trim();
            if (user.Length == 0) user = AccessPolicy.Title(level);
            if (textPassword.Text != station.Passwords.Of(level))
            {
                resultLabel.ForeColor = Color.Firebrick;
                resultLabel.Text = "密码错误";
                station.Log.Write(user, "登录失败", AccessPolicy.Title(level), string.Empty, string.Empty);
                textPassword.SelectAll();
                textPassword.Focus();
                return;
            }
            station.Login(user, level);
            textPassword.Clear();
            resultLabel.ForeColor = Color.FromArgb(0, 150, 60);
            resultLabel.Text = "登录成功";
            ShowCurrent();
            RaiseAccessChanged();
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            if (station == null) return;
            station.Logout();
            textUser.Clear();
            textPassword.Clear();
            resultLabel.ForeColor = SystemColors.ControlText;
            resultLabel.Text = "已登出，回到操作员可见范围";
            ShowCurrent();
            RaiseAccessChanged();
        }

        private void ShowCurrent()
        {
            if (station == null) return;
            var logged = station.User != "NULL";
            currentLabel.Text = logged
                ? "当前用户：" + station.User + "（" + AccessPolicy.Title(station.Level) + "）"
                : "当前用户：NULL（默认操作员可见范围）";
            buttonLogout.Enabled = logged;
            buttonLogin.Enabled = !logged;
            textUser.Enabled = !logged;
            textPassword.Enabled = !logged;
        }

        private void RaiseAccessChanged()
        {
            var handler = AccessChanged;
            if (handler != null) handler();
        }
    }
}
