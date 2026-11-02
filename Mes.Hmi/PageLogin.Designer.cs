namespace Mes.Hmi
{
    partial class PageLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        private void InitializeComponent()
        {
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.cards = new System.Windows.Forms.TableLayoutPanel();
            this.leftCard = new System.Windows.Forms.TableLayoutPanel();
            this.permCaption = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.comboUser = new System.Windows.Forms.ComboBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.registerBox = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.rightCard = new System.Windows.Forms.TableLayoutPanel();
            this.pwdCaption = new System.Windows.Forms.Label();
            this.pwdUserLabel = new System.Windows.Forms.Label();
            this.comboPwdUser = new System.Windows.Forms.ComboBox();
            this.oldPwdLabel = new System.Windows.Forms.Label();
            this.textOldPwd = new System.Windows.Forms.TextBox();
            this.newPwdLabel = new System.Windows.Forms.Label();
            this.textNewPwd = new System.Windows.Forms.TextBox();
            this.confirmPwdLabel = new System.Windows.Forms.Label();
            this.textConfirmPwd = new System.Windows.Forms.TextBox();
            this.buttonChange = new System.Windows.Forms.Button();
            this.pwdResultLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.root.SuspendLayout();
            this.cards.SuspendLayout();
            this.leftCard.SuspendLayout();
            this.rightCard.SuspendLayout();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.titleLabel, 0, 0);
            this.root.Controls.Add(this.cards, 0, 1);
            this.root.Controls.Add(this.hintLabel, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(8, 6, 8, 4);
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            //
            // titleLabel
            //
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(40, 45, 50);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "用户权限管理";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // cards
            //
            this.cards.ColumnCount = 2;
            this.cards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cards.Controls.Add(this.leftCard, 0, 0);
            this.cards.Controls.Add(this.rightCard, 1, 0);
            this.cards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cards.Name = "cards";
            this.cards.RowCount = 1;
            this.cards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cards.TabIndex = 1;
            //
            // leftCard
            //
            this.leftCard.BackColor = System.Drawing.Color.White;
            this.leftCard.ColumnCount = 2;
            this.leftCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.leftCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftCard.Controls.Add(this.permCaption, 0, 0);
            this.leftCard.Controls.Add(this.levelLabel, 0, 1);
            this.leftCard.Controls.Add(this.currentLabel, 1, 1);
            this.leftCard.Controls.Add(this.userLabel, 0, 2);
            this.leftCard.Controls.Add(this.comboUser, 1, 2);
            this.leftCard.Controls.Add(this.passwordLabel, 0, 3);
            this.leftCard.Controls.Add(this.textPassword, 1, 3);
            this.leftCard.Controls.Add(this.registerLabel, 0, 4);
            this.leftCard.Controls.Add(this.registerBox, 1, 4);
            this.leftCard.Controls.Add(this.buttonLogin, 0, 5);
            this.leftCard.Controls.Add(this.resultLabel, 0, 6);
            this.leftCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftCard.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.leftCard.Name = "leftCard";
            this.leftCard.Padding = new System.Windows.Forms.Padding(10, 6, 12, 6);
            this.leftCard.RowCount = 7;
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftCard.TabIndex = 0;
            //
            // permCaption
            //
            this.permCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.permCaption.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.permCaption.ForeColor = System.Drawing.Color.FromArgb(40, 45, 50);
            this.permCaption.Name = "permCaption";
            this.permCaption.TabIndex = 0;
            this.permCaption.Text = "用 户 权 限";
            this.permCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.leftCard.SetColumnSpan(this.permCaption, 2);
            //
            // levelLabel
            //
            this.levelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.TabIndex = 1;
            this.levelLabel.Text = "当前权限";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // currentLabel
            //
            this.currentLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.currentLabel.ForeColor = System.Drawing.Color.FromArgb(40, 120, 60);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.TabIndex = 2;
            this.currentLabel.Text = "无";
            this.currentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // userLabel
            //
            this.userLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.userLabel.Name = "userLabel";
            this.userLabel.TabIndex = 3;
            this.userLabel.Text = "用户名";
            this.userLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // comboUser
            //
            this.comboUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboUser.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.comboUser.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.comboUser.Name = "comboUser";
            this.comboUser.TabIndex = 4;
            //
            // passwordLabel
            //
            this.passwordLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passwordLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.TabIndex = 5;
            this.passwordLabel.Text = "密码";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // textPassword
            //
            this.textPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textPassword.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.textPassword.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.textPassword.Name = "textPassword";
            this.textPassword.TabIndex = 6;
            this.textPassword.UseSystemPasswordChar = true;
            //
            // registerLabel
            //
            this.registerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.TabIndex = 7;
            this.registerLabel.Text = "设备注册";
            this.registerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // registerBox
            //
            this.registerBox.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.registerBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerBox.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.registerBox.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.registerBox.Name = "registerBox";
            this.registerBox.ReadOnly = true;
            this.registerBox.TabIndex = 8;
            //
            // buttonLogin
            //
            this.buttonLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLogin.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(30, 8, 30, 4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.TabIndex = 9;
            this.buttonLogin.Text = "登入 / 登出";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            this.leftCard.SetColumnSpan(this.buttonLogin, 2);
            //
            // resultLabel
            //
            this.resultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.resultLabel.ForeColor = System.Drawing.Color.FromArgb(90, 96, 104);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.TabIndex = 10;
            this.resultLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            //
            // rightCard
            //
            this.rightCard.BackColor = System.Drawing.Color.White;
            this.rightCard.ColumnCount = 2;
            this.rightCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.rightCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightCard.Controls.Add(this.pwdCaption, 0, 0);
            this.rightCard.Controls.Add(this.pwdUserLabel, 0, 1);
            this.rightCard.Controls.Add(this.comboPwdUser, 1, 1);
            this.rightCard.Controls.Add(this.oldPwdLabel, 0, 2);
            this.rightCard.Controls.Add(this.textOldPwd, 1, 2);
            this.rightCard.Controls.Add(this.newPwdLabel, 0, 3);
            this.rightCard.Controls.Add(this.textNewPwd, 1, 3);
            this.rightCard.Controls.Add(this.confirmPwdLabel, 0, 4);
            this.rightCard.Controls.Add(this.textConfirmPwd, 1, 4);
            this.rightCard.Controls.Add(this.buttonChange, 0, 5);
            this.rightCard.Controls.Add(this.pwdResultLabel, 0, 6);
            this.rightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightCard.Margin = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.rightCard.Name = "rightCard";
            this.rightCard.Padding = new System.Windows.Forms.Padding(10, 6, 12, 6);
            this.rightCard.RowCount = 7;
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightCard.TabIndex = 1;
            //
            // pwdCaption
            //
            this.pwdCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwdCaption.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic);
            this.pwdCaption.ForeColor = System.Drawing.Color.FromArgb(40, 45, 50);
            this.pwdCaption.Name = "pwdCaption";
            this.pwdCaption.TabIndex = 0;
            this.pwdCaption.Text = "密 码 修 改";
            this.pwdCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightCard.SetColumnSpan(this.pwdCaption, 2);
            //
            // pwdUserLabel
            //
            this.pwdUserLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwdUserLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.pwdUserLabel.Name = "pwdUserLabel";
            this.pwdUserLabel.TabIndex = 1;
            this.pwdUserLabel.Text = "用户名";
            this.pwdUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // comboPwdUser
            //
            this.comboPwdUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboPwdUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPwdUser.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.comboPwdUser.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.comboPwdUser.Name = "comboPwdUser";
            this.comboPwdUser.TabIndex = 2;
            //
            // oldPwdLabel
            //
            this.oldPwdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oldPwdLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.oldPwdLabel.Name = "oldPwdLabel";
            this.oldPwdLabel.TabIndex = 3;
            this.oldPwdLabel.Text = "当前密码";
            this.oldPwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // textOldPwd
            //
            this.textOldPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textOldPwd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.textOldPwd.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.textOldPwd.Name = "textOldPwd";
            this.textOldPwd.TabIndex = 4;
            this.textOldPwd.UseSystemPasswordChar = true;
            //
            // newPwdLabel
            //
            this.newPwdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newPwdLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.newPwdLabel.Name = "newPwdLabel";
            this.newPwdLabel.TabIndex = 5;
            this.newPwdLabel.Text = "新密码";
            this.newPwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // textNewPwd
            //
            this.textNewPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textNewPwd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.textNewPwd.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.textNewPwd.Name = "textNewPwd";
            this.textNewPwd.TabIndex = 6;
            this.textNewPwd.UseSystemPasswordChar = true;
            //
            // confirmPwdLabel
            //
            this.confirmPwdLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.confirmPwdLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.confirmPwdLabel.Name = "confirmPwdLabel";
            this.confirmPwdLabel.TabIndex = 7;
            this.confirmPwdLabel.Text = "确认密码";
            this.confirmPwdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // textConfirmPwd
            //
            this.textConfirmPwd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textConfirmPwd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.textConfirmPwd.Margin = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.textConfirmPwd.Name = "textConfirmPwd";
            this.textConfirmPwd.TabIndex = 8;
            this.textConfirmPwd.UseSystemPasswordChar = true;
            //
            // buttonChange
            //
            this.buttonChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonChange.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.buttonChange.Margin = new System.Windows.Forms.Padding(30, 8, 30, 4);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.TabIndex = 9;
            this.buttonChange.Text = "确认修改密码";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            this.rightCard.SetColumnSpan(this.buttonChange, 2);
            //
            // pwdResultLabel
            //
            this.pwdResultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pwdResultLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.pwdResultLabel.ForeColor = System.Drawing.Color.FromArgb(90, 96, 104);
            this.pwdResultLabel.Name = "pwdResultLabel";
            this.pwdResultLabel.TabIndex = 10;
            this.pwdResultLabel.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            //
            // hintLabel
            //
            this.hintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.hintLabel.ForeColor = System.Drawing.Color.FromArgb(120, 126, 135);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.TabIndex = 2;
            this.hintLabel.Text = "密码取自 数据\\权限密码.csv（现场在 setting.ini 的 [PassWord] 段），改密码不用重新编译；修改密码要管理员以上。";
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // PageLogin
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageLogin";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.cards.ResumeLayout(false);
            this.leftCard.ResumeLayout(false);
            this.rightCard.ResumeLayout(false);
            this.rightCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel cards;
        private System.Windows.Forms.TableLayoutPanel leftCard;
        private System.Windows.Forms.Label permCaption;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.ComboBox comboUser;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.TextBox registerBox;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.TableLayoutPanel rightCard;
        private System.Windows.Forms.Label pwdCaption;
        private System.Windows.Forms.Label pwdUserLabel;
        private System.Windows.Forms.ComboBox comboPwdUser;
        private System.Windows.Forms.Label oldPwdLabel;
        private System.Windows.Forms.TextBox textOldPwd;
        private System.Windows.Forms.Label newPwdLabel;
        private System.Windows.Forms.TextBox textNewPwd;
        private System.Windows.Forms.Label confirmPwdLabel;
        private System.Windows.Forms.TextBox textConfirmPwd;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.Label pwdResultLabel;
        private System.Windows.Forms.Label hintLabel;
    }
}
