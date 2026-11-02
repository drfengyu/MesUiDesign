namespace Mes.Hmi
{
    partial class TimeDistributionDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea moduleArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend moduleLegend = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series legendFault = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series legendPlan = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series legendIdle = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series legendRun = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series moduleRun = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series moduleIdle = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series modulePlan = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series moduleFault = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title moduleTitle = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.summaryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.runSummary = new System.Windows.Forms.Label();
            this.idleSummary = new System.Windows.Forms.Label();
            this.planSummary = new System.Windows.Forms.Label();
            this.faultSummary = new System.Windows.Forms.Label();
            this.gridModule = new System.Windows.Forms.DataGridView();
            this.colModule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRun = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFault = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plotModule = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.root.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.summaryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotModule)).BeginInit();
            this.bottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.topPanel, 0, 0);
            this.root.Controls.Add(this.plotModule, 0, 1);
            this.root.Controls.Add(this.bottomPanel, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(6);
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.root.Size = new System.Drawing.Size(928, 600);
            this.root.TabIndex = 0;
            // 
            // topPanel
            // 
            this.topPanel.ColumnCount = 2;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.topPanel.Controls.Add(this.summaryPanel, 0, 0);
            this.topPanel.Controls.Add(this.gridModule, 1, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(6, 6);
            this.topPanel.Margin = new System.Windows.Forms.Padding(0);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 1;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.topPanel.Size = new System.Drawing.Size(916, 270);
            this.topPanel.TabIndex = 0;
            // 
            // summaryPanel
            // 
            this.summaryPanel.ColumnCount = 1;
            this.summaryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.summaryPanel.Controls.Add(this.runSummary, 0, 0);
            this.summaryPanel.Controls.Add(this.idleSummary, 0, 1);
            this.summaryPanel.Controls.Add(this.planSummary, 0, 2);
            this.summaryPanel.Controls.Add(this.faultSummary, 0, 3);
            this.summaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.summaryPanel.Location = new System.Drawing.Point(0, 0);
            this.summaryPanel.Margin = new System.Windows.Forms.Padding(0, 0, 8, 0);
            this.summaryPanel.Name = "summaryPanel";
            this.summaryPanel.RowCount = 4;
            this.summaryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.summaryPanel.Size = new System.Drawing.Size(303, 270);
            this.summaryPanel.TabIndex = 0;
            // 
            // runSummary
            // 
            this.runSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.runSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runSummary.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.runSummary.ForeColor = System.Drawing.Color.White;
            this.runSummary.Location = new System.Drawing.Point(0, 0);
            this.runSummary.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.runSummary.Name = "runSummary";
            this.runSummary.Size = new System.Drawing.Size(303, 63);
            this.runSummary.TabIndex = 0;
            this.runSummary.Text = "平均运行时间  0:00.00";
            this.runSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // idleSummary
            // 
            this.idleSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            this.idleSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idleSummary.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.idleSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.idleSummary.Location = new System.Drawing.Point(0, 67);
            this.idleSummary.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.idleSummary.Name = "idleSummary";
            this.idleSummary.Size = new System.Drawing.Size(303, 63);
            this.idleSummary.TabIndex = 1;
            this.idleSummary.Text = "平均待机时间  0:00.00";
            this.idleSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // planSummary
            // 
            this.planSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.planSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.planSummary.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.planSummary.ForeColor = System.Drawing.Color.White;
            this.planSummary.Location = new System.Drawing.Point(0, 134);
            this.planSummary.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.planSummary.Name = "planSummary";
            this.planSummary.Size = new System.Drawing.Size(303, 63);
            this.planSummary.TabIndex = 2;
            this.planSummary.Text = "平均计划停机  0:00.00";
            this.planSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faultSummary
            // 
            this.faultSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.faultSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faultSummary.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.faultSummary.ForeColor = System.Drawing.Color.White;
            this.faultSummary.Location = new System.Drawing.Point(0, 201);
            this.faultSummary.Margin = new System.Windows.Forms.Padding(0);
            this.faultSummary.Name = "faultSummary";
            this.faultSummary.Size = new System.Drawing.Size(303, 69);
            this.faultSummary.TabIndex = 3;
            this.faultSummary.Text = "平均异常时间  0:00.00";
            this.faultSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridModule
            // 
            this.gridModule.AllowUserToAddRows = false;
            this.gridModule.AllowUserToDeleteRows = false;
            this.gridModule.AllowUserToResizeRows = false;
            this.gridModule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridModule.BackgroundColor = System.Drawing.Color.White;
            this.gridModule.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridModule.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.gridModule.ColumnHeadersDefaultCellStyle = headerStyle;
            this.gridModule.ColumnHeadersHeight = 30;
            this.gridModule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridModule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colModule,
            this.colRun,
            this.colIdle,
            this.colPlan,
            this.colFault});
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle.BackColor = System.Drawing.SystemColors.Window;
            cellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            cellStyle.SelectionBackColor = System.Drawing.Color.White;
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            cellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridModule.DefaultCellStyle = cellStyle;
            this.gridModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridModule.EnableHeadersVisualStyles = false;
            this.gridModule.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.gridModule.Location = new System.Drawing.Point(311, 0);
            this.gridModule.Margin = new System.Windows.Forms.Padding(0);
            this.gridModule.MultiSelect = false;
            this.gridModule.Name = "gridModule";
            this.gridModule.ReadOnly = true;
            this.gridModule.RowHeadersVisible = false;
            this.gridModule.RowTemplate.Height = 30;
            this.gridModule.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridModule.Size = new System.Drawing.Size(605, 270);
            this.gridModule.TabIndex = 1;
            // 
            // colModule
            // 
            this.colModule.FillWeight = 34F;
            this.colModule.HeaderText = "模组序号";
            this.colModule.Name = "colModule";
            this.colModule.ReadOnly = true;
            // 
            // colRun
            // 
            this.colRun.FillWeight = 16.5F;
            this.colRun.HeaderText = "运行时间";
            this.colRun.Name = "colRun";
            this.colRun.ReadOnly = true;
            // 
            // colIdle
            // 
            this.colIdle.FillWeight = 16.5F;
            this.colIdle.HeaderText = "待机时间";
            this.colIdle.Name = "colIdle";
            this.colIdle.ReadOnly = true;
            // 
            // colPlan
            // 
            this.colPlan.FillWeight = 16.5F;
            this.colPlan.HeaderText = "计划停机";
            this.colPlan.Name = "colPlan";
            this.colPlan.ReadOnly = true;
            // 
            // colFault
            // 
            this.colFault.FillWeight = 16.5F;
            this.colFault.HeaderText = "异常时间";
            this.colFault.Name = "colFault";
            this.colFault.ReadOnly = true;
            // 
            // plotModule
            // 
            moduleArea.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            moduleArea.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            moduleArea.AxisX.MajorGrid.Enabled = false;
            moduleArea.AxisX.MajorTickMark.Enabled = false;
            moduleArea.AxisY.Interval = 10D;
            moduleArea.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            moduleArea.AxisY.LabelStyle.Format = "0";
            moduleArea.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            moduleArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            moduleArea.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            moduleArea.AxisY.MajorTickMark.Enabled = false;
            moduleArea.BackColor = System.Drawing.Color.White;
            moduleArea.Name = "main";
            this.plotModule.ChartAreas.Add(moduleArea);
            this.plotModule.BackColor = System.Drawing.Color.White;
            this.plotModule.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(233)))), ((int)(((byte)(238)))));
            this.plotModule.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            this.plotModule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotModule.Location = new System.Drawing.Point(6, 276);
            this.plotModule.Margin = new System.Windows.Forms.Padding(0);
            this.plotModule.Name = "plotModule";
            moduleLegend.Alignment = System.Drawing.StringAlignment.Near;
            moduleLegend.BackColor = System.Drawing.Color.Transparent;
            moduleLegend.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            moduleLegend.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            moduleLegend.Font = new System.Drawing.Font("微软雅黑", 9F);
            moduleLegend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            moduleLegend.IsTextAutoFit = false;
            moduleLegend.LegendStyle = System.Windows.Forms.DataVisualization.Charting.LegendStyle.Column;
            moduleLegend.Name = "legend";
            this.plotModule.Legends.Add(moduleLegend);
            legendRun.ChartArea = "main";
            legendRun.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            legendRun.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            legendRun.IsVisibleInLegend = true;
            legendRun.LegendText = "运行时间";
            legendRun.Name = "图例运行时间";
            this.plotModule.Series.Add(legendRun);
            legendIdle.ChartArea = "main";
            legendIdle.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            legendIdle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            legendIdle.IsVisibleInLegend = true;
            legendIdle.LegendText = "待机时间";
            legendIdle.Name = "图例待机时间";
            this.plotModule.Series.Add(legendIdle);
            legendPlan.ChartArea = "main";
            legendPlan.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            legendPlan.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            legendPlan.IsVisibleInLegend = true;
            legendPlan.LegendText = "计划停机";
            legendPlan.Name = "图例计划停机";
            this.plotModule.Series.Add(legendPlan);
            legendFault.ChartArea = "main";
            legendFault.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            legendFault.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            legendFault.IsVisibleInLegend = true;
            legendFault.LegendText = "异常时间";
            legendFault.Name = "图例异常时间";
            this.plotModule.Series.Add(legendFault);
            moduleRun.ChartArea = "main";
            moduleRun.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            moduleRun.Color = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            moduleRun.IsVisibleInLegend = false;
            moduleRun.Name = "运行时间";
            this.plotModule.Series.Add(moduleRun);
            moduleIdle.ChartArea = "main";
            moduleIdle.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            moduleIdle.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(180)))), ((int)(((byte)(60)))));
            moduleIdle.IsVisibleInLegend = false;
            moduleIdle.Name = "待机时间";
            this.plotModule.Series.Add(moduleIdle);
            modulePlan.ChartArea = "main";
            modulePlan.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            modulePlan.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            modulePlan.IsVisibleInLegend = false;
            modulePlan.Name = "计划停机";
            this.plotModule.Series.Add(modulePlan);
            moduleFault.ChartArea = "main";
            moduleFault.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            moduleFault.Color = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            moduleFault.IsVisibleInLegend = false;
            moduleFault.Name = "异常时间";
            this.plotModule.Series.Add(moduleFault);
            this.plotModule.Size = new System.Drawing.Size(916, 264);
            this.plotModule.TabIndex = 1;
            moduleTitle.Alignment = System.Drawing.ContentAlignment.MiddleCenter;
            moduleTitle.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            moduleTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(140)))));
            moduleTitle.Name = "titleModule";
            moduleTitle.Text = "模组时间分布（分钟）";
            this.plotModule.Titles.Add(moduleTitle);
            // 
            // bottomPanel
            // 
            this.bottomPanel.ColumnCount = 2;
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.bottomPanel.Controls.Add(this.btnOk, 1, 0);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bottomPanel.Location = new System.Drawing.Point(6, 546);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.RowCount = 1;
            this.bottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bottomPanel.Size = new System.Drawing.Size(916, 48);
            this.bottomPanel.TabIndex = 2;
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.FlatAppearance.BorderSize = 0;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Location = new System.Drawing.Point(764, 9);
            this.btnOk.Margin = new System.Windows.Forms.Padding(8, 9, 0, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(152, 30);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // TimeDistributionDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 600);
            this.Controls.Add(this.root);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimeDistributionDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "时间分布图";
            this.root.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.summaryPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotModule)).EndInit();
            this.bottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.TableLayoutPanel summaryPanel;
        private System.Windows.Forms.Label runSummary;
        private System.Windows.Forms.Label idleSummary;
        private System.Windows.Forms.Label planSummary;
        private System.Windows.Forms.Label faultSummary;
        private System.Windows.Forms.DataGridView gridModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModule;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFault;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotModule;
        private System.Windows.Forms.TableLayoutPanel bottomPanel;
        private System.Windows.Forms.Button btnOk;
    }
}
