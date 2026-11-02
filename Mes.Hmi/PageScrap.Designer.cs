namespace Mes.Hmi
{
    partial class PageScrap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaTrend = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legendTrend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series seriesTrendLegendRate = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series seriesTrendLegendNg = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series seriesTrendLegendOk = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series seriesTrendOk = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series seriesTrendNg = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series seriesTrendRate = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title titleTrend = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaItem = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series seriesItem = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title titleItem = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartAreaPie = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legendPie = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series seriesPie = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title titlePie = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.tabsTable = new System.Windows.Forms.TableLayoutPanel();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnAux = new System.Windows.Forms.Button();
            this.tabNote = new System.Windows.Forms.Label();
            this.toolbar = new System.Windows.Forms.TableLayoutPanel();
            this.radioList = new System.Windows.Forms.RadioButton();
            this.radioChart = new System.Windows.Forms.RadioButton();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.modeCombo = new System.Windows.Forms.ComboBox();
            this.autoRefresh = new System.Windows.Forms.CheckBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gridDay = new System.Windows.Forms.DataGridView();
            this.colDayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNight = new System.Windows.Forms.DataGridView();
            this.colNightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightPercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartPanel = new System.Windows.Forms.TableLayoutPanel();
            this.plotTrend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bottomCharts = new System.Windows.Forms.TableLayoutPanel();
            this.plotItem = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plotPie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.tabsTable.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNight)).BeginInit();
            this.chartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotTrend)).BeginInit();
            this.bottomCharts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotPie)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.tabsTable, 0, 0);
            this.root.Controls.Add(this.toolbar, 0, 1);
            this.root.Controls.Add(this.contentPanel, 0, 2);
            this.root.Controls.Add(this.bottomPanel, 0, 3);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 4;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // tabsTable
            // 
            this.tabsTable.ColumnCount = 3;
            this.tabsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tabsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tabsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabsTable.Controls.Add(this.btnMain, 0, 0);
            this.tabsTable.Controls.Add(this.btnAux, 1, 0);
            this.tabsTable.Controls.Add(this.tabNote, 2, 0);
            this.tabsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabsTable.Location = new System.Drawing.Point(4, 4);
            this.tabsTable.Margin = new System.Windows.Forms.Padding(0);
            this.tabsTable.Name = "tabsTable";
            this.tabsTable.RowCount = 1;
            this.tabsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tabsTable.Size = new System.Drawing.Size(1172, 34);
            this.tabsTable.TabIndex = 0;
            // 
            // btnMain
            // 
            this.btnMain.BackColor = System.Drawing.Color.White;
            this.btnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMain.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))));
            this.btnMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMain.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.btnMain.Location = new System.Drawing.Point(0, 3);
            this.btnMain.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(108, 31);
            this.btnMain.TabIndex = 0;
            this.btnMain.Text = "主件";
            this.btnMain.UseVisualStyleBackColor = false;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnAux
            // 
            this.btnAux.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.btnAux.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAux.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))));
            this.btnAux.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAux.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnAux.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.btnAux.Location = new System.Drawing.Point(108, 3);
            this.btnAux.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.btnAux.Name = "btnAux";
            this.btnAux.Size = new System.Drawing.Size(108, 31);
            this.btnAux.TabIndex = 1;
            this.btnAux.Text = "辅料";
            this.btnAux.UseVisualStyleBackColor = false;
            this.btnAux.Click += new System.EventHandler(this.btnAux_Click);
            // 
            // tabNote
            // 
            this.tabNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabNote.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tabNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(100)))), ((int)(((byte)(20)))));
            this.tabNote.Location = new System.Drawing.Point(224, 0);
            this.tabNote.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tabNote.Name = "tabNote";
            this.tabNote.Size = new System.Drawing.Size(940, 34);
            this.tabNote.TabIndex = 2;
            this.tabNote.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolbar
            // 
            this.toolbar.ColumnCount = 7;
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.Controls.Add(this.radioList, 0, 0);
            this.toolbar.Controls.Add(this.radioChart, 1, 0);
            this.toolbar.Controls.Add(this.fromPicker, 2, 0);
            this.toolbar.Controls.Add(this.toPicker, 3, 0);
            this.toolbar.Controls.Add(this.modeCombo, 4, 0);
            this.toolbar.Controls.Add(this.autoRefresh, 5, 0);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbar.Location = new System.Drawing.Point(4, 38);
            this.toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RowCount = 1;
            this.toolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.Size = new System.Drawing.Size(1172, 44);
            this.toolbar.TabIndex = 1;
            // 
            // radioList
            // 
            this.radioList.Checked = true;
            this.radioList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioList.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.radioList.Location = new System.Drawing.Point(8, 0);
            this.radioList.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.radioList.Name = "radioList";
            this.radioList.Size = new System.Drawing.Size(96, 44);
            this.radioList.TabIndex = 0;
            this.radioList.TabStop = true;
            this.radioList.Text = "列表显示";
            this.radioList.UseVisualStyleBackColor = true;
            this.radioList.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioChart
            // 
            this.radioChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioChart.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.radioChart.Location = new System.Drawing.Point(112, 0);
            this.radioChart.Margin = new System.Windows.Forms.Padding(0);
            this.radioChart.Name = "radioChart";
            this.radioChart.Size = new System.Drawing.Size(104, 44);
            this.radioChart.TabIndex = 1;
            this.radioChart.Text = "图形显示";
            this.radioChart.UseVisualStyleBackColor = true;
            this.radioChart.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // fromPicker
            // 
            this.fromPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.fromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromPicker.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromPicker.Location = new System.Drawing.Point(224, 10);
            this.fromPicker.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.Size = new System.Drawing.Size(180, 24);
            this.fromPicker.TabIndex = 2;
            this.fromPicker.ValueChanged += new System.EventHandler(this.fromPicker_ValueChanged);
            // 
            // toPicker
            // 
            this.toPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.toPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPicker.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toPicker.Location = new System.Drawing.Point(420, 10);
            this.toPicker.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.toPicker.Name = "toPicker";
            this.toPicker.Size = new System.Drawing.Size(180, 24);
            this.toPicker.TabIndex = 3;
            this.toPicker.ValueChanged += new System.EventHandler(this.toPicker_ValueChanged);
            // 
            // modeCombo
            // 
            this.modeCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.modeCombo.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.modeCombo.FormattingEnabled = true;
            this.modeCombo.Items.AddRange(new object[] {
            "生产模式",
            "非生产模式"});
            this.modeCombo.Location = new System.Drawing.Point(624, 10);
            this.modeCombo.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.modeCombo.Name = "modeCombo";
            this.modeCombo.Size = new System.Drawing.Size(120, 25);
            this.modeCombo.TabIndex = 4;
            this.modeCombo.SelectedIndexChanged += new System.EventHandler(this.modeCombo_SelectedIndexChanged);
            // 
            // autoRefresh
            // 
            this.autoRefresh.Checked = true;
            this.autoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoRefresh.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.autoRefresh.Location = new System.Drawing.Point(752, 0);
            this.autoRefresh.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.autoRefresh.Name = "autoRefresh";
            this.autoRefresh.Size = new System.Drawing.Size(108, 44);
            this.autoRefresh.TabIndex = 5;
            this.autoRefresh.Text = "自动刷新";
            this.autoRefresh.UseVisualStyleBackColor = true;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.listPanel);
            this.contentPanel.Controls.Add(this.chartPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(4, 82);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1172, 516);
            this.contentPanel.TabIndex = 2;
            // 
            // listPanel
            // 
            this.listPanel.ColumnCount = 2;
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listPanel.Controls.Add(this.gridDay, 0, 0);
            this.listPanel.Controls.Add(this.gridNight, 1, 0);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(0, 0);
            this.listPanel.Margin = new System.Windows.Forms.Padding(0);
            this.listPanel.Name = "listPanel";
            this.listPanel.RowCount = 1;
            this.listPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listPanel.Size = new System.Drawing.Size(1172, 516);
            this.listPanel.TabIndex = 0;
            // 
            // gridDay
            // 
            this.gridDay.AllowUserToAddRows = false;
            this.gridDay.AllowUserToDeleteRows = false;
            this.gridDay.AllowUserToResizeRows = false;
            this.gridDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDay.BackgroundColor = System.Drawing.Color.White;
            this.gridDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.gridDay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridDay.ColumnHeadersHeight = 32;
            this.gridDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDayName,
            this.colDayCount,
            this.colDayPercent});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDay.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDay.EnableHeadersVisualStyles = false;
            this.gridDay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.gridDay.Location = new System.Drawing.Point(0, 0);
            this.gridDay.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.gridDay.MultiSelect = false;
            this.gridDay.Name = "gridDay";
            this.gridDay.ReadOnly = true;
            this.gridDay.RowHeadersVisible = false;
            this.gridDay.RowTemplate.Height = 30;
            this.gridDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDay.Size = new System.Drawing.Size(584, 516);
            this.gridDay.TabIndex = 0;
            // 
            // colDayName
            // 
            this.colDayName.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDayName.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.colDayName.FillWeight = 56F;
            this.colDayName.HeaderText = "统计项目";
            this.colDayName.Name = "colDayName";
            this.colDayName.ReadOnly = true;
            // 
            // colDayCount
            // 
            this.colDayCount.FillWeight = 26F;
            this.colDayCount.HeaderText = "白班数量";
            this.colDayCount.Name = "colDayCount";
            this.colDayCount.ReadOnly = true;
            // 
            // colDayPercent
            // 
            this.colDayPercent.FillWeight = 18F;
            this.colDayPercent.HeaderText = "百分比";
            this.colDayPercent.Name = "colDayPercent";
            this.colDayPercent.ReadOnly = true;
            // 
            // gridNight
            // 
            this.gridNight.AllowUserToAddRows = false;
            this.gridNight.AllowUserToDeleteRows = false;
            this.gridNight.AllowUserToResizeRows = false;
            this.gridNight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNight.BackgroundColor = System.Drawing.Color.White;
            this.gridNight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNight.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridNight.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridNight.ColumnHeadersHeight = 32;
            this.gridNight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridNight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNightName,
            this.colNightCount,
            this.colNightPercent});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNight.DefaultCellStyle = dataGridViewCellStyle3;
            this.gridNight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNight.EnableHeadersVisualStyles = false;
            this.gridNight.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.gridNight.Location = new System.Drawing.Point(588, 0);
            this.gridNight.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.gridNight.MultiSelect = false;
            this.gridNight.Name = "gridNight";
            this.gridNight.ReadOnly = true;
            this.gridNight.RowHeadersVisible = false;
            this.gridNight.RowTemplate.Height = 30;
            this.gridNight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNight.Size = new System.Drawing.Size(584, 516);
            this.gridNight.TabIndex = 1;
            // 
            // colNightName
            // 
            this.colNightName.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colNightName.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.colNightName.FillWeight = 56F;
            this.colNightName.HeaderText = "统计项目";
            this.colNightName.Name = "colNightName";
            this.colNightName.ReadOnly = true;
            // 
            // colNightCount
            // 
            this.colNightCount.FillWeight = 26F;
            this.colNightCount.HeaderText = "晚班数量";
            this.colNightCount.Name = "colNightCount";
            this.colNightCount.ReadOnly = true;
            // 
            // colNightPercent
            // 
            this.colNightPercent.FillWeight = 18F;
            this.colNightPercent.HeaderText = "百分比";
            this.colNightPercent.Name = "colNightPercent";
            this.colNightPercent.ReadOnly = true;
            // 
            // chartPanel
            // 
            this.chartPanel.ColumnCount = 1;
            this.chartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chartPanel.Controls.Add(this.plotTrend, 0, 0);
            this.chartPanel.Controls.Add(this.bottomCharts, 0, 1);
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel.Location = new System.Drawing.Point(0, 0);
            this.chartPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.RowCount = 2;
            this.chartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.chartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.chartPanel.Size = new System.Drawing.Size(1172, 516);
            this.chartPanel.TabIndex = 1;
            this.chartPanel.Visible = false;
            // 
            // plotTrend
            // 
            chartAreaTrend.AxisX.LabelStyle.Angle = -45;
            chartAreaTrend.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartAreaTrend.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaTrend.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaTrend.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartAreaTrend.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartAreaTrend.AxisX.MajorTickMark.Enabled = false;
            chartAreaTrend.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartAreaTrend.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaTrend.AxisY.LabelStyle.Format = "0";
            chartAreaTrend.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaTrend.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartAreaTrend.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartAreaTrend.AxisY.MajorTickMark.Enabled = false;
            chartAreaTrend.AxisY.Maximum = 160D;
            chartAreaTrend.AxisY.Minimum = 0D;
            chartAreaTrend.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.Auto;
            chartAreaTrend.AxisY2.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartAreaTrend.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaTrend.AxisY2.LabelStyle.Format = "0.00\'%\'";
            chartAreaTrend.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaTrend.AxisY2.MajorGrid.Enabled = false;
            chartAreaTrend.AxisY2.MajorTickMark.Enabled = false;
            chartAreaTrend.AxisY2.Minimum = 0D;
            chartAreaTrend.BackColor = System.Drawing.Color.White;
            chartAreaTrend.Name = "main";
            this.plotTrend.ChartAreas.Add(chartAreaTrend);
            this.plotTrend.BackColor = System.Drawing.Color.White;
            this.plotTrend.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotTrend.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.plotTrend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotTrend.Location = new System.Drawing.Point(0, 0);
            this.plotTrend.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.plotTrend.Name = "plotTrend";
            legendTrend.Alignment = System.Drawing.StringAlignment.Near;
            legendTrend.BackColor = System.Drawing.Color.Transparent;
            legendTrend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            legendTrend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            legendTrend.Font = new System.Drawing.Font("微软雅黑", 9F);
            legendTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            legendTrend.IsTextAutoFit = false;
            legendTrend.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legendTrend.Name = "legend";
            this.plotTrend.Legends.Add(legendTrend);
            seriesTrendLegendRate.ChartArea = "main";
            seriesTrendLegendRate.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesTrendLegendRate.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            seriesTrendLegendRate.IsVisibleInLegend = true;
            seriesTrendLegendRate.LegendText = "抛料率";
            seriesTrendLegendRate.Name = "图例抛料率";
            this.plotTrend.Series.Add(seriesTrendLegendRate);
            seriesTrendLegendNg.ChartArea = "main";
            seriesTrendLegendNg.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            seriesTrendLegendNg.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            seriesTrendLegendNg.IsVisibleInLegend = true;
            seriesTrendLegendNg.LegendText = "NG数量";
            seriesTrendLegendNg.Name = "图例NG数量";
            this.plotTrend.Series.Add(seriesTrendLegendNg);
            seriesTrendLegendOk.ChartArea = "main";
            seriesTrendLegendOk.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            seriesTrendLegendOk.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            seriesTrendLegendOk.IsVisibleInLegend = true;
            seriesTrendLegendOk.LegendText = "OK数量";
            seriesTrendLegendOk.Name = "图例OK数量";
            this.plotTrend.Series.Add(seriesTrendLegendOk);
            seriesTrendOk.ChartArea = "main";
            seriesTrendOk.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            seriesTrendOk.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            seriesTrendOk.IsVisibleInLegend = false;
            seriesTrendOk.Name = "OK数量";
            this.plotTrend.Series.Add(seriesTrendOk);
            seriesTrendNg.ChartArea = "main";
            seriesTrendNg.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            seriesTrendNg.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            seriesTrendNg.Font = new System.Drawing.Font("微软雅黑", 8F);
            seriesTrendNg.IsVisibleInLegend = false;
            seriesTrendNg.Label = "#VAL";
            seriesTrendNg.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(80)))), ((int)(((byte)(0)))));
            seriesTrendNg.Name = "NG数量";
            this.plotTrend.Series.Add(seriesTrendNg);
            seriesTrendRate.ChartArea = "main";
            seriesTrendRate.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            seriesTrendRate.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            seriesTrendRate.IsVisibleInLegend = false;
            seriesTrendRate.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.None;
            seriesTrendRate.Name = "抛料率";
            seriesTrendRate.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.plotTrend.Series.Add(seriesTrendRate);
            this.plotTrend.Size = new System.Drawing.Size(1172, 295);
            this.plotTrend.TabIndex = 0;
            this.plotTrend.MouseClick += new System.Windows.Forms.MouseEventHandler(this.plotTrend_MouseClick);
            titleTrend.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            titleTrend.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            titleTrend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            titleTrend.Name = "titleTrend";
            titleTrend.Text = "抛料趋势";
            this.plotTrend.Titles.Add(titleTrend);
            // 
            // bottomCharts
            // 
            this.bottomCharts.ColumnCount = 2;
            this.bottomCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.bottomCharts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.bottomCharts.Controls.Add(this.plotItem, 0, 0);
            this.bottomCharts.Controls.Add(this.plotPie, 1, 0);
            this.bottomCharts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomCharts.Location = new System.Drawing.Point(0, 299);
            this.bottomCharts.Margin = new System.Windows.Forms.Padding(0);
            this.bottomCharts.Name = "bottomCharts";
            this.bottomCharts.RowCount = 1;
            this.bottomCharts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomCharts.Size = new System.Drawing.Size(1172, 217);
            this.bottomCharts.TabIndex = 1;
            // 
            // plotItem
            // 
            chartAreaItem.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            chartAreaItem.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            chartAreaItem.AxisX.LabelStyle.TruncatedLabels = false;
            chartAreaItem.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaItem.AxisX.MajorGrid.Enabled = false;
            chartAreaItem.AxisX.MajorTickMark.Enabled = false;
            chartAreaItem.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            chartAreaItem.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaItem.AxisY.LabelStyle.Format = "0";
            chartAreaItem.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartAreaItem.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartAreaItem.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartAreaItem.AxisY.MajorTickMark.Enabled = false;
            chartAreaItem.AxisY.Minimum = 0D;
            chartAreaItem.BackColor = System.Drawing.Color.White;
            chartAreaItem.Name = "main";
            this.plotItem.ChartAreas.Add(chartAreaItem);
            this.plotItem.BackColor = System.Drawing.Color.White;
            this.plotItem.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotItem.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.plotItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotItem.Location = new System.Drawing.Point(0, 0);
            this.plotItem.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.plotItem.Name = "plotItem";
            seriesItem.ChartArea = "main";
            seriesItem.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            seriesItem.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            seriesItem.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            seriesItem.IsValueShownAsLabel = true;
            seriesItem.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            seriesItem.Name = "抛料项目";
            this.plotItem.Series.Add(seriesItem);
            this.plotItem.Size = new System.Drawing.Size(535, 217);
            this.plotItem.TabIndex = 0;
            titleItem.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            titleItem.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            titleItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            titleItem.Name = "titleItem";
            titleItem.Text = "Tossing Item";
            this.plotItem.Titles.Add(titleItem);
            // 
            // plotPie
            // 
            chartAreaPie.BackColor = System.Drawing.Color.White;
            chartAreaPie.Name = "main";
            this.plotPie.ChartAreas.Add(chartAreaPie);
            this.plotPie.BackColor = System.Drawing.Color.White;
            this.plotPie.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotPie.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.plotPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotPie.Location = new System.Drawing.Point(539, 0);
            this.plotPie.Margin = new System.Windows.Forms.Padding(0);
            this.plotPie.Name = "plotPie";
            legendPie.Alignment = System.Drawing.StringAlignment.Center;
            legendPie.BackColor = System.Drawing.Color.Transparent;
            legendPie.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            legendPie.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            legendPie.Font = new System.Drawing.Font("微软雅黑", 9F);
            legendPie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            legendPie.IsTextAutoFit = false;
            legendPie.Name = "legend";
            this.plotPie.Legends.Add(legendPie);
            seriesPie.ChartArea = "main";
            seriesPie.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            seriesPie.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            seriesPie.IsVisibleInLegend = true;
            seriesPie.LegendText = "抛料";
            seriesPie.Name = "抛料分类";
            seriesPie["PieDrawingStyle"] = "SoftEdge";
            seriesPie["PieLabelStyle"] = "Disabled";
            this.plotPie.Series.Add(seriesPie);
            this.plotPie.Size = new System.Drawing.Size(633, 217);
            this.plotPie.TabIndex = 1;
            titlePie.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            titlePie.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            titlePie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            titlePie.Name = "titlePie";
            titlePie.Text = "抛料分类";
            this.plotPie.Titles.Add(titlePie);
            // 
            // bottomPanel
            // 
            this.bottomPanel.ColumnCount = 6;
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.bottomPanel.Controls.Add(this.startDateLabel, 0, 0);
            this.bottomPanel.Controls.Add(this.dateStart, 1, 0);
            this.bottomPanel.Controls.Add(this.endDateLabel, 2, 0);
            this.bottomPanel.Controls.Add(this.dateEnd, 3, 0);
            this.bottomPanel.Controls.Add(this.btnExport, 5, 0);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(4, 598);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.RowCount = 1;
            this.bottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.Size = new System.Drawing.Size(1172, 58);
            this.bottomPanel.TabIndex = 3;
            // 
            // startDateLabel
            // 
            this.startDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startDateLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.startDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.startDateLabel.Location = new System.Drawing.Point(8, 0);
            this.startDateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(72, 58);
            this.startDateLabel.TabIndex = 0;
            this.startDateLabel.Text = "开始日期:";
            this.startDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateStart
            // 
            this.dateStart.CustomFormat = "yyyy/MM/dd";
            this.dateStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateStart.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dateStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateStart.Location = new System.Drawing.Point(80, 15);
            this.dateStart.Margin = new System.Windows.Forms.Padding(0, 15, 8, 15);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(148, 24);
            this.dateStart.TabIndex = 1;
            this.dateStart.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // endDateLabel
            // 
            this.endDateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.endDateLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.endDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.endDateLabel.Location = new System.Drawing.Point(244, 0);
            this.endDateLabel.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.endDateLabel.Name = "endDateLabel";
            this.endDateLabel.Size = new System.Drawing.Size(72, 58);
            this.endDateLabel.TabIndex = 2;
            this.endDateLabel.Text = "结束日期:";
            this.endDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateEnd
            // 
            this.dateEnd.CustomFormat = "yyyy/MM/dd";
            this.dateEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateEnd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.dateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEnd.Location = new System.Drawing.Point(316, 15);
            this.dateEnd.Margin = new System.Windows.Forms.Padding(0, 15, 8, 15);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(148, 24);
            this.dateEnd.TabIndex = 3;
            this.dateEnd.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(972, 12);
            this.btnExport.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(184, 34);
            this.btnExport.TabIndex = 4;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 3000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageScrap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageScrap";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.tabsTable.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNight)).EndInit();
            this.chartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotTrend)).EndInit();
            this.bottomCharts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotPie)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel tabsTable;
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnAux;
        private System.Windows.Forms.Label tabNote;
        private System.Windows.Forms.TableLayoutPanel toolbar;
        private System.Windows.Forms.RadioButton radioList;
        private System.Windows.Forms.RadioButton radioChart;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.ComboBox modeCombo;
        private System.Windows.Forms.CheckBox autoRefresh;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.TableLayoutPanel listPanel;
        private System.Windows.Forms.DataGridView gridDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayPercent;
        private System.Windows.Forms.DataGridView gridNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightPercent;
        private System.Windows.Forms.TableLayoutPanel chartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotTrend;
        private System.Windows.Forms.TableLayoutPanel bottomCharts;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotPie;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Timer refresh;
    }
}
