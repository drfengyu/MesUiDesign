namespace Mes.Hmi
{
    partial class PageFixtureLife
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
            this.lists = new System.Windows.Forms.TableLayoutPanel();
            this.blackGroup = new System.Windows.Forms.GroupBox();
            this.blackList = new System.Windows.Forms.ListBox();
            this.whiteGroup = new System.Windows.Forms.GroupBox();
            this.whiteList = new System.Windows.Forms.ListBox();
            this.blockGroup = new System.Windows.Forms.GroupBox();
            this.blockGrid = new System.Windows.Forms.DataGridView();
            this.blockTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockFixture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blockResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.overviewGroup = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFixture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinorAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMajorAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footer = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.lists.SuspendLayout();
            this.blackGroup.SuspendLayout();
            this.whiteGroup.SuspendLayout();
            this.blockGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.blockGrid)).BeginInit();
            this.overviewGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerStyle
            // 
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            // 
            // cellStyle
            // 
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            cellStyle.SelectionBackColor = System.Drawing.Color.White;
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.lists, 0, 0);
            this.root.Controls.Add(this.blockGroup, 0, 1);
            this.root.Controls.Add(this.overviewGroup, 0, 2);
            this.root.Controls.Add(this.footer, 0, 3);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 4;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 146F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // lists
            // 
            this.lists.ColumnCount = 2;
            this.lists.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lists.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.lists.Controls.Add(this.blackGroup, 0, 0);
            this.lists.Controls.Add(this.whiteGroup, 1, 0);
            this.lists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lists.Location = new System.Drawing.Point(11, 55);
            this.lists.Name = "lists";
            this.lists.RowCount = 1;
            this.lists.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lists.Size = new System.Drawing.Size(1158, 140);
            this.lists.TabIndex = 1;
            // 
            // blackGroup
            // 
            this.blackGroup.Controls.Add(this.blackList);
            this.blackGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackGroup.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.blackGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.blackGroup.Location = new System.Drawing.Point(3, 3);
            this.blackGroup.Name = "blackGroup";
            this.blackGroup.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.blackGroup.Size = new System.Drawing.Size(573, 134);
            this.blackGroup.TabIndex = 0;
            this.blackGroup.TabStop = false;
            this.blackGroup.Text = "保养黑名单";
            // 
            // blackList
            // 
            this.blackList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blackList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blackList.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.blackList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.blackList.FormattingEnabled = true;
            this.blackList.IntegralHeight = false;
            this.blackList.ItemHeight = 17;
            this.blackList.Location = new System.Drawing.Point(8, 21);
            this.blackList.Name = "blackList";
            this.blackList.Size = new System.Drawing.Size(557, 105);
            this.blackList.TabIndex = 0;
            // 
            // whiteGroup
            // 
            this.whiteGroup.Controls.Add(this.whiteList);
            this.whiteGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteGroup.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.whiteGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.whiteGroup.Location = new System.Drawing.Point(582, 3);
            this.whiteGroup.Name = "whiteGroup";
            this.whiteGroup.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.whiteGroup.Size = new System.Drawing.Size(573, 134);
            this.whiteGroup.TabIndex = 1;
            this.whiteGroup.TabStop = false;
            this.whiteGroup.Text = "IQC 白名单（码表状态非停用且未超保养）";
            // 
            // whiteList
            // 
            this.whiteList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.whiteList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.whiteList.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.whiteList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(120)))), ((int)(((byte)(60)))));
            this.whiteList.FormattingEnabled = true;
            this.whiteList.IntegralHeight = false;
            this.whiteList.ItemHeight = 17;
            this.whiteList.Location = new System.Drawing.Point(8, 21);
            this.whiteList.Name = "whiteList";
            this.whiteList.Size = new System.Drawing.Size(557, 105);
            this.whiteList.TabIndex = 0;
            // 
            // blockGroup
            // 
            this.blockGroup.Controls.Add(this.blockGrid);
            this.blockGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockGroup.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.blockGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.blockGroup.Location = new System.Drawing.Point(11, 201);
            this.blockGroup.Name = "blockGroup";
            this.blockGroup.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.blockGroup.Size = new System.Drawing.Size(1158, 126);
            this.blockGroup.TabIndex = 2;
            this.blockGroup.TabStop = false;
            this.blockGroup.Text = "治具卡控记录";
            // 
            // blockGrid
            // 
            this.blockGrid.AllowUserToAddRows = false;
            this.blockGrid.AllowUserToDeleteRows = false;
            this.blockGrid.AllowUserToResizeRows = false;
            this.blockGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.blockGrid.BackgroundColor = System.Drawing.Color.White;
            this.blockGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.blockGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.blockGrid.ColumnHeadersDefaultCellStyle = headerStyle;
            this.blockGrid.ColumnHeadersHeight = 28;
            this.blockGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.blockGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.blockTime,
            this.blockFixture,
            this.blockReason,
            this.blockProduct,
            this.blockResult});
            this.blockGrid.DefaultCellStyle = cellStyle;
            this.blockGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blockGrid.EnableHeadersVisualStyles = false;
            this.blockGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.blockGrid.Location = new System.Drawing.Point(8, 21);
            this.blockGrid.Name = "blockGrid";
            this.blockGrid.ReadOnly = true;
            this.blockGrid.RowHeadersVisible = false;
            this.blockGrid.RowTemplate.Height = 26;
            this.blockGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.blockGrid.Size = new System.Drawing.Size(1142, 97);
            this.blockGrid.TabIndex = 0;
            // 
            // blockTime
            // 
            this.blockTime.FillWeight = 18F;
            this.blockTime.HeaderText = "时间";
            this.blockTime.Name = "blockTime";
            this.blockTime.ReadOnly = true;
            // 
            // blockFixture
            // 
            this.blockFixture.FillWeight = 16F;
            this.blockFixture.HeaderText = "治具码";
            this.blockFixture.Name = "blockFixture";
            this.blockFixture.ReadOnly = true;
            // 
            // blockReason
            // 
            this.blockReason.FillWeight = 30F;
            this.blockReason.HeaderText = "原因";
            this.blockReason.Name = "blockReason";
            this.blockReason.ReadOnly = true;
            // 
            // blockProduct
            // 
            this.blockProduct.FillWeight = 22F;
            this.blockProduct.HeaderText = "产品码";
            this.blockProduct.Name = "blockProduct";
            this.blockProduct.ReadOnly = true;
            // 
            // blockResult
            // 
            this.blockResult.FillWeight = 14F;
            this.blockResult.HeaderText = "结果";
            this.blockResult.Name = "blockResult";
            this.blockResult.ReadOnly = true;
            // 
            // overviewGroup
            // 
            this.overviewGroup.Controls.Add(this.grid);
            this.overviewGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.overviewGroup.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.overviewGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.overviewGroup.Location = new System.Drawing.Point(11, 333);
            this.overviewGroup.Name = "overviewGroup";
            this.overviewGroup.Padding = new System.Windows.Forms.Padding(8, 4, 8, 8);
            this.overviewGroup.Size = new System.Drawing.Size(1158, 282);
            this.overviewGroup.TabIndex = 3;
            this.overviewGroup.TabStop = false;
            this.overviewGroup.Text = "机台/线体治具总览（双击保养计数或保养时间登记保养）";
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
            this.grid.ColumnHeadersHeight = 30;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colFixture,
            this.colMinor,
            this.colMajor,
            this.colMinorAt,
            this.colMajorAt,
            this.colState});
            this.grid.DefaultCellStyle = cellStyle;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.grid.Location = new System.Drawing.Point(8, 21);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 28;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1142, 253);
            this.grid.TabIndex = 0;
            this.grid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellDoubleClick);
            // 
            // colIndex
            // 
            this.colIndex.FillWeight = 6F;
            this.colIndex.HeaderText = "序号";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            // 
            // colFixture
            // 
            this.colFixture.FillWeight = 16F;
            this.colFixture.HeaderText = "治具码";
            this.colFixture.Name = "colFixture";
            this.colFixture.ReadOnly = true;
            // 
            // colMinor
            // 
            this.colMinor.FillWeight = 14F;
            this.colMinor.HeaderText = "小保养计数";
            this.colMinor.Name = "colMinor";
            this.colMinor.ReadOnly = true;
            // 
            // colMajor
            // 
            this.colMajor.FillWeight = 14F;
            this.colMajor.HeaderText = "大保养计数";
            this.colMajor.Name = "colMajor";
            this.colMajor.ReadOnly = true;
            // 
            // colMinorAt
            // 
            this.colMinorAt.FillWeight = 18F;
            this.colMinorAt.HeaderText = "小保养时间";
            this.colMinorAt.Name = "colMinorAt";
            this.colMinorAt.ReadOnly = true;
            // 
            // colMajorAt
            // 
            this.colMajorAt.FillWeight = 18F;
            this.colMajorAt.HeaderText = "大保养时间";
            this.colMajorAt.Name = "colMajorAt";
            this.colMajorAt.ReadOnly = true;
            // 
            // colState
            // 
            this.colState.FillWeight = 10F;
            this.colState.HeaderText = "状态";
            this.colState.Name = "colState";
            this.colState.ReadOnly = true;
            // 
            // footer
            // 
            this.footer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.footer.Font = new System.Drawing.Font("微软雅黑", 8.5F);
            this.footer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(134)))));
            this.footer.Location = new System.Drawing.Point(7, 613);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1166, 34);
            this.footer.TabIndex = 4;
            this.footer.Text = "备注：1、双击【治具码】可删除该治具；2、双击【小保养计数】可清零小保养次数；3、双击【大保养计数】可同时清零大保养和小保养次数；4、双击【小保养计时】可重置小保养时间；5、双击【大保养计时】可同时重置大保养和小保养时间。";
            this.footer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refresh
            // 
            this.refresh.Interval = 2000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageFixtureLife
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageFixtureLife";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.lists.ResumeLayout(false);
            this.blackGroup.ResumeLayout(false);
            this.whiteGroup.ResumeLayout(false);
            this.blockGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.blockGrid)).EndInit();
            this.overviewGroup.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel lists;
        private System.Windows.Forms.GroupBox blackGroup;
        private System.Windows.Forms.ListBox blackList;
        private System.Windows.Forms.GroupBox whiteGroup;
        private System.Windows.Forms.ListBox whiteList;
        private System.Windows.Forms.GroupBox blockGroup;
        private System.Windows.Forms.DataGridView blockGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockFixture;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn blockResult;
        private System.Windows.Forms.GroupBox overviewGroup;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFixture;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinorAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMajorAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colState;
        private System.Windows.Forms.Label footer;
        private System.Windows.Forms.Timer refresh;
    }
}
