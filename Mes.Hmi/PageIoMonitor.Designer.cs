namespace Mes.Hmi
{
    partial class PageIoMonitor
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
            System.Windows.Forms.DataGridViewCellStyle dotStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle nameStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colDotLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameLeft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDotRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNameRight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pager = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.pageLabel = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.pager.SuspendLayout();
            this.SuspendLayout();
            // 
            // dotStyle
            // 
            dotStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dotStyle.Font = new System.Drawing.Font("微软雅黑", 14F);
            dotStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            dotStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // nameStyle
            // 
            nameStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            nameStyle.Font = new System.Drawing.Font("微软雅黑", 12F);
            nameStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            nameStyle.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            nameStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.grid, 0, 0);
            this.root.Controls.Add(this.pager, 0, 1);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(6);
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeColumns = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid.ColumnHeadersVisible = false;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDotLeft,
            this.colNameLeft,
            this.colDotRight,
            this.colNameRight});
            this.grid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.grid.Location = new System.Drawing.Point(9, 9);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 38;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(1162, 584);
            this.grid.TabIndex = 0;
            this.grid.TabStop = false;
            this.grid.Resize += new System.EventHandler(this.grid_Resize);
            // 
            // colDotLeft
            // 
            this.colDotLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDotLeft.DefaultCellStyle = dotStyle;
            this.colDotLeft.FillWeight = 5F;
            this.colDotLeft.HeaderText = "";
            this.colDotLeft.Name = "colDotLeft";
            this.colDotLeft.ReadOnly = true;
            this.colDotLeft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNameLeft
            // 
            this.colNameLeft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameLeft.DefaultCellStyle = nameStyle;
            this.colNameLeft.FillWeight = 45F;
            this.colNameLeft.HeaderText = "";
            this.colNameLeft.Name = "colNameLeft";
            this.colNameLeft.ReadOnly = true;
            this.colNameLeft.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colDotRight
            // 
            this.colDotRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDotRight.DefaultCellStyle = dotStyle;
            this.colDotRight.FillWeight = 5F;
            this.colDotRight.HeaderText = "";
            this.colDotRight.Name = "colDotRight";
            this.colDotRight.ReadOnly = true;
            this.colDotRight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colNameRight
            // 
            this.colNameRight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNameRight.DefaultCellStyle = nameStyle;
            this.colNameRight.FillWeight = 45F;
            this.colNameRight.HeaderText = "";
            this.colNameRight.Name = "colNameRight";
            this.colNameRight.ReadOnly = true;
            this.colNameRight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pager
            // 
            this.pager.ColumnCount = 3;
            this.pager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.pager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pager.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.pager.Controls.Add(this.btnPrevious, 0, 0);
            this.pager.Controls.Add(this.pageLabel, 1, 0);
            this.pager.Controls.Add(this.btnNext, 2, 0);
            this.pager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pager.Location = new System.Drawing.Point(9, 599);
            this.pager.Name = "pager";
            this.pager.RowCount = 1;
            this.pager.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pager.Size = new System.Drawing.Size(1162, 58);
            this.pager.TabIndex = 1;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrevious.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnPrevious.Location = new System.Drawing.Point(4, 6);
            this.btnPrevious.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(142, 46);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "上一页";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // pageLabel
            // 
            this.pageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageLabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.pageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.pageLabel.Location = new System.Drawing.Point(153, 0);
            this.pageLabel.Name = "pageLabel";
            this.pageLabel.Size = new System.Drawing.Size(856, 58);
            this.pageLabel.TabIndex = 1;
            this.pageLabel.Text = "第 1 / 1 页";
            this.pageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnNext.Location = new System.Drawing.Point(1016, 6);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(142, 46);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 300;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageIoMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.root);
            this.Name = "PageIoMonitor";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.pager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDotLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameLeft;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDotRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNameRight;
        private System.Windows.Forms.TableLayoutPanel pager;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label pageLabel;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer refresh;
    }
}
