using Mes.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 密码登录页（《Automation UI V3.11》P36）：标题"用户权限管理"，
    /// 左卡"用户权限"用用户名+密码登入登出，右卡"密码修改"改 数据\权限密码.csv。
    ///
    /// 用户名下拉就是密码表的第一列（现场按等级发密码，五档），
    /// 所以选到哪个名字就等于以哪个等级登录。
    /// </summary>
    public partial class PageLogin : UserControl
    {
        private static readonly Color Ok = Color.FromArgb(0, 150, 60);
        private static readonly Color Bad = Color.FromArgb(190, 40, 40);
        private static readonly Color Plain = Color.FromArgb(90, 96, 104);

        private readonly StationContext station;

        /// <summary>登录态变了，外壳要重算入口灰不灰、页签列哪几页。</summary>
        public event Action AccessChanged;

        public PageLogin()
        {
            InitializeComponent();
        }

        public PageLogin(StationContext station) : this()
        {
            this.station = station;
            var names = station == null || station.Passwords.Count == 0
                ? new System.Collections.Generic.List<string>(AccessPolicy.LevelTitles)
                : station.Passwords.Names;
            foreach (var name in names)
            {
                comboUser.Items.Add(name);
                comboPwdUser.Items.Add(name);
            }
            if (comboUser.Items.Count > 0)
            {
                comboUser.SelectedIndex = 0;
                comboPwdUser.SelectedIndex = 0;
            }
            var register = station == null ? string.Empty : station.Device.Value("设备注册");
            registerBox.Text = string.IsNullOrEmpty(register) ? "未登记" : register;

            if (station != null && station.Passwords.Count == 0)
            {
                resultLabel.ForeColor = Bad;
                resultLabel.Text = "密码表没读到：检查输出目录下的 数据\\权限密码.csv";
            }
            ShowCurrent();
        }

        // ── 登入 / 登出 ────────────────────────────────────────────────────

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (station == null) return;
            if (IsLogged)
            {
                Logout();
                return;
            }
            var user = comboUser.Text;
            var level = (LoginLevel)Math.Max(0, comboUser.SelectedIndex);
            if (!station.Passwords.Matches(user, textPassword.Text))
            {
                resultLabel.ForeColor = Bad;
                resultLabel.Text = "密码错误";
                station.Log.Write(user, "登录失败", AccessPolicy.Title(level), string.Empty, string.Empty);
                textPassword.SelectAll();
                textPassword.Focus();
                return;
            }
            station.Login(user, level);
            textPassword.Clear();
            resultLabel.ForeColor = Ok;
            resultLabel.Text = "已登入：" + user;
            ShowCurrent();
            Raise();
        }

        private void Logout()
        {
            station.Logout();
            textPassword.Clear();
            resultLabel.ForeColor = Plain;
            resultLabel.Text = "已登出，回到操作员可见范围";
            ShowCurrent();
            Raise();
        }

        private bool IsLogged
        {
            get { return station != null && station.User != "NULL"; }
        }

        private void ShowCurrent()
        {
            if (station == null) return;
            var logged = IsLogged;
            currentLabel.Text = logged ? AccessPolicy.Title(station.Level) : "无";
            currentLabel.ForeColor = logged ? Ok : Plain;
            comboUser.Enabled = !logged;
            textPassword.Enabled = !logged;
            buttonLogin.Text = logged ? "登出" : "登入 / 登出";
        }

        // ── 密码修改 ──────────────────────────────────────────────────────

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (station == null) return;
            if (station.Level < LoginLevel.Administrator)
            {
                pwdResultLabel.ForeColor = Bad;
                pwdResultLabel.Text = "改密码要管理员以上等级";
                return;
            }
            var user = comboPwdUser.Text;
            if (!station.Passwords.Matches(user, textOldPwd.Text))
            {
                pwdResultLabel.ForeColor = Bad;
                pwdResultLabel.Text = "当前密码不对";
                return;
            }
            var fresh = textNewPwd.Text;
            if (fresh.Length == 0)
            {
                pwdResultLabel.ForeColor = Bad;
                pwdResultLabel.Text = "新密码不能为空";
                return;
            }
            if (fresh != textConfirmPwd.Text)
            {
                pwdResultLabel.ForeColor = Bad;
                pwdResultLabel.Text = "两次输入的新密码不一致";
                return;
            }
            if (!station.Passwords.Change(user, fresh) || !station.Passwords.Save())
            {
                pwdResultLabel.ForeColor = Bad;
                pwdResultLabel.Text = "写回 数据\\权限密码.csv 失败：文件是不是被 Excel 开着";
                return;
            }
            textOldPwd.Clear();
            textNewPwd.Clear();
            textConfirmPwd.Clear();
            pwdResultLabel.ForeColor = Ok;
            // 日志只记"谁在什么时候改了哪个等级的密码"，新旧密码一个字都不落盘：
            // 操作日志是 UTF-8 明文 csv，谁都能用 Excel 打开，把密码写进去等于把密码公开。
            station.Log.Write(station.User, "密码修改", user, "已修改", "已修改");
            station.Say(user + " 的密码已修改");
        }

        private void Raise()
        {
            var handler = AccessChanged;
            if (handler != null) handler();
        }
    }
}
