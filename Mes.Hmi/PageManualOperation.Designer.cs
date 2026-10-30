namespace Mes.Hmi
{
    partial class PageManualOperation
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
            System.Windows.Forms.DataGridViewCellStyle nameStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle buttonStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dotStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle timeStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.headerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.modeLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.TableLayoutPanel();
            this.sidePanel = new System.Windows.Forms.TableLayoutPanel();
            this.debugTitle = new System.Windows.Forms.Label();
            this.btnResetAlarms = new System.Windows.Forms.Button();
            this.btnHomeAll = new System.Windows.Forms.Button();
            this.sideNote = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colCylinder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHome = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colWork = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colHomeOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWorkOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusLabel = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // headerStyle
            // 
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            // 
            // nameStyle
            // 
            nameStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            nameStyle.Font = new System.Drawing.Font("微软雅黑", 11F);
            nameStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            nameStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            nameStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // buttonStyle
            // 
            buttonStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            buttonStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(242)))), ((int)(((byte)(248)))));
            buttonStyle.Font = new System.Drawing.Font("微软雅黑", 11F);
            buttonStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            buttonStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(226)))), ((int)(((byte)(242)))));
            buttonStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(70)))), ((int)(((byte)(120)))));
            // 
            // dotStyle
            // 
            dotStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dotStyle.Font = new System.Drawing.Font("微软雅黑", 14F);
            dotStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(174)))), ((int)(((byte)(180)))));
            dotStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // timeStyle
            // 
            timeStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            timeStyle.Font = new System.Drawing.Font("微软雅黑", 11F);
            timeStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            timeStyle.SelectionBackColor = System.Drawing.Color.White;
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.headerPanel, 0, 0);
            this.root.Controls.Add(this.bodyPanel, 0, 1);
            this.root.Controls.Add(this.statusLabel, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(6);
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // headerPanel
            // 
            this.headerPanel.ColumnCount = 2;
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.headerPanel.Controls.Add(this.titleLabel, 0, 0);
            this.headerPanel.Controls.Add(this.modeLabel, 1, 0);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headerPanel.Location = new System.Drawing.Point(9, 9);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.RowCount = 1;
            this.headerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.headerPanel.Size = new System.Drawing.Size(1162, 54);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleLabel.Font = new System.Drawing.Font("微软雅黑", 16F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(3, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(756, 54);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "HAF 贴合模组 · 气缸点动";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modeLabel
            // 
            this.modeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.modeLabel.Location = new System.Drawing.Point(765, 0);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.modeLabel.Size = new System.Drawing.Size(394, 54);
            this.modeLabel.TabIndex = 1;
            this.modeLabel.Text = "MA 旋钮：自动";
            this.modeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bodyPanel
            // 
            this.bodyPanel.ColumnCount = 2;
            this.bodyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.bodyPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyPanel.Controls.Add(this.sidePanel, 0, 0);
            this.bodyPanel.Controls.Add(this.grid, 1, 0);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(9, 69);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.RowCount = 1;
            this.bodyPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyPanel.Size = new System.Drawing.Size(1162, 530);
            this.bodyPanel.TabIndex = 1;
            // 
            // sidePanel
            // 
            this.sidePanel.ColumnCount = 1;
            this.sidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidePanel.Controls.Add(this.debugTitle, 0, 0);
            this.sidePanel.Controls.Add(this.btnResetAlarms, 0, 1);
            this.sidePanel.Controls.Add(this.btnHomeAll, 0, 2);
            this.sidePanel.Controls.Add(this.sideNote, 0, 3);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sidePanel.Location = new System.Drawing.Point(3, 3);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.sidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.sidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.sidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.sidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sidePanel.Size = new System.Drawing.Size(294, 524);
            this.sidePanel.TabIndex = 0;
            // 
            // debugTitle
            // 
            this.debugTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.debugTitle.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.debugTitle.Location = new System.Drawing.Point(3, 0);
            this.debugTitle.Name = "debugTitle";
            this.debugTitle.Size = new System.Drawing.Size(278, 40);
            this.debugTitle.TabIndex = 0;
            this.debugTitle.Text = "调试功能";
            this.debugTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnResetAlarms
            // 
            this.btnResetAlarms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetAlarms.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnResetAlarms.Location = new System.Drawing.Point(4, 44);
            this.btnResetAlarms.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetAlarms.Name = "btnResetAlarms";
            this.btnResetAlarms.Size = new System.Drawing.Size(276, 54);
            this.btnResetAlarms.TabIndex = 1;
            this.btnResetAlarms.Text = "复位报警";
            this.btnResetAlarms.UseVisualStyleBackColor = true;
            this.btnResetAlarms.Click += new System.EventHandler(this.btnResetAlarms_Click);
            // 
            // btnHomeAll
            // 
            this.btnHomeAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHomeAll.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.btnHomeAll.Location = new System.Drawing.Point(4, 106);
            this.btnHomeAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnHomeAll.Name = "btnHomeAll";
            this.btnHomeAll.Size = new System.Drawing.Size(276, 54);
            this.btnHomeAll.TabIndex = 2;
            this.btnHomeAll.Text = "全部回原点";
            this.btnHomeAll.UseVisualStyleBackColor = true;
            this.btnHomeAll.Click += new System.EventHandler(this.btnHomeAll_Click);
            // 
            // sideNote
            // 
            this.sideNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sideNote.Font = new System.Drawing.Font("微软雅黑", 10.5F);
            this.sideNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.sideNote.Location = new System.Drawing.Point(3, 164);
            this.sideNote.Name = "sideNote";
            this.sideNote.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.sideNote.Size = new System.Drawing.Size(278, 360);
            this.sideNote.TabIndex = 3;
            this.sideNote.Text = "本机 IO 表里没有伺服轴，也没有真空压力开关；\r\n这里只列出阀和两个到位开关都齐全的气缸。\r\n\r\n点动前请确认 MA 旋钮在手动档：\r\n自动档下点动会被拒绝。";
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
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.grid.ColumnHeadersDefaultCellStyle = headerStyle;
            this.grid.ColumnHeadersHeight = 40;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCylinder,
            this.colHome,
            this.colWork,
            this.colHomeOn,
            this.colWorkOn,
            this.colTime});
            this.grid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.White;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.Font = new System.Drawing.Font("微软雅黑", 11F);
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(236)))), ((int)(((byte)(240)))));
            this.grid.Location = new System.Drawing.Point(303, 3);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 44;
            this.grid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(856, 524);
            this.grid.TabIndex = 1;
            this.grid.TabStop = false;
            this.grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            this.grid.Resize += new System.EventHandler(this.grid_Resize);
            // 
            // colCylinder
            // 
            this.colCylinder.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCylinder.DefaultCellStyle = nameStyle;
            this.colCylinder.FillWeight = 24F;
            this.colCylinder.HeaderText = "气缸";
            this.colCylinder.Name = "colCylinder";
            this.colCylinder.ReadOnly = true;
            this.colCylinder.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colHome
            // 
            this.colHome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHome.DefaultCellStyle = buttonStyle;
            this.colHome.FillWeight = 15F;
            this.colHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colHome.HeaderText = "原点";
            this.colHome.Name = "colHome";
            this.colHome.ReadOnly = true;
            this.colHome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHome.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colHome.Text = "原点";
            this.colHome.UseColumnTextForButtonValue = true;
            // 
            // colWork
            // 
            this.colWork.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWork.DefaultCellStyle = buttonStyle;
            this.colWork.FillWeight = 15F;
            this.colWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colWork.HeaderText = "动点";
            this.colWork.Name = "colWork";
            this.colWork.ReadOnly = true;
            this.colWork.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colWork.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colWork.Text = "动点";
            this.colWork.UseColumnTextForButtonValue = true;
            // 
            // colHomeOn
            // 
            this.colHomeOn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colHomeOn.DefaultCellStyle = dotStyle;
            this.colHomeOn.FillWeight = 15F;
            this.colHomeOn.HeaderText = "原点到位";
            this.colHomeOn.Name = "colHomeOn";
            this.colHomeOn.ReadOnly = true;
            this.colHomeOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colWorkOn
            // 
            this.colWorkOn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colWorkOn.DefaultCellStyle = dotStyle;
            this.colWorkOn.FillWeight = 15F;
            this.colWorkOn.HeaderText = "动点到位";
            this.colWorkOn.Name = "colWorkOn";
            this.colWorkOn.ReadOnly = true;
            this.colWorkOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colTime
            // 
            this.colTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTime.DefaultCellStyle = timeStyle;
            this.colTime.FillWeight = 16F;
            this.colTime.HeaderText = "动作耗时";
            this.colTime.Name = "colTime";
            this.colTime.ReadOnly = true;
            this.colTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // statusLabel
            // 
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusLabel.Font = new System.Drawing.Font("微软雅黑", 11.5F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.statusLabel.Location = new System.Drawing.Point(9, 602);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.statusLabel.Size = new System.Drawing.Size(1162, 52);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "点动用输出阀直接驱动气缸；自动档下会被拒绝。";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // refresh
            // 
            this.refresh.Interval = 100;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageManualOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.root);
            this.Name = "PageManualOperation";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.bodyPanel.ResumeLayout(false);
            this.sidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.TableLayoutPanel bodyPanel;
        private System.Windows.Forms.TableLayoutPanel sidePanel;
        private System.Windows.Forms.Label debugTitle;
        private System.Windows.Forms.Button btnResetAlarms;
        private System.Windows.Forms.Button btnHomeAll;
        private System.Windows.Forms.Label sideNote;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCylinder;
        private System.Windows.Forms.DataGridViewButtonColumn colHome;
        private System.Windows.Forms.DataGridViewButtonColumn colWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHomeOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWorkOn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTime;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer refresh;
    }
}
