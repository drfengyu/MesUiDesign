namespace Mes.Hmi
{
    partial class PagePerformance
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea upArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series upZones = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation upNeedle = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.EllipseAnnotation upHub = new System.Windows.Forms.DataVisualization.Charting.EllipseAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation upValue = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation upUnit = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea uphArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series uphZones = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation uphNeedle = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.EllipseAnnotation uphHub = new System.Windows.Forms.DataVisualization.Charting.EllipseAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation uphValue = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation uphUnit = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.ChartArea yArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series yZones = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.LineAnnotation yNeedle = new System.Windows.Forms.DataVisualization.Charting.LineAnnotation();
            System.Windows.Forms.DataVisualization.Charting.EllipseAnnotation yHub = new System.Windows.Forms.DataVisualization.Charting.EllipseAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation yValue = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            System.Windows.Forms.DataVisualization.Charting.TextAnnotation yUnit = new System.Windows.Forms.DataVisualization.Charting.TextAnnotation();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.toolbar = new System.Windows.Forms.TableLayoutPanel();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.autoRefresh = new System.Windows.Forms.CheckBox();
            this.gaugesPanel = new System.Windows.Forms.TableLayoutPanel();
            this.uptimeHost = new System.Windows.Forms.TableLayoutPanel();
            this.gaugeUptime = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uptimeCaption = new System.Windows.Forms.Label();
            this.uphHost = new System.Windows.Forms.TableLayoutPanel();
            this.gaugeUph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.uphCaption = new System.Windows.Forms.Label();
            this.yieldHost = new System.Windows.Forms.TableLayoutPanel();
            this.gaugeYield = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.yieldCaption = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnDistribution = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.toolbar.SuspendLayout();
            this.gaugesPanel.SuspendLayout();
            this.uptimeHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeUptime)).BeginInit();
            this.uphHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeUph)).BeginInit();
            this.yieldHost.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gaugeYield)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.toolbar, 0, 0);
            this.root.Controls.Add(this.gaugesPanel, 0, 1);
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
            this.toolbar.ColumnCount = 5;
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 196F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.toolbar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.Controls.Add(this.fromPicker, 1, 0);
            this.toolbar.Controls.Add(this.toPicker, 2, 0);
            this.toolbar.Controls.Add(this.autoRefresh, 3, 0);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolbar.Location = new System.Drawing.Point(4, 4);
            this.toolbar.Margin = new System.Windows.Forms.Padding(0);
            this.toolbar.Name = "toolbar";
            this.toolbar.RowCount = 1;
            this.toolbar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.toolbar.Size = new System.Drawing.Size(1172, 44);
            this.toolbar.TabIndex = 0;
            // 
            // fromPicker
            // 
            this.fromPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.fromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromPicker.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromPicker.Location = new System.Drawing.Point(340, 10);
            this.fromPicker.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.Size = new System.Drawing.Size(180, 24);
            this.fromPicker.TabIndex = 0;
            this.fromPicker.ValueChanged += new System.EventHandler(this.fromPicker_ValueChanged);
            // 
            // toPicker
            // 
            this.toPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.toPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPicker.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toPicker.Location = new System.Drawing.Point(536, 10);
            this.toPicker.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.toPicker.Name = "toPicker";
            this.toPicker.Size = new System.Drawing.Size(180, 24);
            this.toPicker.TabIndex = 1;
            this.toPicker.ValueChanged += new System.EventHandler(this.toPicker_ValueChanged);
            // 
            // autoRefresh
            // 
            this.autoRefresh.Checked = true;
            this.autoRefresh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.autoRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.autoRefresh.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.autoRefresh.Location = new System.Drawing.Point(732, 0);
            this.autoRefresh.Margin = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.autoRefresh.Name = "autoRefresh";
            this.autoRefresh.Size = new System.Drawing.Size(108, 44);
            this.autoRefresh.TabIndex = 2;
            this.autoRefresh.Text = "自动刷新";
            this.autoRefresh.UseVisualStyleBackColor = true;
            // 
            // gaugesPanel
            // 
            this.gaugesPanel.ColumnCount = 3;
            this.gaugesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.gaugesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.gaugesPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.gaugesPanel.Controls.Add(this.uptimeHost, 0, 0);
            this.gaugesPanel.Controls.Add(this.uphHost, 1, 0);
            this.gaugesPanel.Controls.Add(this.yieldHost, 2, 0);
            this.gaugesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugesPanel.Location = new System.Drawing.Point(4, 48);
            this.gaugesPanel.Margin = new System.Windows.Forms.Padding(0);
            this.gaugesPanel.Name = "gaugesPanel";
            this.gaugesPanel.RowCount = 1;
            this.gaugesPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gaugesPanel.Size = new System.Drawing.Size(1172, 550);
            this.gaugesPanel.TabIndex = 1;
            // 
            // uptimeHost
            // 
            this.uptimeHost.ColumnCount = 1;
            this.uptimeHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uptimeHost.Controls.Add(this.gaugeUptime, 0, 0);
            this.uptimeHost.Controls.Add(this.uptimeCaption, 0, 1);
            this.uptimeHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uptimeHost.Location = new System.Drawing.Point(0, 0);
            this.uptimeHost.Margin = new System.Windows.Forms.Padding(0);
            this.uptimeHost.Name = "uptimeHost";
            this.uptimeHost.RowCount = 2;
            this.uptimeHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uptimeHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.uptimeHost.Size = new System.Drawing.Size(351, 550);
            this.uptimeHost.TabIndex = 0;
            // 
            // gaugeUptime
            // 
            upArea.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            upArea.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            upArea.AxisY.LabelStyle.Format = "0.0";
            upArea.AxisY.Maximum = 100D;
            upArea.AxisY.Minimum = 0D;
            upArea.BackColor = System.Drawing.Color.White;
            upArea.Name = "gauge";
            this.gaugeUptime.ChartAreas.Add(upArea);
            this.gaugeUptime.BackColor = System.Drawing.Color.White;
            this.gaugeUptime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeUptime.Location = new System.Drawing.Point(8, 8);
            this.gaugeUptime.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.gaugeUptime.Name = "gaugeUptime";
            upZones.ChartArea = "gauge";
            upZones.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            upZones["DoughnutRadius"] = "58";
            upZones["PieLabelStyle"] = "Disabled";
            upZones["PieStartAngle"] = "150";
            upZones.IsVisibleInLegend = false;
            upZones.Name = "zones";
            upZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 192D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))) });
            upZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 24D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(175)))), ((int)(((byte)(20))))) });
            upZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 24D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70))))) });
            upZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 120D) { Color = System.Drawing.Color.Transparent });
            this.gaugeUptime.Series.Add(upZones);
            upNeedle.EndCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            upNeedle.IsSizeAlwaysRelative = true;
            upNeedle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            upNeedle.Name = "needle";
            upNeedle.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            upNeedle.Visible = false;
            this.gaugeUptime.Annotations.Add(upNeedle);
            upHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            upHub.IsSizeAlwaysRelative = true;
            upHub.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            upHub.Name = "hub";
            this.gaugeUptime.Annotations.Add(upHub);
            upValue.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            upValue.IsSizeAlwaysRelative = true;
            upValue.Name = "value";
            upValue.Text = "--";
            upValue.X = 50D;
            upValue.Y = 80D;
            this.gaugeUptime.Annotations.Add(upValue);
            upUnit.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            upUnit.IsSizeAlwaysRelative = true;
            upUnit.Name = "unit";
            upUnit.Text = "%";
            upUnit.X = 50D;
            upUnit.Y = 62D;
            this.gaugeUptime.Annotations.Add(upUnit);
            this.gaugeUptime.Size = new System.Drawing.Size(335, 506);
            this.gaugeUptime.TabIndex = 0;
            this.gaugeUptime.Resize += new System.EventHandler(this.gauge_Resize);
            // 
            // uptimeCaption
            // 
            this.uptimeCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uptimeCaption.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.uptimeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.uptimeCaption.Location = new System.Drawing.Point(8, 514);
            this.uptimeCaption.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.uptimeCaption.Name = "uptimeCaption";
            this.uptimeCaption.Size = new System.Drawing.Size(335, 36);
            this.uptimeCaption.TabIndex = 1;
            this.uptimeCaption.Text = "Uptime占比";
            this.uptimeCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uphHost
            // 
            this.uphHost.ColumnCount = 1;
            this.uphHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uphHost.Controls.Add(this.gaugeUph, 0, 0);
            this.uphHost.Controls.Add(this.uphCaption, 0, 1);
            this.uphHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uphHost.Location = new System.Drawing.Point(351, 0);
            this.uphHost.Margin = new System.Windows.Forms.Padding(0);
            this.uphHost.Name = "uphHost";
            this.uphHost.RowCount = 2;
            this.uphHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uphHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.uphHost.Size = new System.Drawing.Size(468, 550);
            this.uphHost.TabIndex = 1;
            // 
            // gaugeUph
            // 
            uphArea.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            uphArea.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            uphArea.AxisY.LabelStyle.Format = "0.0";
            uphArea.AxisY.Maximum = 100D;
            uphArea.AxisY.Minimum = 0D;
            uphArea.BackColor = System.Drawing.Color.White;
            uphArea.Name = "gauge";
            this.gaugeUph.ChartAreas.Add(uphArea);
            this.gaugeUph.BackColor = System.Drawing.Color.White;
            this.gaugeUph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeUph.Location = new System.Drawing.Point(40, 8);
            this.gaugeUph.Margin = new System.Windows.Forms.Padding(40, 8, 40, 0);
            this.gaugeUph.Name = "gaugeUph";
            uphZones.ChartArea = "gauge";
            uphZones.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            uphZones["DoughnutRadius"] = "58";
            uphZones["PieLabelStyle"] = "Disabled";
            uphZones["PieStartAngle"] = "150";
            uphZones.IsVisibleInLegend = false;
            uphZones.Name = "zones";
            uphZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 192D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))) });
            uphZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 24D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(175)))), ((int)(((byte)(20))))) });
            uphZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 24D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70))))) });
            uphZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 120D) { Color = System.Drawing.Color.Transparent });
            this.gaugeUph.Series.Add(uphZones);
            uphNeedle.EndCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            uphNeedle.IsSizeAlwaysRelative = true;
            uphNeedle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            uphNeedle.Name = "needle";
            uphNeedle.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            uphNeedle.Visible = false;
            this.gaugeUph.Annotations.Add(uphNeedle);
            uphHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            uphHub.IsSizeAlwaysRelative = true;
            uphHub.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            uphHub.Name = "hub";
            this.gaugeUph.Annotations.Add(uphHub);
            uphValue.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            uphValue.IsSizeAlwaysRelative = true;
            uphValue.Name = "value";
            uphValue.Text = "--";
            uphValue.X = 50D;
            uphValue.Y = 80D;
            this.gaugeUph.Annotations.Add(uphValue);
            uphUnit.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            uphUnit.IsSizeAlwaysRelative = true;
            uphUnit.Name = "unit";
            uphUnit.Text = "%";
            uphUnit.X = 50D;
            uphUnit.Y = 62D;
            this.gaugeUph.Annotations.Add(uphUnit);
            this.gaugeUph.Size = new System.Drawing.Size(388, 506);
            this.gaugeUph.TabIndex = 0;
            this.gaugeUph.Resize += new System.EventHandler(this.gauge_Resize);
            // 
            // uphCaption
            // 
            this.uphCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uphCaption.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.uphCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.uphCaption.Location = new System.Drawing.Point(40, 514);
            this.uphCaption.Margin = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.uphCaption.Name = "uphCaption";
            this.uphCaption.Size = new System.Drawing.Size(388, 36);
            this.uphCaption.TabIndex = 1;
            this.uphCaption.Text = "UPH达成率";
            this.uphCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yieldHost
            // 
            this.yieldHost.ColumnCount = 1;
            this.yieldHost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.yieldHost.Controls.Add(this.gaugeYield, 0, 0);
            this.yieldHost.Controls.Add(this.yieldCaption, 0, 1);
            this.yieldHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yieldHost.Location = new System.Drawing.Point(819, 0);
            this.yieldHost.Margin = new System.Windows.Forms.Padding(0);
            this.yieldHost.Name = "yieldHost";
            this.yieldHost.RowCount = 2;
            this.yieldHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.yieldHost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.yieldHost.Size = new System.Drawing.Size(353, 550);
            this.yieldHost.TabIndex = 2;
            // 
            // gaugeYield
            // 
            yArea.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            yArea.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            yArea.AxisY.LabelStyle.Format = "0.0";
            yArea.AxisY.Maximum = 100D;
            yArea.AxisY.Minimum = 0D;
            yArea.BackColor = System.Drawing.Color.White;
            yArea.Name = "gauge";
            this.gaugeYield.ChartAreas.Add(yArea);
            this.gaugeYield.BackColor = System.Drawing.Color.White;
            this.gaugeYield.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeYield.Location = new System.Drawing.Point(8, 8);
            this.gaugeYield.Margin = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.gaugeYield.Name = "gaugeYield";
            yZones.ChartArea = "gauge";
            yZones.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            yZones["DoughnutRadius"] = "58";
            yZones["PieLabelStyle"] = "Disabled";
            yZones["PieStartAngle"] = "150";
            yZones.IsVisibleInLegend = false;
            yZones.Name = "zones";
            yZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 216D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(55)))), ((int)(((byte)(55))))) });
            yZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(175)))), ((int)(((byte)(20))))) });
            yZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D) { Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(70))))) });
            yZones.Points.Add(new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 120D) { Color = System.Drawing.Color.Transparent });
            this.gaugeYield.Series.Add(yZones);
            yNeedle.EndCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.Arrow;
            yNeedle.IsSizeAlwaysRelative = true;
            yNeedle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            yNeedle.Name = "needle";
            yNeedle.StartCap = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            yNeedle.Visible = false;
            this.gaugeYield.Annotations.Add(yNeedle);
            yHub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            yHub.IsSizeAlwaysRelative = true;
            yHub.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(56)))));
            yHub.Name = "hub";
            this.gaugeYield.Annotations.Add(yHub);
            yValue.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            yValue.IsSizeAlwaysRelative = true;
            yValue.Name = "value";
            yValue.Text = "--";
            yValue.X = 50D;
            yValue.Y = 80D;
            this.gaugeYield.Annotations.Add(yValue);
            yUnit.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            yUnit.IsSizeAlwaysRelative = true;
            yUnit.Name = "unit";
            yUnit.Text = "%";
            yUnit.X = 50D;
            yUnit.Y = 62D;
            this.gaugeYield.Annotations.Add(yUnit);
            this.gaugeYield.Size = new System.Drawing.Size(337, 506);
            this.gaugeYield.TabIndex = 0;
            this.gaugeYield.Resize += new System.EventHandler(this.gauge_Resize);
            // 
            // yieldCaption
            // 
            this.yieldCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.yieldCaption.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.yieldCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.yieldCaption.Location = new System.Drawing.Point(8, 514);
            this.yieldCaption.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.yieldCaption.Name = "yieldCaption";
            this.yieldCaption.Size = new System.Drawing.Size(337, 36);
            this.yieldCaption.TabIndex = 1;
            this.yieldCaption.Text = "一次良率";
            this.yieldCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bottomPanel
            // 
            this.bottomPanel.ColumnCount = 3;
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.Controls.Add(this.btnDistribution, 1, 0);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(4, 598);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.RowCount = 1;
            this.bottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.Size = new System.Drawing.Size(1172, 58);
            this.bottomPanel.TabIndex = 2;
            // 
            // btnDistribution
            // 
            this.btnDistribution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.btnDistribution.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDistribution.FlatAppearance.BorderSize = 0;
            this.btnDistribution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDistribution.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnDistribution.ForeColor = System.Drawing.Color.White;
            this.btnDistribution.Location = new System.Drawing.Point(494, 12);
            this.btnDistribution.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.btnDistribution.Name = "btnDistribution";
            this.btnDistribution.Size = new System.Drawing.Size(184, 34);
            this.btnDistribution.TabIndex = 0;
            this.btnDistribution.Text = "时间分布图";
            this.btnDistribution.UseVisualStyleBackColor = false;
            this.btnDistribution.Click += new System.EventHandler(this.btnDistribution_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 3000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PagePerformance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PagePerformance";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.toolbar.ResumeLayout(false);
            this.gaugesPanel.ResumeLayout(false);
            this.uptimeHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gaugeUptime)).EndInit();
            this.uphHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gaugeUph)).EndInit();
            this.yieldHost.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gaugeYield)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel toolbar;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.CheckBox autoRefresh;
        private System.Windows.Forms.TableLayoutPanel gaugesPanel;
        private System.Windows.Forms.TableLayoutPanel uptimeHost;
        private System.Windows.Forms.DataVisualization.Charting.Chart gaugeUptime;
        private System.Windows.Forms.Label uptimeCaption;
        private System.Windows.Forms.TableLayoutPanel uphHost;
        private System.Windows.Forms.DataVisualization.Charting.Chart gaugeUph;
        private System.Windows.Forms.Label uphCaption;
        private System.Windows.Forms.TableLayoutPanel yieldHost;
        private System.Windows.Forms.DataVisualization.Charting.Chart gaugeYield;
        private System.Windows.Forms.Label yieldCaption;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.Button btnDistribution;
        private System.Windows.Forms.Timer refresh;
    }
}
