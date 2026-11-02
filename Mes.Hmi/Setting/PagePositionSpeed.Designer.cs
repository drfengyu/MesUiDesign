namespace Mes.Hmi.Setting
{
    partial class PagePositionSpeed
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.topTabs = new System.Windows.Forms.TableLayoutPanel();
            this.radioAxis = new System.Windows.Forms.RadioButton();
            this.radioIo = new System.Windows.Forms.RadioButton();
            this.topSpacer = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.Panel();
            this.axisPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupBar = new System.Windows.Forms.TableLayoutPanel();
            this.groupLabel = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.axisGrid = new System.Windows.Forms.DataGridView();
            this.colPosLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colMinus = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitPlus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLimitMinus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExcited = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHomed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jogBar = new System.Windows.Forms.TableLayoutPanel();
            this.speedLabel = new System.Windows.Forms.Label();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.btnJog = new System.Windows.Forms.Button();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.btnInch = new System.Windows.Forms.Button();
            this.jogSpacer = new System.Windows.Forms.Panel();
            this.paramTabs = new System.Windows.Forms.TabControl();
            this.tabSystem = new System.Windows.Forms.TabPage();
            this.tabSpeed = new System.Windows.Forms.TabPage();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.tabVision = new System.Windows.Forms.TabPage();
            this.tabSwitch = new System.Windows.Forms.TabPage();
            this.tabPort = new System.Windows.Forms.TabPage();
            this.paramGrid = new System.Windows.Forms.DataGridView();
            this.colParamName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParamUpper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParamLower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParamValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paramButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnMovePoint = new System.Windows.Forms.Button();
            this.btnTeachPoint = new System.Windows.Forms.Button();
            this.btnSaveParam = new System.Windows.Forms.Button();
            this.paramSpacer = new System.Windows.Forms.Panel();
            this.ioPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ioInCard = new System.Windows.Forms.TableLayoutPanel();
            this.comboIn = new System.Windows.Forms.ComboBox();
            this.gridIn = new System.Windows.Forms.DataGridView();
            this.colInSignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ioOutCard = new System.Windows.Forms.TableLayoutPanel();
            this.comboOut = new System.Windows.Forms.ComboBox();
            this.gridOut = new System.Windows.Forms.DataGridView();
            this.colOutSignal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOutNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.jogTimer = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.topTabs.SuspendLayout();
            this.content.SuspendLayout();
            this.axisPanel.SuspendLayout();
            this.groupBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axisGrid)).BeginInit();
            this.jogBar.SuspendLayout();
            this.paramTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.paramGrid)).BeginInit();
            this.paramButtons.SuspendLayout();
            this.ioPanel.SuspendLayout();
            this.ioInCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridIn)).BeginInit();
            this.ioOutCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridOut)).BeginInit();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.topTabs, 0, 0);
            this.root.Controls.Add(this.content, 0, 1);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 2;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // topTabs
            // 
            this.topTabs.ColumnCount = 3;
            this.topTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.topTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 170F));
            this.topTabs.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTabs.Controls.Add(this.radioAxis, 0, 0);
            this.topTabs.Controls.Add(this.radioIo, 1, 0);
            this.topTabs.Controls.Add(this.topSpacer, 2, 0);
            this.topTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topTabs.Location = new System.Drawing.Point(4, 4);
            this.topTabs.Margin = new System.Windows.Forms.Padding(0);
            this.topTabs.Name = "topTabs";
            this.topTabs.RowCount = 1;
            this.topTabs.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topTabs.Size = new System.Drawing.Size(1172, 46);
            this.topTabs.TabIndex = 0;
            // 
            // radioAxis
            // 
            this.radioAxis.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioAxis.Checked = true;
            this.radioAxis.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioAxis.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(228)))), ((int)(((byte)(170)))));
            this.radioAxis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioAxis.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.radioAxis.Location = new System.Drawing.Point(0, 4);
            this.radioAxis.Margin = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.radioAxis.Name = "radioAxis";
            this.radioAxis.Size = new System.Drawing.Size(168, 42);
            this.radioAxis.TabIndex = 0;
            this.radioAxis.TabStop = true;
            this.radioAxis.Text = "轴马达";
            this.radioAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioAxis.UseVisualStyleBackColor = true;
            this.radioAxis.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioIo
            // 
            this.radioIo.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioIo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioIo.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(228)))), ((int)(((byte)(170)))));
            this.radioIo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioIo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.radioIo.Location = new System.Drawing.Point(172, 4);
            this.radioIo.Margin = new System.Windows.Forms.Padding(2, 4, 0, 0);
            this.radioIo.Name = "radioIo";
            this.radioIo.Size = new System.Drawing.Size(168, 42);
            this.radioIo.TabIndex = 1;
            this.radioIo.Text = "IO";
            this.radioIo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioIo.UseVisualStyleBackColor = true;
            // 
            // topSpacer
            // 
            this.topSpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topSpacer.Location = new System.Drawing.Point(340, 0);
            this.topSpacer.Margin = new System.Windows.Forms.Padding(0);
            this.topSpacer.Name = "topSpacer";
            this.topSpacer.Size = new System.Drawing.Size(832, 46);
            this.topSpacer.TabIndex = 2;
            // 
            // content
            // 
            this.content.Controls.Add(this.axisPanel);
            this.content.Controls.Add(this.ioPanel);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Location = new System.Drawing.Point(4, 50);
            this.content.Margin = new System.Windows.Forms.Padding(0);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(1172, 606);
            this.content.TabIndex = 1;
            // 
            // axisPanel
            // 
            this.axisPanel.ColumnCount = 1;
            this.axisPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.axisPanel.Controls.Add(this.groupBar, 0, 0);
            this.axisPanel.Controls.Add(this.axisGrid, 0, 1);
            this.axisPanel.Controls.Add(this.jogBar, 0, 2);
            this.axisPanel.Controls.Add(this.paramTabs, 0, 3);
            this.axisPanel.Controls.Add(this.paramGrid, 0, 4);
            this.axisPanel.Controls.Add(this.paramButtons, 0, 5);
            this.axisPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisPanel.Location = new System.Drawing.Point(0, 0);
            this.axisPanel.Margin = new System.Windows.Forms.Padding(0);
            this.axisPanel.Name = "axisPanel";
            this.axisPanel.RowCount = 6;
            this.axisPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.axisPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62F));
            this.axisPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.axisPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.axisPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38F));
            this.axisPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.axisPanel.Size = new System.Drawing.Size(1172, 606);
            this.axisPanel.TabIndex = 0;
            // 
            // groupBar
            // 
            this.groupBar.ColumnCount = 2;
            this.groupBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.groupBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupBar.Controls.Add(this.groupLabel, 0, 0);
            this.groupBar.Controls.Add(this.comboGroup, 1, 0);
            this.groupBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBar.Location = new System.Drawing.Point(0, 0);
            this.groupBar.Margin = new System.Windows.Forms.Padding(0);
            this.groupBar.Name = "groupBar";
            this.groupBar.RowCount = 1;
            this.groupBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.groupBar.Size = new System.Drawing.Size(1172, 36);
            this.groupBar.TabIndex = 0;
            // 
            // groupLabel
            // 
            this.groupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.groupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.groupLabel.Location = new System.Drawing.Point(0, 0);
            this.groupLabel.Margin = new System.Windows.Forms.Padding(0);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(110, 36);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "轴卡分组::";
            this.groupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboGroup
            // 
            this.comboGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroup.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(114, 5);
            this.comboGroup.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(1054, 27);
            this.comboGroup.TabIndex = 1;
            this.comboGroup.SelectedIndexChanged += new System.EventHandler(this.comboGroup_SelectedIndexChanged);
            // 
            // axisGrid
            // 
            this.axisGrid.AllowUserToAddRows = false;
            this.axisGrid.AllowUserToDeleteRows = false;
            this.axisGrid.AllowUserToResizeRows = false;
            this.axisGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.axisGrid.BackgroundColor = System.Drawing.Color.White;
            this.axisGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.axisGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.axisGrid.ColumnHeadersHeight = 30;
            this.axisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.axisGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPosLabel,
            this.colPos,
            this.colPlus,
            this.colMinus,
            this.colFault,
            this.colLimitPlus,
            this.colLimitMinus,
            this.colHome,
            this.colExcited,
            this.colHomed});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.axisGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.axisGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axisGrid.EnableHeadersVisualStyles = false;
            this.axisGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.axisGrid.Location = new System.Drawing.Point(0, 36);
            this.axisGrid.Margin = new System.Windows.Forms.Padding(0);
            this.axisGrid.MultiSelect = false;
            this.axisGrid.Name = "axisGrid";
            this.axisGrid.ReadOnly = true;
            this.axisGrid.RowHeadersVisible = false;
            this.axisGrid.RowTemplate.Height = 34;
            this.axisGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.axisGrid.Size = new System.Drawing.Size(1172, 260);
            this.axisGrid.TabIndex = 1;
            this.axisGrid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.axisGrid_CellMouseDown);
            this.axisGrid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.axisGrid_CellMouseUp);
            // 
            // colPosLabel
            // 
            this.colPosLabel.FillWeight = 9F;
            this.colPosLabel.HeaderText = "";
            this.colPosLabel.Name = "colPosLabel";
            this.colPosLabel.ReadOnly = true;
            this.colPosLabel.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPos
            // 
            this.colPos.FillWeight = 13F;
            this.colPos.HeaderText = "位置(mm)";
            this.colPos.Name = "colPos";
            this.colPos.ReadOnly = true;
            this.colPos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colPlus
            // 
            this.colPlus.FillWeight = 14F;
            this.colPlus.HeaderText = "点动+";
            this.colPlus.Name = "colPlus";
            this.colPlus.ReadOnly = true;
            this.colPlus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colMinus
            // 
            this.colMinus.FillWeight = 14F;
            this.colMinus.HeaderText = "点动-";
            this.colMinus.Name = "colMinus";
            this.colMinus.ReadOnly = true;
            this.colMinus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colFault
            // 
            this.colFault.FillWeight = 7.5F;
            this.colFault.HeaderText = "";
            this.colFault.Name = "colFault";
            this.colFault.ReadOnly = true;
            this.colFault.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colLimitPlus
            // 
            this.colLimitPlus.FillWeight = 7.5F;
            this.colLimitPlus.HeaderText = "";
            this.colLimitPlus.Name = "colLimitPlus";
            this.colLimitPlus.ReadOnly = true;
            this.colLimitPlus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colLimitMinus
            // 
            this.colLimitMinus.FillWeight = 7.5F;
            this.colLimitMinus.HeaderText = "";
            this.colLimitMinus.Name = "colLimitMinus";
            this.colLimitMinus.ReadOnly = true;
            this.colLimitMinus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colHome
            // 
            this.colHome.FillWeight = 7.5F;
            this.colHome.HeaderText = "";
            this.colHome.Name = "colHome";
            this.colHome.ReadOnly = true;
            this.colHome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colExcited
            // 
            this.colExcited.FillWeight = 7.5F;
            this.colExcited.HeaderText = "";
            this.colExcited.Name = "colExcited";
            this.colExcited.ReadOnly = true;
            this.colExcited.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colHomed
            // 
            this.colHomed.FillWeight = 7.5F;
            this.colHomed.HeaderText = "";
            this.colHomed.Name = "colHomed";
            this.colHomed.ReadOnly = true;
            this.colHomed.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // jogBar
            // 
            this.jogBar.ColumnCount = 5;
            this.jogBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.jogBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.jogBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.jogBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.jogBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.jogBar.Controls.Add(this.speedLabel, 0, 0);
            this.jogBar.Controls.Add(this.speedBox, 1, 0);
            this.jogBar.Controls.Add(this.btnJog, 2, 0);
            this.jogBar.Controls.Add(this.distanceLabel, 0, 1);
            this.jogBar.Controls.Add(this.distanceBox, 1, 1);
            this.jogBar.Controls.Add(this.btnInch, 2, 1);
            this.jogBar.Controls.Add(this.jogSpacer, 4, 0);
            this.jogBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jogBar.Location = new System.Drawing.Point(0, 296);
            this.jogBar.Margin = new System.Windows.Forms.Padding(0);
            this.jogBar.Name = "jogBar";
            this.jogBar.RowCount = 2;
            this.jogBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.jogBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.jogBar.Size = new System.Drawing.Size(1172, 72);
            this.jogBar.TabIndex = 2;
            // 
            // speedLabel
            // 
            this.speedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.speedLabel.Location = new System.Drawing.Point(0, 0);
            this.speedLabel.Margin = new System.Windows.Forms.Padding(0);
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(210, 36);
            this.speedLabel.TabIndex = 0;
            this.speedLabel.Text = "手动速度(mm/s)";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // speedBox
            // 
            this.speedBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.speedBox.Location = new System.Drawing.Point(216, 10);
            this.speedBox.Margin = new System.Windows.Forms.Padding(6, 10, 20, 10);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(138, 25);
            this.speedBox.TabIndex = 1;
            this.speedBox.Text = "10.000";
            this.speedBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnJog
            // 
            this.btnJog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.btnJog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnJog.FlatAppearance.BorderSize = 0;
            this.btnJog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJog.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnJog.ForeColor = System.Drawing.Color.White;
            this.btnJog.Location = new System.Drawing.Point(374, 8);
            this.btnJog.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.btnJog.Name = "btnJog";
            this.btnJog.Size = new System.Drawing.Size(226, 20);
            this.btnJog.TabIndex = 2;
            this.btnJog.Text = "Jog运动";
            this.btnJog.UseVisualStyleBackColor = false;
            this.btnJog.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnJog_MouseDown);
            this.btnJog.MouseLeave += new System.EventHandler(this.jog_MouseLeave);
            this.btnJog.MouseUp += new System.Windows.Forms.MouseEventHandler(this.jog_MouseUp);
            // 
            // distanceLabel
            // 
            this.distanceLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.distanceLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.distanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.distanceLabel.Location = new System.Drawing.Point(0, 36);
            this.distanceLabel.Margin = new System.Windows.Forms.Padding(0);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(210, 36);
            this.distanceLabel.TabIndex = 3;
            this.distanceLabel.Text = "手动距离(mm)";
            this.distanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // distanceBox
            // 
            this.distanceBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.distanceBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.distanceBox.Location = new System.Drawing.Point(216, 46);
            this.distanceBox.Margin = new System.Windows.Forms.Padding(6, 10, 20, 10);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.Size = new System.Drawing.Size(138, 25);
            this.distanceBox.TabIndex = 4;
            this.distanceBox.Text = "10.000";
            this.distanceBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnInch
            // 
            this.btnInch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(124)))));
            this.btnInch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInch.FlatAppearance.BorderSize = 0;
            this.btnInch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInch.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnInch.ForeColor = System.Drawing.Color.White;
            this.btnInch.Location = new System.Drawing.Point(374, 44);
            this.btnInch.Margin = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.btnInch.Name = "btnInch";
            this.btnInch.Size = new System.Drawing.Size(226, 20);
            this.btnInch.TabIndex = 5;
            this.btnInch.Text = "寸动";
            this.btnInch.UseVisualStyleBackColor = false;
            this.btnInch.Click += new System.EventHandler(this.btnInch_Click);
            // 
            // jogSpacer
            // 
            this.jogSpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jogSpacer.Location = new System.Drawing.Point(842, 0);
            this.jogSpacer.Margin = new System.Windows.Forms.Padding(0);
            this.jogSpacer.Name = "jogSpacer";
            this.jogSpacer.Size = new System.Drawing.Size(330, 36);
            this.jogSpacer.TabIndex = 6;
            // 
            // paramTabs
            // 
            this.paramTabs.Controls.Add(this.tabSystem);
            this.paramTabs.Controls.Add(this.tabSpeed);
            this.paramTabs.Controls.Add(this.tabProcess);
            this.paramTabs.Controls.Add(this.tabVision);
            this.paramTabs.Controls.Add(this.tabSwitch);
            this.paramTabs.Controls.Add(this.tabPort);
            this.paramTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramTabs.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.paramTabs.ItemSize = new System.Drawing.Size(150, 30);
            this.paramTabs.Location = new System.Drawing.Point(0, 368);
            this.paramTabs.Margin = new System.Windows.Forms.Padding(0);
            this.paramTabs.Name = "paramTabs";
            this.paramTabs.SelectedIndex = 0;
            this.paramTabs.Size = new System.Drawing.Size(1172, 36);
            this.paramTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.paramTabs.TabIndex = 3;
            this.paramTabs.SelectedIndexChanged += new System.EventHandler(this.paramTabs_SelectedIndexChanged);
            // 
            // tabSystem
            // 
            this.tabSystem.Location = new System.Drawing.Point(4, 34);
            this.tabSystem.Name = "tabSystem";
            this.tabSystem.Size = new System.Drawing.Size(1164, 0);
            this.tabSystem.TabIndex = 0;
            this.tabSystem.Text = "系统参数";
            // 
            // tabSpeed
            // 
            this.tabSpeed.Location = new System.Drawing.Point(4, 34);
            this.tabSpeed.Name = "tabSpeed";
            this.tabSpeed.Size = new System.Drawing.Size(1164, 0);
            this.tabSpeed.TabIndex = 1;
            this.tabSpeed.Text = "速度参数";
            // 
            // tabProcess
            // 
            this.tabProcess.Location = new System.Drawing.Point(4, 34);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Size = new System.Drawing.Size(1164, 0);
            this.tabProcess.TabIndex = 2;
            this.tabProcess.Text = "工艺参数";
            // 
            // tabVision
            // 
            this.tabVision.Location = new System.Drawing.Point(4, 34);
            this.tabVision.Name = "tabVision";
            this.tabVision.Size = new System.Drawing.Size(1164, 0);
            this.tabVision.TabIndex = 3;
            this.tabVision.Text = "视觉参数";
            // 
            // tabSwitch
            // 
            this.tabSwitch.Location = new System.Drawing.Point(4, 34);
            this.tabSwitch.Name = "tabSwitch";
            this.tabSwitch.Size = new System.Drawing.Size(1164, 0);
            this.tabSwitch.TabIndex = 4;
            this.tabSwitch.Text = "功能开关";
            // 
            // tabPort
            // 
            this.tabPort.Location = new System.Drawing.Point(4, 34);
            this.tabPort.Name = "tabPort";
            this.tabPort.Size = new System.Drawing.Size(1164, 0);
            this.tabPort.TabIndex = 5;
            this.tabPort.Text = "端口设置";
            // 
            // paramGrid
            // 
            this.paramGrid.AllowUserToAddRows = false;
            this.paramGrid.AllowUserToDeleteRows = false;
            this.paramGrid.AllowUserToResizeRows = false;
            this.paramGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.paramGrid.BackgroundColor = System.Drawing.Color.White;
            this.paramGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.paramGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.paramGrid.ColumnHeadersHeight = 30;
            this.paramGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.paramGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colParamName,
            this.colParamUpper,
            this.colParamLower,
            this.colParamValue});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.paramGrid.DefaultCellStyle = dataGridViewCellStyle4;
            this.paramGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramGrid.EnableHeadersVisualStyles = false;
            this.paramGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.paramGrid.Location = new System.Drawing.Point(0, 404);
            this.paramGrid.Margin = new System.Windows.Forms.Padding(0);
            this.paramGrid.MultiSelect = false;
            this.paramGrid.Name = "paramGrid";
            this.paramGrid.RowHeadersVisible = false;
            this.paramGrid.RowTemplate.Height = 30;
            this.paramGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.paramGrid.Size = new System.Drawing.Size(1172, 159);
            this.paramGrid.TabIndex = 4;
            // 
            // colParamName
            // 
            this.colParamName.FillWeight = 40F;
            this.colParamName.HeaderText = "参数名";
            this.colParamName.Name = "colParamName";
            this.colParamName.ReadOnly = true;
            this.colParamName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colParamUpper
            // 
            this.colParamUpper.FillWeight = 20F;
            this.colParamUpper.HeaderText = "上限";
            this.colParamUpper.Name = "colParamUpper";
            this.colParamUpper.ReadOnly = true;
            this.colParamUpper.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colParamLower
            // 
            this.colParamLower.FillWeight = 20F;
            this.colParamLower.HeaderText = "下限";
            this.colParamLower.Name = "colParamLower";
            this.colParamLower.ReadOnly = true;
            this.colParamLower.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colParamValue
            // 
            this.colParamValue.FillWeight = 20F;
            this.colParamValue.HeaderText = "参数";
            this.colParamValue.Name = "colParamValue";
            this.colParamValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // paramButtons
            // 
            this.paramButtons.ColumnCount = 5;
            this.paramButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.paramButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.paramButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.paramButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.paramButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.paramButtons.Controls.Add(this.btnMovePoint, 0, 0);
            this.paramButtons.Controls.Add(this.btnTeachPoint, 1, 0);
            this.paramButtons.Controls.Add(this.btnSaveParam, 2, 0);
            this.paramButtons.Controls.Add(this.paramSpacer, 4, 0);
            this.paramButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramButtons.Location = new System.Drawing.Point(0, 563);
            this.paramButtons.Margin = new System.Windows.Forms.Padding(0);
            this.paramButtons.Name = "paramButtons";
            this.paramButtons.RowCount = 1;
            this.paramButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.paramButtons.Size = new System.Drawing.Size(1172, 43);
            this.paramButtons.TabIndex = 5;
            // 
            // btnMovePoint
            // 
            this.btnMovePoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMovePoint.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnMovePoint.Location = new System.Drawing.Point(6, 6);
            this.btnMovePoint.Margin = new System.Windows.Forms.Padding(6, 6, 2, 6);
            this.btnMovePoint.Name = "btnMovePoint";
            this.btnMovePoint.Size = new System.Drawing.Size(226, 31);
            this.btnMovePoint.TabIndex = 0;
            this.btnMovePoint.Text = "点位移动";
            this.btnMovePoint.UseVisualStyleBackColor = true;
            this.btnMovePoint.Click += new System.EventHandler(this.btnMovePoint_Click);
            // 
            // btnTeachPoint
            // 
            this.btnTeachPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTeachPoint.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnTeachPoint.Location = new System.Drawing.Point(236, 6);
            this.btnTeachPoint.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnTeachPoint.Name = "btnTeachPoint";
            this.btnTeachPoint.Size = new System.Drawing.Size(230, 31);
            this.btnTeachPoint.TabIndex = 1;
            this.btnTeachPoint.Text = "点位保存";
            this.btnTeachPoint.UseVisualStyleBackColor = true;
            this.btnTeachPoint.Click += new System.EventHandler(this.btnTeachPoint_Click);
            // 
            // btnSaveParam
            // 
            this.btnSaveParam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveParam.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnSaveParam.Location = new System.Drawing.Point(470, 6);
            this.btnSaveParam.Margin = new System.Windows.Forms.Padding(2, 6, 2, 6);
            this.btnSaveParam.Name = "btnSaveParam";
            this.btnSaveParam.Size = new System.Drawing.Size(230, 31);
            this.btnSaveParam.TabIndex = 2;
            this.btnSaveParam.Text = "参数保存";
            this.btnSaveParam.UseVisualStyleBackColor = true;
            this.btnSaveParam.Click += new System.EventHandler(this.btnSaveParam_Click);
            // 
            // paramSpacer
            // 
            this.paramSpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paramSpacer.Location = new System.Drawing.Point(936, 0);
            this.paramSpacer.Margin = new System.Windows.Forms.Padding(0);
            this.paramSpacer.Name = "paramSpacer";
            this.paramSpacer.Size = new System.Drawing.Size(236, 43);
            this.paramSpacer.TabIndex = 3;
            // 
            // ioPanel
            // 
            this.ioPanel.ColumnCount = 2;
            this.ioPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ioPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ioPanel.Controls.Add(this.ioInCard, 0, 0);
            this.ioPanel.Controls.Add(this.ioOutCard, 1, 0);
            this.ioPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ioPanel.Location = new System.Drawing.Point(0, 0);
            this.ioPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ioPanel.Name = "ioPanel";
            this.ioPanel.RowCount = 1;
            this.ioPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ioPanel.Size = new System.Drawing.Size(1172, 606);
            this.ioPanel.TabIndex = 1;
            this.ioPanel.Visible = false;
            // 
            // ioInCard
            // 
            this.ioInCard.ColumnCount = 1;
            this.ioInCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ioInCard.Controls.Add(this.comboIn, 0, 0);
            this.ioInCard.Controls.Add(this.gridIn, 0, 1);
            this.ioInCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ioInCard.Location = new System.Drawing.Point(0, 0);
            this.ioInCard.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.ioInCard.Name = "ioInCard";
            this.ioInCard.RowCount = 2;
            this.ioInCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ioInCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ioInCard.Size = new System.Drawing.Size(583, 606);
            this.ioInCard.TabIndex = 0;
            // 
            // comboIn
            // 
            this.comboIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboIn.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.comboIn.FormattingEnabled = true;
            this.comboIn.Location = new System.Drawing.Point(4, 5);
            this.comboIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboIn.Name = "comboIn";
            this.comboIn.Size = new System.Drawing.Size(575, 27);
            this.comboIn.TabIndex = 0;
            this.comboIn.SelectedIndexChanged += new System.EventHandler(this.comboIo_SelectedIndexChanged);
            // 
            // gridIn
            // 
            this.gridIn.AllowUserToAddRows = false;
            this.gridIn.AllowUserToDeleteRows = false;
            this.gridIn.AllowUserToResizeRows = false;
            this.gridIn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridIn.BackgroundColor = System.Drawing.Color.White;
            this.gridIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.gridIn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridIn.ColumnHeadersHeight = 30;
            this.gridIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridIn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInSignal,
            this.colInState,
            this.colInNote});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridIn.DefaultCellStyle = dataGridViewCellStyle6;
            this.gridIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridIn.EnableHeadersVisualStyles = false;
            this.gridIn.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.gridIn.Location = new System.Drawing.Point(0, 36);
            this.gridIn.Margin = new System.Windows.Forms.Padding(0);
            this.gridIn.MultiSelect = false;
            this.gridIn.Name = "gridIn";
            this.gridIn.ReadOnly = true;
            this.gridIn.RowHeadersVisible = false;
            this.gridIn.RowTemplate.Height = 28;
            this.gridIn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridIn.Size = new System.Drawing.Size(583, 570);
            this.gridIn.TabIndex = 1;
            // 
            // colInSignal
            // 
            this.colInSignal.FillWeight = 26F;
            this.colInSignal.HeaderText = "信号";
            this.colInSignal.Name = "colInSignal";
            this.colInSignal.ReadOnly = true;
            this.colInSignal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colInState
            // 
            this.colInState.FillWeight = 12F;
            this.colInState.HeaderText = "状态";
            this.colInState.Name = "colInState";
            this.colInState.ReadOnly = true;
            this.colInState.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colInNote
            // 
            this.colInNote.FillWeight = 62F;
            this.colInNote.HeaderText = "备注";
            this.colInNote.Name = "colInNote";
            this.colInNote.ReadOnly = true;
            this.colInNote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ioOutCard
            // 
            this.ioOutCard.ColumnCount = 1;
            this.ioOutCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ioOutCard.Controls.Add(this.comboOut, 0, 0);
            this.ioOutCard.Controls.Add(this.gridOut, 0, 1);
            this.ioOutCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ioOutCard.Location = new System.Drawing.Point(586, 0);
            this.ioOutCard.Margin = new System.Windows.Forms.Padding(0);
            this.ioOutCard.Name = "ioOutCard";
            this.ioOutCard.RowCount = 2;
            this.ioOutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.ioOutCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ioOutCard.Size = new System.Drawing.Size(586, 606);
            this.ioOutCard.TabIndex = 1;
            // 
            // comboOut
            // 
            this.comboOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboOut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOut.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.comboOut.FormattingEnabled = true;
            this.comboOut.Location = new System.Drawing.Point(4, 5);
            this.comboOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboOut.Name = "comboOut";
            this.comboOut.Size = new System.Drawing.Size(578, 27);
            this.comboOut.TabIndex = 0;
            this.comboOut.SelectedIndexChanged += new System.EventHandler(this.comboIo_SelectedIndexChanged);
            // 
            // gridOut
            // 
            this.gridOut.AllowUserToAddRows = false;
            this.gridOut.AllowUserToDeleteRows = false;
            this.gridOut.AllowUserToResizeRows = false;
            this.gridOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOut.BackgroundColor = System.Drawing.Color.White;
            this.gridOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gridOut.ColumnHeadersHeight = 30;
            this.gridOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOutSignal,
            this.colOutState,
            this.colOutNote});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("微软雅黑", 9F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOut.DefaultCellStyle = dataGridViewCellStyle7;
            this.gridOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOut.EnableHeadersVisualStyles = false;
            this.gridOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(230)))), ((int)(((byte)(236)))));
            this.gridOut.Location = new System.Drawing.Point(0, 36);
            this.gridOut.Margin = new System.Windows.Forms.Padding(0);
            this.gridOut.MultiSelect = false;
            this.gridOut.Name = "gridOut";
            this.gridOut.ReadOnly = true;
            this.gridOut.RowHeadersVisible = false;
            this.gridOut.RowTemplate.Height = 28;
            this.gridOut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOut.Size = new System.Drawing.Size(586, 570);
            this.gridOut.TabIndex = 1;
            this.gridOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridOut_CellContentClick);
            // 
            // colOutSignal
            // 
            this.colOutSignal.FillWeight = 26F;
            this.colOutSignal.HeaderText = "信号";
            this.colOutSignal.Name = "colOutSignal";
            this.colOutSignal.ReadOnly = true;
            this.colOutSignal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colOutState
            // 
            this.colOutState.FillWeight = 12F;
            this.colOutState.HeaderText = "状态";
            this.colOutState.Name = "colOutState";
            this.colOutState.ReadOnly = true;
            this.colOutState.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colOutNote
            // 
            this.colOutNote.FillWeight = 62F;
            this.colOutNote.HeaderText = "备注";
            this.colOutNote.Name = "colOutNote";
            this.colOutNote.ReadOnly = true;
            this.colOutNote.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // refresh
            // 
            this.refresh.Interval = 400;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // jogTimer
            // 
            this.jogTimer.Tick += new System.EventHandler(this.jogTimer_Tick);
            // 
            // PagePositionSpeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.root);
            this.Name = "PagePositionSpeed";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.topTabs.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.axisPanel.ResumeLayout(false);
            this.groupBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axisGrid)).EndInit();
            this.jogBar.ResumeLayout(false);
            this.jogBar.PerformLayout();
            this.paramTabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.paramGrid)).EndInit();
            this.paramButtons.ResumeLayout(false);
            this.ioPanel.ResumeLayout(false);
            this.ioInCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridIn)).EndInit();
            this.ioOutCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridOut)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel topTabs;
        private System.Windows.Forms.RadioButton radioAxis;
        private System.Windows.Forms.RadioButton radioIo;
        private System.Windows.Forms.Panel topSpacer;
        private System.Windows.Forms.Panel content;
        private System.Windows.Forms.TableLayoutPanel axisPanel;
        private System.Windows.Forms.TableLayoutPanel groupBar;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.DataGridView axisGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPosLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPos;
        private System.Windows.Forms.DataGridViewButtonColumn colPlus;
        private System.Windows.Forms.DataGridViewButtonColumn colMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFault;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitPlus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLimitMinus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExcited;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHomed;
        private System.Windows.Forms.TableLayoutPanel jogBar;
        private System.Windows.Forms.Label speedLabel;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.Button btnJog;
        private System.Windows.Forms.Label distanceLabel;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.Button btnInch;
        private System.Windows.Forms.Panel jogSpacer;
        private System.Windows.Forms.TabControl paramTabs;
        private System.Windows.Forms.TabPage tabSystem;
        private System.Windows.Forms.TabPage tabSpeed;
        private System.Windows.Forms.TabPage tabProcess;
        private System.Windows.Forms.TabPage tabVision;
        private System.Windows.Forms.TabPage tabSwitch;
        private System.Windows.Forms.TabPage tabPort;
        private System.Windows.Forms.DataGridView paramGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParamName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParamUpper;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParamLower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParamValue;
        private System.Windows.Forms.TableLayoutPanel paramButtons;
        private System.Windows.Forms.Button btnMovePoint;
        private System.Windows.Forms.Button btnTeachPoint;
        private System.Windows.Forms.Button btnSaveParam;
        private System.Windows.Forms.Panel paramSpacer;
        private System.Windows.Forms.TableLayoutPanel ioPanel;
        private System.Windows.Forms.TableLayoutPanel ioInCard;
        private System.Windows.Forms.ComboBox comboIn;
        private System.Windows.Forms.DataGridView gridIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInSignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInNote;
        private System.Windows.Forms.TableLayoutPanel ioOutCard;
        private System.Windows.Forms.ComboBox comboOut;
        private System.Windows.Forms.DataGridView gridOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutSignal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutState;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOutNote;
        private System.Windows.Forms.Timer refresh;
        private System.Windows.Forms.Timer jogTimer;
    }
}
