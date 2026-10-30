namespace Mes.Hmi
{
    partial class PagePlaceholder
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(600, 48);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "页面标题";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // noteLabel
            // 
            this.noteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLabel.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.noteLabel.ForeColor = System.Drawing.Color.FromArgb(90, 96, 105);
            this.noteLabel.Location = new System.Drawing.Point(0, 48);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(600, 252);
            this.noteLabel.TabIndex = 1;
            this.noteLabel.Text = "该页面尚未实现";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PagePlaceholder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "PagePlaceholder";
            this.Size = new System.Drawing.Size(600, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label noteLabel;
    }
}
