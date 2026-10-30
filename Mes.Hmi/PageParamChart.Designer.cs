namespace Mes.Hmi
{
    partial class PageParamChart
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPressure = new System.Windows.Forms.TabPage();
            this.plots = new System.Windows.Forms.TableLayoutPanel();
            this.plotPressure = new Mes.Hmi.PlotBox();
            this.plotTemperature = new Mes.Hmi.PlotBox();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.tabs.SuspendLayout();
            this.tabPressure.SuspendLayout();
            this.plots.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPressure);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.Padding = new System.Drawing.Point(10, 4);
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1180, 660);
            this.tabs.TabIndex = 0;
            // 
            // tabPressure
            // 
            this.tabPressure.BackColor = System.Drawing.Color.White;
            this.tabPressure.Controls.Add(this.plots);
            this.tabPressure.Location = new System.Drawing.Point(4, 30);
            this.tabPressure.Name = "tabPressure";
            this.tabPressure.Padding = new System.Windows.Forms.Padding(2);
            this.tabPressure.Size = new System.Drawing.Size(1172, 626);
            this.tabPressure.TabIndex = 0;
            this.tabPressure.Text = "页面0:穴1压力&温度(采样周期:500 ms)";
            // 
            // plots
            // 
            this.plots.ColumnCount = 1;
            this.plots.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.plots.Controls.Add(this.plotPressure, 0, 0);
            this.plots.Controls.Add(this.plotTemperature, 0, 1);
            this.plots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plots.Location = new System.Drawing.Point(2, 2);
            this.plots.Name = "plots";
            this.plots.RowCount = 2;
            this.plots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plots.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.plots.Size = new System.Drawing.Size(1168, 622);
            this.plots.TabIndex = 0;
            // 
            // plotPressure
            // 
            this.plotPressure.BackColor = System.Drawing.Color.White;
            this.plotPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotPressure.Location = new System.Drawing.Point(0, 0);
            this.plotPressure.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.plotPressure.Name = "plotPressure";
            this.plotPressure.Size = new System.Drawing.Size(1168, 307);
            this.plotPressure.TabIndex = 0;
            this.plotPressure.Unit = "MPa";
            // 
            // plotTemperature
            // 
            this.plotTemperature.BackColor = System.Drawing.Color.White;
            this.plotTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotTemperature.Location = new System.Drawing.Point(0, 315);
            this.plotTemperature.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.plotTemperature.Name = "plotTemperature";
            this.plotTemperature.Size = new System.Drawing.Size(1168, 307);
            this.plotTemperature.TabIndex = 1;
            this.plotTemperature.Unit = "℃";
            // 
            // refresh
            // 
            this.refresh.Interval = 500;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageParamChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabs);
            this.Name = "PageParamChart";
            this.Size = new System.Drawing.Size(1180, 660);
            this.tabs.ResumeLayout(false);
            this.tabPressure.ResumeLayout(false);
            this.plots.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPressure;
        private System.Windows.Forms.TableLayoutPanel plots;
        private Mes.Hmi.PlotBox plotPressure;
        private Mes.Hmi.PlotBox plotTemperature;
        private System.Windows.Forms.Timer refresh;
    }
}
