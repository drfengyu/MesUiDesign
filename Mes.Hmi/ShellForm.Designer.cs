namespace Mes.Hmi
{
    partial class ShellForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShellForm));
            this.topBar = new System.Windows.Forms.Panel();
            this.navLayout = new System.Windows.Forms.TableLayoutPanel();
            this.navStrip = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnStatistics = new System.Windows.Forms.ToolStripButton();
            this.btnIo = new System.Windows.Forms.ToolStripButton();
            this.btnManual = new System.Windows.Forms.ToolStripButton();
            this.btnSetting = new System.Windows.Forms.ToolStripButton();
            this.btnAlarm = new System.Windows.Forms.ToolStripButton();
            this.btnUser = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.machineLabel = new System.Windows.Forms.Label();
            this.controlStrip = new System.Windows.Forms.ToolStrip();
            this.btnRun = new System.Windows.Forms.ToolStripButton();
            this.btnPause = new System.Windows.Forms.ToolStripButton();
            this.btnStop = new System.Windows.Forms.ToolStripButton();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.contentHost = new System.Windows.Forms.Panel();
            this.navPanel = new System.Windows.Forms.Panel();
            this.navPages = new System.Windows.Forms.FlowLayoutPanel();
            this.navAlarmClear = new System.Windows.Forms.Button();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.userLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.plcLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mesLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.storeLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.activityLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.runLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clockLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.topBar.SuspendLayout();
            this.navLayout.SuspendLayout();
            this.navStrip.SuspendLayout();
            this.controlStrip.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.navPanel.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.Controls.Add(this.navLayout);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1384, 76);
            this.topBar.TabIndex = 0;
            // 
            // navLayout
            // 
            // 第 1 列是没人占的 Percent 100 空列，吃掉导航条与机台名之间的剩余宽度，
            // 原来 spacerPanel 干的就是这件事，删掉控件后这条列留着，机台名和右侧按钮才贴得住。
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.navLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.navLayout.Controls.Add(this.navStrip, 0, 0);
            this.navLayout.Controls.Add(this.machineLabel, 2, 0);
            this.navLayout.Controls.Add(this.controlStrip, 3, 0);
            this.navLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navLayout.Location = new System.Drawing.Point(0, 0);
            this.navLayout.Name = "navLayout";
            this.navLayout.RowCount = 1;
            this.navLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.navLayout.Size = new System.Drawing.Size(1384, 76);
            this.navLayout.TabIndex = 0;
            // 
            // navStrip
            // 
            this.navStrip.CanOverflow = false;
            this.navStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.navStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.navStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.btnStatistics,
            this.btnIo,
            this.btnManual,
            this.btnSetting,
            this.btnAlarm,
            this.btnUser,
            this.btnHelp});
            this.navStrip.Location = new System.Drawing.Point(0, 0);
            this.navStrip.Name = "navStrip";
            this.navStrip.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.navStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.navStrip.Size = new System.Drawing.Size(630, 76);
            this.navStrip.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(54, 70);
            this.btnHome.Text = "主界面";
            this.btnHome.ToolTipText = "主界面";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnStatistics
            // 
            this.btnStatistics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStatistics.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistics.Image")));
            this.btnStatistics.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStatistics.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(54, 70);
            this.btnStatistics.Text = "数据统计";
            this.btnStatistics.ToolTipText = "数据统计";
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // btnIo
            // 
            this.btnIo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIo.Image = ((System.Drawing.Image)(resources.GetObject("btnIo.Image")));
            this.btnIo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIo.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnIo.Name = "btnIo";
            this.btnIo.Size = new System.Drawing.Size(54, 70);
            this.btnIo.Text = "IO监视";
            this.btnIo.ToolTipText = "IO监视";
            this.btnIo.Click += new System.EventHandler(this.btnIo_Click);
            // 
            // btnManual
            // 
            this.btnManual.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnManual.Image = ((System.Drawing.Image)(resources.GetObject("btnManual.Image")));
            this.btnManual.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManual.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(54, 70);
            this.btnManual.Text = "手动操作";
            this.btnManual.ToolTipText = "手动操作";
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSetting.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(54, 70);
            this.btnSetting.Text = "参数设置";
            this.btnSetting.ToolTipText = "参数设置";
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnAlarm
            // 
            this.btnAlarm.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAlarm.Image = ((System.Drawing.Image)(resources.GetObject("btnAlarm.Image")));
            this.btnAlarm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAlarm.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(54, 70);
            this.btnAlarm.Text = "异常报警";
            this.btnAlarm.ToolTipText = "异常报警";
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnUser
            // 
            this.btnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUser.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(54, 70);
            this.btnUser.Text = "用户登陆";
            this.btnUser.ToolTipText = "用户登陆";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(54, 70);
            this.btnHelp.Text = "帮助信息";
            this.btnHelp.ToolTipText = "帮助信息";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // machineLabel
            // 
            this.machineLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(200)))), ((int)(((byte)(60)))));
            this.machineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineLabel.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.machineLabel.Location = new System.Drawing.Point(816, 0);
            this.machineLabel.Name = "machineLabel";
            this.machineLabel.Size = new System.Drawing.Size(334, 76);
            this.machineLabel.TabIndex = 1;
            this.machineLabel.Text = "MES 数据上传追溯";
            this.machineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlStrip
            // 
            this.controlStrip.CanOverflow = false;
            this.controlStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.controlStrip.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.controlStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRun,
            this.btnPause,
            this.btnStop});
            this.controlStrip.Location = new System.Drawing.Point(1153, 0);
            this.controlStrip.Name = "controlStrip";
            this.controlStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.controlStrip.Size = new System.Drawing.Size(231, 76);
            this.controlStrip.TabIndex = 2;
            // 
            // btnRun
            // 
            this.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRun.Image = ((System.Drawing.Image)(resources.GetObject("btnRun.Image")));
            this.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRun.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(54, 70);
            this.btnRun.Text = "启动";
            this.btnRun.ToolTipText = "启动";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnPause
            // 
            this.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPause.Image = ((System.Drawing.Image)(resources.GetObject("btnPause.Image")));
            this.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPause.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(54, 70);
            this.btnPause.Text = "暂停";
            this.btnPause.ToolTipText = "暂停";
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStop
            // 
            this.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStop.Image = ((System.Drawing.Image)(resources.GetObject("btnStop.Image")));
            this.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStop.Margin = new System.Windows.Forms.Padding(11, 3, 11, 3);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(54, 70);
            this.btnStop.Text = "停止";
            this.btnStop.ToolTipText = "停止";
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.White;
            this.bodyPanel.Controls.Add(this.contentHost);
            this.bodyPanel.Controls.Add(this.navPanel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 76);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1384, 710);
            this.bodyPanel.TabIndex = 1;
            // 
            // contentHost
            // 
            this.contentHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentHost.Location = new System.Drawing.Point(176, 0);
            this.contentHost.Name = "contentHost";
            this.contentHost.Padding = new System.Windows.Forms.Padding(8);
            this.contentHost.Size = new System.Drawing.Size(1208, 710);
            this.contentHost.TabIndex = 1;
            // 
            // navPanel
            // 
            this.navPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.navPanel.Controls.Add(this.navPages);
            this.navPanel.Controls.Add(this.navAlarmClear);
            this.navPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navPanel.Location = new System.Drawing.Point(0, 0);
            this.navPanel.Name = "navPanel";
            this.navPanel.Size = new System.Drawing.Size(176, 710);
            this.navPanel.TabIndex = 0;
            // 
            // navPages
            // 
            this.navPages.AutoScroll = true;
            this.navPages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPages.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.navPages.Location = new System.Drawing.Point(0, 0);
            this.navPages.Name = "navPages";
            this.navPages.Padding = new System.Windows.Forms.Padding(4, 8, 0, 0);
            this.navPages.Size = new System.Drawing.Size(176, 660);
            this.navPages.TabIndex = 0;
            this.navPages.WrapContents = false;
            // 
            // navAlarmClear
            // 
            this.navAlarmClear.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navAlarmClear.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.navAlarmClear.Location = new System.Drawing.Point(0, 660);
            this.navAlarmClear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 6);
            this.navAlarmClear.Name = "navAlarmClear";
            this.navAlarmClear.Size = new System.Drawing.Size(176, 50);
            this.navAlarmClear.TabIndex = 1;
            this.navAlarmClear.Text = "清除报警";
            this.navAlarmClear.UseVisualStyleBackColor = true;
            this.navAlarmClear.Visible = false;
            this.navAlarmClear.Click += new System.EventHandler(this.navAlarmClear_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userLabel,
            this.plcLabel,
            this.mesLabel,
            this.storeLabel,
            this.activityLabel,
            this.runLabel,
            this.clockLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 786);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1384, 22);
            this.statusBar.SizingGrip = false;
            this.statusBar.TabIndex = 2;
            // 
            // userLabel
            // 
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(99, 17);
            this.userLabel.Text = "当前用户：NULL";
            // 
            // plcLabel
            // 
            this.plcLabel.Name = "plcLabel";
            this.plcLabel.Size = new System.Drawing.Size(51, 17);
            this.plcLabel.Text = "PLC:NG";
            // 
            // mesLabel
            // 
            this.mesLabel.Name = "mesLabel";
            this.mesLabel.Size = new System.Drawing.Size(56, 17);
            this.mesLabel.Text = "MES:NG";
            // 
            // storeLabel
            // 
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(54, 17);
            this.storeLabel.Text = "记录:NG";
            // 
            // activityLabel
            // 
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(951, 17);
            this.activityLabel.Spring = true;
            this.activityLabel.Text = "就绪";
            this.activityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // runLabel
            // 
            this.runLabel.Name = "runLabel";
            this.runLabel.Size = new System.Drawing.Size(32, 17);
            this.runLabel.Text = "停止";
            // 
            // clockLabel
            // 
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(126, 17);
            this.clockLabel.Text = "2026-01-01 00:00:00";
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // ShellForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 808);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.topBar);
            this.MinimumSize = new System.Drawing.Size(1024, 600);
            this.Name = "ShellForm";
            this.Text = "MES 上位机";
            this.topBar.ResumeLayout(false);
            this.navLayout.ResumeLayout(false);
            this.navLayout.PerformLayout();
            this.navStrip.ResumeLayout(false);
            this.navStrip.PerformLayout();
            this.controlStrip.ResumeLayout(false);
            this.controlStrip.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.navPanel.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.TableLayoutPanel navLayout;
        private System.Windows.Forms.ToolStrip navStrip;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnStatistics;
        private System.Windows.Forms.ToolStripButton btnIo;
        private System.Windows.Forms.ToolStripButton btnManual;
        private System.Windows.Forms.ToolStripButton btnSetting;
        private System.Windows.Forms.ToolStripButton btnAlarm;
        private System.Windows.Forms.ToolStripButton btnUser;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Label machineLabel;
        private System.Windows.Forms.ToolStrip controlStrip;
        private System.Windows.Forms.ToolStripButton btnRun;
        private System.Windows.Forms.ToolStripButton btnPause;
        private System.Windows.Forms.ToolStripButton btnStop;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel contentHost;
        private System.Windows.Forms.Panel navPanel;
        private System.Windows.Forms.FlowLayoutPanel navPages;
        private System.Windows.Forms.Button navAlarmClear;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel userLabel;
        private System.Windows.Forms.ToolStripStatusLabel plcLabel;
        private System.Windows.Forms.ToolStripStatusLabel mesLabel;
        private System.Windows.Forms.ToolStripStatusLabel storeLabel;
        private System.Windows.Forms.ToolStripStatusLabel activityLabel;
        private System.Windows.Forms.ToolStripStatusLabel runLabel;
        private System.Windows.Forms.ToolStripStatusLabel clockLabel;
        private System.Windows.Forms.Timer clock;
    }
}
