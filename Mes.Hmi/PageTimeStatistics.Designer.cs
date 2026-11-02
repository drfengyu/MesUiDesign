namespace Mes.Hmi
{
    partial class PageTimeStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.toolbar = new System.Windows.Forms.TableLayoutPanel();
            this.radioList = new System.Windows.Forms.RadioButton();
            this.radioChart = new System.Windows.Forms.RadioButton();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.autoRefresh = new System.Windows.Forms.CheckBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.listPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gridDay = new System.Windows.Forms.DataGridView();
            this.colDayHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayIdle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridNight = new System.Windows.Forms.DataGridView();
            this.colNightHour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightIdle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCt = new System.Windows.Forms.DataGridView();
            this.colCtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCtValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartPanel = new System.Windows.Forms.TableLayoutPanel();
            this.plotTime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.endDateLabel = new System.Windows.Forms.Label();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnExport = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.listPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCt)).BeginInit();
            this.chartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotTime)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.toolbar, 0, 0);
            this.root.Controls.Add(this.contentPanel, 0, 1);
            this.root.Controls.Add(this.bottomPanel, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // toolbar
            // 
            this.toolbar.ColumnCount = 6;
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.Controls.Add(this.radioList, 0, 0);
            this.toolbar.Controls.Add(this.radioChart, 1, 0);
            this.toolbar.Controls.Add(this.fromPicker, 2, 0);
            this.toolbar.Controls.Add(this.toPicker, 3, 0);
            this.toolbar.Controls.Add(this.autoRefresh, 4, 0);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbar.Location = new System.Drawing.Point(4, 4);
            this.toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RowCount = 1;
            this.toolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.Size = new System.Drawing.Size(1172, 44);
            this.toolbar.TabIndex = 0;
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
            this.radioChart.Location = new System.Drawing.Point(104, 0);
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
            this.fromPicker.Location = new System.Drawing.Point(216, 10);
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
            this.toPicker.Location = new System.Drawing.Point(412, 10);
            this.toPicker.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.toPicker.Name = "toPicker";
            this.toPicker.Size = new System.Drawing.Size(180, 24);
            this.toPicker.TabIndex = 3;
            this.toPicker.ValueChanged += new System.EventHandler(this.toPicker_ValueChanged);
            // 
            // autoRefresh
            // 
            this.autoRefresh.Checked = true;
            this.autoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoRefresh.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.autoRefresh.Location = new System.Drawing.Point(608, 0);
            this.autoRefresh.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.autoRefresh.Name = "autoRefresh";
            this.autoRefresh.Size = new System.Drawing.Size(108, 44);
            this.autoRefresh.TabIndex = 4;
            this.autoRefresh.Text = "自动刷新";
            this.autoRefresh.UseVisualStyleBackColor = true;
            // 
            // contentPanel
            // 
            this.contentPanel.Controls.Add(this.listPanel);
            this.contentPanel.Controls.Add(this.chartPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(4, 48);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1172, 550);
            this.contentPanel.TabIndex = 1;
            // 
            // listPanel
            // 
            this.listPanel.ColumnCount = 3;
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.listPanel.Controls.Add(this.gridDay, 0, 0);
            this.listPanel.Controls.Add(this.gridNight, 1, 0);
            this.listPanel.Controls.Add(this.gridCt, 2, 0);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Location = new System.Drawing.Point(0, 0);
            this.listPanel.Margin = new System.Windows.Forms.Padding(0);
            this.listPanel.Name = "listPanel";
            this.listPanel.RowCount = 1;
            this.listPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listPanel.Size = new System.Drawing.Size(1172, 550);
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
            this.colDayHour,
            this.colDayRun,
            this.colDayIdle,
            this.colDayPlan,
            this.colDayFault});
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
            this.gridDay.Size = new System.Drawing.Size(466, 550);
            this.gridDay.TabIndex = 0;
            // 
            // colDayHour
            // 
            this.colDayHour.FillWeight = 26F;
            this.colDayHour.HeaderText = "时间段";
            this.colDayHour.Name = "colDayHour";
            this.colDayHour.ReadOnly = true;
            // 
            // colDayRun
            // 
            this.colDayRun.FillWeight = 19F;
            this.colDayRun.HeaderText = "运行时间";
            this.colDayRun.Name = "colDayRun";
            this.colDayRun.ReadOnly = true;
            // 
            // colDayIdle
            // 
            this.colDayIdle.FillWeight = 19F;
            this.colDayIdle.HeaderText = "待机时间";
            this.colDayIdle.Name = "colDayIdle";
            this.colDayIdle.ReadOnly = true;
            // 
            // colDayPlan
            // 
            this.colDayPlan.FillWeight = 18F;
            this.colDayPlan.HeaderText = "计划停机";
            this.colDayPlan.Name = "colDayPlan";
            this.colDayPlan.ReadOnly = true;
            // 
            // colDayFault
            // 
            this.colDayFault.FillWeight = 18F;
            this.colDayFault.HeaderText = "异常时间";
            this.colDayFault.Name = "colDayFault";
            this.colDayFault.ReadOnly = true;
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
            this.colNightHour,
            this.colNightRun,
            this.colNightIdle,
            this.colNightPlan,
            this.colNightFault});
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
            this.gridNight.Location = new System.Drawing.Point(470, 0);
            this.gridNight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gridNight.MultiSelect = false;
            this.gridNight.Name = "gridNight";
            this.gridNight.ReadOnly = true;
            this.gridNight.RowHeadersVisible = false;
            this.gridNight.RowTemplate.Height = 30;
            this.gridNight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNight.Size = new System.Drawing.Size(464, 550);
            this.gridNight.TabIndex = 1;
            // 
            // colNightHour
            // 
            this.colNightHour.FillWeight = 26F;
            this.colNightHour.HeaderText = "时间段";
            this.colNightHour.Name = "colNightHour";
            this.colNightHour.ReadOnly = true;
            // 
            // colNightRun
            // 
            this.colNightRun.FillWeight = 19F;
            this.colNightRun.HeaderText = "运行时间";
            this.colNightRun.Name = "colNightRun";
            this.colNightRun.ReadOnly = true;
            // 
            // colNightIdle
            // 
            this.colNightIdle.FillWeight = 19F;
            this.colNightIdle.HeaderText = "待机时间";
            this.colNightIdle.Name = "colNightIdle";
            this.colNightIdle.ReadOnly = true;
            // 
            // colNightPlan
            // 
            this.colNightPlan.FillWeight = 18F;
            this.colNightPlan.HeaderText = "计划停机";
            this.colNightPlan.Name = "colNightPlan";
            this.colNightPlan.ReadOnly = true;
            // 
            // colNightFault
            // 
            this.colNightFault.FillWeight = 18F;
            this.colNightFault.HeaderText = "异常时间";
            this.colNightFault.Name = "colNightFault";
            this.colNightFault.ReadOnly = true;
            // 
            // gridCt
            // 
            this.gridCt.AllowUserToAddRows = false;
            this.gridCt.AllowUserToDeleteRows = false;
            this.gridCt.AllowUserToResizeRows = false;
            this.gridCt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCt.BackgroundColor = System.Drawing.Color.White;
            this.gridCt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCt.ColumnHeadersVisible = false;
            this.gridCt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCtName,
            this.colCtValue});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridCt.DefaultCellStyle = dataGridViewCellStyle4;
            this.gridCt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCt.EnableHeadersVisualStyles = false;
            this.gridCt.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.gridCt.Location = new System.Drawing.Point(938, 0);
            this.gridCt.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.gridCt.MultiSelect = false;
            this.gridCt.Name = "gridCt";
            this.gridCt.ReadOnly = true;
            this.gridCt.RowHeadersVisible = false;
            this.gridCt.RowTemplate.Height = 40;
            this.gridCt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCt.Size = new System.Drawing.Size(234, 550);
            this.gridCt.TabIndex = 2;
            // 
            // colCtName
            // 
            this.colCtName.FillWeight = 62F;
            this.colCtName.HeaderText = "项目";
            this.colCtName.Name = "colCtName";
            this.colCtName.ReadOnly = true;
            // 
            // colCtValue
            // 
            this.colCtValue.FillWeight = 38F;
            this.colCtValue.HeaderText = "值";
            this.colCtValue.Name = "colCtValue";
            this.colCtValue.ReadOnly = true;
            // 
            // chartPanel
            // 
            this.chartPanel.ColumnCount = 1;
            this.chartPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chartPanel.Controls.Add(this.plotTime, 0, 0);
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel.Location = new System.Drawing.Point(0, 0);
            this.chartPanel.Margin = new System.Windows.Forms.Padding(0);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.RowCount = 1;
            this.chartPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.chartPanel.Size = new System.Drawing.Size(1172, 550);
            this.chartPanel.TabIndex = 1;
            this.chartPanel.Visible = false;
            // 
            // plotTime
            // 
            this.plotTime.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotTime.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LabelStyle.Angle = -45;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Interval = 2D;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisY.LabelStyle.Format = "0";
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisY.MajorGrid.Enabled = false;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 60D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "main";
            this.plotTime.ChartAreas.Add(chartArea1);
            this.plotTime.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            legend1.Font = new System.Drawing.Font("微软雅黑", 9F);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            legend1.Name = "legend";
            this.plotTime.Legends.Add(legend1);
            this.plotTime.Location = new System.Drawing.Point(0, 0);
            this.plotTime.Margin = new System.Windows.Forms.Padding(0);
            this.plotTime.Name = "plotTime";
            series1.ChartArea = "main";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            series1.Legend = "legend";
            series1.LegendText = "异常时间";
            series1.Name = "图例异常时间";
            series2.ChartArea = "main";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            series2.Legend = "legend";
            series2.LegendText = "计划停机";
            series2.Name = "图例计划停机";
            series3.ChartArea = "main";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            series3.Legend = "legend";
            series3.LegendText = "待机时间";
            series3.Name = "图例待机时间";
            series4.ChartArea = "main";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            series4.Legend = "legend";
            series4.LegendText = "运行时间";
            series4.Name = "图例运行时间";
            series5.ChartArea = "main";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            series5.IsVisibleInLegend = false;
            series5.Legend = "legend";
            series5.Name = "运行时间";
            series6.ChartArea = "main";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            series6.IsVisibleInLegend = false;
            series6.Legend = "legend";
            series6.Name = "待机时间";
            series7.ChartArea = "main";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            series7.IsVisibleInLegend = false;
            series7.Legend = "legend";
            series7.Name = "计划停机";
            series8.ChartArea = "main";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            series8.IsVisibleInLegend = false;
            series8.Legend = "legend";
            series8.Name = "异常时间";
            this.plotTime.Series.Add(series1);
            this.plotTime.Series.Add(series2);
            this.plotTime.Series.Add(series3);
            this.plotTime.Series.Add(series4);
            this.plotTime.Series.Add(series5);
            this.plotTime.Series.Add(series6);
            this.plotTime.Series.Add(series7);
            this.plotTime.Series.Add(series8);
            this.plotTime.Size = new System.Drawing.Size(1172, 550);
            this.plotTime.TabIndex = 0;
            title1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            title1.Name = "titleTime";
            title1.Text = "Hour DT";
            this.plotTime.Titles.Add(title1);
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
            this.bottomPanel.TabIndex = 2;
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
            this.btnExport.Location = new System.Drawing.Point(980, 12);
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
            // PageTimeStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageTimeStatistics";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridNight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCt)).EndInit();
            this.chartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotTime)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel toolbar;
        private System.Windows.Forms.RadioButton radioList;
        private System.Windows.Forms.RadioButton radioChart;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.CheckBox autoRefresh;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.TableLayoutPanel listPanel;
        private System.Windows.Forms.DataGridView gridDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayIdle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayFault;
        private System.Windows.Forms.DataGridView gridNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightHour;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightIdle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightFault;
        private System.Windows.Forms.DataGridView gridCt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCtValue;
        private System.Windows.Forms.TableLayoutPanel chartPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotTime;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Timer refresh;
    }
}
