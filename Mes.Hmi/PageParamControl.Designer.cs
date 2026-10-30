namespace Mes.Hmi
{
    partial class PageParamControl
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabProcess = new System.Windows.Forms.TabPage();
            this.tabVision = new System.Windows.Forms.TabPage();
            this.tabRobot = new System.Windows.Forms.TabPage();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colParam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commGroup = new System.Windows.Forms.GroupBox();
            this.commNote = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.tabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.commGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerStyle
            // 
            headerStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            headerStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            headerStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            headerStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            headerStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            // 
            // cellStyle
            // 
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            cellStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            cellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            cellStyle.SelectionBackColor = System.Drawing.Color.White;
            cellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.tabs, 0, 0);
            this.root.Controls.Add(this.grid, 0, 1);
            this.root.Controls.Add(this.commGroup, 0, 2);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 3;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabProcess);
            this.tabs.Controls.Add(this.tabVision);
            this.tabs.Controls.Add(this.tabRobot);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tabs.ItemSize = new System.Drawing.Size(170, 30);
            this.tabs.Location = new System.Drawing.Point(11, 55);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1158, 36);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabProcess
            // 
            this.tabProcess.Location = new System.Drawing.Point(4, 34);
            this.tabProcess.Name = "tabProcess";
            this.tabProcess.Size = new System.Drawing.Size(1150, 0);
            this.tabProcess.TabIndex = 0;
            this.tabProcess.Text = "工艺设备ERS";
            // 
            // tabVision
            // 
            this.tabVision.Location = new System.Drawing.Point(4, 34);
            this.tabVision.Name = "tabVision";
            this.tabVision.Size = new System.Drawing.Size(1150, 0);
            this.tabVision.TabIndex = 1;
            this.tabVision.Text = "视觉ERS";
            // 
            // tabRobot
            // 
            this.tabRobot.Location = new System.Drawing.Point(4, 34);
            this.tabRobot.Name = "tabRobot";
            this.tabRobot.Size = new System.Drawing.Size(1150, 0);
            this.tabRobot.TabIndex = 2;
            this.tabRobot.Text = "机械手ERS";
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
            this.grid.ColumnHeadersHeight = 34;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIndex,
            this.colStation,
            this.colParam,
            this.colLower,
            this.colUpper,
            this.colValue,
            this.colResult});
            this.grid.DefaultCellStyle = cellStyle;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(239)))), ((int)(((byte)(243)))));
            this.grid.Location = new System.Drawing.Point(11, 97);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 28;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1158, 336);
            this.grid.TabIndex = 2;
            // 
            // colIndex
            // 
            this.colIndex.FillWeight = 6F;
            this.colIndex.HeaderText = "序号";
            this.colIndex.Name = "colIndex";
            this.colIndex.ReadOnly = true;
            // 
            // colStation
            // 
            this.colStation.FillWeight = 12F;
            this.colStation.HeaderText = "工站";
            this.colStation.Name = "colStation";
            this.colStation.ReadOnly = true;
            // 
            // colParam
            // 
            this.colParam.FillWeight = 36F;
            this.colParam.HeaderText = "参数项";
            this.colParam.Name = "colParam";
            this.colParam.ReadOnly = true;
            // 
            // colLower
            // 
            this.colLower.FillWeight = 11F;
            this.colLower.HeaderText = "系统管控下限";
            this.colLower.Name = "colLower";
            this.colLower.ReadOnly = true;
            // 
            // colUpper
            // 
            this.colUpper.FillWeight = 11F;
            this.colUpper.HeaderText = "系统管控上限";
            this.colUpper.Name = "colUpper";
            this.colUpper.ReadOnly = true;
            // 
            // colValue
            // 
            this.colValue.FillWeight = 12F;
            this.colValue.HeaderText = "当前值";
            this.colValue.Name = "colValue";
            this.colValue.ReadOnly = true;
            // 
            // colResult
            // 
            this.colResult.FillWeight = 12F;
            this.colResult.HeaderText = "比对结果";
            this.colResult.Name = "colResult";
            this.colResult.ReadOnly = true;
            // 
            // commGroup
            // 
            this.commGroup.Controls.Add(this.commNote);
            this.commGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commGroup.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.commGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.commGroup.Location = new System.Drawing.Point(11, 439);
            this.commGroup.Name = "commGroup";
            this.commGroup.Padding = new System.Windows.Forms.Padding(10, 4, 10, 8);
            this.commGroup.Size = new System.Drawing.Size(1158, 116);
            this.commGroup.TabIndex = 3;
            this.commGroup.TabStop = false;
            this.commGroup.Text = "通讯记录";
            // 
            // commNote
            // 
            this.commNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.commNote.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.commNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(126)))), ((int)(((byte)(134)))));
            this.commNote.Location = new System.Drawing.Point(10, 21);
            this.commNote.Name = "commNote";
            this.commNote.Size = new System.Drawing.Size(1138, 87);
            this.commNote.TabIndex = 0;
            this.commNote.Text = "本机未接 MES 接口，暂无与服务器的通讯记录。\r\n接入后在此显示报站 / 过站的请求与应答（checkIn / checkOut）。";
            // 
            // refresh
            // 
            this.refresh.Interval = 1000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageParamControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageParamControl";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.commGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabProcess;
        private System.Windows.Forms.TabPage tabVision;
        private System.Windows.Forms.TabPage tabRobot;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStation;
        private System.Windows.Forms.DataGridViewTextBoxColumn colParam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLower;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpper;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResult;
        private System.Windows.Forms.GroupBox commGroup;
        private System.Windows.Forms.Label commNote;
        private System.Windows.Forms.Timer refresh;
    }
}
