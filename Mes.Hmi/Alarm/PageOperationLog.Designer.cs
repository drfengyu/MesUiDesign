namespace Mes.Hmi.Alarm
{
    partial class PageOperationLog
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.queryBar = new System.Windows.Forms.TableLayoutPanel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.machineLabel = new System.Windows.Forms.Label();
            this.machineCombo = new System.Windows.Forms.ComboBox();
            this.barcodeLabel = new System.Windows.Forms.Label();
            this.barcodeBox = new System.Windows.Forms.TextBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeCombo = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.querySpacer = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecond = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThird = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFourth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.root.SuspendLayout();
            this.queryBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.queryBar, 0, 0);
            this.root.Controls.Add(this.grid, 0, 1);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 2;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // queryBar
            // 
            this.queryBar.BackColor = System.Drawing.Color.White;
            this.queryBar.ColumnCount = 9;
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 176F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 82F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queryBar.Controls.Add(this.timeLabel, 0, 0);
            this.queryBar.Controls.Add(this.fromPicker, 1, 0);
            this.queryBar.Controls.Add(this.toLabel, 2, 0);
            this.queryBar.Controls.Add(this.toPicker, 3, 0);
            this.queryBar.Controls.Add(this.machineLabel, 4, 0);
            this.queryBar.Controls.Add(this.machineCombo, 5, 0);
            this.queryBar.Controls.Add(this.barcodeLabel, 0, 1);
            this.queryBar.Controls.Add(this.barcodeBox, 1, 1);
            this.queryBar.Controls.Add(this.typeLabel, 2, 1);
            this.queryBar.Controls.Add(this.typeCombo, 3, 1);
            this.queryBar.Controls.Add(this.btnQuery, 6, 0);
            this.queryBar.Controls.Add(this.btnExport, 7, 0);
            this.queryBar.Controls.Add(this.querySpacer, 8, 0);
            this.queryBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBar.Location = new System.Drawing.Point(7, 7);
            this.queryBar.Name = "queryBar";
            this.queryBar.RowCount = 2;
            this.queryBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queryBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queryBar.Size = new System.Drawing.Size(1166, 82);
            this.queryBar.TabIndex = 0;
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.timeLabel.Location = new System.Drawing.Point(3, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(52, 41);
            this.timeLabel.TabIndex = 0;
            this.timeLabel.Text = "时间";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // fromPicker
            // 
            this.fromPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.fromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromPicker.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromPicker.Location = new System.Drawing.Point(62, 8);
            this.fromPicker.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.Size = new System.Drawing.Size(168, 23);
            this.fromPicker.TabIndex = 1;
            // 
            // toLabel
            // 
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toLabel.Location = new System.Drawing.Point(237, 0);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(42, 41);
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "至";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toPicker
            // 
            this.toPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.toPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPicker.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toPicker.Location = new System.Drawing.Point(286, 8);
            this.toPicker.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.toPicker.Name = "toPicker";
            this.toPicker.Size = new System.Drawing.Size(168, 23);
            this.toPicker.TabIndex = 3;
            // 
            // machineLabel
            // 
            this.machineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.machineLabel.Location = new System.Drawing.Point(461, 0);
            this.machineLabel.Name = "machineLabel";
            this.machineLabel.Size = new System.Drawing.Size(76, 41);
            this.machineLabel.TabIndex = 4;
            this.machineLabel.Text = "机台名称";
            this.machineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // machineCombo
            // 
            this.machineCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machineCombo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.machineCombo.Location = new System.Drawing.Point(544, 8);
            this.machineCombo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.machineCombo.Name = "machineCombo";
            this.machineCombo.Size = new System.Drawing.Size(152, 25);
            this.machineCombo.TabIndex = 5;
            // 
            // barcodeLabel
            // 
            this.barcodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.barcodeLabel.Location = new System.Drawing.Point(3, 41);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.Size = new System.Drawing.Size(52, 41);
            this.barcodeLabel.TabIndex = 6;
            this.barcodeLabel.Text = "条码";
            this.barcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // barcodeBox
            // 
            this.barcodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.barcodeBox.Location = new System.Drawing.Point(62, 49);
            this.barcodeBox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.Size = new System.Drawing.Size(168, 23);
            this.barcodeBox.TabIndex = 7;
            // 
            // typeLabel
            // 
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.typeLabel.Location = new System.Drawing.Point(237, 41);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(42, 41);
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "类型";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // typeCombo
            // 
            this.typeCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.typeCombo.Location = new System.Drawing.Point(286, 49);
            this.typeCombo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.Size = new System.Drawing.Size(168, 25);
            this.typeCombo.TabIndex = 9;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            // 
            // btnQuery
            // 
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnQuery.Location = new System.Drawing.Point(704, 6);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuery.Name = "btnQuery";
            this.queryBar.SetRowSpan(this.btnQuery, 2);
            this.btnQuery.Size = new System.Drawing.Size(92, 70);
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // btnExport
            // 
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnExport.Location = new System.Drawing.Point(804, 6);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExport.Name = "btnExport";
            this.queryBar.SetRowSpan(this.btnExport, 2);
            this.btnExport.Size = new System.Drawing.Size(92, 70);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // querySpacer
            // 
            this.querySpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.querySpacer.Location = new System.Drawing.Point(903, 3);
            this.querySpacer.Name = "querySpacer";
            this.querySpacer.Size = new System.Drawing.Size(260, 35);
            this.querySpacer.TabIndex = 12;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeight = 30;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirst,
            this.colSecond,
            this.colThird,
            this.colFourth});
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.grid.Location = new System.Drawing.Point(4, 96);
            this.grid.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 26;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1172, 560);
            this.grid.TabIndex = 1;
            // 
            // colFirst
            // 
            this.colFirst.FillWeight = 26F;
            this.colFirst.HeaderText = "开始时间";
            this.colFirst.Name = "colFirst";
            this.colFirst.ReadOnly = true;
            this.colFirst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colSecond
            // 
            this.colSecond.FillWeight = 26F;
            this.colSecond.HeaderText = "结束时间";
            this.colSecond.Name = "colSecond";
            this.colSecond.ReadOnly = true;
            this.colSecond.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colThird
            // 
            this.colThird.FillWeight = 18F;
            this.colThird.HeaderText = "故障代码";
            this.colThird.Name = "colThird";
            this.colThird.ReadOnly = true;
            this.colThird.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // colFourth
            // 
            this.colFourth.FillWeight = 30F;
            this.colFourth.HeaderText = "故障描述";
            this.colFourth.Name = "colFourth";
            this.colFourth.ReadOnly = true;
            this.colFourth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PageOperationLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.root);
            this.Name = "PageOperationLog";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.queryBar.ResumeLayout(false);
            this.queryBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel queryBar;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.Label machineLabel;
        private System.Windows.Forms.ComboBox machineCombo;
        private System.Windows.Forms.Label barcodeLabel;
        private System.Windows.Forms.TextBox barcodeBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.ComboBox typeCombo;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Panel querySpacer;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecond;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThird;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFourth;
    }
}
