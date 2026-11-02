namespace Mes.Hmi
{
    partial class PageCardLogin
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
            this.components = new System.ComponentModel.Container();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.scanBar = new System.Windows.Forms.TableLayoutPanel();
            this.cardLabel = new System.Windows.Forms.Label();
            this.cardBox = new System.Windows.Forms.TextBox();
            this.btnCardIn = new System.Windows.Forms.Button();
            this.btnCardOut = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.listCaption = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.scanBar.SuspendLayout();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.titleLabel, 0, 0);
            this.root.Controls.Add(this.scanBar, 0, 1);
            this.root.Controls.Add(this.listCaption, 0, 2);
            this.root.Controls.Add(this.list, 0, 3);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(8, 6, 8, 4);
            this.root.RowCount = 4;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
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
            // scanBar
            //
            this.scanBar.BackColor = System.Drawing.Color.White;
            this.scanBar.ColumnCount = 5;
            this.scanBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.scanBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scanBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.scanBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.scanBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.scanBar.Controls.Add(this.cardLabel, 0, 0);
            this.scanBar.Controls.Add(this.cardBox, 1, 0);
            this.scanBar.Controls.Add(this.btnCardIn, 2, 0);
            this.scanBar.Controls.Add(this.btnCardOut, 3, 0);
            this.scanBar.Controls.Add(this.statusLabel, 4, 0);
            this.scanBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scanBar.Name = "scanBar";
            this.scanBar.RowCount = 1;
            this.scanBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.scanBar.TabIndex = 1;
            //
            // cardLabel
            //
            this.cardLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.cardLabel.Name = "cardLabel";
            this.cardLabel.TabIndex = 0;
            this.cardLabel.Text = "请刷卡";
            this.cardLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // cardBox
            //
            this.cardBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardBox.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cardBox.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.cardBox.Name = "cardBox";
            this.cardBox.TabIndex = 1;
            this.cardBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cardBox_KeyDown);
            //
            // btnCardIn
            //
            this.btnCardIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCardIn.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnCardIn.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnCardIn.Name = "btnCardIn";
            this.btnCardIn.TabIndex = 2;
            this.btnCardIn.Text = "刷卡登录";
            this.btnCardIn.UseVisualStyleBackColor = true;
            this.btnCardIn.Click += new System.EventHandler(this.btnCardIn_Click);
            //
            // btnCardOut
            //
            this.btnCardOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCardOut.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnCardOut.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.btnCardOut.Name = "btnCardOut";
            this.btnCardOut.TabIndex = 3;
            this.btnCardOut.Text = "刷卡登出";
            this.btnCardOut.UseVisualStyleBackColor = true;
            this.btnCardOut.Click += new System.EventHandler(this.btnCardOut_Click);
            //
            // statusLabel
            //
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(90, 96, 104);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "刷卡后按回车即登录";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // listCaption
            //
            this.listCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.listCaption.ForeColor = System.Drawing.Color.FromArgb(90, 96, 104);
            this.listCaption.Name = "listCaption";
            this.listCaption.TabIndex = 5;
            this.listCaption.Text = "登陆 / 登出记录";
            this.listCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // list
            //
            this.list.BackColor = System.Drawing.Color.White;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.list.IntegralHeight = false;
            this.list.ItemHeight = 24;
            this.list.Name = "list";
            this.list.TabIndex = 3;
            //
            // refresh
            //
            this.refresh.Interval = 1000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            //
            // PageCardLogin
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageCardLogin";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.scanBar.ResumeLayout(false);
            this.scanBar.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TableLayoutPanel scanBar;
        private System.Windows.Forms.Label cardLabel;
        private System.Windows.Forms.TextBox cardBox;
        private System.Windows.Forms.Button btnCardIn;
        private System.Windows.Forms.Button btnCardOut;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label listCaption;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.Timer refresh;
    }
}
