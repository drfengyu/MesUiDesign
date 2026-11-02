namespace Mes.Hmi
{
    partial class PageAlarmActive
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
            this.listPanel = new System.Windows.Forms.TableLayoutPanel();
            this.listCaption = new System.Windows.Forms.Label();
            this.list = new System.Windows.Forms.ListBox();
            this.mapPanel = new System.Windows.Forms.TableLayoutPanel();
            this.mapCaption = new System.Windows.Forms.Label();
            this.map = new System.Windows.Forms.Panel();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.listPanel.SuspendLayout();
            this.mapPanel.SuspendLayout();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 2;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66F));
            this.root.Controls.Add(this.listPanel, 0, 0);
            this.root.Controls.Add(this.mapPanel, 1, 0);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 1;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            //
            // listPanel
            //
            this.listPanel.BackColor = System.Drawing.Color.White;
            this.listPanel.ColumnCount = 1;
            this.listPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listPanel.Controls.Add(this.listCaption, 0, 0);
            this.listPanel.Controls.Add(this.list, 0, 1);
            this.listPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listPanel.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.listPanel.Name = "listPanel";
            this.listPanel.RowCount = 2;
            this.listPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.listPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.listPanel.TabIndex = 0;
            //
            // listCaption
            //
            this.listCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.listCaption.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.listCaption.Name = "listCaption";
            this.listCaption.TabIndex = 0;
            this.listCaption.Text = "当前报警：0 条";
            this.listCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // list
            //
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.list.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.list.IntegralHeight = false;
            this.list.ItemHeight = 24;
            this.list.Name = "list";
            this.list.ScrollAlwaysVisible = true;
            this.list.TabIndex = 1;
            //
            // mapPanel
            //
            this.mapPanel.ColumnCount = 1;
            this.mapPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mapPanel.Controls.Add(this.mapCaption, 0, 0);
            this.mapPanel.Controls.Add(this.map, 0, 1);
            this.mapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapPanel.Name = "mapPanel";
            this.mapPanel.RowCount = 2;
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.mapPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mapPanel.TabIndex = 1;
            //
            // mapCaption
            //
            this.mapCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.mapCaption.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.mapCaption.Name = "mapCaption";
            this.mapCaption.TabIndex = 0;
            this.mapCaption.Text = "整机视图";
            this.mapCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // map
            //
            this.map.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map.Dock = System.Windows.Forms.DockStyle.Fill;
            this.map.Name = "map";
            this.map.TabIndex = 1;
            //
            // refresh
            //
            this.refresh.Interval = 400;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            //
            // PageAlarmActive
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageAlarmActive";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.listPanel.ResumeLayout(false);
            this.mapPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel listPanel;
        private System.Windows.Forms.Label listCaption;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TableLayoutPanel mapPanel;
        private System.Windows.Forms.Label mapCaption;
        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.Timer refresh;
    }
}
