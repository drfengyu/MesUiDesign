namespace Mes.Hmi.Statistics
{
    partial class PageCpk
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.contentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.chartGrid = new System.Windows.Forms.TableLayoutPanel();
            this.cardNormal = new System.Windows.Forms.TableLayoutPanel();
            this.normalTitle = new System.Windows.Forms.Label();
            this.plotNormal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cardSample = new System.Windows.Forms.TableLayoutPanel();
            this.sampleTitle = new System.Windows.Forms.Label();
            this.sampleBar = new System.Windows.Forms.TableLayoutPanel();
            this.checkTarget = new System.Windows.Forms.CheckBox();
            this.checkNow = new System.Windows.Forms.CheckBox();
            this.checkMax = new System.Windows.Forms.CheckBox();
            this.checkMin = new System.Windows.Forms.CheckBox();
            this.plotSample = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cardHist = new System.Windows.Forms.TableLayoutPanel();
            this.histTitle = new System.Windows.Forms.Label();
            this.plotHist = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cardRecent = new System.Windows.Forms.TableLayoutPanel();
            this.recentTitle = new System.Windows.Forms.Label();
            this.plotRecent = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.settingsPanel = new System.Windows.Forms.TableLayoutPanel();
            this.groupLabel = new System.Windows.Forms.Label();
            this.comboGroup = new System.Windows.Forms.ComboBox();
            this.itemLabel = new System.Windows.Forms.Label();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.targetLabel = new System.Windows.Forms.Label();
            this.textTarget = new System.Windows.Forms.TextBox();
            this.upperLabel = new System.Windows.Forms.Label();
            this.textUpper = new System.Windows.Forms.TextBox();
            this.lowerLabel = new System.Windows.Forms.Label();
            this.textLower = new System.Windows.Forms.TextBox();
            this.countLabel = new System.Windows.Forms.Label();
            this.textCount = new System.Windows.Forms.TextBox();
            this.fromLabel = new System.Windows.Forms.Label();
            this.pickFrom = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.pickTo = new System.Windows.Forms.DateTimePicker();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.readoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.cpkLabel = new System.Windows.Forms.Label();
            this.cpkValue = new System.Windows.Forms.Label();
            this.deviationLabel = new System.Windows.Forms.Label();
            this.deviationValue = new System.Windows.Forms.Label();
            this.btnCompensate = new System.Windows.Forms.Button();
            this.checkAuto = new System.Windows.Forms.CheckBox();
            this.noteLabel = new System.Windows.Forms.Label();
            this.root.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.chartGrid.SuspendLayout();
            this.cardNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotNormal)).BeginInit();
            this.cardSample.SuspendLayout();
            this.sampleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotSample)).BeginInit();
            this.cardHist.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotHist)).BeginInit();
            this.cardRecent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotRecent)).BeginInit();
            this.settingsPanel.SuspendLayout();
            this.readoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.contentPanel, 0, 0);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 1;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.ColumnCount = 2;
            this.contentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.contentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.contentPanel.Controls.Add(this.chartGrid, 0, 0);
            this.contentPanel.Controls.Add(this.settingsPanel, 1, 0);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(4, 4);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.RowCount = 1;
            this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentPanel.Size = new System.Drawing.Size(1172, 652);
            this.contentPanel.TabIndex = 0;
            // 
            // chartGrid
            // 
            this.chartGrid.ColumnCount = 2;
            this.chartGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartGrid.Controls.Add(this.cardNormal, 0, 0);
            this.chartGrid.Controls.Add(this.cardSample, 1, 0);
            this.chartGrid.Controls.Add(this.cardHist, 0, 1);
            this.chartGrid.Controls.Add(this.cardRecent, 1, 1);
            this.chartGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartGrid.Location = new System.Drawing.Point(0, 0);
            this.chartGrid.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.chartGrid.Name = "chartGrid";
            this.chartGrid.RowCount = 2;
            this.chartGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.chartGrid.Size = new System.Drawing.Size(886, 652);
            this.chartGrid.TabIndex = 0;
            // 
            // cardNormal
            // 
            this.cardNormal.BackColor = System.Drawing.Color.White;
            this.cardNormal.ColumnCount = 1;
            this.cardNormal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardNormal.Controls.Add(this.normalTitle, 0, 0);
            this.cardNormal.Controls.Add(this.plotNormal, 0, 1);
            this.cardNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardNormal.Location = new System.Drawing.Point(0, 0);
            this.cardNormal.Margin = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.cardNormal.Name = "cardNormal";
            this.cardNormal.RowCount = 2;
            this.cardNormal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.cardNormal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardNormal.Size = new System.Drawing.Size(441, 324);
            this.cardNormal.TabIndex = 0;
            // 
            // normalTitle
            // 
            this.normalTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.normalTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.normalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.normalTitle.Location = new System.Drawing.Point(0, 0);
            this.normalTitle.Margin = new System.Windows.Forms.Padding(0);
            this.normalTitle.Name = "normalTitle";
            this.normalTitle.Size = new System.Drawing.Size(441, 28);
            this.normalTitle.TabIndex = 0;
            this.normalTitle.Text = "正态分布曲线";
            this.normalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plotNormal
            // 
            this.plotNormal.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotNormal.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea1.AxisX.LabelStyle.Format = "0.###";
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea1.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea1.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "main";
            this.plotNormal.ChartAreas.Add(chartArea1);
            this.plotNormal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotNormal.Location = new System.Drawing.Point(0, 28);
            this.plotNormal.Margin = new System.Windows.Forms.Padding(0);
            this.plotNormal.Name = "plotNormal";
            series1.ChartArea = "main";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(220)))));
            series1.Name = "正态分布";
            this.plotNormal.Series.Add(series1);
            this.plotNormal.Size = new System.Drawing.Size(441, 296);
            this.plotNormal.TabIndex = 1;
            // 
            // cardSample
            // 
            this.cardSample.BackColor = System.Drawing.Color.White;
            this.cardSample.ColumnCount = 1;
            this.cardSample.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardSample.Controls.Add(this.sampleTitle, 0, 0);
            this.cardSample.Controls.Add(this.sampleBar, 0, 1);
            this.cardSample.Controls.Add(this.plotSample, 0, 2);
            this.cardSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardSample.Location = new System.Drawing.Point(445, 0);
            this.cardSample.Margin = new System.Windows.Forms.Padding(2, 0, 0, 2);
            this.cardSample.Name = "cardSample";
            this.cardSample.RowCount = 3;
            this.cardSample.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.cardSample.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.cardSample.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardSample.Size = new System.Drawing.Size(441, 324);
            this.cardSample.TabIndex = 1;
            // 
            // sampleTitle
            // 
            this.sampleTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.sampleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.sampleTitle.Location = new System.Drawing.Point(0, 0);
            this.sampleTitle.Margin = new System.Windows.Forms.Padding(0);
            this.sampleTitle.Name = "sampleTitle";
            this.sampleTitle.Size = new System.Drawing.Size(441, 28);
            this.sampleTitle.TabIndex = 0;
            this.sampleTitle.Text = "样品数据分布";
            this.sampleTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sampleBar
            // 
            this.sampleBar.ColumnCount = 4;
            this.sampleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.sampleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.sampleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.sampleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.sampleBar.Controls.Add(this.checkTarget, 0, 0);
            this.sampleBar.Controls.Add(this.checkNow, 1, 0);
            this.sampleBar.Controls.Add(this.checkMax, 2, 0);
            this.sampleBar.Controls.Add(this.checkMin, 3, 0);
            this.sampleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleBar.Location = new System.Drawing.Point(0, 28);
            this.sampleBar.Margin = new System.Windows.Forms.Padding(0);
            this.sampleBar.Name = "sampleBar";
            this.sampleBar.RowCount = 1;
            this.sampleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sampleBar.Size = new System.Drawing.Size(441, 28);
            this.sampleBar.TabIndex = 0;
            // 
            // checkTarget
            // 
            this.checkTarget.Checked = true;
            this.checkTarget.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkTarget.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.checkTarget.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            this.checkTarget.Location = new System.Drawing.Point(0, 0);
            this.checkTarget.Margin = new System.Windows.Forms.Padding(0);
            this.checkTarget.Name = "checkTarget";
            this.checkTarget.Size = new System.Drawing.Size(110, 28);
            this.checkTarget.TabIndex = 0;
            this.checkTarget.Text = "标准值";
            this.checkTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkTarget.UseVisualStyleBackColor = true;
            this.checkTarget.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // checkNow
            // 
            this.checkNow.Checked = true;
            this.checkNow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkNow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkNow.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.checkNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            this.checkNow.Location = new System.Drawing.Point(110, 0);
            this.checkNow.Margin = new System.Windows.Forms.Padding(0);
            this.checkNow.Name = "checkNow";
            this.checkNow.Size = new System.Drawing.Size(110, 28);
            this.checkNow.TabIndex = 1;
            this.checkNow.Text = "当前值";
            this.checkNow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkNow.UseVisualStyleBackColor = true;
            this.checkNow.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // checkMax
            // 
            this.checkMax.Checked = true;
            this.checkMax.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkMax.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.checkMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.checkMax.Location = new System.Drawing.Point(220, 0);
            this.checkMax.Margin = new System.Windows.Forms.Padding(0);
            this.checkMax.Name = "checkMax";
            this.checkMax.Size = new System.Drawing.Size(110, 28);
            this.checkMax.TabIndex = 2;
            this.checkMax.Text = "最大值";
            this.checkMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMax.UseVisualStyleBackColor = true;
            this.checkMax.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // checkMin
            // 
            this.checkMin.Checked = true;
            this.checkMin.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkMin.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.checkMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            this.checkMin.Location = new System.Drawing.Point(330, 0);
            this.checkMin.Margin = new System.Windows.Forms.Padding(0);
            this.checkMin.Name = "checkMin";
            this.checkMin.Size = new System.Drawing.Size(111, 28);
            this.checkMin.TabIndex = 3;
            this.checkMin.Text = "最小值";
            this.checkMin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkMin.UseVisualStyleBackColor = true;
            this.checkMin.CheckedChanged += new System.EventHandler(this.check_CheckedChanged);
            // 
            // plotSample
            // 
            this.plotSample.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotSample.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea2.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea2.AxisY.LabelStyle.Format = "0.###";
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "main";
            this.plotSample.ChartAreas.Add(chartArea2);
            this.plotSample.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotSample.Location = new System.Drawing.Point(0, 56);
            this.plotSample.Margin = new System.Windows.Forms.Padding(0);
            this.plotSample.Name = "plotSample";
            series2.BorderWidth = 2;
            series2.ChartArea = "main";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(120)))), ((int)(((byte)(210)))));
            series2.MarkerSize = 4;
            series2.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series2.Name = "当前值";
            series3.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series3.BorderWidth = 2;
            series3.ChartArea = "main";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(140)))), ((int)(((byte)(0)))));
            series3.Name = "标准值";
            series4.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series4.BorderWidth = 2;
            series4.ChartArea = "main";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            series4.Name = "最大值";
            series5.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series5.BorderWidth = 2;
            series5.ChartArea = "main";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(80)))));
            series5.Name = "最小值";
            this.plotSample.Series.Add(series2);
            this.plotSample.Series.Add(series3);
            this.plotSample.Series.Add(series4);
            this.plotSample.Series.Add(series5);
            this.plotSample.Size = new System.Drawing.Size(441, 268);
            this.plotSample.TabIndex = 1;
            // 
            // cardHist
            // 
            this.cardHist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cardHist.ColumnCount = 1;
            this.cardHist.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardHist.Controls.Add(this.histTitle, 0, 0);
            this.cardHist.Controls.Add(this.plotHist, 0, 1);
            this.cardHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardHist.Location = new System.Drawing.Point(0, 328);
            this.cardHist.Margin = new System.Windows.Forms.Padding(0, 2, 2, 0);
            this.cardHist.Name = "cardHist";
            this.cardHist.RowCount = 2;
            this.cardHist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.cardHist.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardHist.Size = new System.Drawing.Size(441, 324);
            this.cardHist.TabIndex = 2;
            // 
            // histTitle
            // 
            this.histTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.histTitle.ForeColor = System.Drawing.Color.White;
            this.histTitle.Location = new System.Drawing.Point(0, 0);
            this.histTitle.Margin = new System.Windows.Forms.Padding(0);
            this.histTitle.Name = "histTitle";
            this.histTitle.Size = new System.Drawing.Size(441, 28);
            this.histTitle.TabIndex = 0;
            this.histTitle.Text = "分段计数";
            this.histTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plotHist
            // 
            this.plotHist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.plotHist.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.plotHist.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.AxisX.LabelStyle.Angle = -30;
            chartArea3.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 7.5F);
            chartArea3.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            chartArea3.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(122)))));
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.MajorTickMark.Enabled = false;
            chartArea3.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea3.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(230)))), ((int)(((byte)(235)))));
            chartArea3.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(122)))));
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(60)))), ((int)(((byte)(65)))));
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.MajorTickMark.Enabled = false;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            chartArea3.Name = "main";
            this.plotHist.ChartAreas.Add(chartArea3);
            this.plotHist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotHist.Location = new System.Drawing.Point(0, 28);
            this.plotHist.Margin = new System.Windows.Forms.Padding(0);
            this.plotHist.Name = "plotHist";
            series6.ChartArea = "main";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(220)))));
            series6.Name = "分段计数";
            this.plotHist.Series.Add(series6);
            this.plotHist.Size = new System.Drawing.Size(441, 296);
            this.plotHist.TabIndex = 1;
            // 
            // cardRecent
            // 
            this.cardRecent.BackColor = System.Drawing.Color.White;
            this.cardRecent.ColumnCount = 1;
            this.cardRecent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardRecent.Controls.Add(this.recentTitle, 0, 0);
            this.cardRecent.Controls.Add(this.plotRecent, 0, 1);
            this.cardRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cardRecent.Location = new System.Drawing.Point(445, 328);
            this.cardRecent.Margin = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.cardRecent.Name = "cardRecent";
            this.cardRecent.RowCount = 2;
            this.cardRecent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.cardRecent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardRecent.Size = new System.Drawing.Size(441, 324);
            this.cardRecent.TabIndex = 3;
            // 
            // recentTitle
            // 
            this.recentTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.recentTitle.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.recentTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.recentTitle.Location = new System.Drawing.Point(0, 0);
            this.recentTitle.Margin = new System.Windows.Forms.Padding(0);
            this.recentTitle.Name = "recentTitle";
            this.recentTitle.Size = new System.Drawing.Size(441, 28);
            this.recentTitle.TabIndex = 0;
            this.recentTitle.Text = "最近8组CPK";
            this.recentTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plotRecent
            // 
            this.plotRecent.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotRecent.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea4.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea4.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.MajorTickMark.Enabled = false;
            chartArea4.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea4.AxisY.LabelStyle.Format = "0.00";
            chartArea4.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea4.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.MajorTickMark.Enabled = false;
            chartArea4.AxisY.Minimum = 0D;
            chartArea4.AxisY2.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            chartArea4.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(90)))));
            chartArea4.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            chartArea4.AxisY2.MajorGrid.Enabled = false;
            chartArea4.AxisY2.MajorTickMark.Enabled = false;
            chartArea4.AxisY2.Minimum = 0D;
            chartArea4.BackColor = System.Drawing.Color.White;
            chartArea4.Name = "main";
            this.plotRecent.ChartAreas.Add(chartArea4);
            this.plotRecent.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend1.Font = new System.Drawing.Font("微软雅黑", 8F);
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            legend1.IsTextAutoFit = false;
            legend1.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Row;
            legend1.Name = "legend";
            this.plotRecent.Legends.Add(legend1);
            this.plotRecent.Location = new System.Drawing.Point(0, 28);
            this.plotRecent.Margin = new System.Windows.Forms.Padding(0);
            this.plotRecent.Name = "plotRecent";
            series7.ChartArea = "main";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(220)))));
            series7.Legend = "legend";
            series7.LegendText = "中值";
            series7.Name = "图例中值";
            series8.ChartArea = "main";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            series8.Legend = "legend";
            series8.LegendText = "目标值";
            series8.Name = "图例目标值";
            series9.ChartArea = "main";
            series9.Color = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            series9.Legend = "legend";
            series9.LegendText = "数据区间数量";
            series9.Name = "图例数据区间数量";
            series10.BorderWidth = 2;
            series10.ChartArea = "main";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(90)))), ((int)(((byte)(220)))));
            series10.IsVisibleInLegend = false;
            series10.Legend = "legend";
            series10.MarkerSize = 6;
            series10.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series10.Name = "中值";
            series11.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series11.BorderWidth = 2;
            series11.ChartArea = "main";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(150)))), ((int)(((byte)(40)))));
            series11.IsVisibleInLegend = false;
            series11.Legend = "legend";
            series11.Name = "目标值";
            series12.ChartArea = "main";
            series12.Color = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(205)))), ((int)(((byte)(175)))));
            series12.IsVisibleInLegend = false;
            series12.Legend = "legend";
            series12.Name = "数据区间数量";
            series12.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.plotRecent.Series.Add(series7);
            this.plotRecent.Series.Add(series8);
            this.plotRecent.Series.Add(series9);
            this.plotRecent.Series.Add(series10);
            this.plotRecent.Series.Add(series11);
            this.plotRecent.Series.Add(series12);
            this.plotRecent.Size = new System.Drawing.Size(441, 296);
            this.plotRecent.TabIndex = 1;
            // 
            // settingsPanel
            // 
            this.settingsPanel.ColumnCount = 2;
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.settingsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsPanel.Controls.Add(this.groupLabel, 0, 1);
            this.settingsPanel.Controls.Add(this.comboGroup, 1, 1);
            this.settingsPanel.Controls.Add(this.itemLabel, 0, 2);
            this.settingsPanel.Controls.Add(this.comboItem, 1, 2);
            this.settingsPanel.Controls.Add(this.targetLabel, 0, 3);
            this.settingsPanel.Controls.Add(this.textTarget, 1, 3);
            this.settingsPanel.Controls.Add(this.upperLabel, 0, 4);
            this.settingsPanel.Controls.Add(this.textUpper, 1, 4);
            this.settingsPanel.Controls.Add(this.lowerLabel, 0, 5);
            this.settingsPanel.Controls.Add(this.textLower, 1, 5);
            this.settingsPanel.Controls.Add(this.countLabel, 0, 6);
            this.settingsPanel.Controls.Add(this.textCount, 1, 6);
            this.settingsPanel.Controls.Add(this.fromLabel, 0, 7);
            this.settingsPanel.Controls.Add(this.pickFrom, 1, 7);
            this.settingsPanel.Controls.Add(this.toLabel, 0, 8);
            this.settingsPanel.Controls.Add(this.pickTo, 1, 8);
            this.settingsPanel.Controls.Add(this.btnUpdate, 0, 9);
            this.settingsPanel.Controls.Add(this.readoutPanel, 0, 10);
            this.settingsPanel.Controls.Add(this.btnCompensate, 0, 11);
            this.settingsPanel.Controls.Add(this.checkAuto, 0, 12);
            this.settingsPanel.Controls.Add(this.noteLabel, 0, 13);
            this.settingsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPanel.Location = new System.Drawing.Point(894, 0);
            this.settingsPanel.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.settingsPanel.Name = "settingsPanel";
            this.settingsPanel.Padding = new System.Windows.Forms.Padding(6, 4, 4, 4);
            this.settingsPanel.RowCount = 15;
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.settingsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.settingsPanel.Size = new System.Drawing.Size(278, 652);
            this.settingsPanel.TabIndex = 1;
            // 
            // groupLabel
            // 
            this.groupLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.groupLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.groupLabel.Location = new System.Drawing.Point(6, 14);
            this.groupLabel.Margin = new System.Windows.Forms.Padding(0);
            this.groupLabel.Name = "groupLabel";
            this.groupLabel.Size = new System.Drawing.Size(84, 34);
            this.groupLabel.TabIndex = 0;
            this.groupLabel.Text = "分组名称:";
            this.groupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboGroup
            // 
            this.comboGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboGroup.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboGroup.FormattingEnabled = true;
            this.comboGroup.Location = new System.Drawing.Point(94, 18);
            this.comboGroup.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.comboGroup.Name = "comboGroup";
            this.comboGroup.Size = new System.Drawing.Size(180, 25);
            this.comboGroup.TabIndex = 1;
            this.comboGroup.SelectedIndexChanged += new System.EventHandler(this.comboGroup_SelectedIndexChanged);
            // 
            // itemLabel
            // 
            this.itemLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.itemLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.itemLabel.Location = new System.Drawing.Point(6, 48);
            this.itemLabel.Margin = new System.Windows.Forms.Padding(0);
            this.itemLabel.Name = "itemLabel";
            this.itemLabel.Size = new System.Drawing.Size(84, 34);
            this.itemLabel.TabIndex = 2;
            this.itemLabel.Text = "选择项:";
            this.itemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboItem
            // 
            this.comboItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboItem.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(94, 52);
            this.comboItem.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(180, 25);
            this.comboItem.TabIndex = 3;
            this.comboItem.SelectedIndexChanged += new System.EventHandler(this.comboItem_SelectedIndexChanged);
            // 
            // targetLabel
            // 
            this.targetLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.targetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.targetLabel.Location = new System.Drawing.Point(6, 82);
            this.targetLabel.Margin = new System.Windows.Forms.Padding(0);
            this.targetLabel.Name = "targetLabel";
            this.targetLabel.Size = new System.Drawing.Size(84, 34);
            this.targetLabel.TabIndex = 4;
            this.targetLabel.Text = "目标值:";
            this.targetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textTarget
            // 
            this.textTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textTarget.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textTarget.Location = new System.Drawing.Point(94, 86);
            this.textTarget.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.textTarget.Name = "textTarget";
            this.textTarget.Size = new System.Drawing.Size(180, 23);
            this.textTarget.TabIndex = 5;
            // 
            // upperLabel
            // 
            this.upperLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.upperLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.upperLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.upperLabel.Location = new System.Drawing.Point(6, 116);
            this.upperLabel.Margin = new System.Windows.Forms.Padding(0);
            this.upperLabel.Name = "upperLabel";
            this.upperLabel.Size = new System.Drawing.Size(84, 34);
            this.upperLabel.TabIndex = 6;
            this.upperLabel.Text = "上限值:";
            this.upperLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textUpper
            // 
            this.textUpper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textUpper.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textUpper.Location = new System.Drawing.Point(94, 120);
            this.textUpper.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.textUpper.Name = "textUpper";
            this.textUpper.Size = new System.Drawing.Size(180, 23);
            this.textUpper.TabIndex = 7;
            // 
            // lowerLabel
            // 
            this.lowerLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lowerLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lowerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.lowerLabel.Location = new System.Drawing.Point(6, 150);
            this.lowerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.lowerLabel.Name = "lowerLabel";
            this.lowerLabel.Size = new System.Drawing.Size(84, 34);
            this.lowerLabel.TabIndex = 8;
            this.lowerLabel.Text = "下限值:";
            this.lowerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textLower
            // 
            this.textLower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLower.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textLower.Location = new System.Drawing.Point(94, 154);
            this.textLower.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.textLower.Name = "textLower";
            this.textLower.Size = new System.Drawing.Size(180, 23);
            this.textLower.TabIndex = 9;
            // 
            // countLabel
            // 
            this.countLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.countLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.countLabel.Location = new System.Drawing.Point(6, 184);
            this.countLabel.Margin = new System.Windows.Forms.Padding(0);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(84, 34);
            this.countLabel.TabIndex = 10;
            this.countLabel.Text = "选取产品数量:";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textCount
            // 
            this.textCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.textCount.Location = new System.Drawing.Point(94, 188);
            this.textCount.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.textCount.Name = "textCount";
            this.textCount.Size = new System.Drawing.Size(180, 23);
            this.textCount.TabIndex = 11;
            this.textCount.Text = "32";
            // 
            // fromLabel
            // 
            this.fromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.fromLabel.Location = new System.Drawing.Point(6, 218);
            this.fromLabel.Margin = new System.Windows.Forms.Padding(0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(84, 38);
            this.fromLabel.TabIndex = 12;
            this.fromLabel.Text = "开始时间:";
            this.fromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pickFrom
            // 
            this.pickFrom.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.pickFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickFrom.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.pickFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickFrom.Location = new System.Drawing.Point(94, 222);
            this.pickFrom.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.pickFrom.Name = "pickFrom";
            this.pickFrom.Size = new System.Drawing.Size(180, 22);
            this.pickFrom.TabIndex = 13;
            // 
            // toLabel
            // 
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.toLabel.Location = new System.Drawing.Point(6, 256);
            this.toLabel.Margin = new System.Windows.Forms.Padding(0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(84, 38);
            this.toLabel.TabIndex = 14;
            this.toLabel.Text = "结束时间:";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pickTo
            // 
            this.pickTo.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.pickTo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pickTo.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.pickTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickTo.Location = new System.Drawing.Point(94, 260);
            this.pickTo.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.pickTo.Name = "pickTo";
            this.pickTo.Size = new System.Drawing.Size(180, 22);
            this.pickTo.TabIndex = 15;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.settingsPanel.SetColumnSpan(this.btnUpdate, 2);
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(6, 300);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(268, 34);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "更新数据";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // readoutPanel
            // 
            this.readoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.readoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.readoutPanel.ColumnCount = 2;
            this.settingsPanel.SetColumnSpan(this.readoutPanel, 2);
            this.readoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48F));
            this.readoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52F));
            this.readoutPanel.Controls.Add(this.cpkLabel, 0, 0);
            this.readoutPanel.Controls.Add(this.cpkValue, 1, 0);
            this.readoutPanel.Controls.Add(this.deviationLabel, 0, 1);
            this.readoutPanel.Controls.Add(this.deviationValue, 1, 1);
            this.readoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readoutPanel.Location = new System.Drawing.Point(6, 344);
            this.readoutPanel.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.readoutPanel.Name = "readoutPanel";
            this.readoutPanel.RowCount = 2;
            this.readoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.readoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.readoutPanel.Size = new System.Drawing.Size(268, 78);
            this.readoutPanel.TabIndex = 17;
            // 
            // cpkLabel
            // 
            this.cpkLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpkLabel.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.cpkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.cpkLabel.Location = new System.Drawing.Point(1, 1);
            this.cpkLabel.Margin = new System.Windows.Forms.Padding(0);
            this.cpkLabel.Name = "cpkLabel";
            this.cpkLabel.Size = new System.Drawing.Size(127, 37);
            this.cpkLabel.TabIndex = 0;
            this.cpkLabel.Text = "CPK";
            this.cpkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cpkValue
            // 
            this.cpkValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cpkValue.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.cpkValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            this.cpkValue.Location = new System.Drawing.Point(129, 1);
            this.cpkValue.Margin = new System.Windows.Forms.Padding(0);
            this.cpkValue.Name = "cpkValue";
            this.cpkValue.Size = new System.Drawing.Size(138, 37);
            this.cpkValue.TabIndex = 1;
            this.cpkValue.Text = "--";
            this.cpkValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deviationLabel
            // 
            this.deviationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviationLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.deviationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.deviationLabel.Location = new System.Drawing.Point(1, 39);
            this.deviationLabel.Margin = new System.Windows.Forms.Padding(0);
            this.deviationLabel.Name = "deviationLabel";
            this.deviationLabel.Size = new System.Drawing.Size(127, 38);
            this.deviationLabel.TabIndex = 2;
            this.deviationLabel.Text = "数据组偏差";
            this.deviationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deviationValue
            // 
            this.deviationValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deviationValue.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.deviationValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(110)))), ((int)(((byte)(20)))));
            this.deviationValue.Location = new System.Drawing.Point(129, 39);
            this.deviationValue.Margin = new System.Windows.Forms.Padding(0);
            this.deviationValue.Name = "deviationValue";
            this.deviationValue.Size = new System.Drawing.Size(138, 38);
            this.deviationValue.TabIndex = 3;
            this.deviationValue.Text = "--";
            this.deviationValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCompensate
            // 
            this.btnCompensate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(238)))), ((int)(((byte)(246)))));
            this.settingsPanel.SetColumnSpan(this.btnCompensate, 2);
            this.btnCompensate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompensate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(185)))), ((int)(((byte)(215)))));
            this.btnCompensate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompensate.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnCompensate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.btnCompensate.Location = new System.Drawing.Point(6, 432);
            this.btnCompensate.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnCompensate.Name = "btnCompensate";
            this.btnCompensate.Size = new System.Drawing.Size(268, 34);
            this.btnCompensate.TabIndex = 18;
            this.btnCompensate.Text = "确认补偿偏差";
            this.btnCompensate.UseVisualStyleBackColor = false;
            this.btnCompensate.Click += new System.EventHandler(this.btnCompensate_Click);
            // 
            // checkAuto
            // 
            this.checkAuto.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkAuto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(116)))), ((int)(((byte)(124)))));
            this.settingsPanel.SetColumnSpan(this.checkAuto, 2);
            this.checkAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkAuto.FlatAppearance.BorderSize = 0;
            this.checkAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkAuto.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.checkAuto.ForeColor = System.Drawing.Color.White;
            this.checkAuto.Location = new System.Drawing.Point(6, 478);
            this.checkAuto.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.checkAuto.Name = "checkAuto";
            this.checkAuto.Size = new System.Drawing.Size(268, 34);
            this.checkAuto.TabIndex = 19;
            this.checkAuto.Text = "自动补偿：关";
            this.checkAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkAuto.UseVisualStyleBackColor = false;
            this.checkAuto.CheckedChanged += new System.EventHandler(this.checkAuto_CheckedChanged);
            // 
            // noteLabel
            // 
            this.settingsPanel.SetColumnSpan(this.noteLabel, 2);
            this.noteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLabel.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.noteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(134)))));
            this.noteLabel.Location = new System.Drawing.Point(6, 518);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(268, 64);
            this.noteLabel.TabIndex = 20;
            this.noteLabel.Text = "补偿条件：CPK 位于规格范围内（≥1.33）\r\n补偿值 = 平均值 - 标准值";
            // 
            // PageCpk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.root);
            this.Name = "PageCpk";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.chartGrid.ResumeLayout(false);
            this.cardNormal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotNormal)).EndInit();
            this.cardSample.ResumeLayout(false);
            this.sampleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotSample)).EndInit();
            this.cardHist.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotHist)).EndInit();
            this.cardRecent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotRecent)).EndInit();
            this.settingsPanel.ResumeLayout(false);
            this.settingsPanel.PerformLayout();
            this.readoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel contentPanel;
        private System.Windows.Forms.TableLayoutPanel chartGrid;
        private System.Windows.Forms.TableLayoutPanel cardNormal;
        private System.Windows.Forms.Label normalTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotNormal;
        private System.Windows.Forms.TableLayoutPanel cardSample;
        private System.Windows.Forms.Label sampleTitle;
        private System.Windows.Forms.TableLayoutPanel sampleBar;
        private System.Windows.Forms.CheckBox checkTarget;
        private System.Windows.Forms.CheckBox checkNow;
        private System.Windows.Forms.CheckBox checkMax;
        private System.Windows.Forms.CheckBox checkMin;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotSample;
        private System.Windows.Forms.TableLayoutPanel cardHist;
        private System.Windows.Forms.Label histTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotHist;
        private System.Windows.Forms.TableLayoutPanel cardRecent;
        private System.Windows.Forms.Label recentTitle;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotRecent;
        private System.Windows.Forms.TableLayoutPanel settingsPanel;
        private System.Windows.Forms.Label groupLabel;
        private System.Windows.Forms.ComboBox comboGroup;
        private System.Windows.Forms.Label itemLabel;
        private System.Windows.Forms.ComboBox comboItem;
        private System.Windows.Forms.Label targetLabel;
        private System.Windows.Forms.TextBox textTarget;
        private System.Windows.Forms.Label upperLabel;
        private System.Windows.Forms.TextBox textUpper;
        private System.Windows.Forms.Label lowerLabel;
        private System.Windows.Forms.TextBox textLower;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.TextBox textCount;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker pickFrom;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker pickTo;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TableLayoutPanel readoutPanel;
        private System.Windows.Forms.Label cpkLabel;
        private System.Windows.Forms.Label cpkValue;
        private System.Windows.Forms.Label deviationLabel;
        private System.Windows.Forms.Label deviationValue;
        private System.Windows.Forms.Button btnCompensate;
        private System.Windows.Forms.CheckBox checkAuto;
        private System.Windows.Forms.Label noteLabel;
    }
}
