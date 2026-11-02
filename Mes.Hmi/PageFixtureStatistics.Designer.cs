namespace Mes.Hmi
{
    partial class PageFixtureStatistics
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
            System.Windows.Forms.DataGridViewCellStyle ngHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle ngCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea quantityArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series quantitySeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title quantityTitle = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea ngArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series ngSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.toolbar = new System.Windows.Forms.TableLayoutPanel();
            this.radioQuantity = new System.Windows.Forms.RadioButton();
            this.radioNg = new System.Windows.Forms.RadioButton();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.autoRefresh = new System.Windows.Forms.CheckBox();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.quantityPanel = new System.Windows.Forms.TableLayoutPanel();
            this.optionsBar = new System.Windows.Forms.TableLayoutPanel();
            this.measureCaption = new System.Windows.Forms.Label();
            this.radioDistinct = new System.Windows.Forms.RadioButton();
            this.radioAll = new System.Windows.Forms.RadioButton();
            this.countCaption = new System.Windows.Forms.Label();
            this.plotQuantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ngPanel = new System.Windows.Forms.TableLayoutPanel();
            this.plotNg = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ngListWrap = new System.Windows.Forms.TableLayoutPanel();
            this.gridNg = new System.Windows.Forms.DataGridView();
            this.colNgCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.quantityPanel.SuspendLayout();
            this.optionsBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotQuantity)).BeginInit();
            this.ngPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotNg)).BeginInit();
            this.ngListWrap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNg)).BeginInit();
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
            this.toolbar.Controls.Add(this.radioQuantity, 0, 0);
            this.toolbar.Controls.Add(this.radioNg, 1, 0);
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
            // radioQuantity
            // 
            this.radioQuantity.Checked = true;
            this.radioQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioQuantity.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.radioQuantity.Location = new System.Drawing.Point(8, 0);
            this.radioQuantity.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.radioQuantity.Name = "radioQuantity";
            this.radioQuantity.Size = new System.Drawing.Size(96, 44);
            this.radioQuantity.TabIndex = 0;
            this.radioQuantity.TabStop = true;
            this.radioQuantity.Text = "数量统计";
            this.radioQuantity.UseVisualStyleBackColor = true;
            this.radioQuantity.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // radioNg
            // 
            this.radioNg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioNg.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.radioNg.Location = new System.Drawing.Point(104, 0);
            this.radioNg.Margin = new System.Windows.Forms.Padding(0);
            this.radioNg.Name = "radioNg";
            this.radioNg.Size = new System.Drawing.Size(104, 44);
            this.radioNg.TabIndex = 1;
            this.radioNg.Text = "异常统计";
            this.radioNg.UseVisualStyleBackColor = true;
            this.radioNg.CheckedChanged += new System.EventHandler(this.radio_CheckedChanged);
            // 
            // fromPicker
            // 
            this.fromPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.fromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromPicker.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromPicker.Location = new System.Drawing.Point(208, 10);
            this.fromPicker.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.Size = new System.Drawing.Size(188, 24);
            this.fromPicker.TabIndex = 2;
            this.fromPicker.ValueChanged += new System.EventHandler(this.fromPicker_ValueChanged);
            // 
            // toPicker
            // 
            this.toPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.toPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPicker.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toPicker.Location = new System.Drawing.Point(404, 10);
            this.toPicker.Margin = new System.Windows.Forms.Padding(0, 10, 8, 10);
            this.toPicker.Name = "toPicker";
            this.toPicker.Size = new System.Drawing.Size(188, 24);
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
            this.contentPanel.Controls.Add(this.quantityPanel);
            this.contentPanel.Controls.Add(this.ngPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(4, 48);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1172, 550);
            this.contentPanel.TabIndex = 1;
            // 
            // quantityPanel
            // 
            this.quantityPanel.ColumnCount = 1;
            this.quantityPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.quantityPanel.Controls.Add(this.optionsBar, 0, 0);
            this.quantityPanel.Controls.Add(this.plotQuantity, 0, 1);
            this.quantityPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityPanel.Location = new System.Drawing.Point(0, 0);
            this.quantityPanel.Margin = new System.Windows.Forms.Padding(0);
            this.quantityPanel.Name = "quantityPanel";
            this.quantityPanel.RowCount = 2;
            this.quantityPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.quantityPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.quantityPanel.Size = new System.Drawing.Size(1172, 550);
            this.quantityPanel.TabIndex = 0;
            // 
            // optionsBar
            // 
            this.optionsBar.ColumnCount = 5;
            this.optionsBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.optionsBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.optionsBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.optionsBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 260F));
            this.optionsBar.Controls.Add(this.measureCaption, 0, 0);
            this.optionsBar.Controls.Add(this.radioDistinct, 1, 0);
            this.optionsBar.Controls.Add(this.radioAll, 2, 0);
            this.optionsBar.Controls.Add(this.countCaption, 4, 0);
            this.optionsBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.optionsBar.Location = new System.Drawing.Point(0, 0);
            this.optionsBar.Margin = new System.Windows.Forms.Padding(0);
            this.optionsBar.Name = "optionsBar";
            this.optionsBar.RowCount = 1;
            this.optionsBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.optionsBar.Size = new System.Drawing.Size(1172, 40);
            this.optionsBar.TabIndex = 0;
            // 
            // measureCaption
            // 
            this.measureCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.measureCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.measureCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.measureCaption.Location = new System.Drawing.Point(8, 0);
            this.measureCaption.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.measureCaption.Name = "measureCaption";
            this.measureCaption.Size = new System.Drawing.Size(56, 40);
            this.measureCaption.TabIndex = 0;
            this.measureCaption.Text = "口径:";
            this.measureCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioDistinct
            // 
            this.radioDistinct.Checked = true;
            this.radioDistinct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioDistinct.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.radioDistinct.Location = new System.Drawing.Point(68, 0);
            this.radioDistinct.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.radioDistinct.Name = "radioDistinct";
            this.radioDistinct.Size = new System.Drawing.Size(92, 40);
            this.radioDistinct.TabIndex = 1;
            this.radioDistinct.TabStop = true;
            this.radioDistinct.Text = "去重";
            this.radioDistinct.UseVisualStyleBackColor = true;
            this.radioDistinct.CheckedChanged += new System.EventHandler(this.measure_CheckedChanged);
            // 
            // radioAll
            // 
            this.radioAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioAll.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.radioAll.Location = new System.Drawing.Point(160, 0);
            this.radioAll.Margin = new System.Windows.Forms.Padding(0);
            this.radioAll.Name = "radioAll";
            this.radioAll.Size = new System.Drawing.Size(108, 40);
            this.radioAll.TabIndex = 2;
            this.radioAll.Text = "不去重";
            this.radioAll.UseVisualStyleBackColor = true;
            this.radioAll.CheckedChanged += new System.EventHandler(this.measure_CheckedChanged);
            // 
            // countCaption
            // 
            this.countCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.countCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.countCaption.Location = new System.Drawing.Point(912, 0);
            this.countCaption.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.countCaption.Name = "countCaption";
            this.countCaption.Size = new System.Drawing.Size(252, 40);
            this.countCaption.TabIndex = 4;
            this.countCaption.Text = "治具分类数量：0 pcs";
            this.countCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // plotQuantity
            // 
            quantityArea.AxisX.LabelStyle.Angle = -45;
            quantityArea.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            quantityArea.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            quantityArea.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            quantityArea.AxisX.MajorGrid.Enabled = false;
            quantityArea.AxisX.MajorTickMark.Enabled = false;
            quantityArea.AxisY.Interval = 10D;
            quantityArea.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            quantityArea.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            quantityArea.AxisY.LabelStyle.Format = "0";
            quantityArea.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            quantityArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            quantityArea.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            quantityArea.AxisY.MajorTickMark.Enabled = false;
            quantityArea.AxisY.Minimum = 0D;
            quantityArea.BackColor = System.Drawing.Color.White;
            quantityArea.Name = "main";
            this.plotQuantity.ChartAreas.Add(quantityArea);
            this.plotQuantity.BackColor = System.Drawing.Color.White;
            this.plotQuantity.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotQuantity.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.plotQuantity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotQuantity.Location = new System.Drawing.Point(0, 40);
            this.plotQuantity.Margin = new System.Windows.Forms.Padding(0);
            this.plotQuantity.Name = "plotQuantity";
            quantitySeries.ChartArea = "main";
            quantitySeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            quantitySeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            quantitySeries.Font = new System.Drawing.Font("微软雅黑", 8F);
            quantitySeries.IsValueShownAsLabel = true;
            quantitySeries.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            quantitySeries.Name = "治具数量";
            this.plotQuantity.Series.Add(quantitySeries);
            this.plotQuantity.Size = new System.Drawing.Size(1172, 510);
            this.plotQuantity.TabIndex = 1;
            quantityTitle.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            quantityTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            quantityTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            quantityTitle.Name = "titleQuantity";
            quantityTitle.Text = "治具数量";
            this.plotQuantity.Titles.Add(quantityTitle);
            // 
            // ngPanel
            // 
            this.ngPanel.ColumnCount = 1;
            this.ngPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ngPanel.Controls.Add(this.plotNg, 0, 0);
            this.ngPanel.Controls.Add(this.ngListWrap, 0, 1);
            this.ngPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngPanel.Location = new System.Drawing.Point(0, 0);
            this.ngPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ngPanel.Name = "ngPanel";
            this.ngPanel.RowCount = 2;
            this.ngPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.ngPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.ngPanel.Size = new System.Drawing.Size(1172, 550);
            this.ngPanel.TabIndex = 1;
            this.ngPanel.Visible = false;
            // 
            // plotNg
            // 
            ngArea.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            ngArea.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            ngArea.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            ngArea.AxisX.MajorGrid.Enabled = false;
            ngArea.AxisX.MajorTickMark.Enabled = false;
            ngArea.AxisY.Interval = 1D;
            ngArea.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            ngArea.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            ngArea.AxisY.LabelStyle.Format = "0";
            ngArea.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            ngArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            ngArea.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            ngArea.AxisY.MajorTickMark.Enabled = false;
            ngArea.AxisY.Minimum = 0D;
            ngArea.BackColor = System.Drawing.Color.White;
            ngArea.Name = "main";
            this.plotNg.ChartAreas.Add(ngArea);
            this.plotNg.BackColor = System.Drawing.Color.White;
            this.plotNg.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotNg.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.plotNg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotNg.Location = new System.Drawing.Point(0, 0);
            this.plotNg.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.plotNg.Name = "plotNg";
            ngSeries.ChartArea = "main";
            ngSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            ngSeries.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            ngSeries.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            ngSeries.IsValueShownAsLabel = true;
            ngSeries.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            ngSeries.Name = "NG数量";
            this.plotNg.Series.Add(ngSeries);
            this.plotNg.Size = new System.Drawing.Size(1172, 304);
            this.plotNg.TabIndex = 0;
            // 
            // ngListWrap
            // 
            this.ngListWrap.ColumnCount = 3;
            this.ngListWrap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ngListWrap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.ngListWrap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ngListWrap.Controls.Add(this.gridNg, 1, 0);
            this.ngListWrap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ngListWrap.Location = new System.Drawing.Point(0, 308);
            this.ngListWrap.Margin = new System.Windows.Forms.Padding(0);
            this.ngListWrap.Name = "ngListWrap";
            this.ngListWrap.RowCount = 1;
            this.ngListWrap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ngListWrap.Size = new System.Drawing.Size(1172, 242);
            this.ngListWrap.TabIndex = 1;
            // 
            // gridNg
            // 
            this.gridNg.AllowUserToAddRows = false;
            this.gridNg.AllowUserToDeleteRows = false;
            this.gridNg.AllowUserToResizeRows = false;
            this.gridNg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNg.BackgroundColor = System.Drawing.Color.White;
            this.gridNg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNg.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            ngHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            ngHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            ngHeaderStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            ngHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            ngHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            ngHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.gridNg.ColumnHeadersDefaultCellStyle = ngHeaderStyle;
            this.gridNg.ColumnHeadersHeight = 30;
            this.gridNg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridNg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNgCode,
            this.colNgCount});
            ngCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            ngCellStyle.BackColor = System.Drawing.SystemColors.Window;
            ngCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            ngCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            ngCellStyle.SelectionBackColor = System.Drawing.Color.White;
            ngCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            ngCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNg.DefaultCellStyle = ngCellStyle;
            this.gridNg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNg.EnableHeadersVisualStyles = false;
            this.gridNg.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.gridNg.Location = new System.Drawing.Point(234, 0);
            this.gridNg.Margin = new System.Windows.Forms.Padding(0);
            this.gridNg.MultiSelect = false;
            this.gridNg.Name = "gridNg";
            this.gridNg.ReadOnly = true;
            this.gridNg.RowHeadersVisible = false;
            this.gridNg.RowTemplate.Height = 30;
            this.gridNg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNg.Size = new System.Drawing.Size(704, 242);
            this.gridNg.TabIndex = 0;
            // 
            // colNgCode
            // 
            this.colNgCode.FillWeight = 65F;
            this.colNgCode.HeaderText = "治具码";
            this.colNgCode.Name = "colNgCode";
            this.colNgCode.ReadOnly = true;
            // 
            // colNgCount
            // 
            this.colNgCount.FillWeight = 35F;
            this.colNgCount.HeaderText = "异常次数";
            this.colNgCount.Name = "colNgCount";
            this.colNgCount.ReadOnly = true;
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
            // PageFixtureStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageFixtureStatistics";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.quantityPanel.ResumeLayout(false);
            this.optionsBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotQuantity)).EndInit();
            this.ngPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotNg)).EndInit();
            this.ngListWrap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNg)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel toolbar;
        private System.Windows.Forms.RadioButton radioQuantity;
        private System.Windows.Forms.RadioButton radioNg;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.CheckBox autoRefresh;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.TableLayoutPanel quantityPanel;
        private System.Windows.Forms.TableLayoutPanel optionsBar;
        private System.Windows.Forms.Label measureCaption;
        private System.Windows.Forms.RadioButton radioDistinct;
        private System.Windows.Forms.RadioButton radioAll;
        private System.Windows.Forms.Label countCaption;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotQuantity;
        private System.Windows.Forms.TableLayoutPanel ngPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotNg;
        private System.Windows.Forms.TableLayoutPanel ngListWrap;
        private System.Windows.Forms.DataGridView gridNg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgCount;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Timer refresh;
    }
}
