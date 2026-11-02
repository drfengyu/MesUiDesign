namespace Mes.Hmi
{
    partial class PageHelpDoc
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
            this.caption = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colOne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTwo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hintLabel = new System.Windows.Forms.Label();
            this.root.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.caption, 0, 0);
            this.root.Controls.Add(this.grid, 0, 1);
            this.root.Controls.Add(this.hintLabel, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(8, 6, 8, 4);
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            //
            // caption
            //
            this.caption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.caption.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.caption.Name = "caption";
            this.caption.TabIndex = 0;
            this.caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // grid
            //
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.grid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.grid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.grid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 66, 72);
            this.grid.ColumnHeadersHeight = 30;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colOne,
            this.colTwo,
            this.colThree,
            this.colFour});
            this.grid.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.grid.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            this.grid.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.grid.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.grid.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(220, 224, 230);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 30;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.TabIndex = 1;
            //
            // colOne
            //
            this.colOne.HeaderText = "编号";
            this.colOne.Name = "colOne";
            this.colOne.FillWeight = 14F;
            this.colOne.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colTwo
            //
            this.colTwo.HeaderText = "项目";
            this.colTwo.Name = "colTwo";
            this.colTwo.FillWeight = 10F;
            this.colTwo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            //
            // colThree
            //
            this.colThree.HeaderText = "说明";
            this.colThree.Name = "colThree";
            this.colThree.FillWeight = 30F;
            this.colThree.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colFour
            //
            this.colFour.HeaderText = "处理";
            this.colFour.Name = "colFour";
            this.colFour.FillWeight = 46F;
            this.colFour.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // hintLabel
            //
            this.hintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.hintLabel.ForeColor = System.Drawing.Color.FromArgb(120, 126, 135);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.TabIndex = 2;
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // PageHelpDoc
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageHelpDoc";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTwo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThree;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFour;
        private System.Windows.Forms.Label hintLabel;
    }
}
