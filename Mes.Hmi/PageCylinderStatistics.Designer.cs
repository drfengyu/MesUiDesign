namespace Mes.Hmi
{
    partial class PageCylinderStatistics
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
            System.Windows.Forms.DataGridViewCellStyle dayHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dayCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle nightHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle nightCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.contentPanel = new System.Windows.Forms.TableLayoutPanel();
            this.dayCard = new System.Windows.Forms.TableLayoutPanel();
            this.dayTitle = new System.Windows.Forms.Label();
            this.gridDay = new System.Windows.Forms.DataGridView();
            this.colDayName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayFaults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDayClear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.nightCard = new System.Windows.Forms.TableLayoutPanel();
            this.nightTitle = new System.Windows.Forms.Label();
            this.gridNight = new System.Windows.Forms.DataGridView();
            this.colNightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightActions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightFaults = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNightClear = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pagerPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.dayCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDay)).BeginInit();
            this.nightCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridNight)).BeginInit();
            this.pagerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.contentPanel, 0, 0);
            this.root.Controls.Add(this.pagerPanel, 0, 1);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 2;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // contentPanel
            // 
            this.contentPanel.ColumnCount = 2;
            this.contentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.contentPanel.Controls.Add(this.dayCard, 0, 0);
            this.contentPanel.Controls.Add(this.nightCard, 1, 0);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(4, 4);
            this.contentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.RowCount = 1;
            this.contentPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.contentPanel.Size = new System.Drawing.Size(1172, 598);
            this.contentPanel.TabIndex = 0;
            // 
            // dayCard
            // 
            this.dayCard.ColumnCount = 1;
            this.dayCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dayCard.Controls.Add(this.dayTitle, 0, 0);
            this.dayCard.Controls.Add(this.gridDay, 0, 1);
            this.dayCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayCard.Location = new System.Drawing.Point(0, 0);
            this.dayCard.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.dayCard.Name = "dayCard";
            this.dayCard.RowCount = 2;
            this.dayCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.dayCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dayCard.Size = new System.Drawing.Size(583, 598);
            this.dayCard.TabIndex = 0;
            // 
            // dayTitle
            // 
            this.dayTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dayTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.dayTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.dayTitle.Location = new System.Drawing.Point(0, 0);
            this.dayTitle.Margin = new System.Windows.Forms.Padding(0);
            this.dayTitle.Name = "dayTitle";
            this.dayTitle.Size = new System.Drawing.Size(583, 34);
            this.dayTitle.TabIndex = 0;
            this.dayTitle.Text = "白班";
            this.dayTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridDay
            // 
            this.gridDay.AllowUserToAddRows = false;
            this.gridDay.AllowUserToDeleteRows = false;
            this.gridDay.AllowUserToResizeRows = false;
            this.gridDay.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDay.BackgroundColor = System.Drawing.Color.White;
            this.gridDay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridDay.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dayHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dayHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dayHeaderStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            dayHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            dayHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dayHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.gridDay.ColumnHeadersDefaultCellStyle = dayHeaderStyle;
            this.gridDay.ColumnHeadersHeight = 32;
            this.gridDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDayName,
            this.colDayActions,
            this.colDayFaults,
            this.colDayClear});
            dayCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dayCellStyle.BackColor = System.Drawing.SystemColors.Window;
            dayCellStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            dayCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dayCellStyle.SelectionBackColor = System.Drawing.Color.White;
            dayCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            dayCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridDay.DefaultCellStyle = dayCellStyle;
            this.gridDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDay.EnableHeadersVisualStyles = false;
            this.gridDay.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.gridDay.Location = new System.Drawing.Point(0, 34);
            this.gridDay.Margin = new System.Windows.Forms.Padding(0);
            this.gridDay.MultiSelect = false;
            this.gridDay.Name = "gridDay";
            this.gridDay.ReadOnly = true;
            this.gridDay.RowHeadersVisible = false;
            this.gridDay.RowTemplate.Height = 32;
            this.gridDay.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDay.Size = new System.Drawing.Size(583, 564);
            this.gridDay.TabIndex = 1;
            this.gridDay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // colDayName
            // 
            this.colDayName.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colDayName.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.colDayName.FillWeight = 58F;
            this.colDayName.HeaderText = "气缸名称";
            this.colDayName.Name = "colDayName";
            this.colDayName.ReadOnly = true;
            // 
            // colDayActions
            // 
            this.colDayActions.FillWeight = 16F;
            this.colDayActions.HeaderText = "动作次数";
            this.colDayActions.Name = "colDayActions";
            this.colDayActions.ReadOnly = true;
            // 
            // colDayFaults
            // 
            this.colDayFaults.FillWeight = 16F;
            this.colDayFaults.HeaderText = "故障次数";
            this.colDayFaults.Name = "colDayFaults";
            this.colDayFaults.ReadOnly = true;
            // 
            // colDayClear
            // 
            this.colDayClear.FillWeight = 10F;
            this.colDayClear.HeaderText = string.Empty;
            this.colDayClear.Name = "colDayClear";
            this.colDayClear.ReadOnly = true;
            this.colDayClear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colDayClear.Text = "清零";
            this.colDayClear.UseColumnTextForButtonValue = true;
            // 
            // nightCard
            // 
            this.nightCard.ColumnCount = 1;
            this.nightCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.nightCard.Controls.Add(this.nightTitle, 0, 0);
            this.nightCard.Controls.Add(this.gridNight, 0, 1);
            this.nightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightCard.Location = new System.Drawing.Point(589, 0);
            this.nightCard.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.nightCard.Name = "nightCard";
            this.nightCard.RowCount = 2;
            this.nightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.nightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.nightCard.Size = new System.Drawing.Size(583, 598);
            this.nightCard.TabIndex = 1;
            // 
            // nightTitle
            // 
            this.nightTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nightTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.nightTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.nightTitle.Location = new System.Drawing.Point(0, 0);
            this.nightTitle.Margin = new System.Windows.Forms.Padding(0);
            this.nightTitle.Name = "nightTitle";
            this.nightTitle.Size = new System.Drawing.Size(583, 34);
            this.nightTitle.TabIndex = 0;
            this.nightTitle.Text = "晚班";
            this.nightTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridNight
            // 
            this.gridNight.AllowUserToAddRows = false;
            this.gridNight.AllowUserToDeleteRows = false;
            this.gridNight.AllowUserToResizeRows = false;
            this.gridNight.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNight.BackgroundColor = System.Drawing.Color.White;
            this.gridNight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNight.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            nightHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            nightHeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            nightHeaderStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            nightHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            nightHeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            nightHeaderStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.gridNight.ColumnHeadersDefaultCellStyle = nightHeaderStyle;
            this.gridNight.ColumnHeadersHeight = 32;
            this.gridNight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridNight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNightName,
            this.colNightActions,
            this.colNightFaults,
            this.colNightClear});
            nightCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            nightCellStyle.BackColor = System.Drawing.SystemColors.Window;
            nightCellStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            nightCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            nightCellStyle.SelectionBackColor = System.Drawing.Color.White;
            nightCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            nightCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridNight.DefaultCellStyle = nightCellStyle;
            this.gridNight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNight.EnableHeadersVisualStyles = false;
            this.gridNight.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.gridNight.Location = new System.Drawing.Point(0, 34);
            this.gridNight.Margin = new System.Windows.Forms.Padding(0);
            this.gridNight.MultiSelect = false;
            this.gridNight.Name = "gridNight";
            this.gridNight.ReadOnly = true;
            this.gridNight.RowHeadersVisible = false;
            this.gridNight.RowTemplate.Height = 32;
            this.gridNight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNight.Size = new System.Drawing.Size(583, 564);
            this.gridNight.TabIndex = 1;
            this.gridNight.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellContentClick);
            // 
            // colNightName
            // 
            this.colNightName.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colNightName.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.colNightName.FillWeight = 58F;
            this.colNightName.HeaderText = "气缸名称";
            this.colNightName.Name = "colNightName";
            this.colNightName.ReadOnly = true;
            // 
            // colNightActions
            // 
            this.colNightActions.FillWeight = 16F;
            this.colNightActions.HeaderText = "动作次数";
            this.colNightActions.Name = "colNightActions";
            this.colNightActions.ReadOnly = true;
            // 
            // colNightFaults
            // 
            this.colNightFaults.FillWeight = 16F;
            this.colNightFaults.HeaderText = "故障次数";
            this.colNightFaults.Name = "colNightFaults";
            this.colNightFaults.ReadOnly = true;
            // 
            // colNightClear
            // 
            this.colNightClear.FillWeight = 10F;
            this.colNightClear.HeaderText = string.Empty;
            this.colNightClear.Name = "colNightClear";
            this.colNightClear.ReadOnly = true;
            this.colNightClear.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colNightClear.Text = "清零";
            this.colNightClear.UseColumnTextForButtonValue = true;
            // 
            // pagerPanel
            // 
            this.pagerPanel.ColumnCount = 5;
            this.pagerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pagerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.pagerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pagerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.pagerPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pagerPanel.Controls.Add(this.btnPrev, 1, 0);
            this.pagerPanel.Controls.Add(this.btnNext, 3, 0);
            this.pagerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pagerPanel.Location = new System.Drawing.Point(4, 602);
            this.pagerPanel.Margin = new System.Windows.Forms.Padding(0);
            this.pagerPanel.Name = "pagerPanel";
            this.pagerPanel.RowCount = 1;
            this.pagerPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pagerPanel.Size = new System.Drawing.Size(1172, 54);
            this.pagerPanel.TabIndex = 1;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrev.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))));
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnPrev.Location = new System.Drawing.Point(446, 9);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(130, 36);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "上一页";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(214)))), ((int)(((byte)(220)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnNext.Location = new System.Drawing.Point(596, 9);
            this.btnNext.Margin = new System.Windows.Forms.Padding(0, 9, 0, 9);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(130, 36);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "下一页";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // refresh
            // 
            this.refresh.Interval = 2000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageCylinderStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageCylinderStatistics";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.dayCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDay)).EndInit();
            this.nightCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridNight)).EndInit();
            this.pagerPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel contentPanel;
        private System.Windows.Forms.TableLayoutPanel dayCard;
        private System.Windows.Forms.Label dayTitle;
        private System.Windows.Forms.DataGridView gridDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDayFaults;
        private System.Windows.Forms.DataGridViewButtonColumn colDayClear;
        private System.Windows.Forms.TableLayoutPanel nightCard;
        private System.Windows.Forms.Label nightTitle;
        private System.Windows.Forms.DataGridView gridNight;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightActions;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNightFaults;
        private System.Windows.Forms.DataGridViewButtonColumn colNightClear;
        private System.Windows.Forms.TableLayoutPanel pagerPanel;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer refresh;
    }
}
