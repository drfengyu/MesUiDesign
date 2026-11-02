namespace Mes.Hmi
{
    partial class PageAlarmTop5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea countArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series countSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea minutesArea = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series minutesSeries = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.queryBar = new System.Windows.Forms.TableLayoutPanel();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.chkHistory = new System.Windows.Forms.CheckBox();
            this.chkTop10 = new System.Windows.Forms.CheckBox();
            this.querySpacer = new System.Windows.Forms.Panel();
            this.content = new System.Windows.Forms.TableLayoutPanel();
            this.countCard = new System.Windows.Forms.TableLayoutPanel();
            this.countCaption = new System.Windows.Forms.Label();
            this.plotCount = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridCount = new System.Windows.Forms.DataGridView();
            this.colCountCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCountText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minutesCard = new System.Windows.Forms.TableLayoutPanel();
            this.minutesCaption = new System.Windows.Forms.Label();
            this.plotMinutes = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gridMinutes = new System.Windows.Forms.DataGridView();
            this.colMinutesCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinutesTimes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinutesText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.root.SuspendLayout();
            this.queryBar.SuspendLayout();
            this.content.SuspendLayout();
            this.countCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCount)).BeginInit();
            this.minutesCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMinutes)).BeginInit();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.queryBar, 0, 0);
            this.root.Controls.Add(this.content, 0, 1);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 2;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            //
            // queryBar
            //
            this.queryBar.BackColor = System.Drawing.Color.White;
            this.queryBar.ColumnCount = 7;
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queryBar.Controls.Add(this.fromPicker, 0, 0);
            this.queryBar.Controls.Add(this.toPicker, 2, 0);
            this.queryBar.Controls.Add(this.btnQuery, 3, 0);
            this.queryBar.Controls.Add(this.chkHistory, 4, 0);
            this.queryBar.Controls.Add(this.chkTop10, 5, 0);
            this.queryBar.Controls.Add(this.querySpacer, 6, 0);
            this.queryBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBar.Name = "queryBar";
            this.queryBar.RowCount = 1;
            this.queryBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queryBar.TabIndex = 0;
            //
            // fromPicker
            //
            this.fromPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.fromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromPicker.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromPicker.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.TabIndex = 0;
            //
            // toPicker
            //
            this.toPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.toPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toPicker.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.toPicker.Name = "toPicker";
            this.toPicker.TabIndex = 2;
            //
            // btnQuery
            //
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            //
            // chkHistory
            //
            this.chkHistory.Checked = true;
            this.chkHistory.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkHistory.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkHistory.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.chkHistory.Name = "chkHistory";
            this.chkHistory.TabIndex = 4;
            this.chkHistory.Text = "读取报警履历";
            this.chkHistory.CheckedChanged += new System.EventHandler(this.chkHistory_CheckedChanged);
            //
            // chkTop10
            //
            this.chkTop10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkTop10.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkTop10.Margin = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.chkTop10.Name = "chkTop10";
            this.chkTop10.TabIndex = 5;
            this.chkTop10.Text = "TOP 10";
            this.chkTop10.CheckedChanged += new System.EventHandler(this.chkHistory_CheckedChanged);
            //
            // querySpacer
            //
            this.querySpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.querySpacer.Name = "querySpacer";
            this.querySpacer.TabIndex = 6;
            //
            // content
            //
            this.content.ColumnCount = 2;
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.content.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.content.Controls.Add(this.countCard, 0, 0);
            this.content.Controls.Add(this.minutesCard, 1, 0);
            this.content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.content.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.content.Name = "content";
            this.content.RowCount = 1;
            this.content.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.content.TabIndex = 1;
            //
            // countCard
            //
            this.countCard.BackColor = System.Drawing.Color.White;
            this.countCard.ColumnCount = 1;
            this.countCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.countCard.Controls.Add(this.countCaption, 0, 0);
            this.countCard.Controls.Add(this.plotCount, 0, 1);
            this.countCard.Controls.Add(this.gridCount, 0, 2);
            this.countCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countCard.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.countCard.Name = "countCard";
            this.countCard.RowCount = 3;
            this.countCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.countCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.countCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.countCard.TabIndex = 0;
            //
            // countCaption
            //
            this.countCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.countCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.countCaption.ForeColor = System.Drawing.Color.FromArgb(30, 70, 140);
            this.countCaption.Name = "countCaption";
            this.countCaption.TabIndex = 0;
            this.countCaption.Text = "异常次数TOP";
            this.countCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // plotCount
            //
            countArea.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            countArea.AxisX.MajorGrid.Enabled = false;
            countArea.AxisX.MajorTickMark.Enabled = false;
            countArea.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            countArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(232, 235, 239);
            countArea.AxisY.MajorTickMark.Enabled = false;
            countArea.AxisY.Minimum = 0D;
            countArea.Name = "main";
            this.plotCount.ChartAreas.Add(countArea);
            this.plotCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotCount.Margin = new System.Windows.Forms.Padding(0);
            this.plotCount.Name = "plotCount";
            countSeries.ChartArea = "main";
            countSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            countSeries.IsValueShownAsLabel = true;
            countSeries.Name = "异常次数";
            this.plotCount.Series.Add(countSeries);
            this.plotCount.TabIndex = 1;
            //
            // gridCount
            //
            this.gridCount.AllowUserToAddRows = false;
            this.gridCount.AllowUserToDeleteRows = false;
            this.gridCount.AllowUserToResizeRows = false;
            this.gridCount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCount.BackgroundColor = System.Drawing.Color.White;
            this.gridCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridCount.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCount.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridCount.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.gridCount.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.gridCount.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 66, 72);
            this.gridCount.ColumnHeadersHeight = 28;
            this.gridCount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridCount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCountCode,
            this.colCountTimes,
            this.colCountText});
            this.gridCount.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridCount.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridCount.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gridCount.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.gridCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCount.EnableHeadersVisualStyles = false;
            this.gridCount.GridColor = System.Drawing.Color.FromArgb(236, 239, 243);
            this.gridCount.MultiSelect = false;
            this.gridCount.Name = "gridCount";
            this.gridCount.ReadOnly = true;
            this.gridCount.RowHeadersVisible = false;
            this.gridCount.RowTemplate.Height = 26;
            this.gridCount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCount.TabIndex = 2;
            //
            // colCountCode
            //
            this.colCountCode.HeaderText = "报警代码";
            this.colCountCode.Name = "colCountCode";
            this.colCountCode.FillWeight = 26F;
            this.colCountCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colCountTimes
            //
            this.colCountTimes.HeaderText = "次数";
            this.colCountTimes.Name = "colCountTimes";
            this.colCountTimes.FillWeight = 12F;
            this.colCountTimes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colCountText
            //
            this.colCountText.HeaderText = "报警信息";
            this.colCountText.Name = "colCountText";
            this.colCountText.FillWeight = 62F;
            this.colCountText.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // minutesCard
            //
            this.minutesCard.BackColor = System.Drawing.Color.White;
            this.minutesCard.ColumnCount = 1;
            this.minutesCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.minutesCard.Controls.Add(this.minutesCaption, 0, 0);
            this.minutesCard.Controls.Add(this.plotMinutes, 0, 1);
            this.minutesCard.Controls.Add(this.gridMinutes, 0, 2);
            this.minutesCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesCard.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.minutesCard.Name = "minutesCard";
            this.minutesCard.RowCount = 3;
            this.minutesCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.minutesCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58F));
            this.minutesCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42F));
            this.minutesCard.TabIndex = 1;
            //
            // minutesCaption
            //
            this.minutesCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minutesCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.minutesCaption.ForeColor = System.Drawing.Color.FromArgb(30, 70, 140);
            this.minutesCaption.Name = "minutesCaption";
            this.minutesCaption.TabIndex = 0;
            this.minutesCaption.Text = "异常时间TOP";
            this.minutesCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // plotMinutes
            //
            minutesArea.AxisX.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            minutesArea.AxisX.MajorGrid.Enabled = false;
            minutesArea.AxisX.MajorTickMark.Enabled = false;
            minutesArea.AxisY.LabelStyle.Font = new System.Drawing.Font("微软雅黑", 8F);
            minutesArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(232, 235, 239);
            minutesArea.AxisY.MajorTickMark.Enabled = false;
            minutesArea.AxisY.Minimum = 0D;
            minutesArea.Name = "main";
            this.plotMinutes.ChartAreas.Add(minutesArea);
            this.plotMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotMinutes.Margin = new System.Windows.Forms.Padding(0);
            this.plotMinutes.Name = "plotMinutes";
            minutesSeries.ChartArea = "main";
            minutesSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            minutesSeries.IsValueShownAsLabel = true;
            minutesSeries.Name = "异常分钟";
            this.plotMinutes.Series.Add(minutesSeries);
            this.plotMinutes.TabIndex = 1;
            //
            // gridMinutes
            //
            this.gridMinutes.AllowUserToAddRows = false;
            this.gridMinutes.AllowUserToDeleteRows = false;
            this.gridMinutes.AllowUserToResizeRows = false;
            this.gridMinutes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMinutes.BackgroundColor = System.Drawing.Color.White;
            this.gridMinutes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridMinutes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridMinutes.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMinutes.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridMinutes.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.gridMinutes.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.gridMinutes.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 66, 72);
            this.gridMinutes.ColumnHeadersHeight = 28;
            this.gridMinutes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridMinutes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMinutesCode,
            this.colMinutesTimes,
            this.colMinutesText});
            this.gridMinutes.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridMinutes.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridMinutes.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gridMinutes.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.gridMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMinutes.EnableHeadersVisualStyles = false;
            this.gridMinutes.GridColor = System.Drawing.Color.FromArgb(236, 239, 243);
            this.gridMinutes.MultiSelect = false;
            this.gridMinutes.Name = "gridMinutes";
            this.gridMinutes.ReadOnly = true;
            this.gridMinutes.RowHeadersVisible = false;
            this.gridMinutes.RowTemplate.Height = 26;
            this.gridMinutes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMinutes.TabIndex = 2;
            //
            // colMinutesCode
            //
            this.colMinutesCode.HeaderText = "报警代码";
            this.colMinutesCode.Name = "colMinutesCode";
            this.colMinutesCode.FillWeight = 26F;
            this.colMinutesCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colMinutesTimes
            //
            this.colMinutesTimes.HeaderText = "分钟";
            this.colMinutesTimes.Name = "colMinutesTimes";
            this.colMinutesTimes.FillWeight = 12F;
            this.colMinutesTimes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colMinutesText
            //
            this.colMinutesText.HeaderText = "报警信息";
            this.colMinutesText.Name = "colMinutesText";
            this.colMinutesText.FillWeight = 62F;
            this.colMinutesText.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // PageAlarmTop5
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageAlarmTop5";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.queryBar.ResumeLayout(false);
            this.content.ResumeLayout(false);
            this.countCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCount)).EndInit();
            this.minutesCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plotMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMinutes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel queryBar;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.CheckBox chkHistory;
        private System.Windows.Forms.CheckBox chkTop10;
        private System.Windows.Forms.Panel querySpacer;
        private System.Windows.Forms.TableLayoutPanel content;
        private System.Windows.Forms.TableLayoutPanel countCard;
        private System.Windows.Forms.Label countCaption;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotCount;
        private System.Windows.Forms.DataGridView gridCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCountText;
        private System.Windows.Forms.TableLayoutPanel minutesCard;
        private System.Windows.Forms.Label minutesCaption;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotMinutes;
        private System.Windows.Forms.DataGridView gridMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinutesCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinutesTimes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinutesText;
    }
}
