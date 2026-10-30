namespace Mes.Hmi
{
    partial class PageMachineSimulator
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
            this.components = new System.ComponentModel.Container();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.modeRow = new System.Windows.Forms.TableLayoutPanel();
            this.modeTitle = new System.Windows.Forms.Label();
            this.btnMa = new System.Windows.Forms.Button();
            this.cycleRow = new System.Windows.Forms.TableLayoutPanel();
            this.cycleTitle = new System.Windows.Forms.Label();
            this.numericCycle = new System.Windows.Forms.NumericUpDown();
            this.alarmRow = new System.Windows.Forms.TableLayoutPanel();
            this.alarmTitle = new System.Windows.Forms.Label();
            this.numericAlarmEvery = new System.Windows.Forms.NumericUpDown();
            this.channelRow = new System.Windows.Forms.TableLayoutPanel();
            this.channelTitle = new System.Windows.Forms.Label();
            this.numericChannel = new System.Windows.Forms.NumericUpDown();
            this.btnInjectAlarm = new System.Windows.Forms.Button();
            this.linkTitle = new System.Windows.Forms.Label();
            this.checkLink1 = new System.Windows.Forms.CheckBox();
            this.checkLink2 = new System.Windows.Forms.CheckBox();
            this.checkLink3 = new System.Windows.Forms.CheckBox();
            this.checkLink4 = new System.Windows.Forms.CheckBox();
            this.btnLinksAll = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.logPanel = new System.Windows.Forms.TableLayoutPanel();
            this.logHeader = new System.Windows.Forms.TableLayoutPanel();
            this.logTitle = new System.Windows.Forms.Label();
            this.btnClearLog = new System.Windows.Forms.Button();
            this.eventList = new System.Windows.Forms.ListBox();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.modeRow.SuspendLayout();
            this.cycleRow.SuspendLayout();
            this.alarmRow.SuspendLayout();
            this.channelRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlarmEvery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChannel)).BeginInit();
            this.logPanel.SuspendLayout();
            this.logHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 2;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 470F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.leftPanel, 0, 0);
            this.root.Controls.Add(this.logPanel, 1, 0);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(6);
            this.root.RowCount = 1;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Controls.Add(this.titleLabel, 0, 0);
            this.leftPanel.Controls.Add(this.noteLabel, 0, 1);
            this.leftPanel.Controls.Add(this.modeRow, 0, 2);
            this.leftPanel.Controls.Add(this.cycleRow, 0, 3);
            this.leftPanel.Controls.Add(this.alarmRow, 0, 4);
            this.leftPanel.Controls.Add(this.channelRow, 0, 5);
            this.leftPanel.Controls.Add(this.btnInjectAlarm, 0, 6);
            this.leftPanel.Controls.Add(this.linkTitle, 0, 7);
            this.leftPanel.Controls.Add(this.checkLink1, 0, 8);
            this.leftPanel.Controls.Add(this.checkLink2, 0, 9);
            this.leftPanel.Controls.Add(this.checkLink3, 0, 10);
            this.leftPanel.Controls.Add(this.checkLink4, 0, 11);
            this.leftPanel.Controls.Add(this.btnLinksAll, 0, 12);
            this.leftPanel.Controls.Add(this.statusLabel, 0, 13);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(9, 9);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Size = new System.Drawing.Size(464, 642);
            this.leftPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(446, 44);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "模拟机台";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noteLabel
            // 
            this.noteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.noteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.noteLabel.Location = new System.Drawing.Point(3, 44);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(446, 48);
            this.noteLabel.TabIndex = 1;
            this.noteLabel.Text = "扮演 PLC 那一侧：拨旋钮、改节拍、注入报警、拨连接灯。\r\n只在模拟驱动下有效，接真机后整页删掉。";
            // 
            // modeRow
            // 
            this.modeRow.ColumnCount = 2;
            this.modeRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modeRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.modeRow.Controls.Add(this.modeTitle, 0, 0);
            this.modeRow.Controls.Add(this.btnMa, 1, 0);
            this.modeRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeRow.Location = new System.Drawing.Point(3, 95);
            this.modeRow.Name = "modeRow";
            this.modeRow.RowCount = 1;
            this.modeRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.modeRow.Size = new System.Drawing.Size(446, 48);
            this.modeRow.TabIndex = 2;
            // 
            // modeTitle
            // 
            this.modeTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeTitle.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.modeTitle.Location = new System.Drawing.Point(3, 0);
            this.modeTitle.Name = "modeTitle";
            this.modeTitle.Size = new System.Drawing.Size(270, 48);
            this.modeTitle.TabIndex = 0;
            this.modeTitle.Text = "MA 旋钮（I 1000.0）";
            this.modeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnMa
            // 
            this.btnMa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(244)))), ((int)(((byte)(222)))));
            this.btnMa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMa.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnMa.Location = new System.Drawing.Point(280, 6);
            this.btnMa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMa.Name = "btnMa";
            this.btnMa.Size = new System.Drawing.Size(162, 36);
            this.btnMa.TabIndex = 1;
            this.btnMa.Text = "自动";
            this.btnMa.UseVisualStyleBackColor = false;
            this.btnMa.Click += new System.EventHandler(this.btnMa_Click);
            // 
            // cycleRow
            // 
            this.cycleRow.ColumnCount = 2;
            this.cycleRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cycleRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.cycleRow.Controls.Add(this.cycleTitle, 0, 0);
            this.cycleRow.Controls.Add(this.numericCycle, 1, 0);
            this.cycleRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cycleRow.Location = new System.Drawing.Point(3, 149);
            this.cycleRow.Name = "cycleRow";
            this.cycleRow.RowCount = 1;
            this.cycleRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cycleRow.Size = new System.Drawing.Size(446, 48);
            this.cycleRow.TabIndex = 3;
            // 
            // cycleTitle
            // 
            this.cycleTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cycleTitle.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.cycleTitle.Location = new System.Drawing.Point(3, 0);
            this.cycleTitle.Name = "cycleTitle";
            this.cycleTitle.Size = new System.Drawing.Size(270, 48);
            this.cycleTitle.TabIndex = 0;
            this.cycleTitle.Text = "节拍 CycleMs";
            this.cycleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericCycle
            // 
            this.numericCycle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericCycle.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.numericCycle.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericCycle.Location = new System.Drawing.Point(280, 9);
            this.numericCycle.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numericCycle.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericCycle.Name = "numericCycle";
            this.numericCycle.Size = new System.Drawing.Size(162, 29);
            this.numericCycle.TabIndex = 1;
            this.numericCycle.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericCycle.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericCycle.ValueChanged += new System.EventHandler(this.numericCycle_ValueChanged);
            // 
            // alarmRow
            // 
            this.alarmRow.ColumnCount = 2;
            this.alarmRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.alarmRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.alarmRow.Controls.Add(this.alarmTitle, 0, 0);
            this.alarmRow.Controls.Add(this.numericAlarmEvery, 1, 0);
            this.alarmRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alarmRow.Location = new System.Drawing.Point(3, 203);
            this.alarmRow.Name = "alarmRow";
            this.alarmRow.RowCount = 1;
            this.alarmRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.alarmRow.Size = new System.Drawing.Size(446, 48);
            this.alarmRow.TabIndex = 4;
            // 
            // alarmTitle
            // 
            this.alarmTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alarmTitle.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.alarmTitle.Location = new System.Drawing.Point(3, 0);
            this.alarmTitle.Name = "alarmTitle";
            this.alarmTitle.Size = new System.Drawing.Size(270, 48);
            this.alarmTitle.TabIndex = 0;
            this.alarmTitle.Text = "报警间隔（片，0=不自动报）";
            this.alarmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericAlarmEvery
            // 
            this.numericAlarmEvery.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericAlarmEvery.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.numericAlarmEvery.Location = new System.Drawing.Point(280, 9);
            this.numericAlarmEvery.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericAlarmEvery.Name = "numericAlarmEvery";
            this.numericAlarmEvery.Size = new System.Drawing.Size(162, 29);
            this.numericAlarmEvery.TabIndex = 1;
            this.numericAlarmEvery.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericAlarmEvery.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericAlarmEvery.ValueChanged += new System.EventHandler(this.numericAlarmEvery_ValueChanged);
            // 
            // channelRow
            // 
            this.channelRow.ColumnCount = 2;
            this.channelRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.channelRow.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.channelRow.Controls.Add(this.channelTitle, 0, 0);
            this.channelRow.Controls.Add(this.numericChannel, 1, 0);
            this.channelRow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelRow.Location = new System.Drawing.Point(3, 257);
            this.channelRow.Name = "channelRow";
            this.channelRow.RowCount = 1;
            this.channelRow.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.channelRow.Size = new System.Drawing.Size(446, 48);
            this.channelRow.TabIndex = 5;
            // 
            // channelTitle
            // 
            this.channelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.channelTitle.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.channelTitle.Location = new System.Drawing.Point(3, 0);
            this.channelTitle.Name = "channelTitle";
            this.channelTitle.Size = new System.Drawing.Size(270, 48);
            this.channelTitle.TabIndex = 0;
            this.channelTitle.Text = "报警通道（MW62000）";
            this.channelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numericChannel
            // 
            this.numericChannel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericChannel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.numericChannel.Location = new System.Drawing.Point(280, 9);
            this.numericChannel.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericChannel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericChannel.Name = "numericChannel";
            this.numericChannel.Size = new System.Drawing.Size(162, 29);
            this.numericChannel.TabIndex = 1;
            this.numericChannel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericChannel.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericChannel.ValueChanged += new System.EventHandler(this.numericChannel_ValueChanged);
            // 
            // btnInjectAlarm
            // 
            this.btnInjectAlarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInjectAlarm.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnInjectAlarm.Location = new System.Drawing.Point(4, 315);
            this.btnInjectAlarm.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnInjectAlarm.Name = "btnInjectAlarm";
            this.btnInjectAlarm.Size = new System.Drawing.Size(444, 42);
            this.btnInjectAlarm.TabIndex = 6;
            this.btnInjectAlarm.Text = "立即注入一条报警";
            this.btnInjectAlarm.UseVisualStyleBackColor = true;
            this.btnInjectAlarm.Click += new System.EventHandler(this.btnInjectAlarm_Click);
            // 
            // linkTitle
            // 
            this.linkTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkTitle.Font = new System.Drawing.Font("微软雅黑", 11.5F, System.Drawing.FontStyle.Bold);
            this.linkTitle.Location = new System.Drawing.Point(3, 363);
            this.linkTitle.Name = "linkTitle";
            this.linkTitle.Size = new System.Drawing.Size(446, 36);
            this.linkTitle.TabIndex = 7;
            this.linkTitle.Text = "主界面连接灯（MW62080~62083）";
            this.linkTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkLink1
            // 
            this.checkLink1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkLink1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.checkLink1.Location = new System.Drawing.Point(8, 403);
            this.checkLink1.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.checkLink1.Name = "checkLink1";
            this.checkLink1.Size = new System.Drawing.Size(440, 28);
            this.checkLink1.TabIndex = 8;
            this.checkLink1.Text = "定位相机连接";
            this.checkLink1.CheckedChanged += new System.EventHandler(this.link_CheckedChanged);
            // 
            // checkLink2
            // 
            this.checkLink2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkLink2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.checkLink2.Location = new System.Drawing.Point(8, 439);
            this.checkLink2.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.checkLink2.Name = "checkLink2";
            this.checkLink2.Size = new System.Drawing.Size(440, 28);
            this.checkLink2.TabIndex = 9;
            this.checkLink2.Text = "纠偏相机连接";
            this.checkLink2.CheckedChanged += new System.EventHandler(this.link_CheckedChanged);
            // 
            // checkLink3
            // 
            this.checkLink3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkLink3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.checkLink3.Location = new System.Drawing.Point(8, 475);
            this.checkLink3.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.checkLink3.Name = "checkLink3";
            this.checkLink3.Size = new System.Drawing.Size(440, 28);
            this.checkLink3.TabIndex = 10;
            this.checkLink3.Text = "扫码枪连接";
            this.checkLink3.CheckedChanged += new System.EventHandler(this.link_CheckedChanged);
            // 
            // checkLink4
            // 
            this.checkLink4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkLink4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.checkLink4.Location = new System.Drawing.Point(8, 511);
            this.checkLink4.Margin = new System.Windows.Forms.Padding(8, 4, 4, 4);
            this.checkLink4.Name = "checkLink4";
            this.checkLink4.Size = new System.Drawing.Size(440, 28);
            this.checkLink4.TabIndex = 11;
            this.checkLink4.Text = "机械手连接";
            this.checkLink4.CheckedChanged += new System.EventHandler(this.link_CheckedChanged);
            // 
            // btnLinksAll
            // 
            this.btnLinksAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLinksAll.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.btnLinksAll.Location = new System.Drawing.Point(4, 551);
            this.btnLinksAll.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLinksAll.Name = "btnLinksAll";
            this.btnLinksAll.Size = new System.Drawing.Size(444, 42);
            this.btnLinksAll.TabIndex = 12;
            this.btnLinksAll.Text = "全部置连接 OK";
            this.btnLinksAll.UseVisualStyleBackColor = true;
            this.btnLinksAll.Click += new System.EventHandler(this.btnLinksAll_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.statusLabel.Location = new System.Drawing.Point(3, 597);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(446, 45);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "机台线程：未启动";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // logPanel
            // 
            this.logPanel.ColumnCount = 1;
            this.logPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logPanel.Controls.Add(this.logHeader, 0, 0);
            this.logPanel.Controls.Add(this.eventList, 0, 1);
            this.logPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logPanel.Location = new System.Drawing.Point(479, 9);
            this.logPanel.Name = "logPanel";
            this.logPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.logPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logPanel.Size = new System.Drawing.Size(692, 642);
            this.logPanel.TabIndex = 1;
            // 
            // logHeader
            // 
            this.logHeader.ColumnCount = 2;
            this.logHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logHeader.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.logHeader.Controls.Add(this.logTitle, 0, 0);
            this.logHeader.Controls.Add(this.btnClearLog, 1, 0);
            this.logHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logHeader.Location = new System.Drawing.Point(3, 3);
            this.logHeader.Name = "logHeader";
            this.logHeader.RowCount = 1;
            this.logHeader.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.logHeader.Size = new System.Drawing.Size(686, 42);
            this.logHeader.TabIndex = 0;
            // 
            // logTitle
            // 
            this.logTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logTitle.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.logTitle.Location = new System.Drawing.Point(3, 0);
            this.logTitle.Name = "logTitle";
            this.logTitle.Size = new System.Drawing.Size(570, 42);
            this.logTitle.TabIndex = 0;
            this.logTitle.Text = "机台事件";
            this.logTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnClearLog
            // 
            this.btnClearLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearLog.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.btnClearLog.Location = new System.Drawing.Point(580, 4);
            this.btnClearLog.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearLog.Name = "btnClearLog";
            this.btnClearLog.Size = new System.Drawing.Size(102, 34);
            this.btnClearLog.TabIndex = 1;
            this.btnClearLog.Text = "清空";
            this.btnClearLog.UseVisualStyleBackColor = true;
            this.btnClearLog.Click += new System.EventHandler(this.btnClearLog_Click);
            // 
            // eventList
            // 
            this.eventList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eventList.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.eventList.IntegralHeight = false;
            this.eventList.ItemHeight = 20;
            this.eventList.Location = new System.Drawing.Point(3, 51);
            this.eventList.Name = "eventList";
            this.eventList.Size = new System.Drawing.Size(686, 588);
            this.eventList.TabIndex = 1;
            // 
            // refresh
            // 
            this.refresh.Interval = 500;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageMachineSimulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.root);
            this.Name = "PageMachineSimulator";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.modeRow.ResumeLayout(false);
            this.cycleRow.ResumeLayout(false);
            this.cycleRow.PerformLayout();
            this.alarmRow.ResumeLayout(false);
            this.alarmRow.PerformLayout();
            this.channelRow.ResumeLayout(false);
            this.channelRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAlarmEvery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericChannel)).EndInit();
            this.logPanel.ResumeLayout(false);
            this.logHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.TableLayoutPanel modeRow;
        private System.Windows.Forms.Label modeTitle;
        private System.Windows.Forms.Button btnMa;
        private System.Windows.Forms.TableLayoutPanel cycleRow;
        private System.Windows.Forms.Label cycleTitle;
        private System.Windows.Forms.NumericUpDown numericCycle;
        private System.Windows.Forms.TableLayoutPanel alarmRow;
        private System.Windows.Forms.Label alarmTitle;
        private System.Windows.Forms.NumericUpDown numericAlarmEvery;
        private System.Windows.Forms.TableLayoutPanel channelRow;
        private System.Windows.Forms.Label channelTitle;
        private System.Windows.Forms.NumericUpDown numericChannel;
        private System.Windows.Forms.Button btnInjectAlarm;
        private System.Windows.Forms.Label linkTitle;
        private System.Windows.Forms.CheckBox checkLink1;
        private System.Windows.Forms.CheckBox checkLink2;
        private System.Windows.Forms.CheckBox checkLink3;
        private System.Windows.Forms.CheckBox checkLink4;
        private System.Windows.Forms.Button btnLinksAll;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.TableLayoutPanel logPanel;
        private System.Windows.Forms.TableLayoutPanel logHeader;
        private System.Windows.Forms.Label logTitle;
        private System.Windows.Forms.Button btnClearLog;
        private System.Windows.Forms.ListBox eventList;
        private System.Windows.Forms.Timer refresh;
    }
}
