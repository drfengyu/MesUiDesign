namespace Mes.Hmi
{
    partial class PageAlarmHistory
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
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.querySpacer = new System.Windows.Forms.Panel();
            this.list = new System.Windows.Forms.ListBox();
            this.root.SuspendLayout();
            this.queryBar.SuspendLayout();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.queryBar, 0, 0);
            this.root.Controls.Add(this.list, 0, 1);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 2;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            //
            // queryBar
            //
            this.queryBar.BackColor = System.Drawing.Color.White;
            this.queryBar.ColumnCount = 6;
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 220F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.queryBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queryBar.Controls.Add(this.fromLabel, 0, 0);
            this.queryBar.Controls.Add(this.fromPicker, 1, 0);
            this.queryBar.Controls.Add(this.toLabel, 2, 0);
            this.queryBar.Controls.Add(this.toPicker, 3, 0);
            this.queryBar.Controls.Add(this.btnQuery, 4, 0);
            this.queryBar.Controls.Add(this.querySpacer, 5, 0);
            this.queryBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBar.Name = "queryBar";
            this.queryBar.RowCount = 1;
            this.queryBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queryBar.TabIndex = 0;
            //
            // fromLabel
            //
            this.fromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "起始";
            this.fromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // fromPicker
            //
            this.fromPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.fromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromPicker.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromPicker.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.TabIndex = 1;
            //
            // toLabel
            //
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toLabel.Name = "toLabel";
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "至 结束";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // toPicker
            //
            this.toPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.toPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPicker.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toPicker.Margin = new System.Windows.Forms.Padding(4, 9, 4, 9);
            this.toPicker.Name = "toPicker";
            this.toPicker.TabIndex = 3;
            //
            // btnQuery
            //
            this.btnQuery.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 7, 4, 7);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            //
            // querySpacer
            //
            this.querySpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.querySpacer.Name = "querySpacer";
            this.querySpacer.TabIndex = 5;
            //
            // list
            //
            this.list.BackColor = System.Drawing.Color.White;
            this.list.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.list.IntegralHeight = false;
            this.list.ItemHeight = 24;
            this.list.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.list.Name = "list";
            this.list.TabIndex = 1;
            //
            // PageAlarmHistory
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageAlarmHistory";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.queryBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel queryBar;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Panel querySpacer;
        private System.Windows.Forms.ListBox list;
    }
}
