namespace Mes.Hmi
{
    partial class PageUptime
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
            System.Windows.Forms.DataGridViewCellStyle headerStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.leftPanel = new System.Windows.Forms.TableLayoutPanel();
            this.faultTitle = new System.Windows.Forms.Label();
            this.faultBody = new System.Windows.Forms.TableLayoutPanel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.faultLabel = new System.Windows.Forms.Label();
            this.codeLabel = new System.Windows.Forms.Label();
            this.faultCodeBox = new System.Windows.Forms.TextBox();
            this.btnManualFault = new System.Windows.Forms.Button();
            this.startLabel = new System.Windows.Forms.Label();
            this.faultStartLabel = new System.Windows.Forms.Label();
            this.btnEndFault = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.btnPlannedStart = new System.Windows.Forms.Button();
            this.btnFirstStart = new System.Windows.Forms.Button();
            this.btnChangeStart = new System.Windows.Forms.Button();
            this.btnPlannedEnd = new System.Windows.Forms.Button();
            this.btnFirstEnd = new System.Windows.Forms.Button();
            this.btnChangeEnd = new System.Windows.Forms.Button();
            this.plannedElapsed = new System.Windows.Forms.Label();
            this.firstElapsed = new System.Windows.Forms.Label();
            this.changeElapsed = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightPanel = new System.Windows.Forms.TableLayoutPanel();
            this.plotPie = new Mes.Hmi.PlotBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.queryPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExportBottom = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.faultBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.rightPanel.SuspendLayout();
            this.queryPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerStyle
            // 
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            // 
            // cellStyle
            // 
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            cellStyle.SelectionBackColor = System.Drawing.Color.White;
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            // 
            // root
            // 
            this.root.ColumnCount = 2;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.root.Controls.Add(this.leftPanel, 0, 0);
            this.root.Controls.Add(this.rightPanel, 1, 0);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 1;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.ColumnCount = 1;
            this.leftPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Controls.Add(this.faultTitle, 0, 0);
            this.leftPanel.Controls.Add(this.faultBody, 0, 1);
            this.leftPanel.Controls.Add(this.grid, 0, 2);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftPanel.Location = new System.Drawing.Point(7, 7);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.RowCount = 3;
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 246F));
            this.leftPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftPanel.Size = new System.Drawing.Size(650, 646);
            this.leftPanel.TabIndex = 0;
            // 
            // faultTitle
            // 
            this.faultTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.faultTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faultTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.faultTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.faultTitle.Location = new System.Drawing.Point(0, 0);
            this.faultTitle.Margin = new System.Windows.Forms.Padding(0);
            this.faultTitle.Name = "faultTitle";
            this.faultTitle.Size = new System.Drawing.Size(650, 36);
            this.faultTitle.TabIndex = 0;
            this.faultTitle.Text = "故障计时";
            this.faultTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faultBody
            // 
            this.faultBody.ColumnCount = 4;
            this.faultBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.faultBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.faultBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.faultBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.faultBody.Controls.Add(this.infoLabel, 0, 0);
            this.faultBody.Controls.Add(this.faultLabel, 1, 0);
            this.faultBody.Controls.Add(this.codeLabel, 0, 1);
            this.faultBody.Controls.Add(this.faultCodeBox, 1, 1);
            this.faultBody.Controls.Add(this.btnManualFault, 2, 1);
            this.faultBody.Controls.Add(this.startLabel, 0, 2);
            this.faultBody.Controls.Add(this.faultStartLabel, 1, 2);
            this.faultBody.Controls.Add(this.btnEndFault, 2, 2);
            this.faultBody.Controls.Add(this.debugLabel, 0, 3);
            this.faultBody.Controls.Add(this.btnPlannedStart, 0, 4);
            this.faultBody.Controls.Add(this.btnFirstStart, 1, 4);
            this.faultBody.Controls.Add(this.btnChangeStart, 2, 4);
            this.faultBody.Controls.Add(this.btnPlannedEnd, 0, 5);
            this.faultBody.Controls.Add(this.btnFirstEnd, 1, 5);
            this.faultBody.Controls.Add(this.btnChangeEnd, 2, 5);
            this.faultBody.Controls.Add(this.plannedElapsed, 0, 6);
            this.faultBody.Controls.Add(this.firstElapsed, 1, 6);
            this.faultBody.Controls.Add(this.changeElapsed, 2, 6);
            this.faultBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faultBody.Location = new System.Drawing.Point(0, 36);
            this.faultBody.Margin = new System.Windows.Forms.Padding(0);
            this.faultBody.Name = "faultBody";
            this.faultBody.RowCount = 7;
            this.faultBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.faultBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.faultBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.faultBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.faultBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.faultBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.faultBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.faultBody.Size = new System.Drawing.Size(650, 246);
            this.faultBody.TabIndex = 1;
            // 
            // infoLabel
            // 
            this.infoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.infoLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.infoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.infoLabel.Location = new System.Drawing.Point(3, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(72, 30);
            this.infoLabel.TabIndex = 0;
            this.infoLabel.Text = "故障信息:";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // faultLabel
            // 
            this.faultLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faultLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.faultLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(134)))));
            this.faultLabel.Location = new System.Drawing.Point(81, 0);
            this.faultLabel.Name = "faultLabel";
            this.faultLabel.Size = new System.Drawing.Size(281, 30);
            this.faultLabel.TabIndex = 1;
            this.faultLabel.Text = "当前无故障";
            this.faultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // codeLabel
            // 
            this.codeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.codeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.codeLabel.Location = new System.Drawing.Point(3, 30);
            this.codeLabel.Name = "codeLabel";
            this.codeLabel.Size = new System.Drawing.Size(72, 38);
            this.codeLabel.TabIndex = 2;
            this.codeLabel.Text = "当前代码:";
            this.codeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // faultCodeBox
            // 
            this.faultCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faultCodeBox.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.faultCodeBox.Location = new System.Drawing.Point(81, 33);
            this.faultCodeBox.Name = "faultCodeBox";
            this.faultCodeBox.ReadOnly = true;
            this.faultCodeBox.Size = new System.Drawing.Size(281, 24);
            this.faultCodeBox.TabIndex = 3;
            this.faultCodeBox.TabStop = false;
            // 
            // btnManualFault
            // 
            this.btnManualFault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnManualFault.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnManualFault.Location = new System.Drawing.Point(368, 32);
            this.btnManualFault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManualFault.Name = "btnManualFault";
            this.btnManualFault.Size = new System.Drawing.Size(240, 34);
            this.btnManualFault.TabIndex = 4;
            this.btnManualFault.Text = "手动选择故障代码";
            this.btnManualFault.UseVisualStyleBackColor = true;
            this.btnManualFault.Click += new System.EventHandler(this.btnManualFault_Click);
            // 
            // startLabel
            // 
            this.startLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.startLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.startLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.startLabel.Location = new System.Drawing.Point(3, 68);
            this.startLabel.Name = "startLabel";
            this.startLabel.Size = new System.Drawing.Size(72, 34);
            this.startLabel.TabIndex = 5;
            this.startLabel.Text = "开始时间:";
            this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // faultStartLabel
            // 
            this.faultStartLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faultStartLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.faultStartLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.faultStartLabel.Location = new System.Drawing.Point(81, 68);
            this.faultStartLabel.Name = "faultStartLabel";
            this.faultStartLabel.Size = new System.Drawing.Size(281, 34);
            this.faultStartLabel.TabIndex = 6;
            this.faultStartLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnEndFault
            // 
            this.btnEndFault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEndFault.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnEndFault.Location = new System.Drawing.Point(368, 70);
            this.btnEndFault.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEndFault.Name = "btnEndFault";
            this.btnEndFault.Size = new System.Drawing.Size(240, 30);
            this.btnEndFault.TabIndex = 7;
            this.btnEndFault.Text = "结束当前故障";
            this.btnEndFault.UseVisualStyleBackColor = true;
            this.btnEndFault.Click += new System.EventHandler(this.btnEndFault_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugLabel.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.debugLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(146)))), ((int)(((byte)(154)))));
            this.debugLabel.Location = new System.Drawing.Point(3, 102);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(72, 22);
            this.debugLabel.TabIndex = 8;
            this.debugLabel.Text = "点位调试(M)[3031001]";
            this.debugLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPlannedStart
            // 
            this.btnPlannedStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlannedStart.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnPlannedStart.Location = new System.Drawing.Point(2, 126);
            this.btnPlannedStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlannedStart.Name = "btnPlannedStart";
            this.btnPlannedStart.Size = new System.Drawing.Size(213, 41);
            this.btnPlannedStart.TabIndex = 9;
            this.btnPlannedStart.Text = "计划停机开始";
            this.btnPlannedStart.UseVisualStyleBackColor = true;
            this.btnPlannedStart.Click += new System.EventHandler(this.btnPlannedStart_Click);
            // 
            // btnFirstStart
            // 
            this.btnFirstStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirstStart.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFirstStart.Location = new System.Drawing.Point(222, 126);
            this.btnFirstStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstStart.Name = "btnFirstStart";
            this.btnFirstStart.Size = new System.Drawing.Size(186, 41);
            this.btnFirstStart.TabIndex = 10;
            this.btnFirstStart.Text = "首件计时开始";
            this.btnFirstStart.UseVisualStyleBackColor = true;
            this.btnFirstStart.Click += new System.EventHandler(this.btnFirstStart_Click);
            // 
            // btnChangeStart
            // 
            this.btnChangeStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeStart.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnChangeStart.Location = new System.Drawing.Point(413, 126);
            this.btnChangeStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeStart.Name = "btnChangeStart";
            this.btnChangeStart.Size = new System.Drawing.Size(133, 41);
            this.btnChangeStart.TabIndex = 11;
            this.btnChangeStart.Text = "切线计时开始";
            this.btnChangeStart.UseVisualStyleBackColor = true;
            this.btnChangeStart.Click += new System.EventHandler(this.btnChangeStart_Click);
            // 
            // btnPlannedEnd
            // 
            this.btnPlannedEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlannedEnd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnPlannedEnd.Location = new System.Drawing.Point(2, 171);
            this.btnPlannedEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlannedEnd.Name = "btnPlannedEnd";
            this.btnPlannedEnd.Size = new System.Drawing.Size(213, 41);
            this.btnPlannedEnd.TabIndex = 12;
            this.btnPlannedEnd.Text = "计划停机结束";
            this.btnPlannedEnd.UseVisualStyleBackColor = true;
            this.btnPlannedEnd.Click += new System.EventHandler(this.btnPlannedEnd_Click);
            // 
            // btnFirstEnd
            // 
            this.btnFirstEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFirstEnd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnFirstEnd.Location = new System.Drawing.Point(222, 171);
            this.btnFirstEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstEnd.Name = "btnFirstEnd";
            this.btnFirstEnd.Size = new System.Drawing.Size(186, 41);
            this.btnFirstEnd.TabIndex = 13;
            this.btnFirstEnd.Text = "首件计时结束";
            this.btnFirstEnd.UseVisualStyleBackColor = true;
            this.btnFirstEnd.Click += new System.EventHandler(this.btnFirstEnd_Click);
            // 
            // btnChangeEnd
            // 
            this.btnChangeEnd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnChangeEnd.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnChangeEnd.Location = new System.Drawing.Point(413, 171);
            this.btnChangeEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnChangeEnd.Name = "btnChangeEnd";
            this.btnChangeEnd.Size = new System.Drawing.Size(133, 41);
            this.btnChangeEnd.TabIndex = 14;
            this.btnChangeEnd.Text = "切线计时结束";
            this.btnChangeEnd.UseVisualStyleBackColor = true;
            this.btnChangeEnd.Click += new System.EventHandler(this.btnChangeEnd_Click);
            // 
            // plannedElapsed
            // 
            this.plannedElapsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plannedElapsed.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.plannedElapsed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(134)))));
            this.plannedElapsed.Location = new System.Drawing.Point(2, 215);
            this.plannedElapsed.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.plannedElapsed.Name = "plannedElapsed";
            this.plannedElapsed.Size = new System.Drawing.Size(213, 30);
            this.plannedElapsed.TabIndex = 15;
            this.plannedElapsed.Text = "未计时";
            this.plannedElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstElapsed
            // 
            this.firstElapsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.firstElapsed.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.firstElapsed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(134)))));
            this.firstElapsed.Location = new System.Drawing.Point(222, 215);
            this.firstElapsed.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.firstElapsed.Name = "firstElapsed";
            this.firstElapsed.Size = new System.Drawing.Size(186, 30);
            this.firstElapsed.TabIndex = 16;
            this.firstElapsed.Text = "未计时";
            this.firstElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeElapsed
            // 
            this.changeElapsed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.changeElapsed.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.changeElapsed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(134)))));
            this.changeElapsed.Location = new System.Drawing.Point(413, 215);
            this.changeElapsed.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.changeElapsed.Name = "changeElapsed";
            this.changeElapsed.Size = new System.Drawing.Size(133, 30);
            this.changeElapsed.TabIndex = 17;
            this.changeElapsed.Text = "未计时";
            this.changeElapsed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid.ColumnHeadersDefaultCellStyle = headerStyle;
            this.grid.ColumnHeadersHeight = 32;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colStart,
            this.colCode,
            this.colMinutes,
            this.colText});
            this.grid.DefaultCellStyle = cellStyle;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.grid.Location = new System.Drawing.Point(0, 282);
            this.grid.Margin = new System.Windows.Forms.Padding(0);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 30;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(650, 364);
            this.grid.TabIndex = 2;
            // 
            // colIndex
            // 
            this.colIndex.FillWeight = 8F;
            this.colIndex.HeaderText = "序号";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            // 
            // colStart
            // 
            this.colStart.FillWeight = 28F;
            this.colStart.HeaderText = "开始时间";
            this.colStart.Name = "colStart";
            this.colStart.ReadOnly = true;
            // 
            // colCode
            // 
            this.colCode.FillWeight = 18F;
            this.colCode.HeaderText = "故障代码";
            this.colCode.Name = "colCode";
            this.colCode.ReadOnly = true;
            // 
            // colMinutes
            // 
            this.colMinutes.FillWeight = 12F;
            this.colMinutes.HeaderText = "分钟";
            this.colMinutes.Name = "colMinutes";
            this.colMinutes.ReadOnly = true;
            // 
            // colText
            // 
            this.colText.FillWeight = 34F;
            this.colText.HeaderText = "故障描述";
            this.colText.Name = "colText";
            this.colText.ReadOnly = true;
            // 
            // rightPanel
            // 
            this.rightPanel.ColumnCount = 1;
            this.rightPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.Controls.Add(this.plotPie, 0, 0);
            this.rightPanel.Controls.Add(this.btnExport, 0, 1);
            this.rightPanel.Controls.Add(this.queryPanel, 0, 2);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(664, 7);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.RowCount = 3;
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.rightPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.rightPanel.Size = new System.Drawing.Size(506, 646);
            this.rightPanel.TabIndex = 1;
            // 
            // plotPie
            // 
            this.plotPie.BackColor = System.Drawing.Color.White;
            this.plotPie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotPie.Kind = Mes.Hmi.PlotKind.Pie;
            this.plotPie.Location = new System.Drawing.Point(0, 0);
            this.plotPie.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.plotPie.Name = "plotPie";
            this.plotPie.Size = new System.Drawing.Size(506, 438);
            this.plotPie.TabIndex = 0;
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(177)))), ((int)(((byte)(131)))));
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(40)))), ((int)(((byte)(10)))));
            this.btnExport.Location = new System.Drawing.Point(0, 446);
            this.btnExport.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(506, 64);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "手动导出数据";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // queryPanel
            // 
            this.queryPanel.ColumnCount = 3;
            this.queryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.queryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queryPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queryPanel.Controls.Add(this.fromLabel, 0, 0);
            this.queryPanel.Controls.Add(this.fromPicker, 1, 0);
            this.queryPanel.Controls.Add(this.toLabel, 0, 1);
            this.queryPanel.Controls.Add(this.toPicker, 1, 1);
            this.queryPanel.Controls.Add(this.btnQuery, 1, 2);
            this.queryPanel.Controls.Add(this.btnExportBottom, 2, 2);
            this.queryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryPanel.Location = new System.Drawing.Point(0, 514);
            this.queryPanel.Margin = new System.Windows.Forms.Padding(0);
            this.queryPanel.Name = "queryPanel";
            this.queryPanel.RowCount = 3;
            this.queryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.queryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.queryPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.queryPanel.Size = new System.Drawing.Size(506, 132);
            this.queryPanel.TabIndex = 2;
            // 
            // fromLabel
            // 
            this.fromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.fromLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.fromLabel.Location = new System.Drawing.Point(3, 0);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(78, 39);
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "起始时间:";
            this.fromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fromPicker
            // 
            this.fromPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.fromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromPicker.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromPicker.Location = new System.Drawing.Point(84, 8);
            this.fromPicker.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.Size = new System.Drawing.Size(211, 24);
            this.fromPicker.TabIndex = 1;
            // 
            // toLabel
            // 
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.toLabel.Location = new System.Drawing.Point(3, 39);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(78, 39);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "结束时间:";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toPicker
            // 
            this.toPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.toPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPicker.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toPicker.Location = new System.Drawing.Point(84, 47);
            this.toPicker.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.toPicker.Name = "toPicker";
            this.toPicker.Size = new System.Drawing.Size(211, 24);
            this.toPicker.TabIndex = 3;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnQuery.Location = new System.Drawing.Point(86, 82);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(2, 4, 6, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(203, 46);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "刷新";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExportBottom
            // 
            this.btnExportBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(200)))), ((int)(((byte)(90)))));
            this.btnExportBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExportBottom.FlatAppearance.BorderSize = 0;
            this.btnExportBottom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportBottom.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnExportBottom.ForeColor = System.Drawing.Color.White;
            this.btnExportBottom.Location = new System.Drawing.Point(297, 82);
            this.btnExportBottom.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.btnExportBottom.Name = "btnExportBottom";
            this.btnExportBottom.Size = new System.Drawing.Size(207, 46);
            this.btnExportBottom.TabIndex = 5;
            this.btnExportBottom.Text = "导出";
            this.btnExportBottom.UseVisualStyleBackColor = false;
            this.btnExportBottom.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 1000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageUptime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageUptime";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.leftPanel.ResumeLayout(false);
            this.faultBody.ResumeLayout(false);
            this.faultBody.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.rightPanel.ResumeLayout(false);
            this.queryPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel leftPanel;
        private System.Windows.Forms.Label faultTitle;
        private System.Windows.Forms.TableLayoutPanel faultBody;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label faultLabel;
        private System.Windows.Forms.Label codeLabel;
        private System.Windows.Forms.TextBox faultCodeBox;
        private System.Windows.Forms.Button btnManualFault;
        private System.Windows.Forms.Label startLabel;
        private System.Windows.Forms.Label faultStartLabel;
        private System.Windows.Forms.Button btnEndFault;
        private System.Windows.Forms.Label debugLabel;
        private System.Windows.Forms.Button btnPlannedStart;
        private System.Windows.Forms.Button btnFirstStart;
        private System.Windows.Forms.Button btnChangeStart;
        private System.Windows.Forms.Button btnPlannedEnd;
        private System.Windows.Forms.Button btnFirstEnd;
        private System.Windows.Forms.Button btnChangeEnd;
        private System.Windows.Forms.Label plannedElapsed;
        private System.Windows.Forms.Label firstElapsed;
        private System.Windows.Forms.Label changeElapsed;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.TableLayoutPanel rightPanel;
        private Mes.Hmi.PlotBox plotPie;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.TableLayoutPanel queryPanel;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExportBottom;
        private System.Windows.Forms.Timer refresh;
    }
}
