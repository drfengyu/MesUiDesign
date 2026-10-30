namespace Mes.Hmi
{
    partial class PageHome
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
            this.actionPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEStop = new System.Windows.Forms.Button();
            this.btnRefillLeft = new System.Windows.Forms.Button();
            this.btnRefillRight = new System.Windows.Forms.Button();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnMute = new System.Windows.Forms.Button();
            this.midLayout = new System.Windows.Forms.TableLayoutPanel();
            this.stationPanel = new System.Windows.Forms.TableLayoutPanel();
            this.slideTabs = new System.Windows.Forms.TabControl();
            this.tabLeft = new System.Windows.Forms.TabPage();
            this.tabRight = new System.Windows.Forms.TabPage();
            this.slideStatusLabel = new System.Windows.Forms.Label();
            this.linkPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lampCamera = new System.Windows.Forms.Label();
            this.lampOffset = new System.Windows.Forms.Label();
            this.lampScanner = new System.Windows.Forms.Label();
            this.lampRobot = new System.Windows.Forms.Label();
            this.cavityTable = new System.Windows.Forms.TableLayoutPanel();
            this.cavityName1 = new System.Windows.Forms.Label();
            this.cavityState1 = new System.Windows.Forms.Label();
            this.cavityName2 = new System.Windows.Forms.Label();
            this.cavityState2 = new System.Windows.Forms.Label();
            this.cavityName3 = new System.Windows.Forms.Label();
            this.cavityState3 = new System.Windows.Forms.Label();
            this.cavityName4 = new System.Windows.Forms.Label();
            this.cavityState4 = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.codePanel = new System.Windows.Forms.TableLayoutPanel();
            this.lblLeftCode = new System.Windows.Forms.Label();
            this.txtLeftCode = new System.Windows.Forms.TextBox();
            this.lblRightCode = new System.Windows.Forms.Label();
            this.txtRightCode = new System.Windows.Forms.TextBox();
            this.lblWorkOrder = new System.Windows.Forms.Label();
            this.txtWorkOrder = new System.Windows.Forms.TextBox();
            this.lblFixture = new System.Windows.Forms.Label();
            this.txtFixture = new System.Windows.Forms.TextBox();
            this.alarmTitle = new System.Windows.Forms.Label();
            this.alarmList = new System.Windows.Forms.ListBox();
            this.batchPanel = new System.Windows.Forms.TableLayoutPanel();
            this.batchTable = new System.Windows.Forms.TableLayoutPanel();
            this.lblInput = new System.Windows.Forms.Label();
            this.valInput = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.valOutput = new System.Windows.Forms.Label();
            this.lblNg = new System.Windows.Forms.Label();
            this.valNg = new System.Windows.Forms.Label();
            this.lblYield = new System.Windows.Forms.Label();
            this.valYield = new System.Windows.Forms.Label();
            this.lblCt = new System.Windows.Forms.Label();
            this.valCt = new System.Windows.Forms.Label();
            this.btnResetBatch = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.actionPanel.SuspendLayout();
            this.midLayout.SuspendLayout();
            this.stationPanel.SuspendLayout();
            this.slideTabs.SuspendLayout();
            this.linkPanel.SuspendLayout();
            this.cavityTable.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.codePanel.SuspendLayout();
            this.batchPanel.SuspendLayout();
            this.batchTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.actionPanel, 0, 0);
            this.root.Controls.Add(this.midLayout, 0, 1);
            this.root.Controls.Add(this.batchPanel, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(6);
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // actionPanel
            // 
            this.actionPanel.ColumnCount = 4;
            this.actionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.actionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.actionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.actionPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.actionPanel.Controls.Add(this.btnReset, 0, 0);
            this.actionPanel.Controls.Add(this.btnEStop, 1, 0);
            this.actionPanel.Controls.Add(this.btnRefillLeft, 2, 0);
            this.actionPanel.Controls.Add(this.btnRefillRight, 3, 0);
            this.actionPanel.Controls.Add(this.btnChart, 0, 1);
            this.actionPanel.Controls.Add(this.btnMute, 1, 1);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.actionPanel.Location = new System.Drawing.Point(9, 9);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.RowCount = 2;
            this.actionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.actionPanel.Size = new System.Drawing.Size(1162, 102);
            this.actionPanel.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReset.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(4, 4);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(282, 43);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "复位";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEStop
            // 
            this.btnEStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.btnEStop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEStop.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnEStop.Location = new System.Drawing.Point(294, 4);
            this.btnEStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnEStop.Name = "btnEStop";
            this.btnEStop.Size = new System.Drawing.Size(282, 43);
            this.btnEStop.TabIndex = 1;
            this.btnEStop.Text = "急停";
            this.btnEStop.UseVisualStyleBackColor = false;
            this.btnEStop.Click += new System.EventHandler(this.btnEStop_Click);
            // 
            // btnRefillLeft
            // 
            this.btnRefillLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefillLeft.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRefillLeft.Location = new System.Drawing.Point(584, 4);
            this.btnRefillLeft.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefillLeft.Name = "btnRefillLeft";
            this.btnRefillLeft.Size = new System.Drawing.Size(282, 43);
            this.btnRefillLeft.TabIndex = 2;
            this.btnRefillLeft.Text = "左料仓手动补料";
            this.btnRefillLeft.UseVisualStyleBackColor = true;
            this.btnRefillLeft.Click += new System.EventHandler(this.btnRefillLeft_Click);
            // 
            // btnRefillRight
            // 
            this.btnRefillRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRefillRight.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnRefillRight.Location = new System.Drawing.Point(874, 4);
            this.btnRefillRight.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefillRight.Name = "btnRefillRight";
            this.btnRefillRight.Size = new System.Drawing.Size(284, 43);
            this.btnRefillRight.TabIndex = 3;
            this.btnRefillRight.Text = "右料仓手动补料";
            this.btnRefillRight.UseVisualStyleBackColor = true;
            this.btnRefillRight.Click += new System.EventHandler(this.btnRefillRight_Click);
            // 
            // btnChart
            // 
            this.btnChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChart.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnChart.Location = new System.Drawing.Point(4, 55);
            this.btnChart.Margin = new System.Windows.Forms.Padding(4);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(282, 43);
            this.btnChart.TabIndex = 4;
            this.btnChart.Text = "图形测试";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnMute
            // 
            this.btnMute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMute.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnMute.Location = new System.Drawing.Point(294, 55);
            this.btnMute.Margin = new System.Windows.Forms.Padding(4);
            this.btnMute.Name = "btnMute";
            this.btnMute.Size = new System.Drawing.Size(282, 43);
            this.btnMute.TabIndex = 5;
            this.btnMute.Text = "屏蔽蜂鸣";
            this.btnMute.UseVisualStyleBackColor = true;
            this.btnMute.Click += new System.EventHandler(this.btnMute_Click);
            // 
            // midLayout
            // 
            this.midLayout.ColumnCount = 2;
            this.midLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.midLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.midLayout.Controls.Add(this.stationPanel, 0, 0);
            this.midLayout.Controls.Add(this.rightPanel, 1, 0);
            this.midLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.midLayout.Location = new System.Drawing.Point(9, 117);
            this.midLayout.Name = "midLayout";
            this.midLayout.Size = new System.Drawing.Size(1162, 402);
            this.midLayout.TabIndex = 1;
            // 
            // stationPanel
            // 
            this.stationPanel.ColumnCount = 1;
            this.stationPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.stationPanel.Controls.Add(this.slideTabs, 0, 0);
            this.stationPanel.Controls.Add(this.slideStatusLabel, 0, 1);
            this.stationPanel.Controls.Add(this.linkPanel, 0, 2);
            this.stationPanel.Controls.Add(this.cavityTable, 0, 3);
            this.stationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stationPanel.Location = new System.Drawing.Point(3, 3);
            this.stationPanel.Name = "stationPanel";
            this.stationPanel.Padding = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.stationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.stationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.stationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.stationPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.stationPanel.Size = new System.Drawing.Size(826, 404);
            this.stationPanel.TabIndex = 0;
            // 
            // slideTabs
            // 
            this.slideTabs.Controls.Add(this.tabLeft);
            this.slideTabs.Controls.Add(this.tabRight);
            this.slideTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideTabs.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.slideTabs.Location = new System.Drawing.Point(3, 3);
            this.slideTabs.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.slideTabs.Name = "slideTabs";
            this.slideTabs.SelectedIndex = 0;
            this.slideTabs.Size = new System.Drawing.Size(812, 35);
            this.slideTabs.TabIndex = 0;
            this.slideTabs.SelectedIndexChanged += new System.EventHandler(this.slideTabs_SelectedIndexChanged);
            // 
            // tabLeft
            // 
            this.tabLeft.Location = new System.Drawing.Point(4, 28);
            this.tabLeft.Name = "tabLeft";
            this.tabLeft.Size = new System.Drawing.Size(804, 3);
            this.tabLeft.TabIndex = 0;
            this.tabLeft.Text = "左滑台";
            this.tabLeft.UseVisualStyleBackColor = true;
            // 
            // tabRight
            // 
            this.tabRight.Location = new System.Drawing.Point(4, 28);
            this.tabRight.Name = "tabRight";
            this.tabRight.Size = new System.Drawing.Size(804, 3);
            this.tabRight.TabIndex = 1;
            this.tabRight.Text = "右滑台";
            this.tabRight.UseVisualStyleBackColor = true;
            // 
            // slideStatusLabel
            // 
            this.slideStatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.slideStatusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.slideStatusLabel.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.slideStatusLabel.Location = new System.Drawing.Point(3, 38);
            this.slideStatusLabel.Name = "slideStatusLabel";
            this.slideStatusLabel.Size = new System.Drawing.Size(812, 30);
            this.slideStatusLabel.TabIndex = 1;
            this.slideStatusLabel.Text = "滑台状态OK,等待上料...";
            this.slideStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // linkPanel
            // 
            this.linkPanel.ColumnCount = 4;
            this.linkPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.linkPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.linkPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.linkPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.linkPanel.Controls.Add(this.lampCamera, 0, 0);
            this.linkPanel.Controls.Add(this.lampOffset, 1, 0);
            this.linkPanel.Controls.Add(this.lampScanner, 2, 0);
            this.linkPanel.Controls.Add(this.lampRobot, 3, 0);
            this.linkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkPanel.Location = new System.Drawing.Point(3, 71);
            this.linkPanel.Name = "linkPanel";
            this.linkPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.linkPanel.Size = new System.Drawing.Size(812, 28);
            this.linkPanel.TabIndex = 2;
            // 
            // lampCamera
            // 
            this.lampCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lampCamera.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lampCamera.Location = new System.Drawing.Point(3, 0);
            this.lampCamera.Name = "lampCamera";
            this.lampCamera.Size = new System.Drawing.Size(197, 28);
            this.lampCamera.TabIndex = 0;
            this.lampCamera.Text = "定位相机连接OK";
            this.lampCamera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lampOffset
            // 
            this.lampOffset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lampOffset.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lampOffset.Location = new System.Drawing.Point(206, 0);
            this.lampOffset.Name = "lampOffset";
            this.lampOffset.Size = new System.Drawing.Size(197, 28);
            this.lampOffset.TabIndex = 1;
            this.lampOffset.Text = "纠偏相机连接OK";
            this.lampOffset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lampScanner
            // 
            this.lampScanner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lampScanner.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lampScanner.Location = new System.Drawing.Point(409, 0);
            this.lampScanner.Name = "lampScanner";
            this.lampScanner.Size = new System.Drawing.Size(197, 28);
            this.lampScanner.TabIndex = 2;
            this.lampScanner.Text = "扫码枪连接OK";
            this.lampScanner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lampRobot
            // 
            this.lampRobot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lampRobot.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lampRobot.Location = new System.Drawing.Point(612, 0);
            this.lampRobot.Name = "lampRobot";
            this.lampRobot.Size = new System.Drawing.Size(197, 28);
            this.lampRobot.TabIndex = 3;
            this.lampRobot.Text = "机械手连接OK";
            this.lampRobot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cavityTable
            // 
            this.cavityTable.ColumnCount = 2;
            this.cavityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.cavityTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cavityTable.Controls.Add(this.cavityName1, 0, 0);
            this.cavityTable.Controls.Add(this.cavityState1, 1, 0);
            this.cavityTable.Controls.Add(this.cavityName2, 0, 1);
            this.cavityTable.Controls.Add(this.cavityState2, 1, 1);
            this.cavityTable.Controls.Add(this.cavityName3, 0, 2);
            this.cavityTable.Controls.Add(this.cavityState3, 1, 2);
            this.cavityTable.Controls.Add(this.cavityName4, 0, 3);
            this.cavityTable.Controls.Add(this.cavityState4, 1, 3);
            this.cavityTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityTable.Location = new System.Drawing.Point(3, 105);
            this.cavityTable.Name = "cavityTable";
            this.cavityTable.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.cavityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cavityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cavityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cavityTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.cavityTable.Size = new System.Drawing.Size(812, 296);
            this.cavityTable.TabIndex = 3;
            // 
            // cavityName1
            // 
            this.cavityName1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityName1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.cavityName1.Location = new System.Drawing.Point(4, 8);
            this.cavityName1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cavityName1.Name = "cavityName1";
            this.cavityName1.Size = new System.Drawing.Size(122, 68);
            this.cavityName1.TabIndex = 0;
            this.cavityName1.Text = "Cavity-1";
            // 
            // cavityState1
            // 
            this.cavityState1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityState1.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cavityState1.Location = new System.Drawing.Point(134, 8);
            this.cavityState1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cavityState1.Name = "cavityState1";
            this.cavityState1.Size = new System.Drawing.Size(674, 68);
            this.cavityState1.TabIndex = 1;
            this.cavityState1.Text = "腔体正常，正在等待装载零件";
            this.cavityState1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cavityName2
            // 
            this.cavityName2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityName2.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.cavityName2.Location = new System.Drawing.Point(4, 80);
            this.cavityName2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cavityName2.Name = "cavityName2";
            this.cavityName2.Size = new System.Drawing.Size(122, 68);
            this.cavityName2.TabIndex = 2;
            this.cavityName2.Text = "Cavity-2";
            // 
            // cavityState2
            // 
            this.cavityState2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityState2.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cavityState2.Location = new System.Drawing.Point(134, 80);
            this.cavityState2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cavityState2.Name = "cavityState2";
            this.cavityState2.Size = new System.Drawing.Size(674, 68);
            this.cavityState2.TabIndex = 3;
            this.cavityState2.Text = "腔体正常，正在等待装载零件";
            this.cavityState2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cavityName3
            // 
            this.cavityName3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityName3.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.cavityName3.Location = new System.Drawing.Point(4, 152);
            this.cavityName3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cavityName3.Name = "cavityName3";
            this.cavityName3.Size = new System.Drawing.Size(122, 68);
            this.cavityName3.TabIndex = 4;
            this.cavityName3.Text = "Cavity-3";
            // 
            // cavityState3
            // 
            this.cavityState3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityState3.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cavityState3.Location = new System.Drawing.Point(134, 152);
            this.cavityState3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cavityState3.Name = "cavityState3";
            this.cavityState3.Size = new System.Drawing.Size(674, 68);
            this.cavityState3.TabIndex = 5;
            this.cavityState3.Text = "腔体正常，正在等待装载零件";
            this.cavityState3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cavityName4
            // 
            this.cavityName4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityName4.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.cavityName4.Location = new System.Drawing.Point(4, 224);
            this.cavityName4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cavityName4.Name = "cavityName4";
            this.cavityName4.Size = new System.Drawing.Size(122, 70);
            this.cavityName4.TabIndex = 6;
            this.cavityName4.Text = "Cavity-4";
            // 
            // cavityState4
            // 
            this.cavityState4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cavityState4.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.cavityState4.Location = new System.Drawing.Point(134, 224);
            this.cavityState4.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cavityState4.Name = "cavityState4";
            this.cavityState4.Size = new System.Drawing.Size(674, 70);
            this.cavityState4.TabIndex = 7;
            this.cavityState4.Text = "腔体正常，正在等待装载零件";
            this.cavityState4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rightPanel
            // 
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Controls.Add(this.codePanel, 0, 0);
            this.rightPanel.Controls.Add(this.alarmTitle, 0, 1);
            this.rightPanel.Controls.Add(this.alarmList, 0, 2);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(835, 3);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 148F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Size = new System.Drawing.Size(324, 404);
            this.rightPanel.TabIndex = 1;
            // 
            // codePanel
            // 
            this.codePanel.ColumnCount = 2;
            this.codePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.codePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.codePanel.Controls.Add(this.lblLeftCode, 0, 0);
            this.codePanel.Controls.Add(this.txtLeftCode, 1, 0);
            this.codePanel.Controls.Add(this.lblRightCode, 0, 1);
            this.codePanel.Controls.Add(this.txtRightCode, 1, 1);
            this.codePanel.Controls.Add(this.lblWorkOrder, 0, 2);
            this.codePanel.Controls.Add(this.txtWorkOrder, 1, 2);
            this.codePanel.Controls.Add(this.lblFixture, 0, 3);
            this.codePanel.Controls.Add(this.txtFixture, 1, 3);
            this.codePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codePanel.Location = new System.Drawing.Point(3, 3);
            this.codePanel.Name = "codePanel";
            this.codePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.codePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.codePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.codePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.codePanel.Size = new System.Drawing.Size(318, 142);
            this.codePanel.TabIndex = 0;
            // 
            // lblLeftCode
            // 
            this.lblLeftCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftCode.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblLeftCode.Location = new System.Drawing.Point(3, 0);
            this.lblLeftCode.Name = "lblLeftCode";
            this.lblLeftCode.Size = new System.Drawing.Size(94, 35);
            this.lblLeftCode.TabIndex = 0;
            this.lblLeftCode.Text = "左HAF码";
            this.lblLeftCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtLeftCode
            // 
            this.txtLeftCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLeftCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtLeftCode.Location = new System.Drawing.Point(103, 6);
            this.txtLeftCode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtLeftCode.Name = "txtLeftCode";
            this.txtLeftCode.ReadOnly = true;
            this.txtLeftCode.Size = new System.Drawing.Size(212, 27);
            this.txtLeftCode.TabIndex = 1;
            // 
            // lblRightCode
            // 
            this.lblRightCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightCode.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblRightCode.Location = new System.Drawing.Point(3, 35);
            this.lblRightCode.Name = "lblRightCode";
            this.lblRightCode.Size = new System.Drawing.Size(94, 35);
            this.lblRightCode.TabIndex = 2;
            this.lblRightCode.Text = "右HAF码";
            this.lblRightCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtRightCode
            // 
            this.txtRightCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRightCode.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtRightCode.Location = new System.Drawing.Point(103, 41);
            this.txtRightCode.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtRightCode.Name = "txtRightCode";
            this.txtRightCode.ReadOnly = true;
            this.txtRightCode.Size = new System.Drawing.Size(212, 27);
            this.txtRightCode.TabIndex = 3;
            // 
            // lblWorkOrder
            // 
            this.lblWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWorkOrder.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblWorkOrder.Location = new System.Drawing.Point(3, 70);
            this.lblWorkOrder.Name = "lblWorkOrder";
            this.lblWorkOrder.Size = new System.Drawing.Size(94, 35);
            this.lblWorkOrder.TabIndex = 4;
            this.lblWorkOrder.Text = "工单号";
            this.lblWorkOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtWorkOrder
            // 
            this.txtWorkOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtWorkOrder.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtWorkOrder.Location = new System.Drawing.Point(103, 76);
            this.txtWorkOrder.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtWorkOrder.Name = "txtWorkOrder";
            this.txtWorkOrder.Size = new System.Drawing.Size(212, 27);
            this.txtWorkOrder.TabIndex = 5;
            this.txtWorkOrder.Leave += new System.EventHandler(this.txtWorkOrder_Leave);
            // 
            // lblFixture
            // 
            this.lblFixture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFixture.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lblFixture.Location = new System.Drawing.Point(3, 105);
            this.lblFixture.Name = "lblFixture";
            this.lblFixture.Size = new System.Drawing.Size(94, 37);
            this.lblFixture.TabIndex = 6;
            this.lblFixture.Text = "当前治具";
            this.lblFixture.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFixture
            // 
            this.txtFixture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFixture.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.txtFixture.Location = new System.Drawing.Point(103, 111);
            this.txtFixture.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.txtFixture.Name = "txtFixture";
            this.txtFixture.ReadOnly = true;
            this.txtFixture.Size = new System.Drawing.Size(212, 27);
            this.txtFixture.TabIndex = 7;
            // 
            // alarmTitle
            // 
            this.alarmTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alarmTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alarmTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.alarmTitle.Location = new System.Drawing.Point(3, 148);
            this.alarmTitle.Name = "alarmTitle";
            this.alarmTitle.Size = new System.Drawing.Size(318, 26);
            this.alarmTitle.TabIndex = 1;
            this.alarmTitle.Text = "报警信息";
            this.alarmTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alarmList
            // 
            this.alarmList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.alarmList.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.alarmList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.alarmList.IntegralHeight = false;
            this.alarmList.ItemHeight = 19;
            this.alarmList.Location = new System.Drawing.Point(3, 177);
            this.alarmList.Name = "alarmList";
            this.alarmList.Size = new System.Drawing.Size(318, 224);
            this.alarmList.TabIndex = 2;
            // 
            // batchPanel
            // 
            this.batchPanel.ColumnCount = 2;
            this.batchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.batchPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.batchPanel.Controls.Add(this.batchTable, 0, 0);
            this.batchPanel.Controls.Add(this.btnResetBatch, 1, 0);
            this.batchPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batchPanel.Location = new System.Drawing.Point(9, 525);
            this.batchPanel.Name = "batchPanel";
            this.batchPanel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.batchPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.batchPanel.Size = new System.Drawing.Size(1162, 126);
            this.batchPanel.TabIndex = 2;
            // 
            // batchTable
            // 
            this.batchTable.ColumnCount = 2;
            this.batchTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.batchTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.batchTable.Controls.Add(this.lblInput, 0, 0);
            this.batchTable.Controls.Add(this.valInput, 1, 0);
            this.batchTable.Controls.Add(this.lblOutput, 0, 1);
            this.batchTable.Controls.Add(this.valOutput, 1, 1);
            this.batchTable.Controls.Add(this.lblNg, 0, 2);
            this.batchTable.Controls.Add(this.valNg, 1, 2);
            this.batchTable.Controls.Add(this.lblYield, 0, 3);
            this.batchTable.Controls.Add(this.valYield, 1, 3);
            this.batchTable.Controls.Add(this.lblCt, 0, 4);
            this.batchTable.Controls.Add(this.valCt, 1, 4);
            this.batchTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.batchTable.Location = new System.Drawing.Point(3, 9);
            this.batchTable.Name = "batchTable";
            this.batchTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.batchTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.batchTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.batchTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.batchTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.batchTable.Size = new System.Drawing.Size(826, 114);
            this.batchTable.TabIndex = 0;
            // 
            // lblInput
            // 
            this.lblInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInput.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblInput.Location = new System.Drawing.Point(3, 0);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(124, 22);
            this.lblInput.TabIndex = 0;
            this.lblInput.Text = "投入数量";
            this.lblInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valInput
            // 
            this.valInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valInput.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.valInput.Location = new System.Drawing.Point(133, 0);
            this.valInput.Name = "valInput";
            this.valInput.Size = new System.Drawing.Size(690, 22);
            this.valInput.TabIndex = 1;
            this.valInput.Text = "0";
            this.valInput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblOutput
            // 
            this.lblOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOutput.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblOutput.Location = new System.Drawing.Point(3, 22);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(124, 22);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "产出数量";
            this.lblOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valOutput
            // 
            this.valOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valOutput.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.valOutput.Location = new System.Drawing.Point(133, 22);
            this.valOutput.Name = "valOutput";
            this.valOutput.Size = new System.Drawing.Size(690, 22);
            this.valOutput.TabIndex = 3;
            this.valOutput.Text = "0";
            this.valOutput.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNg
            // 
            this.lblNg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNg.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblNg.Location = new System.Drawing.Point(3, 44);
            this.lblNg.Name = "lblNg";
            this.lblNg.Size = new System.Drawing.Size(124, 22);
            this.lblNg.TabIndex = 4;
            this.lblNg.Text = "NG数量";
            this.lblNg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valNg
            // 
            this.valNg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valNg.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.valNg.Location = new System.Drawing.Point(133, 44);
            this.valNg.Name = "valNg";
            this.valNg.Size = new System.Drawing.Size(690, 22);
            this.valNg.TabIndex = 5;
            this.valNg.Text = "0";
            this.valNg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYield
            // 
            this.lblYield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblYield.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblYield.Location = new System.Drawing.Point(3, 66);
            this.lblYield.Name = "lblYield";
            this.lblYield.Size = new System.Drawing.Size(124, 22);
            this.lblYield.TabIndex = 6;
            this.lblYield.Text = "良率";
            this.lblYield.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valYield
            // 
            this.valYield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valYield.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.valYield.Location = new System.Drawing.Point(133, 66);
            this.valYield.Name = "valYield";
            this.valYield.Size = new System.Drawing.Size(690, 22);
            this.valYield.TabIndex = 7;
            this.valYield.Text = "0";
            this.valYield.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCt
            // 
            this.lblCt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCt.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.lblCt.Location = new System.Drawing.Point(3, 88);
            this.lblCt.Name = "lblCt";
            this.lblCt.Size = new System.Drawing.Size(124, 26);
            this.lblCt.TabIndex = 8;
            this.lblCt.Text = "CT(s)";
            this.lblCt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // valCt
            // 
            this.valCt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valCt.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.valCt.Location = new System.Drawing.Point(133, 88);
            this.valCt.Name = "valCt";
            this.valCt.Size = new System.Drawing.Size(690, 26);
            this.valCt.TabIndex = 9;
            this.valCt.Text = "0";
            this.valCt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnResetBatch
            // 
            this.btnResetBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetBatch.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.btnResetBatch.Location = new System.Drawing.Point(836, 10);
            this.btnResetBatch.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetBatch.Name = "btnResetBatch";
            this.btnResetBatch.Size = new System.Drawing.Size(322, 112);
            this.btnResetBatch.TabIndex = 1;
            this.btnResetBatch.Text = "重置批次统计数据";
            this.btnResetBatch.UseVisualStyleBackColor = true;
            this.btnResetBatch.Click += new System.EventHandler(this.btnResetBatch_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 500;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.root);
            this.Name = "PageHome";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.actionPanel.ResumeLayout(false);
            this.midLayout.ResumeLayout(false);
            this.stationPanel.ResumeLayout(false);
            this.slideTabs.ResumeLayout(false);
            this.linkPanel.ResumeLayout(false);
            this.cavityTable.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.codePanel.ResumeLayout(false);
            this.codePanel.PerformLayout();
            this.batchPanel.ResumeLayout(false);
            this.batchTable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel actionPanel;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEStop;
        private System.Windows.Forms.Button btnRefillLeft;
        private System.Windows.Forms.Button btnRefillRight;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnMute;
        private System.Windows.Forms.TableLayoutPanel midLayout;
        private System.Windows.Forms.TableLayoutPanel stationPanel;
        private System.Windows.Forms.TabControl slideTabs;
        private System.Windows.Forms.TabPage tabLeft;
        private System.Windows.Forms.TabPage tabRight;
        private System.Windows.Forms.Label slideStatusLabel;
        private System.Windows.Forms.TableLayoutPanel linkPanel;
        private System.Windows.Forms.Label lampCamera;
        private System.Windows.Forms.Label lampOffset;
        private System.Windows.Forms.Label lampScanner;
        private System.Windows.Forms.Label lampRobot;
        private System.Windows.Forms.TableLayoutPanel cavityTable;
        private System.Windows.Forms.Label cavityName1;
        private System.Windows.Forms.Label cavityState1;
        private System.Windows.Forms.Label cavityName2;
        private System.Windows.Forms.Label cavityState2;
        private System.Windows.Forms.Label cavityName3;
        private System.Windows.Forms.Label cavityState3;
        private System.Windows.Forms.Label cavityName4;
        private System.Windows.Forms.Label cavityState4;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private System.Windows.Forms.TableLayoutPanel codePanel;
        private System.Windows.Forms.Label lblLeftCode;
        private System.Windows.Forms.TextBox txtLeftCode;
        private System.Windows.Forms.Label lblRightCode;
        private System.Windows.Forms.TextBox txtRightCode;
        private System.Windows.Forms.Label lblWorkOrder;
        private System.Windows.Forms.TextBox txtWorkOrder;
        private System.Windows.Forms.Label lblFixture;
        private System.Windows.Forms.TextBox txtFixture;
        private System.Windows.Forms.Label alarmTitle;
        private System.Windows.Forms.ListBox alarmList;
        private System.Windows.Forms.TableLayoutPanel batchPanel;
        private System.Windows.Forms.TableLayoutPanel batchTable;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label valInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label valOutput;
        private System.Windows.Forms.Label lblNg;
        private System.Windows.Forms.Label valNg;
        private System.Windows.Forms.Label lblYield;
        private System.Windows.Forms.Label valYield;
        private System.Windows.Forms.Label lblCt;
        private System.Windows.Forms.Label valCt;
        private System.Windows.Forms.Button btnResetBatch;
        private System.Windows.Forms.Timer refresh;
    }
}
