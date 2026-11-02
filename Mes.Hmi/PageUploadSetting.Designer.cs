namespace Mes.Hmi
{
    partial class PageUploadSetting
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
            System.Windows.Forms.DataGridViewCellStyle keyHeaderStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle keyCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle valueCellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.pageTitle = new System.Windows.Forms.Label();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabTrace = new System.Windows.Forms.TabPage();
            this.tabPdca = new System.Windows.Forms.TabPage();
            this.tabOee = new System.Windows.Forms.TabPage();
            this.projectBar = new System.Windows.Forms.TableLayoutPanel();
            this.projectLabel = new System.Windows.Forms.Label();
            this.comboProject = new System.Windows.Forms.ComboBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.barSpacer = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.DataGridView();
            this.colKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonBar = new System.Windows.Forms.TableLayoutPanel();
            this.btnModify = new System.Windows.Forms.Button();
            this.root.SuspendLayout();
            this.projectBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.buttonBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.pageTitle, 0, 0);
            this.root.Controls.Add(this.tabs, 0, 1);
            this.root.Controls.Add(this.projectBar, 0, 2);
            this.root.Controls.Add(this.grid, 0, 3);
            this.root.Controls.Add(this.buttonBar, 0, 4);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(8, 6, 8, 8);
            this.root.RowCount = 5;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // pageTitle
            // 
            this.pageTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.pageTitle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            this.pageTitle.Location = new System.Drawing.Point(8, 6);
            this.pageTitle.Margin = new System.Windows.Forms.Padding(0);
            this.pageTitle.Name = "pageTitle";
            this.pageTitle.Size = new System.Drawing.Size(1164, 32);
            this.pageTitle.TabIndex = 0;
            this.pageTitle.Text = "上传设置(数据\\上传设置.csv)";
            this.pageTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabTrace);
            this.tabs.Controls.Add(this.tabPdca);
            this.tabs.Controls.Add(this.tabOee);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.tabs.ItemSize = new System.Drawing.Size(140, 30);
            this.tabs.Location = new System.Drawing.Point(8, 38);
            this.tabs.Margin = new System.Windows.Forms.Padding(0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1164, 42);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabTrace
            // 
            this.tabTrace.Name = "tabTrace";
            this.tabTrace.Text = "Trace";
            // 
            // tabPdca
            // 
            this.tabPdca.Name = "tabPdca";
            this.tabPdca.Text = "PDCA";
            // 
            // tabOee
            // 
            this.tabOee.Name = "tabOee";
            this.tabOee.Text = "OEE";
            // 
            // projectBar
            // 
            this.projectBar.ColumnCount = 4;
            this.projectBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.projectBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.projectBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.projectBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.projectBar.Controls.Add(this.projectLabel, 0, 0);
            this.projectBar.Controls.Add(this.comboProject, 1, 0);
            this.projectBar.Controls.Add(this.btnLoad, 2, 0);
            this.projectBar.Controls.Add(this.barSpacer, 3, 0);
            this.projectBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectBar.Location = new System.Drawing.Point(8, 80);
            this.projectBar.Margin = new System.Windows.Forms.Padding(0);
            this.projectBar.Name = "projectBar";
            this.projectBar.RowCount = 1;
            this.projectBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.projectBar.Size = new System.Drawing.Size(1164, 44);
            this.projectBar.TabIndex = 2;
            // 
            // projectLabel
            // 
            this.projectLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.projectLabel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.projectLabel.ForeColor = System.Drawing.Color.FromArgb(60, 66, 72);
            this.projectLabel.Location = new System.Drawing.Point(0, 0);
            this.projectLabel.Margin = new System.Windows.Forms.Padding(0);
            this.projectLabel.Name = "projectLabel";
            this.projectLabel.Size = new System.Drawing.Size(162, 44);
            this.projectLabel.TabIndex = 0;
            this.projectLabel.Text = "专案";
            this.projectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboProject
            // 
            this.comboProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboProject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboProject.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.comboProject.FormattingEnabled = true;
            this.comboProject.Location = new System.Drawing.Point(166, 8);
            this.comboProject.Margin = new System.Windows.Forms.Padding(4, 8, 20, 8);
            this.comboProject.Name = "comboProject";
            this.comboProject.Size = new System.Drawing.Size(283, 28);
            this.comboProject.TabIndex = 1;
            this.comboProject.SelectedIndexChanged += new System.EventHandler(this.comboProject_SelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.FromArgb(120, 200, 90);
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLoad.FlatAppearance.BorderSize = 0;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Margin = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(162, 32);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "设置";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // barSpacer
            // 
            this.barSpacer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.barSpacer.Location = new System.Drawing.Point(612, 0);
            this.barSpacer.Margin = new System.Windows.Forms.Padding(0);
            this.barSpacer.Name = "barSpacer";
            this.barSpacer.Size = new System.Drawing.Size(552, 44);
            this.barSpacer.TabIndex = 3;
            // 
            // grid
            // 
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            keyHeaderStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            keyHeaderStyle.BackColor = System.Drawing.Color.FromArgb(240, 242, 245);
            keyHeaderStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F, System.Drawing.FontStyle.Bold);
            keyHeaderStyle.ForeColor = System.Drawing.Color.FromArgb(60, 66, 72);
            keyHeaderStyle.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.grid.ColumnHeadersDefaultCellStyle = keyHeaderStyle;
            this.grid.ColumnHeadersHeight = 34;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colKey,
            this.colValue});
            keyCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            keyCellStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            keyCellStyle.ForeColor = System.Drawing.Color.FromArgb(40, 80, 150);
            keyCellStyle.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.grid.DefaultCellStyle = keyCellStyle;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.GridColor = System.Drawing.Color.FromArgb(226, 230, 236);
            this.grid.Location = new System.Drawing.Point(8, 124);
            this.grid.Margin = new System.Windows.Forms.Padding(0);
            this.grid.MultiSelect = false;
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersVisible = false;
            this.grid.RowTemplate.Height = 34;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(1164, 372);
            this.grid.TabIndex = 3;
            // 
            // colKey
            // 
            this.colKey.FillWeight = 30F;
            this.colKey.HeaderText = "";
            this.colKey.Name = "colKey";
            this.colKey.ReadOnly = true;
            this.colKey.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // colValue
            // 
            this.colValue.HeaderText = "";
            this.colValue.Name = "colValue";
            valueCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            valueCellStyle.BackColor = System.Drawing.Color.FromArgb(246, 248, 250);
            valueCellStyle.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            valueCellStyle.ForeColor = System.Drawing.Color.FromArgb(45, 50, 55);
            valueCellStyle.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.colValue.DefaultCellStyle = valueCellStyle;
            this.colValue.FillWeight = 70F;
            this.colValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // buttonBar
            // 
            this.buttonBar.ColumnCount = 3;
            this.buttonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.buttonBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.buttonBar.Controls.Add(this.btnModify, 1, 0);
            this.buttonBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonBar.Location = new System.Drawing.Point(8, 496);
            this.buttonBar.Margin = new System.Windows.Forms.Padding(0);
            this.buttonBar.Name = "buttonBar";
            this.buttonBar.RowCount = 1;
            this.buttonBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttonBar.Size = new System.Drawing.Size(1164, 60);
            this.buttonBar.TabIndex = 4;
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(250, 220, 60);
            this.btnModify.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModify.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(200, 175, 30);
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold);
            this.btnModify.ForeColor = System.Drawing.Color.FromArgb(60, 50, 0);
            this.btnModify.Margin = new System.Windows.Forms.Padding(0, 8, 0, 8);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(465, 44);
            this.btnModify.TabIndex = 0;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // PageUploadSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageUploadSetting";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.projectBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.buttonBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.Label pageTitle;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabTrace;
        private System.Windows.Forms.TabPage tabPdca;
        private System.Windows.Forms.TabPage tabOee;
        private System.Windows.Forms.TableLayoutPanel projectBar;
        private System.Windows.Forms.Label projectLabel;
        private System.Windows.Forms.ComboBox comboProject;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel barSpacer;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn colValue;
        private System.Windows.Forms.TableLayoutPanel buttonBar;
        private System.Windows.Forms.Button btnModify;
    }
}
