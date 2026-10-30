namespace Mes.Hmi
{
    partial class PartChangeDialog
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        private void InitializeComponent()
        {
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.detail = new System.Windows.Forms.TableLayoutPanel();
            this.nameCaption = new System.Windows.Forms.Label();
            this.nameValue = new System.Windows.Forms.Label();
            this.modelCaption = new System.Windows.Forms.Label();
            this.modelValue = new System.Windows.Forms.Label();
            this.ratedCaption = new System.Windows.Forms.Label();
            this.ratedValue = new System.Windows.Forms.Label();
            this.oldCodeCaption = new System.Windows.Forms.Label();
            this.oldCodeValue = new System.Windows.Forms.Label();
            this.replacedCaption = new System.Windows.Forms.Label();
            this.replacedValue = new System.Windows.Forms.Label();
            this.currentCaption = new System.Windows.Forms.Label();
            this.currentValue = new System.Windows.Forms.Label();
            this.remainCaption = new System.Windows.Forms.Label();
            this.remainValue = new System.Windows.Forms.Label();
            this.newCodeCaption = new System.Windows.Forms.Label();
            this.newCodeBox = new System.Windows.Forms.TextBox();
            this.reasonCaption = new System.Windows.Forms.Label();
            this.reasonBox = new System.Windows.Forms.ComboBox();
            this.buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.root.SuspendLayout();
            this.detail.SuspendLayout();
            this.buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.detail, 0, 0);
            this.root.Controls.Add(this.buttons, 0, 1);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(14);
            this.root.RowCount = 2;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.root.Size = new System.Drawing.Size(560, 520);
            this.root.TabIndex = 0;
            // 
            // detail
            // 
            this.detail.ColumnCount = 2;
            this.detail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.detail.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.detail.Controls.Add(this.nameCaption, 0, 0);
            this.detail.Controls.Add(this.nameValue, 1, 0);
            this.detail.Controls.Add(this.modelCaption, 0, 1);
            this.detail.Controls.Add(this.modelValue, 1, 1);
            this.detail.Controls.Add(this.ratedCaption, 0, 2);
            this.detail.Controls.Add(this.ratedValue, 1, 2);
            this.detail.Controls.Add(this.oldCodeCaption, 0, 3);
            this.detail.Controls.Add(this.oldCodeValue, 1, 3);
            this.detail.Controls.Add(this.replacedCaption, 0, 4);
            this.detail.Controls.Add(this.replacedValue, 1, 4);
            this.detail.Controls.Add(this.currentCaption, 0, 5);
            this.detail.Controls.Add(this.currentValue, 1, 5);
            this.detail.Controls.Add(this.remainCaption, 0, 6);
            this.detail.Controls.Add(this.remainValue, 1, 6);
            this.detail.Controls.Add(this.newCodeCaption, 0, 7);
            this.detail.Controls.Add(this.newCodeBox, 1, 7);
            this.detail.Controls.Add(this.reasonCaption, 0, 8);
            this.detail.Controls.Add(this.reasonBox, 1, 8);
            this.detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detail.Location = new System.Drawing.Point(17, 17);
            this.detail.Name = "detail";
            this.detail.RowCount = 9;
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.detail.Size = new System.Drawing.Size(526, 428);
            this.detail.TabIndex = 0;
            // 
            // nameCaption
            // 
            this.nameCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameCaption.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.nameCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.nameCaption.Location = new System.Drawing.Point(3, 0);
            this.nameCaption.Name = "nameCaption";
            this.nameCaption.Size = new System.Drawing.Size(104, 47);
            this.nameCaption.TabIndex = 0;
            this.nameCaption.Text = "品名";
            this.nameCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nameValue
            // 
            this.nameValue.BackColor = System.Drawing.Color.White;
            this.nameValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.nameValue.Location = new System.Drawing.Point(113, 0);
            this.nameValue.Name = "nameValue";
            this.nameValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.nameValue.Size = new System.Drawing.Size(410, 47);
            this.nameValue.TabIndex = 1;
            this.nameValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelCaption
            // 
            this.modelCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelCaption.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.modelCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.modelCaption.Location = new System.Drawing.Point(3, 47);
            this.modelCaption.Name = "modelCaption";
            this.modelCaption.Size = new System.Drawing.Size(104, 47);
            this.modelCaption.TabIndex = 2;
            this.modelCaption.Text = "型号";
            this.modelCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // modelValue
            // 
            this.modelValue.BackColor = System.Drawing.Color.White;
            this.modelValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modelValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.modelValue.Location = new System.Drawing.Point(113, 47);
            this.modelValue.Name = "modelValue";
            this.modelValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.modelValue.Size = new System.Drawing.Size(410, 47);
            this.modelValue.TabIndex = 3;
            this.modelValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ratedCaption
            // 
            this.ratedCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratedCaption.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ratedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.ratedCaption.Location = new System.Drawing.Point(3, 94);
            this.ratedCaption.Name = "ratedCaption";
            this.ratedCaption.Size = new System.Drawing.Size(104, 47);
            this.ratedCaption.TabIndex = 4;
            this.ratedCaption.Text = "标准寿命";
            this.ratedCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ratedValue
            // 
            this.ratedValue.BackColor = System.Drawing.Color.White;
            this.ratedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ratedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratedValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.ratedValue.Location = new System.Drawing.Point(113, 94);
            this.ratedValue.Name = "ratedValue";
            this.ratedValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ratedValue.Size = new System.Drawing.Size(410, 47);
            this.ratedValue.TabIndex = 5;
            this.ratedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oldCodeCaption
            // 
            this.oldCodeCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oldCodeCaption.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.oldCodeCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.oldCodeCaption.Location = new System.Drawing.Point(3, 141);
            this.oldCodeCaption.Name = "oldCodeCaption";
            this.oldCodeCaption.Size = new System.Drawing.Size(104, 47);
            this.oldCodeCaption.TabIndex = 6;
            this.oldCodeCaption.Text = "原条码";
            this.oldCodeCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // oldCodeValue
            // 
            this.oldCodeValue.BackColor = System.Drawing.Color.White;
            this.oldCodeValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.oldCodeValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.oldCodeValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.oldCodeValue.Location = new System.Drawing.Point(113, 141);
            this.oldCodeValue.Name = "oldCodeValue";
            this.oldCodeValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.oldCodeValue.Size = new System.Drawing.Size(410, 47);
            this.oldCodeValue.TabIndex = 7;
            this.oldCodeValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // replacedCaption
            // 
            this.replacedCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replacedCaption.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.replacedCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.replacedCaption.Location = new System.Drawing.Point(3, 188);
            this.replacedCaption.Name = "replacedCaption";
            this.replacedCaption.Size = new System.Drawing.Size(104, 47);
            this.replacedCaption.TabIndex = 8;
            this.replacedCaption.Text = "上次更换";
            this.replacedCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // replacedValue
            // 
            this.replacedValue.BackColor = System.Drawing.Color.White;
            this.replacedValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.replacedValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.replacedValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.replacedValue.Location = new System.Drawing.Point(113, 188);
            this.replacedValue.Name = "replacedValue";
            this.replacedValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.replacedValue.Size = new System.Drawing.Size(410, 47);
            this.replacedValue.TabIndex = 9;
            this.replacedValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentCaption
            // 
            this.currentCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentCaption.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.currentCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.currentCaption.Location = new System.Drawing.Point(3, 235);
            this.currentCaption.Name = "currentCaption";
            this.currentCaption.Size = new System.Drawing.Size(104, 47);
            this.currentCaption.TabIndex = 10;
            this.currentCaption.Text = "当前寿命";
            this.currentCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentValue
            // 
            this.currentValue.BackColor = System.Drawing.Color.White;
            this.currentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.currentValue.Location = new System.Drawing.Point(113, 235);
            this.currentValue.Name = "currentValue";
            this.currentValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.currentValue.Size = new System.Drawing.Size(410, 47);
            this.currentValue.TabIndex = 11;
            this.currentValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remainCaption
            // 
            this.remainCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remainCaption.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.remainCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.remainCaption.Location = new System.Drawing.Point(3, 282);
            this.remainCaption.Name = "remainCaption";
            this.remainCaption.Size = new System.Drawing.Size(104, 47);
            this.remainCaption.TabIndex = 12;
            this.remainCaption.Text = "剩余寿命";
            this.remainCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // remainValue
            // 
            this.remainValue.BackColor = System.Drawing.Color.White;
            this.remainValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.remainValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.remainValue.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.remainValue.Location = new System.Drawing.Point(113, 282);
            this.remainValue.Name = "remainValue";
            this.remainValue.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.remainValue.Size = new System.Drawing.Size(410, 47);
            this.remainValue.TabIndex = 13;
            this.remainValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newCodeCaption
            // 
            this.newCodeCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newCodeCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.newCodeCaption.Location = new System.Drawing.Point(3, 329);
            this.newCodeCaption.Name = "newCodeCaption";
            this.newCodeCaption.Size = new System.Drawing.Size(104, 47);
            this.newCodeCaption.TabIndex = 14;
            this.newCodeCaption.Text = "新条码";
            this.newCodeCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newCodeBox
            // 
            this.newCodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newCodeBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.newCodeBox.Location = new System.Drawing.Point(115, 335);
            this.newCodeBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.newCodeBox.Name = "newCodeBox";
            this.newCodeBox.Size = new System.Drawing.Size(406, 25);
            this.newCodeBox.TabIndex = 15;
            // 
            // reasonCaption
            // 
            this.reasonCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonCaption.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.reasonCaption.Location = new System.Drawing.Point(3, 376);
            this.reasonCaption.Name = "reasonCaption";
            this.reasonCaption.Size = new System.Drawing.Size(104, 52);
            this.reasonCaption.TabIndex = 16;
            this.reasonCaption.Text = "更换原因";
            this.reasonCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // reasonBox
            // 
            this.reasonBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reasonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.reasonBox.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.reasonBox.Items.AddRange(new object[] {
            "到期更换",
            "损坏更换",
            "寿命预警",
            "其他"});
            this.reasonBox.Location = new System.Drawing.Point(115, 382);
            this.reasonBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.reasonBox.Name = "reasonBox";
            this.reasonBox.Size = new System.Drawing.Size(406, 25);
            this.reasonBox.TabIndex = 17;
            // 
            // buttons
            // 
            this.buttons.ColumnCount = 4;
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttons.Controls.Add(this.btnOk, 1, 0);
            this.buttons.Controls.Add(this.btnCancel, 2, 0);
            this.buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttons.Location = new System.Drawing.Point(17, 451);
            this.buttons.Name = "buttons";
            this.buttons.Padding = new System.Windows.Forms.Padding(0, 12, 0, 8);
            this.buttons.RowCount = 1;
            this.buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.buttons.Size = new System.Drawing.Size(526, 52);
            this.buttons.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(137, 15);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(126, 29);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.Location = new System.Drawing.Point(271, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(126, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // PartChangeDialog
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(560, 520);
            this.Controls.Add(this.root);
            this.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PartChangeDialog";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "配件更换";
            this.root.ResumeLayout(false);
            this.detail.ResumeLayout(false);
            this.detail.PerformLayout();
            this.buttons.ResumeLayout(false);
            this.buttons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TableLayoutPanel detail;
        private System.Windows.Forms.Label nameCaption;
        private System.Windows.Forms.Label nameValue;
        private System.Windows.Forms.Label modelCaption;
        private System.Windows.Forms.Label modelValue;
        private System.Windows.Forms.Label ratedCaption;
        private System.Windows.Forms.Label ratedValue;
        private System.Windows.Forms.Label oldCodeCaption;
        private System.Windows.Forms.Label oldCodeValue;
        private System.Windows.Forms.Label replacedCaption;
        private System.Windows.Forms.Label replacedValue;
        private System.Windows.Forms.Label currentCaption;
        private System.Windows.Forms.Label currentValue;
        private System.Windows.Forms.Label remainCaption;
        private System.Windows.Forms.Label remainValue;
        private System.Windows.Forms.Label newCodeCaption;
        private System.Windows.Forms.TextBox newCodeBox;
        private System.Windows.Forms.Label reasonCaption;
        private System.Windows.Forms.ComboBox reasonBox;
        private System.Windows.Forms.TableLayoutPanel buttons;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}
