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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.components = new System.ComponentModel.Container();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPressure = new System.Windows.Forms.TabPage();
            this.plots = new System.Windows.Forms.TableLayoutPanel();
            this.plotPressure = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.plotTemperature = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.tabs.SuspendLayout();
            this.tabPressure.SuspendLayout();
            this.plots.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotPressure)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotTemperature)).BeginInit();
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
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.Name = "main";
            this.plotPressure.ChartAreas.Add(chartArea1);
            this.plotPressure.BackColor = System.Drawing.Color.White;
            this.plotPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            legend1.IsTextAutoFit = false;
            legend1.Name = "legend";
            this.plotPressure.Legends.Add(legend1);
            this.plotPressure.Location = new System.Drawing.Point(0, 0);
            this.plotPressure.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.plotPressure.Name = "plotPressure";
            series1.ChartArea = "main";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            series1.LegendText = "穴1压力";
            series1.Name = "穴1压力";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "main";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            series2.LegendText = "穴2压力";
            series2.Name = "穴2压力";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "main";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            series3.LegendText = "穴3压力";
            series3.Name = "穴3压力";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.ChartArea = "main";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            series4.LegendText = "穴4压力";
            series4.Name = "穴4压力";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.plotPressure.Series.Add(series1);
            this.plotPressure.Series.Add(series2);
            this.plotPressure.Series.Add(series3);
            this.plotPressure.Series.Add(series4);
            this.plotPressure.Size = new System.Drawing.Size(1168, 307);
            this.plotPressure.TabIndex = 0;
            // 
            // plotTemperature
            // 
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea2.AxisX.MajorTickMark.Enabled = false;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(156)))), ((int)(((byte)(164)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(239)))));
            chartArea2.AxisY.MajorTickMark.Enabled = false;
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Name = "main";
            this.plotTemperature.ChartAreas.Add(chartArea2);
            this.plotTemperature.BackColor = System.Drawing.Color.White;
            this.plotTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(215)))), ((int)(((byte)(222)))));
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
            legend2.IsTextAutoFit = false;
            legend2.Name = "legend";
            this.plotTemperature.Legends.Add(legend2);
            this.plotTemperature.Location = new System.Drawing.Point(0, 315);
            this.plotTemperature.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.plotTemperature.Name = "plotTemperature";
            series5.ChartArea = "main";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(160)))), ((int)(((byte)(120)))));
            series5.LegendText = "穴1温度";
            series5.Name = "穴1温度";
            series5.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series6.ChartArea = "main";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(120)))), ((int)(((byte)(200)))));
            series6.LegendText = "穴2温度";
            series6.Name = "穴2温度";
            series6.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series7.ChartArea = "main";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(150)))), ((int)(((byte)(30)))));
            series7.LegendText = "穴3温度";
            series7.Name = "穴3温度";
            series7.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series8.ChartArea = "main";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(60)))), ((int)(((byte)(70)))));
            series8.LegendText = "穴4温度";
            series8.Name = "穴4温度";
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.plotTemperature.Series.Add(series5);
            this.plotTemperature.Series.Add(series6);
            this.plotTemperature.Series.Add(series7);
            this.plotTemperature.Series.Add(series8);
            this.plotTemperature.Size = new System.Drawing.Size(1168, 307);
            this.plotTemperature.TabIndex = 1;
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
            ((System.ComponentModel.ISupportInitialize)(this.plotPressure)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plotTemperature)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPressure;
        private System.Windows.Forms.TableLayoutPanel plots;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotPressure;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotTemperature;
        private System.Windows.Forms.Timer refresh;
    }
}
