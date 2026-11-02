namespace Mes.Hmi
{
    partial class PageFaultAnalysis
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
            this.leftCard = new System.Windows.Forms.TableLayoutPanel();
            this.queryCard = new System.Windows.Forms.TableLayoutPanel();
            this.timeBlock = new System.Windows.Forms.TableLayoutPanel();
            this.fromLabel = new System.Windows.Forms.Label();
            this.fromPicker = new System.Windows.Forms.DateTimePicker();
            this.toLabel = new System.Windows.Forms.Label();
            this.toPicker = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.typeBlock = new System.Windows.Forms.TableLayoutPanel();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.chkType0 = new System.Windows.Forms.CheckBox();
            this.chkType1 = new System.Windows.Forms.CheckBox();
            this.chkType2 = new System.Windows.Forms.CheckBox();
            this.chkType3 = new System.Windows.Forms.CheckBox();
            this.sortBar = new System.Windows.Forms.TableLayoutPanel();
            this.radioMinutes = new System.Windows.Forms.RadioButton();
            this.radioCount = new System.Windows.Forms.RadioButton();
            this.gridFault = new System.Windows.Forms.DataGridView();
            this.colCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMinutes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colText = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rightCard = new System.Windows.Forms.TableLayoutPanel();
            this.mapCaption = new System.Windows.Forms.Label();
            this.map = new System.Windows.Forms.Panel();
            this.detailCard = new System.Windows.Forms.TableLayoutPanel();
            this.zoneCaption = new System.Windows.Forms.Label();
            this.zoneValue = new System.Windows.Forms.Label();
            this.descCaption = new System.Windows.Forms.Label();
            this.descValue = new System.Windows.Forms.Label();
            this.solutionCaption = new System.Windows.Forms.Label();
            this.solutionValue = new System.Windows.Forms.TextBox();
            this.blinkTimer = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.leftCard.SuspendLayout();
            this.queryCard.SuspendLayout();
            this.timeBlock.SuspendLayout();
            this.typeBlock.SuspendLayout();
            this.sortBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFault)).BeginInit();
            this.rightCard.SuspendLayout();
            this.detailCard.SuspendLayout();
            this.SuspendLayout();
            //
            // root
            //
            this.root.ColumnCount = 2;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 430F));
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.leftCard, 0, 0);
            this.root.Controls.Add(this.rightCard, 1, 0);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 1;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            //
            // leftCard
            //
            this.leftCard.BackColor = System.Drawing.Color.White;
            this.leftCard.ColumnCount = 1;
            this.leftCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftCard.Controls.Add(this.queryCard, 0, 0);
            this.leftCard.Controls.Add(this.sortBar, 0, 1);
            this.leftCard.Controls.Add(this.gridFault, 0, 2);
            this.leftCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.leftCard.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.leftCard.Name = "leftCard";
            this.leftCard.RowCount = 3;
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.leftCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.leftCard.TabIndex = 0;
            //
            // queryCard
            //
            this.queryCard.ColumnCount = 2;
            this.queryCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.queryCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queryCard.Controls.Add(this.timeBlock, 0, 0);
            this.queryCard.Controls.Add(this.typeBlock, 1, 0);
            this.queryCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryCard.Name = "queryCard";
            this.queryCard.RowCount = 1;
            this.queryCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.queryCard.TabIndex = 0;
            //
            // timeBlock
            //
            this.timeBlock.ColumnCount = 2;
            this.timeBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.timeBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeBlock.Controls.Add(this.fromLabel, 0, 0);
            this.timeBlock.Controls.Add(this.fromPicker, 1, 0);
            this.timeBlock.Controls.Add(this.toLabel, 0, 1);
            this.timeBlock.Controls.Add(this.toPicker, 1, 1);
            this.timeBlock.Controls.Add(this.btnQuery, 1, 2);
            this.timeBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeBlock.Name = "timeBlock";
            this.timeBlock.RowCount = 3;
            this.timeBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.timeBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.timeBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.timeBlock.TabIndex = 0;
            //
            // fromLabel
            //
            this.fromLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.TabIndex = 0;
            this.fromLabel.Text = "开始时间";
            this.fromLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // fromPicker
            //
            this.fromPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.fromPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fromPicker.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.fromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fromPicker.Margin = new System.Windows.Forms.Padding(4, 6, 8, 6);
            this.fromPicker.Name = "fromPicker";
            this.fromPicker.TabIndex = 1;
            //
            // toLabel
            //
            this.toLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toLabel.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.toLabel.Name = "toLabel";
            this.toLabel.TabIndex = 2;
            this.toLabel.Text = "结束时间";
            this.toLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // toPicker
            //
            this.toPicker.CustomFormat = "yyyy/MM/dd HH:mm:ss";
            this.toPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toPicker.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.toPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.toPicker.Margin = new System.Windows.Forms.Padding(4, 6, 8, 6);
            this.toPicker.Name = "toPicker";
            this.toPicker.TabIndex = 3;
            //
            // btnQuery
            //
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnQuery.Location = new System.Drawing.Point(82, 82);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 6, 8, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(120, 34);
            this.btnQuery.TabIndex = 4;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            //
            // typeBlock
            //
            this.typeBlock.ColumnCount = 1;
            this.typeBlock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.typeBlock.Controls.Add(this.chkAll, 0, 0);
            this.typeBlock.Controls.Add(this.chkType0, 0, 1);
            this.typeBlock.Controls.Add(this.chkType1, 0, 2);
            this.typeBlock.Controls.Add(this.chkType2, 0, 3);
            this.typeBlock.Controls.Add(this.chkType3, 0, 4);
            this.typeBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typeBlock.Name = "typeBlock";
            this.typeBlock.RowCount = 5;
            this.typeBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.typeBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.typeBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.typeBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.typeBlock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.typeBlock.TabIndex = 1;
            //
            // chkAll
            //
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkAll.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkAll.Name = "chkAll";
            this.chkAll.TabIndex = 0;
            this.chkAll.Text = "<全部>";
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            //
            // chkType0
            //
            this.chkType0.Checked = true;
            this.chkType0.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkType0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkType0.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkType0.Name = "chkType0";
            this.chkType0.TabIndex = 1;
            this.chkType0.Text = "机构(600)";
            //
            // chkType1
            //
            this.chkType1.Checked = true;
            this.chkType1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkType1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkType1.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkType1.Name = "chkType1";
            this.chkType1.TabIndex = 2;
            this.chkType1.Text = "气动(601)";
            //
            // chkType2
            //
            this.chkType2.Checked = true;
            this.chkType2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkType2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkType2.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkType2.Name = "chkType2";
            this.chkType2.TabIndex = 3;
            this.chkType2.Text = "电控(602)";
            //
            // chkType3
            //
            this.chkType3.Checked = true;
            this.chkType3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkType3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkType3.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.chkType3.Name = "chkType3";
            this.chkType3.TabIndex = 4;
            this.chkType3.Text = "视觉(603)";
            //
            // sortBar
            //
            this.sortBar.ColumnCount = 2;
            this.sortBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.sortBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sortBar.Controls.Add(this.radioMinutes, 0, 0);
            this.sortBar.Controls.Add(this.radioCount, 1, 0);
            this.sortBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortBar.Name = "sortBar";
            this.sortBar.Padding = new System.Windows.Forms.Padding(6, 3, 0, 0);
            this.sortBar.RowCount = 1;
            this.sortBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.sortBar.TabIndex = 1;
            //
            // radioMinutes
            //
            this.radioMinutes.Checked = true;
            this.radioMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioMinutes.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.radioMinutes.Name = "radioMinutes";
            this.radioMinutes.TabIndex = 0;
            this.radioMinutes.TabStop = true;
            this.radioMinutes.Text = "按时间排序";
            this.radioMinutes.CheckedChanged += new System.EventHandler(this.sort_CheckedChanged);
            //
            // radioCount
            //
            this.radioCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioCount.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.radioCount.Name = "radioCount";
            this.radioCount.TabIndex = 1;
            this.radioCount.Text = "按次数排序";
            this.radioCount.CheckedChanged += new System.EventHandler(this.sort_CheckedChanged);
            //
            // gridFault
            //
            this.gridFault.AllowUserToAddRows = false;
            this.gridFault.AllowUserToDeleteRows = false;
            this.gridFault.AllowUserToResizeRows = false;
            this.gridFault.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFault.BackgroundColor = System.Drawing.Color.White;
            this.gridFault.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridFault.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridFault.ColumnHeadersDefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridFault.ColumnHeadersDefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.gridFault.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            this.gridFault.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.gridFault.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(60, 66, 72);
            this.gridFault.ColumnHeadersHeight = 28;
            this.gridFault.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridFault.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCode,
            this.colMinutes,
            this.colCount,
            this.colText});
            this.gridFault.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.gridFault.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gridFault.DefaultCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.gridFault.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.gridFault.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFault.EnableHeadersVisualStyles = false;
            this.gridFault.GridColor = System.Drawing.Color.FromArgb(236, 239, 243);
            this.gridFault.MultiSelect = false;
            this.gridFault.Name = "gridFault";
            this.gridFault.ReadOnly = true;
            this.gridFault.RowHeadersVisible = false;
            this.gridFault.RowTemplate.Height = 26;
            this.gridFault.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridFault.TabIndex = 2;
            this.gridFault.SelectionChanged += new System.EventHandler(this.gridFault_SelectionChanged);
            //
            // colCode
            //
            this.colCode.HeaderText = "故障代码";
            this.colCode.Name = "colCode";
            this.colCode.FillWeight = 28F;
            this.colCode.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colMinutes
            //
            this.colMinutes.HeaderText = "总时间(分钟)";
            this.colMinutes.Name = "colMinutes";
            this.colMinutes.FillWeight = 24F;
            this.colMinutes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colCount
            //
            this.colCount.HeaderText = "次数";
            this.colCount.Name = "colCount";
            this.colCount.FillWeight = 12F;
            this.colCount.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // colText
            //
            this.colText.HeaderText = "故障描述";
            this.colText.Name = "colText";
            this.colText.FillWeight = 36F;
            this.colText.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            //
            // rightCard
            //
            this.rightCard.BackColor = System.Drawing.Color.White;
            this.rightCard.ColumnCount = 1;
            this.rightCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightCard.Controls.Add(this.mapCaption, 0, 0);
            this.rightCard.Controls.Add(this.map, 0, 1);
            this.rightCard.Controls.Add(this.detailCard, 0, 2);
            this.rightCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightCard.Name = "rightCard";
            this.rightCard.RowCount = 3;
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.rightCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.rightCard.TabIndex = 1;
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
            // detailCard
            //
            this.detailCard.ColumnCount = 2;
            this.detailCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.detailCard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.detailCard.Controls.Add(this.zoneCaption, 0, 0);
            this.detailCard.Controls.Add(this.zoneValue, 1, 0);
            this.detailCard.Controls.Add(this.descCaption, 0, 1);
            this.detailCard.Controls.Add(this.descValue, 1, 1);
            this.detailCard.Controls.Add(this.solutionCaption, 0, 2);
            this.detailCard.Controls.Add(this.solutionValue, 1, 2);
            this.detailCard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailCard.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.detailCard.Name = "detailCard";
            this.detailCard.RowCount = 3;
            this.detailCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.detailCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.detailCard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.detailCard.TabIndex = 2;
            //
            // zoneCaption
            //
            this.zoneCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoneCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.zoneCaption.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.zoneCaption.Name = "zoneCaption";
            this.zoneCaption.TabIndex = 0;
            this.zoneCaption.Text = "部位";
            this.zoneCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // zoneValue
            //
            this.zoneValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zoneValue.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.zoneValue.ForeColor = System.Drawing.Color.FromArgb(190, 40, 40);
            this.zoneValue.Name = "zoneValue";
            this.zoneValue.TabIndex = 1;
            this.zoneValue.Text = "—";
            this.zoneValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // descCaption
            //
            this.descCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.descCaption.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.descCaption.Name = "descCaption";
            this.descCaption.TabIndex = 2;
            this.descCaption.Text = "报警描述";
            this.descCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // descValue
            //
            this.descValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descValue.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.descValue.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.descValue.Name = "descValue";
            this.descValue.TabIndex = 3;
            this.descValue.Text = "—";
            this.descValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // solutionCaption
            //
            this.solutionCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            this.solutionCaption.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.solutionCaption.Name = "solutionCaption";
            this.solutionCaption.TabIndex = 4;
            this.solutionCaption.Text = "处理对策";
            this.solutionCaption.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            //
            // solutionValue
            //
            this.solutionValue.BackColor = System.Drawing.Color.FromArgb(250, 251, 252);
            this.solutionValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.solutionValue.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.solutionValue.Margin = new System.Windows.Forms.Padding(4, 3, 3, 3);
            this.solutionValue.Multiline = true;
            this.solutionValue.Name = "solutionValue";
            this.solutionValue.ReadOnly = true;
            this.solutionValue.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.solutionValue.TabIndex = 5;
            //
            // blinkTimer
            //
            this.blinkTimer.Interval = 500;
            this.blinkTimer.Tick += new System.EventHandler(this.blinkTimer_Tick);
            //
            // PageFaultAnalysis
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            this.Controls.Add(this.root);
            this.Name = "PageFaultAnalysis";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.leftCard.ResumeLayout(false);
            this.queryCard.ResumeLayout(false);
            this.timeBlock.ResumeLayout(false);
            this.typeBlock.ResumeLayout(false);
            this.sortBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFault)).EndInit();
            this.rightCard.ResumeLayout(false);
            this.detailCard.ResumeLayout(false);
            this.detailCard.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel leftCard;
        private System.Windows.Forms.TableLayoutPanel queryCard;
        private System.Windows.Forms.TableLayoutPanel timeBlock;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.DateTimePicker fromPicker;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.DateTimePicker toPicker;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TableLayoutPanel typeBlock;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.CheckBox chkType0;
        private System.Windows.Forms.CheckBox chkType1;
        private System.Windows.Forms.CheckBox chkType2;
        private System.Windows.Forms.CheckBox chkType3;
        private System.Windows.Forms.TableLayoutPanel sortBar;
        private System.Windows.Forms.RadioButton radioMinutes;
        private System.Windows.Forms.RadioButton radioCount;
        private System.Windows.Forms.DataGridView gridFault;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMinutes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colText;
        private System.Windows.Forms.TableLayoutPanel rightCard;
        private System.Windows.Forms.Label mapCaption;
        private System.Windows.Forms.Panel map;
        private System.Windows.Forms.TableLayoutPanel detailCard;
        private System.Windows.Forms.Label zoneCaption;
        private System.Windows.Forms.Label zoneValue;
        private System.Windows.Forms.Label descCaption;
        private System.Windows.Forms.Label descValue;
        private System.Windows.Forms.Label solutionCaption;
        private System.Windows.Forms.TextBox solutionValue;
        private System.Windows.Forms.Timer blinkTimer;
    }
}
