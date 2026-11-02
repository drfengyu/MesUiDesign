namespace Mes.Hmi
{
    partial class PageMachineInfo
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
            this.cards = new System.Windows.Forms.TableLayoutPanel();
            this.hwCard = new System.Windows.Forms.TableLayoutPanel();
            this.hwCaption = new System.Windows.Forms.Label();
            this.hwRows = new System.Windows.Forms.TableLayoutPanel();
            this.swCard = new System.Windows.Forms.TableLayoutPanel();
            this.swCaption = new System.Windows.Forms.Label();
            this.swRows = new System.Windows.Forms.TableLayoutPanel();
            this.logCaption = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.TextBox();
            this.root.SuspendLayout();
            this.cards.SuspendLayout();
            this.hwCard.SuspendLayout();
            this.swCard.SuspendLayout();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.cards, 0, 0);
            this.root.Controls.Add(this.logCaption, 0, 1);
            this.root.Controls.Add(this.logBox, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(8, 6, 8, 4);
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 210F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            //
            // cards
            //
            this.cards.ColumnCount = 2;
            this.cards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cards.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cards.Controls.Add(this.hwCard, 0, 0);
            this.cards.Controls.Add(this.swCard, 1, 0);
            this.cards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cards.Name = "cards";
            this.cards.RowCount = 1;
            this.cards.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cards.TabIndex = 0;
            //
            // hwCard
            //
            this.hwCard.BackColor = System.Drawing.Color.White;
            this.hwCard.ColumnCount = 1;
            this.hwCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hwCard.Controls.Add(this.hwCaption, 0, 0);
            this.hwCard.Controls.Add(this.hwRows, 0, 1);
            this.hwCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hwCard.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.hwCard.Name = "hwCard";
            this.hwCard.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.hwCard.RowCount = 2;
            this.hwCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.hwCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hwCard.TabIndex = 0;
            //
            // hwCaption
            //
            this.hwCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hwCaption.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.hwCaption.ForeColor = System.Drawing.Color.FromArgb(40, 45, 50);
            this.hwCaption.Name = "hwCaption";
            this.hwCaption.TabIndex = 0;
            this.hwCaption.Text = "机台硬件信息";
            this.hwCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // hwRows
            //
            this.hwRows.AutoScroll = true;
            this.hwRows.ColumnCount = 1;
            this.hwRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.hwRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hwRows.Name = "hwRows";
            this.hwRows.RowCount = 0;
            this.hwRows.TabIndex = 1;
            //
            // swCard
            //
            this.swCard.BackColor = System.Drawing.Color.White;
            this.swCard.ColumnCount = 1;
            this.swCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.swCard.Controls.Add(this.swCaption, 0, 0);
            this.swCard.Controls.Add(this.swRows, 0, 1);
            this.swCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swCard.Margin = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.swCard.Name = "swCard";
            this.swCard.Padding = new System.Windows.Forms.Padding(12, 6, 12, 6);
            this.swCard.RowCount = 2;
            this.swCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.swCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.swCard.TabIndex = 1;
            //
            // swCaption
            //
            this.swCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swCaption.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.swCaption.ForeColor = System.Drawing.Color.FromArgb(40, 45, 50);
            this.swCaption.Name = "swCaption";
            this.swCaption.TabIndex = 0;
            this.swCaption.Text = "机台软件信息";
            this.swCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // swRows
            //
            this.swRows.AutoScroll = true;
            this.swRows.ColumnCount = 1;
            this.swRows.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.swRows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.swRows.Name = "swRows";
            this.swRows.RowCount = 0;
            this.swRows.TabIndex = 1;
            //
            // logCaption
            //
            this.logCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.logCaption.ForeColor = System.Drawing.Color.FromArgb(60, 66, 72);
            this.logCaption.Name = "logCaption";
            this.logCaption.TabIndex = 1;
            this.logCaption.Text = "程序更新记录:CHANGELOG.md";
            this.logCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // logBox
            //
            this.logBox.BackColor = System.Drawing.Color.White;
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.logBox.Margin = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.logBox.Multiline = true;
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.logBox.TabIndex = 2;
            //
            // PageMachineInfo
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageMachineInfo";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.cards.ResumeLayout(false);
            this.hwCard.ResumeLayout(false);
            this.swCard.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel cards;
        private System.Windows.Forms.TableLayoutPanel hwCard;
        private System.Windows.Forms.Label hwCaption;
        private System.Windows.Forms.TableLayoutPanel hwRows;
        private System.Windows.Forms.TableLayoutPanel swCard;
        private System.Windows.Forms.Label swCaption;
        private System.Windows.Forms.TableLayoutPanel swRows;
        private System.Windows.Forms.Label logCaption;
        private System.Windows.Forms.TextBox logBox;
    }
}
