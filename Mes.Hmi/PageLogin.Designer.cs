namespace Mes.Hmi
{
    partial class PageLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.currentLabel = new System.Windows.Forms.Label();
            this.hintLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(24, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(400, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "用户登录";
            // 
            // levelLabel
            // 
            this.levelLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.levelLabel.Location = new System.Drawing.Point(28, 74);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(90, 30);
            this.levelLabel.TabIndex = 1;
            this.levelLabel.Text = "等级";
            // 
            // userLabel
            // 
            this.userLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.userLabel.Location = new System.Drawing.Point(28, 124);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(90, 30);
            this.userLabel.TabIndex = 2;
            this.userLabel.Text = "用户名";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.passwordLabel.Location = new System.Drawing.Point(28, 174);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(90, 30);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "密码";
            // 
            // comboLevel
            // 
            this.comboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLevel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.comboLevel.Location = new System.Drawing.Point(128, 72);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(240, 32);
            this.comboLevel.TabIndex = 4;
            this.comboLevel.SelectedIndexChanged += new System.EventHandler(this.comboLevel_SelectedIndexChanged);
            // 
            // textUser
            // 
            this.textUser.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textUser.Location = new System.Drawing.Point(128, 122);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(240, 30);
            this.textUser.TabIndex = 5;
            // 
            // textPassword
            // 
            this.textPassword.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.textPassword.Location = new System.Drawing.Point(128, 172);
            this.textPassword.Name = "textPassword";
            this.textPassword.Size = new System.Drawing.Size(240, 30);
            this.textPassword.TabIndex = 6;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(60, 200, 60);
            this.buttonLogin.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.Location = new System.Drawing.Point(128, 226);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(112, 52);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "登录";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.buttonLogout.Location = new System.Drawing.Point(256, 226);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(112, 52);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "登出";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.resultLabel.Location = new System.Drawing.Point(28, 296);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(600, 30);
            this.resultLabel.TabIndex = 9;
            // 
            // currentLabel
            // 
            this.currentLabel.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.currentLabel.Location = new System.Drawing.Point(28, 330);
            this.currentLabel.Name = "currentLabel";
            this.currentLabel.Size = new System.Drawing.Size(600, 30);
            this.currentLabel.TabIndex = 10;
            this.currentLabel.Text = "当前用户：NULL";
            // 
            // hintLabel
            // 
            this.hintLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.hintLabel.ForeColor = System.Drawing.Color.FromArgb(120, 126, 135);
            this.hintLabel.Location = new System.Drawing.Point(28, 366);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(640, 40);
            this.hintLabel.TabIndex = 11;
            this.hintLabel.Text = "密码取自 数据\\权限密码.csv（现场在 setting.ini 的 [PassWord] 段），改密码不用重新编译。";
            // 
            // PageLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.levelLabel);
            this.Controls.Add(this.comboLevel);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.textPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.currentLabel);
            this.Controls.Add(this.hintLabel);
            this.Name = "PageLogin";
            this.Size = new System.Drawing.Size(700, 420);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label currentLabel;
        private System.Windows.Forms.Label hintLabel;
    }
}
