namespace Mes.Hmi
{
    partial class PagePermissionMatrix
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
            this.components = new System.ComponentModel.Container();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.caption = new System.Windows.Forms.Label();
            this.matrix = new System.Windows.Forms.TableLayoutPanel();
            this.hintLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.root.SuspendLayout();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.caption, 0, 0);
            this.root.Controls.Add(this.matrix, 0, 1);
            this.root.Controls.Add(this.hintLabel, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(8, 6, 8, 4);
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
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
            this.caption.Text = "权限管理";
            this.caption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // matrix
            //
            this.matrix.AutoScroll = true;
            this.matrix.BackColor = System.Drawing.Color.White;
            this.matrix.ColumnCount = 7;
            this.matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.matrix.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.matrix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.matrix.Name = "matrix";
            this.matrix.RowCount = 1;
            this.matrix.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.matrix.TabIndex = 1;
            //
            // hintLabel
            //
            this.hintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hintLabel.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.hintLabel.ForeColor = System.Drawing.Color.FromArgb(120, 126, 135);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.TabIndex = 2;
            this.hintLabel.Text = "勾表示这一等级至少能进该模块下的一页；把鼠标停在模块名上可以看每一页要求的最低等级。矩阵由 AccessPolicy 现算，改权限不用改这张画面。";
            this.hintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // PagePermissionMatrix
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PagePermissionMatrix";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.Label caption;
        private System.Windows.Forms.TableLayoutPanel matrix;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
