namespace Mes.Hmi
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
            this.queryBar.Name = "queryBar";
            this.queryBar.RowCount = 2;
            this.queryBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queryBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.queryBar.TabIndex = 0;
            //
            // timeLabel
            //
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.timeLabel.Name = "timeLabel";
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
            this.fromPicker.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.TabIndex = 1;
            //
            // toLabel
            //
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toLabel.Name = "toLabel";
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
            this.toPicker.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.toPicker.Name = "toPicker";
            this.toPicker.TabIndex = 3;
            //
            // machineLabel
            //
            this.machineLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.machineLabel.Name = "machineLabel";
            this.machineLabel.TabIndex = 4;
            this.machineLabel.Text = "机台名称";
            this.machineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // machineCombo
            //
            this.machineCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.machineCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.machineCombo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.machineCombo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.machineCombo.Name = "machineCombo";
            this.machineCombo.TabIndex = 5;
            //
            // barcodeLabel
            //
            this.barcodeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.barcodeLabel.Name = "barcodeLabel";
            this.barcodeLabel.TabIndex = 6;
            this.barcodeLabel.Text = "条码";
            this.barcodeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // barcodeBox
            //
            this.barcodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barcodeBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.barcodeBox.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.barcodeBox.Name = "barcodeBox";
            this.barcodeBox.TabIndex = 7;
            //
            // typeLabel
            //
            this.typeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.TabIndex = 8;
            this.typeLabel.Text = "类型";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // typeCombo
            //
            this.typeCombo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCombo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.typeCombo.Margin = new System.Windows.Forms.Padding(4, 8, 4, 8);
            this.typeCombo.Name = "typeCombo";
            this.typeCombo.TabIndex = 9;
            this.typeCombo.SelectedIndexChanged += new System.EventHandler(this.typeCombo_SelectedIndexChanged);
            //
            // btnQuery
            //
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.TabIndex = 10;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.queryBar.SetRowSpan(this.btnQuery, 2);
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            //
            // btnExport
            //
            this.btnExport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExport.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnExport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExport.Name = "btnExport";
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "导出";
            this.btnExport.UseVisualStyleBackColor = true;
            this.queryBar.SetRowSpan(this.btnExport, 2);
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            //
            // querySpacer
            //
            this.querySpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.querySpacer.Name = "querySpacer";
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
            this.grid.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 66, 72);
            this.grid.ColumnHeadersHeight = 30;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFirst,
            this.colSecond,
            this.colThird,
            this.colFourth});
            this.grid.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.grid.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grid.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(236, 239, 243);
            this.grid.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 26;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.TabIndex = 1;
            //
            // colFirst
            //
            this.colFirst.HeaderText = "开始时间";
            this.colFirst.Name = "colFirst";
            this.colFirst.FillWeight = 26F;
            this.colFirst.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colSecond
            //
            this.colSecond.HeaderText = "结束时间";
            this.colSecond.Name = "colSecond";
            this.colSecond.FillWeight = 26F;
            this.colSecond.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colThird
            //
            this.colThird.HeaderText = "故障代码";
            this.colThird.Name = "colThird";
            this.colThird.FillWeight = 18F;
            this.colThird.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colFourth
            //
            this.colFourth.HeaderText = "故障描述";
            this.colFourth.Name = "colFourth";
            this.colFourth.FillWeight = 30F;
            this.colFourth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // PageOperationLog
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageOperationLog";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.queryBar.ResumeLayout(false);
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
