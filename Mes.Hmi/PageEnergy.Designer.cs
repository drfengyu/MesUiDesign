namespace Mes.Hmi
{
    partial class PageEnergy
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
            this.root = new System.Windows.Forms.TableLayoutPanel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPower = new System.Windows.Forms.TabPage();
            this.powerBody = new System.Windows.Forms.TableLayoutPanel();
            this.powerSide = new System.Windows.Forms.TableLayoutPanel();
            this.powerMode = new System.Windows.Forms.TableLayoutPanel();
            this.btnPowerLive = new System.Windows.Forms.Button();
            this.btnPowerHistory = new System.Windows.Forms.Button();
            this.voltageCaption = new System.Windows.Forms.Label();
            this.gaugeVoltage = new Mes.Hmi.GaugeBox();
            this.voltageValue = new System.Windows.Forms.Label();
            this.currentCaption = new System.Windows.Forms.Label();
            this.gaugeCurrent = new Mes.Hmi.GaugeBox();
            this.currentValue = new System.Windows.Forms.Label();
            this.energyCaption = new System.Windows.Forms.Label();
            this.energyBox = new System.Windows.Forms.Label();
            this.todayCaption = new System.Windows.Forms.Label();
            this.todayValue = new System.Windows.Forms.Label();
            this.powerContent = new System.Windows.Forms.Panel();
            this.realPower = new System.Windows.Forms.TableLayoutPanel();
            this.plotVoltage = new Mes.Hmi.PlotBox();
            this.plotCurrent = new Mes.Hmi.PlotBox();
            this.plotPower = new Mes.Hmi.PlotBox();
            this.plotHistoryPower = new Mes.Hmi.PlotBox();
            this.tabAir = new System.Windows.Forms.TabPage();
            this.airBody = new System.Windows.Forms.TableLayoutPanel();
            this.airSide = new System.Windows.Forms.TableLayoutPanel();
            this.airMode = new System.Windows.Forms.TableLayoutPanel();
            this.btnAirLive = new System.Windows.Forms.Button();
            this.btnAirHistory = new System.Windows.Forms.Button();
            this.airPressureCaption = new System.Windows.Forms.Label();
            this.airGaugePressure = new Mes.Hmi.GaugeBox();
            this.airPressureValue = new System.Windows.Forms.Label();
            this.airFlowCaption = new System.Windows.Forms.Label();
            this.airGaugeFlow = new Mes.Hmi.GaugeBox();
            this.airFlowValue = new System.Windows.Forms.Label();
            this.airEnergyCaption = new System.Windows.Forms.Label();
            this.airEnergyBox = new System.Windows.Forms.Label();
            this.airContent = new System.Windows.Forms.Panel();
            this.realAir = new System.Windows.Forms.TableLayoutPanel();
            this.plotAirPressure = new Mes.Hmi.PlotBox();
            this.plotAirFlow = new Mes.Hmi.PlotBox();
            this.plotHistoryAir = new Mes.Hmi.PlotBox();
            this.tabWater = new System.Windows.Forms.TabPage();
            this.waterBody = new System.Windows.Forms.TableLayoutPanel();
            this.waterSide = new System.Windows.Forms.TableLayoutPanel();
            this.waterMode = new System.Windows.Forms.TableLayoutPanel();
            this.btnWaterLive = new System.Windows.Forms.Button();
            this.btnWaterHistory = new System.Windows.Forms.Button();
            this.waterPressureCaption = new System.Windows.Forms.Label();
            this.waterGaugePressure = new Mes.Hmi.GaugeBox();
            this.waterPressureValue = new System.Windows.Forms.Label();
            this.waterFlowCaption = new System.Windows.Forms.Label();
            this.waterGaugeFlow = new Mes.Hmi.GaugeBox();
            this.waterFlowValue = new System.Windows.Forms.Label();
            this.waterEnergyCaption = new System.Windows.Forms.Label();
            this.waterEnergyBox = new System.Windows.Forms.Label();
            this.waterContent = new System.Windows.Forms.Panel();
            this.realWater = new System.Windows.Forms.TableLayoutPanel();
            this.plotWaterPressure = new Mes.Hmi.PlotBox();
            this.plotWaterFlow = new Mes.Hmi.PlotBox();
            this.plotHistoryWater = new Mes.Hmi.PlotBox();
            this.refresh = new System.Windows.Forms.Timer(this.components);
            this.root.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPower.SuspendLayout();
            this.powerBody.SuspendLayout();
            this.powerSide.SuspendLayout();
            this.powerMode.SuspendLayout();
            this.powerContent.SuspendLayout();
            this.realPower.SuspendLayout();
            this.tabAir.SuspendLayout();
            this.airBody.SuspendLayout();
            this.airSide.SuspendLayout();
            this.airMode.SuspendLayout();
            this.airContent.SuspendLayout();
            this.realAir.SuspendLayout();
            this.tabWater.SuspendLayout();
            this.waterBody.SuspendLayout();
            this.waterSide.SuspendLayout();
            this.waterMode.SuspendLayout();
            this.waterContent.SuspendLayout();
            this.realWater.SuspendLayout();
            this.SuspendLayout();
            // 
            // root
            // 
            this.root.ColumnCount = 1;
            this.root.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Controls.Add(this.tabs, 0, 0);
            this.root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.root.Location = new System.Drawing.Point(0, 0);
            this.root.Name = "root";
            this.root.Padding = new System.Windows.Forms.Padding(4);
            this.root.RowCount = 1;
            this.root.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.root.Size = new System.Drawing.Size(1180, 660);
            this.root.TabIndex = 0;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabPower);
            this.tabs.Controls.Add(this.tabAir);
            this.tabs.Controls.Add(this.tabWater);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tabs.ItemSize = new System.Drawing.Size(200, 34);
            this.tabs.Location = new System.Drawing.Point(4, 4);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1172, 652);
            this.tabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabs.TabIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            this.tabs.Resize += new System.EventHandler(this.tabs_Resize);
            // 
            // tabPower
            // 
            this.tabPower.Controls.Add(this.powerBody);
            this.tabPower.Location = new System.Drawing.Point(4, 38);
            this.tabPower.Name = "tabPower";
            this.tabPower.Padding = new System.Windows.Forms.Padding(3);
            this.tabPower.Size = new System.Drawing.Size(1164, 610);
            this.tabPower.TabIndex = 0;
            this.tabPower.Text = "耗电量";
            this.tabPower.UseVisualStyleBackColor = true;
            // 
            // powerBody
            // 
            this.powerBody.ColumnCount = 2;
            this.powerBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.powerBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.powerBody.Controls.Add(this.powerSide, 0, 0);
            this.powerBody.Controls.Add(this.powerContent, 1, 0);
            this.powerBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerBody.Location = new System.Drawing.Point(3, 3);
            this.powerBody.Name = "powerBody";
            this.powerBody.RowCount = 1;
            this.powerBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.powerBody.Size = new System.Drawing.Size(1158, 604);
            this.powerBody.TabIndex = 0;
            // 
            // powerSide
            // 
            this.powerSide.ColumnCount = 1;
            this.powerSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.powerSide.Controls.Add(this.powerMode, 0, 0);
            this.powerSide.Controls.Add(this.voltageCaption, 0, 1);
            this.powerSide.Controls.Add(this.gaugeVoltage, 0, 2);
            this.powerSide.Controls.Add(this.voltageValue, 0, 3);
            this.powerSide.Controls.Add(this.currentCaption, 0, 4);
            this.powerSide.Controls.Add(this.gaugeCurrent, 0, 5);
            this.powerSide.Controls.Add(this.currentValue, 0, 6);
            this.powerSide.Controls.Add(this.energyCaption, 0, 7);
            this.powerSide.Controls.Add(this.energyBox, 0, 8);
            this.powerSide.Controls.Add(this.todayCaption, 0, 9);
            this.powerSide.Controls.Add(this.todayValue, 0, 10);
            this.powerSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerSide.Location = new System.Drawing.Point(3, 3);
            this.powerSide.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.powerSide.Name = "powerSide";
            this.powerSide.RowCount = 11;
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.powerSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.powerSide.Size = new System.Drawing.Size(289, 598);
            this.powerSide.TabIndex = 0;
            // 
            // powerMode
            // 
            this.powerMode.ColumnCount = 2;
            this.powerMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.powerMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.powerMode.Controls.Add(this.btnPowerLive, 0, 0);
            this.powerMode.Controls.Add(this.btnPowerHistory, 1, 0);
            this.powerMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerMode.Location = new System.Drawing.Point(0, 0);
            this.powerMode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.powerMode.Name = "powerMode";
            this.powerMode.RowCount = 1;
            this.powerMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.powerMode.Size = new System.Drawing.Size(289, 40);
            this.powerMode.TabIndex = 0;
            // 
            // btnPowerLive
            // 
            this.btnPowerLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPowerLive.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnPowerLive.Location = new System.Drawing.Point(0, 0);
            this.btnPowerLive.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnPowerLive.Name = "btnPowerLive";
            this.btnPowerLive.Size = new System.Drawing.Size(141, 40);
            this.btnPowerLive.TabIndex = 0;
            this.btnPowerLive.Text = "实时数据";
            this.btnPowerLive.UseVisualStyleBackColor = true;
            this.btnPowerLive.Click += new System.EventHandler(this.btnPowerLive_Click);
            // 
            // btnPowerHistory
            // 
            this.btnPowerHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPowerHistory.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnPowerHistory.Location = new System.Drawing.Point(147, 0);
            this.btnPowerHistory.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnPowerHistory.Name = "btnPowerHistory";
            this.btnPowerHistory.Size = new System.Drawing.Size(142, 40);
            this.btnPowerHistory.TabIndex = 1;
            this.btnPowerHistory.Text = "历史数据";
            this.btnPowerHistory.UseVisualStyleBackColor = true;
            this.btnPowerHistory.Click += new System.EventHandler(this.btnPowerHistory_Click);
            // 
            // voltageCaption
            // 
            this.voltageCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voltageCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.voltageCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.voltageCaption.Location = new System.Drawing.Point(0, 44);
            this.voltageCaption.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.voltageCaption.Name = "voltageCaption";
            this.voltageCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.voltageCaption.Size = new System.Drawing.Size(289, 22);
            this.voltageCaption.TabIndex = 1;
            this.voltageCaption.Text = "电压";
            this.voltageCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gaugeVoltage
            // 
            this.gaugeVoltage.BackColor = System.Drawing.Color.White;
            this.gaugeVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeVoltage.Format = "0";
            this.gaugeVoltage.Location = new System.Drawing.Point(0, 66);
            this.gaugeVoltage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.gaugeVoltage.Max = 400D;
            this.gaugeVoltage.Min = 0D;
            this.gaugeVoltage.Name = "gaugeVoltage";
            this.gaugeVoltage.Size = new System.Drawing.Size(289, 115);
            this.gaugeVoltage.TabIndex = 2;
            this.gaugeVoltage.Unit = "V";
            // 
            // voltageValue
            // 
            this.voltageValue.BackColor = System.Drawing.Color.White;
            this.voltageValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voltageValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.voltageValue.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.voltageValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.voltageValue.Location = new System.Drawing.Point(0, 183);
            this.voltageValue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.voltageValue.Name = "voltageValue";
            this.voltageValue.Size = new System.Drawing.Size(289, 30);
            this.voltageValue.TabIndex = 3;
            this.voltageValue.Text = "实时电压  --";
            this.voltageValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // currentCaption
            // 
            this.currentCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.currentCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.currentCaption.Location = new System.Drawing.Point(0, 217);
            this.currentCaption.Margin = new System.Windows.Forms.Padding(0);
            this.currentCaption.Name = "currentCaption";
            this.currentCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.currentCaption.Size = new System.Drawing.Size(289, 22);
            this.currentCaption.TabIndex = 4;
            this.currentCaption.Text = "电流";
            this.currentCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gaugeCurrent
            // 
            this.gaugeCurrent.BackColor = System.Drawing.Color.White;
            this.gaugeCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gaugeCurrent.Format = "0.0";
            this.gaugeCurrent.Location = new System.Drawing.Point(0, 239);
            this.gaugeCurrent.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.gaugeCurrent.Max = 100D;
            this.gaugeCurrent.Min = 0D;
            this.gaugeCurrent.Name = "gaugeCurrent";
            this.gaugeCurrent.Size = new System.Drawing.Size(289, 115);
            this.gaugeCurrent.TabIndex = 5;
            this.gaugeCurrent.Unit = "A";
            // 
            // currentValue
            // 
            this.currentValue.BackColor = System.Drawing.Color.White;
            this.currentValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.currentValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentValue.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.currentValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.currentValue.Location = new System.Drawing.Point(0, 356);
            this.currentValue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.currentValue.Name = "currentValue";
            this.currentValue.Size = new System.Drawing.Size(289, 30);
            this.currentValue.TabIndex = 6;
            this.currentValue.Text = "实时电流  --";
            this.currentValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // energyCaption
            // 
            this.energyCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.energyCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.energyCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.energyCaption.Location = new System.Drawing.Point(0, 390);
            this.energyCaption.Margin = new System.Windows.Forms.Padding(0);
            this.energyCaption.Name = "energyCaption";
            this.energyCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.energyCaption.Size = new System.Drawing.Size(289, 22);
            this.energyCaption.TabIndex = 7;
            this.energyCaption.Text = "电能";
            this.energyCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // energyBox
            // 
            this.energyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.energyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.energyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.energyBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.energyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(70)))));
            this.energyBox.Location = new System.Drawing.Point(0, 415);
            this.energyBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.energyBox.Name = "energyBox";
            this.energyBox.Size = new System.Drawing.Size(289, 53);
            this.energyBox.TabIndex = 8;
            this.energyBox.Text = "0.00 kW";
            this.energyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // todayCaption
            // 
            this.todayCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todayCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.todayCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.todayCaption.Location = new System.Drawing.Point(0, 472);
            this.todayCaption.Margin = new System.Windows.Forms.Padding(0);
            this.todayCaption.Name = "todayCaption";
            this.todayCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.todayCaption.Size = new System.Drawing.Size(289, 24);
            this.todayCaption.TabIndex = 9;
            this.todayCaption.Text = "今日总耗电";
            this.todayCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // todayValue
            // 
            this.todayValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.todayValue.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.todayValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(70)))));
            this.todayValue.Location = new System.Drawing.Point(0, 496);
            this.todayValue.Margin = new System.Windows.Forms.Padding(0);
            this.todayValue.Name = "todayValue";
            this.todayValue.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.todayValue.Size = new System.Drawing.Size(289, 38);
            this.todayValue.TabIndex = 10;
            this.todayValue.Text = "0.000 kWh";
            this.todayValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // powerContent
            // 
            this.powerContent.Controls.Add(this.plotHistoryPower);
            this.powerContent.Controls.Add(this.realPower);
            this.powerContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.powerContent.Location = new System.Drawing.Point(300, 3);
            this.powerContent.Name = "powerContent";
            this.powerContent.Size = new System.Drawing.Size(855, 598);
            this.powerContent.TabIndex = 1;
            // 
            // realPower
            // 
            this.realPower.ColumnCount = 1;
            this.realPower.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.realPower.Controls.Add(this.plotVoltage, 0, 0);
            this.realPower.Controls.Add(this.plotCurrent, 0, 1);
            this.realPower.Controls.Add(this.plotPower, 0, 2);
            this.realPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realPower.Location = new System.Drawing.Point(0, 0);
            this.realPower.Name = "realPower";
            this.realPower.RowCount = 3;
            this.realPower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.realPower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.realPower.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.realPower.Size = new System.Drawing.Size(855, 598);
            this.realPower.TabIndex = 0;
            // 
            // plotVoltage
            // 
            this.plotVoltage.BackColor = System.Drawing.Color.White;
            this.plotVoltage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotVoltage.Location = new System.Drawing.Point(0, 0);
            this.plotVoltage.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.plotVoltage.Name = "plotVoltage";
            this.plotVoltage.ShowLegend = false;
            this.plotVoltage.Size = new System.Drawing.Size(855, 195);
            this.plotVoltage.TabIndex = 0;
            this.plotVoltage.Title = "动态电压数据 (V)";
            // 
            // plotCurrent
            // 
            this.plotCurrent.BackColor = System.Drawing.Color.White;
            this.plotCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotCurrent.Location = new System.Drawing.Point(0, 203);
            this.plotCurrent.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.plotCurrent.Name = "plotCurrent";
            this.plotCurrent.ShowLegend = false;
            this.plotCurrent.Size = new System.Drawing.Size(855, 191);
            this.plotCurrent.TabIndex = 1;
            this.plotCurrent.Title = "动态电流数据 (A)";
            // 
            // plotPower
            // 
            this.plotPower.BackColor = System.Drawing.Color.White;
            this.plotPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotPower.Location = new System.Drawing.Point(0, 402);
            this.plotPower.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.plotPower.Name = "plotPower";
            this.plotPower.ShowLegend = false;
            this.plotPower.Size = new System.Drawing.Size(855, 196);
            this.plotPower.TabIndex = 2;
            this.plotPower.Title = "动态能耗数据 (kW)";
            // 
            // plotHistoryPower
            // 
            this.plotHistoryPower.BackColor = System.Drawing.Color.White;
            this.plotHistoryPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotHistoryPower.Location = new System.Drawing.Point(0, 0);
            this.plotHistoryPower.Name = "plotHistoryPower";
            this.plotHistoryPower.ShowLegend = false;
            this.plotHistoryPower.Size = new System.Drawing.Size(855, 598);
            this.plotHistoryPower.TabIndex = 1;
            this.plotHistoryPower.Title = "每日耗电量 (kWh)";
            this.plotHistoryPower.Visible = false;
            // 
            // tabAir
            // 
            this.tabAir.Controls.Add(this.airBody);
            this.tabAir.Location = new System.Drawing.Point(4, 38);
            this.tabAir.Name = "tabAir";
            this.tabAir.Padding = new System.Windows.Forms.Padding(3);
            this.tabAir.Size = new System.Drawing.Size(1164, 610);
            this.tabAir.TabIndex = 1;
            this.tabAir.Text = "耗气量";
            this.tabAir.UseVisualStyleBackColor = true;
            // 
            // airBody
            // 
            this.airBody.ColumnCount = 2;
            this.airBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.airBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.airBody.Controls.Add(this.airSide, 0, 0);
            this.airBody.Controls.Add(this.airContent, 1, 0);
            this.airBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airBody.Location = new System.Drawing.Point(3, 3);
            this.airBody.Name = "airBody";
            this.airBody.RowCount = 1;
            this.airBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.airBody.Size = new System.Drawing.Size(1158, 604);
            this.airBody.TabIndex = 0;
            // 
            // airSide
            // 
            this.airSide.ColumnCount = 1;
            this.airSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.airSide.Controls.Add(this.airMode, 0, 0);
            this.airSide.Controls.Add(this.airPressureCaption, 0, 1);
            this.airSide.Controls.Add(this.airGaugePressure, 0, 2);
            this.airSide.Controls.Add(this.airPressureValue, 0, 3);
            this.airSide.Controls.Add(this.airFlowCaption, 0, 4);
            this.airSide.Controls.Add(this.airGaugeFlow, 0, 5);
            this.airSide.Controls.Add(this.airFlowValue, 0, 6);
            this.airSide.Controls.Add(this.airEnergyCaption, 0, 7);
            this.airSide.Controls.Add(this.airEnergyBox, 0, 8);
            this.airSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airSide.Location = new System.Drawing.Point(3, 3);
            this.airSide.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.airSide.Name = "airSide";
            this.airSide.RowCount = 9;
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.airSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.airSide.Size = new System.Drawing.Size(289, 598);
            this.airSide.TabIndex = 0;
            // 
            // airMode
            // 
            this.airMode.ColumnCount = 2;
            this.airMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.airMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.airMode.Controls.Add(this.btnAirLive, 0, 0);
            this.airMode.Controls.Add(this.btnAirHistory, 1, 0);
            this.airMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airMode.Location = new System.Drawing.Point(0, 0);
            this.airMode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.airMode.Name = "airMode";
            this.airMode.RowCount = 1;
            this.airMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.airMode.Size = new System.Drawing.Size(289, 40);
            this.airMode.TabIndex = 0;
            // 
            // btnAirLive
            // 
            this.btnAirLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAirLive.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnAirLive.Location = new System.Drawing.Point(0, 0);
            this.btnAirLive.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnAirLive.Name = "btnAirLive";
            this.btnAirLive.Size = new System.Drawing.Size(141, 40);
            this.btnAirLive.TabIndex = 0;
            this.btnAirLive.Text = "实时数据";
            this.btnAirLive.UseVisualStyleBackColor = true;
            this.btnAirLive.Click += new System.EventHandler(this.btnAirLive_Click);
            // 
            // btnAirHistory
            // 
            this.btnAirHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAirHistory.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnAirHistory.Location = new System.Drawing.Point(147, 0);
            this.btnAirHistory.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnAirHistory.Name = "btnAirHistory";
            this.btnAirHistory.Size = new System.Drawing.Size(142, 40);
            this.btnAirHistory.TabIndex = 1;
            this.btnAirHistory.Text = "历史数据";
            this.btnAirHistory.UseVisualStyleBackColor = true;
            this.btnAirHistory.Click += new System.EventHandler(this.btnAirHistory_Click);
            // 
            // airPressureCaption
            // 
            this.airPressureCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airPressureCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.airPressureCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.airPressureCaption.Location = new System.Drawing.Point(0, 44);
            this.airPressureCaption.Margin = new System.Windows.Forms.Padding(0);
            this.airPressureCaption.Name = "airPressureCaption";
            this.airPressureCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.airPressureCaption.Size = new System.Drawing.Size(289, 22);
            this.airPressureCaption.TabIndex = 1;
            this.airPressureCaption.Text = "总气压";
            this.airPressureCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airGaugePressure
            // 
            this.airGaugePressure.BackColor = System.Drawing.Color.White;
            this.airGaugePressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airGaugePressure.Format = "0.0";
            this.airGaugePressure.Location = new System.Drawing.Point(0, 66);
            this.airGaugePressure.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.airGaugePressure.Max = 800D;
            this.airGaugePressure.Min = 0D;
            this.airGaugePressure.Name = "airGaugePressure";
            this.airGaugePressure.Size = new System.Drawing.Size(289, 173);
            this.airGaugePressure.TabIndex = 2;
            this.airGaugePressure.Unit = "kPa";
            // 
            // airPressureValue
            // 
            this.airPressureValue.BackColor = System.Drawing.Color.White;
            this.airPressureValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airPressureValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airPressureValue.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.airPressureValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.airPressureValue.Location = new System.Drawing.Point(0, 241);
            this.airPressureValue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.airPressureValue.Name = "airPressureValue";
            this.airPressureValue.Size = new System.Drawing.Size(289, 30);
            this.airPressureValue.TabIndex = 3;
            this.airPressureValue.Text = "实时气压  --";
            this.airPressureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airFlowCaption
            // 
            this.airFlowCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airFlowCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.airFlowCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.airFlowCaption.Location = new System.Drawing.Point(0, 275);
            this.airFlowCaption.Margin = new System.Windows.Forms.Padding(0);
            this.airFlowCaption.Name = "airFlowCaption";
            this.airFlowCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.airFlowCaption.Size = new System.Drawing.Size(289, 22);
            this.airFlowCaption.TabIndex = 4;
            this.airFlowCaption.Text = "流量";
            this.airFlowCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airGaugeFlow
            // 
            this.airGaugeFlow.BackColor = System.Drawing.Color.White;
            this.airGaugeFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airGaugeFlow.Format = "0.00";
            this.airGaugeFlow.Location = new System.Drawing.Point(0, 297);
            this.airGaugeFlow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.airGaugeFlow.Max = 100D;
            this.airGaugeFlow.Min = 0D;
            this.airGaugeFlow.Name = "airGaugeFlow";
            this.airGaugeFlow.Size = new System.Drawing.Size(289, 173);
            this.airGaugeFlow.TabIndex = 5;
            this.airGaugeFlow.Unit = "L/min";
            // 
            // airFlowValue
            // 
            this.airFlowValue.BackColor = System.Drawing.Color.White;
            this.airFlowValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airFlowValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airFlowValue.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.airFlowValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.airFlowValue.Location = new System.Drawing.Point(0, 472);
            this.airFlowValue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.airFlowValue.Name = "airFlowValue";
            this.airFlowValue.Size = new System.Drawing.Size(289, 30);
            this.airFlowValue.TabIndex = 6;
            this.airFlowValue.Text = "实时流量  --";
            this.airFlowValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airEnergyCaption
            // 
            this.airEnergyCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airEnergyCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.airEnergyCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.airEnergyCaption.Location = new System.Drawing.Point(0, 506);
            this.airEnergyCaption.Margin = new System.Windows.Forms.Padding(0);
            this.airEnergyCaption.Name = "airEnergyCaption";
            this.airEnergyCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.airEnergyCaption.Size = new System.Drawing.Size(289, 22);
            this.airEnergyCaption.TabIndex = 7;
            this.airEnergyCaption.Text = "今日总耗气";
            this.airEnergyCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // airEnergyBox
            // 
            this.airEnergyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.airEnergyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.airEnergyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airEnergyBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.airEnergyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(70)))));
            this.airEnergyBox.Location = new System.Drawing.Point(0, 531);
            this.airEnergyBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.airEnergyBox.Name = "airEnergyBox";
            this.airEnergyBox.Size = new System.Drawing.Size(289, 63);
            this.airEnergyBox.TabIndex = 8;
            this.airEnergyBox.Text = "0.000 m³";
            this.airEnergyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // airContent
            // 
            this.airContent.Controls.Add(this.plotHistoryAir);
            this.airContent.Controls.Add(this.realAir);
            this.airContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.airContent.Location = new System.Drawing.Point(300, 3);
            this.airContent.Name = "airContent";
            this.airContent.Size = new System.Drawing.Size(855, 598);
            this.airContent.TabIndex = 1;
            // 
            // realAir
            // 
            this.realAir.ColumnCount = 1;
            this.realAir.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.realAir.Controls.Add(this.plotAirPressure, 0, 0);
            this.realAir.Controls.Add(this.plotAirFlow, 0, 1);
            this.realAir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realAir.Location = new System.Drawing.Point(0, 0);
            this.realAir.Name = "realAir";
            this.realAir.RowCount = 2;
            this.realAir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.realAir.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.realAir.Size = new System.Drawing.Size(855, 598);
            this.realAir.TabIndex = 0;
            // 
            // plotAirPressure
            // 
            this.plotAirPressure.BackColor = System.Drawing.Color.White;
            this.plotAirPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotAirPressure.Location = new System.Drawing.Point(0, 0);
            this.plotAirPressure.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.plotAirPressure.Name = "plotAirPressure";
            this.plotAirPressure.ShowLegend = false;
            this.plotAirPressure.Size = new System.Drawing.Size(855, 295);
            this.plotAirPressure.TabIndex = 0;
            this.plotAirPressure.Title = "总气压 (kPa)";
            // 
            // plotAirFlow
            // 
            this.plotAirFlow.BackColor = System.Drawing.Color.White;
            this.plotAirFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotAirFlow.Location = new System.Drawing.Point(0, 303);
            this.plotAirFlow.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.plotAirFlow.Name = "plotAirFlow";
            this.plotAirFlow.ShowLegend = false;
            this.plotAirFlow.Size = new System.Drawing.Size(855, 295);
            this.plotAirFlow.TabIndex = 1;
            this.plotAirFlow.Title = "动态流量数据 (L/min)";
            // 
            // plotHistoryAir
            // 
            this.plotHistoryAir.BackColor = System.Drawing.Color.White;
            this.plotHistoryAir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotHistoryAir.Location = new System.Drawing.Point(0, 0);
            this.plotHistoryAir.Name = "plotHistoryAir";
            this.plotHistoryAir.ShowLegend = false;
            this.plotHistoryAir.Size = new System.Drawing.Size(855, 598);
            this.plotHistoryAir.TabIndex = 1;
            this.plotHistoryAir.Title = "每日耗气量 (m³)";
            this.plotHistoryAir.Visible = false;
            // 
            // tabWater
            // 
            this.tabWater.Controls.Add(this.waterBody);
            this.tabWater.Location = new System.Drawing.Point(4, 38);
            this.tabWater.Name = "tabWater";
            this.tabWater.Padding = new System.Windows.Forms.Padding(3);
            this.tabWater.Size = new System.Drawing.Size(1164, 610);
            this.tabWater.TabIndex = 2;
            this.tabWater.Text = "耗水量";
            this.tabWater.UseVisualStyleBackColor = true;
            // 
            // waterBody
            // 
            this.waterBody.ColumnCount = 2;
            this.waterBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.waterBody.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.waterBody.Controls.Add(this.waterSide, 0, 0);
            this.waterBody.Controls.Add(this.waterContent, 1, 0);
            this.waterBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterBody.Location = new System.Drawing.Point(3, 3);
            this.waterBody.Name = "waterBody";
            this.waterBody.RowCount = 1;
            this.waterBody.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.waterBody.Size = new System.Drawing.Size(1158, 604);
            this.waterBody.TabIndex = 0;
            // 
            // waterSide
            // 
            this.waterSide.ColumnCount = 1;
            this.waterSide.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.waterSide.Controls.Add(this.waterMode, 0, 0);
            this.waterSide.Controls.Add(this.waterPressureCaption, 0, 1);
            this.waterSide.Controls.Add(this.waterGaugePressure, 0, 2);
            this.waterSide.Controls.Add(this.waterPressureValue, 0, 3);
            this.waterSide.Controls.Add(this.waterFlowCaption, 0, 4);
            this.waterSide.Controls.Add(this.waterGaugeFlow, 0, 5);
            this.waterSide.Controls.Add(this.waterFlowValue, 0, 6);
            this.waterSide.Controls.Add(this.waterEnergyCaption, 0, 7);
            this.waterSide.Controls.Add(this.waterEnergyBox, 0, 8);
            this.waterSide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterSide.Location = new System.Drawing.Point(3, 3);
            this.waterSide.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.waterSide.Name = "waterSide";
            this.waterSide.RowCount = 9;
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.waterSide.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.waterSide.Size = new System.Drawing.Size(289, 598);
            this.waterSide.TabIndex = 0;
            // 
            // waterMode
            // 
            this.waterMode.ColumnCount = 2;
            this.waterMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.waterMode.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.waterMode.Controls.Add(this.btnWaterLive, 0, 0);
            this.waterMode.Controls.Add(this.btnWaterHistory, 1, 0);
            this.waterMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterMode.Location = new System.Drawing.Point(0, 0);
            this.waterMode.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.waterMode.Name = "waterMode";
            this.waterMode.RowCount = 1;
            this.waterMode.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.waterMode.Size = new System.Drawing.Size(289, 40);
            this.waterMode.TabIndex = 0;
            // 
            // btnWaterLive
            // 
            this.btnWaterLive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWaterLive.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnWaterLive.Location = new System.Drawing.Point(0, 0);
            this.btnWaterLive.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.btnWaterLive.Name = "btnWaterLive";
            this.btnWaterLive.Size = new System.Drawing.Size(141, 40);
            this.btnWaterLive.TabIndex = 0;
            this.btnWaterLive.Text = "实时数据";
            this.btnWaterLive.UseVisualStyleBackColor = true;
            this.btnWaterLive.Click += new System.EventHandler(this.btnWaterLive_Click);
            // 
            // btnWaterHistory
            // 
            this.btnWaterHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWaterHistory.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.btnWaterHistory.Location = new System.Drawing.Point(147, 0);
            this.btnWaterHistory.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.btnWaterHistory.Name = "btnWaterHistory";
            this.btnWaterHistory.Size = new System.Drawing.Size(142, 40);
            this.btnWaterHistory.TabIndex = 1;
            this.btnWaterHistory.Text = "历史数据";
            this.btnWaterHistory.UseVisualStyleBackColor = true;
            this.btnWaterHistory.Click += new System.EventHandler(this.btnWaterHistory_Click);
            // 
            // waterPressureCaption
            // 
            this.waterPressureCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterPressureCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.waterPressureCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.waterPressureCaption.Location = new System.Drawing.Point(0, 44);
            this.waterPressureCaption.Margin = new System.Windows.Forms.Padding(0);
            this.waterPressureCaption.Name = "waterPressureCaption";
            this.waterPressureCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.waterPressureCaption.Size = new System.Drawing.Size(289, 22);
            this.waterPressureCaption.TabIndex = 1;
            this.waterPressureCaption.Text = "水压";
            this.waterPressureCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waterGaugePressure
            // 
            this.waterGaugePressure.BackColor = System.Drawing.Color.White;
            this.waterGaugePressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterGaugePressure.Format = "0.0";
            this.waterGaugePressure.Location = new System.Drawing.Point(0, 66);
            this.waterGaugePressure.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.waterGaugePressure.Max = 800D;
            this.waterGaugePressure.Min = 0D;
            this.waterGaugePressure.Name = "waterGaugePressure";
            this.waterGaugePressure.Size = new System.Drawing.Size(289, 173);
            this.waterGaugePressure.TabIndex = 2;
            this.waterGaugePressure.Unit = "kPa";
            // 
            // waterPressureValue
            // 
            this.waterPressureValue.BackColor = System.Drawing.Color.White;
            this.waterPressureValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterPressureValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterPressureValue.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.waterPressureValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.waterPressureValue.Location = new System.Drawing.Point(0, 241);
            this.waterPressureValue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.waterPressureValue.Name = "waterPressureValue";
            this.waterPressureValue.Size = new System.Drawing.Size(289, 30);
            this.waterPressureValue.TabIndex = 3;
            this.waterPressureValue.Text = "实时水压  --";
            this.waterPressureValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waterFlowCaption
            // 
            this.waterFlowCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterFlowCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.waterFlowCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.waterFlowCaption.Location = new System.Drawing.Point(0, 275);
            this.waterFlowCaption.Margin = new System.Windows.Forms.Padding(0);
            this.waterFlowCaption.Name = "waterFlowCaption";
            this.waterFlowCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.waterFlowCaption.Size = new System.Drawing.Size(289, 22);
            this.waterFlowCaption.TabIndex = 4;
            this.waterFlowCaption.Text = "流量";
            this.waterFlowCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waterGaugeFlow
            // 
            this.waterGaugeFlow.BackColor = System.Drawing.Color.White;
            this.waterGaugeFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterGaugeFlow.Format = "0.00";
            this.waterGaugeFlow.Location = new System.Drawing.Point(0, 297);
            this.waterGaugeFlow.Margin = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.waterGaugeFlow.Max = 100D;
            this.waterGaugeFlow.Min = 0D;
            this.waterGaugeFlow.Name = "waterGaugeFlow";
            this.waterGaugeFlow.Size = new System.Drawing.Size(289, 173);
            this.waterGaugeFlow.TabIndex = 5;
            this.waterGaugeFlow.Unit = "L/min";
            // 
            // waterFlowValue
            // 
            this.waterFlowValue.BackColor = System.Drawing.Color.White;
            this.waterFlowValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterFlowValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterFlowValue.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.waterFlowValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(66)))), ((int)(((byte)(72)))));
            this.waterFlowValue.Location = new System.Drawing.Point(0, 472);
            this.waterFlowValue.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.waterFlowValue.Name = "waterFlowValue";
            this.waterFlowValue.Size = new System.Drawing.Size(289, 30);
            this.waterFlowValue.TabIndex = 6;
            this.waterFlowValue.Text = "实时流量  --";
            this.waterFlowValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waterEnergyCaption
            // 
            this.waterEnergyCaption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterEnergyCaption.Font = new System.Drawing.Font("微软雅黑", 9.5F);
            this.waterEnergyCaption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(96)))), ((int)(((byte)(105)))));
            this.waterEnergyCaption.Location = new System.Drawing.Point(0, 506);
            this.waterEnergyCaption.Margin = new System.Windows.Forms.Padding(0);
            this.waterEnergyCaption.Name = "waterEnergyCaption";
            this.waterEnergyCaption.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.waterEnergyCaption.Size = new System.Drawing.Size(289, 22);
            this.waterEnergyCaption.TabIndex = 7;
            this.waterEnergyCaption.Text = "今日总耗水";
            this.waterEnergyCaption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // waterEnergyBox
            // 
            this.waterEnergyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(240)))), ((int)(((byte)(220)))));
            this.waterEnergyBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.waterEnergyBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterEnergyBox.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold);
            this.waterEnergyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(70)))));
            this.waterEnergyBox.Location = new System.Drawing.Point(0, 531);
            this.waterEnergyBox.Margin = new System.Windows.Forms.Padding(0, 3, 0, 4);
            this.waterEnergyBox.Name = "waterEnergyBox";
            this.waterEnergyBox.Size = new System.Drawing.Size(289, 63);
            this.waterEnergyBox.TabIndex = 8;
            this.waterEnergyBox.Text = "0.000 m³";
            this.waterEnergyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // waterContent
            // 
            this.waterContent.Controls.Add(this.plotHistoryWater);
            this.waterContent.Controls.Add(this.realWater);
            this.waterContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.waterContent.Location = new System.Drawing.Point(300, 3);
            this.waterContent.Name = "waterContent";
            this.waterContent.Size = new System.Drawing.Size(855, 598);
            this.waterContent.TabIndex = 1;
            // 
            // realWater
            // 
            this.realWater.ColumnCount = 1;
            this.realWater.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.realWater.Controls.Add(this.plotWaterPressure, 0, 0);
            this.realWater.Controls.Add(this.plotWaterFlow, 0, 1);
            this.realWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.realWater.Location = new System.Drawing.Point(0, 0);
            this.realWater.Name = "realWater";
            this.realWater.RowCount = 2;
            this.realWater.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.realWater.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.realWater.Size = new System.Drawing.Size(855, 598);
            this.realWater.TabIndex = 0;
            // 
            // plotWaterPressure
            // 
            this.plotWaterPressure.BackColor = System.Drawing.Color.White;
            this.plotWaterPressure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotWaterPressure.Location = new System.Drawing.Point(0, 0);
            this.plotWaterPressure.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.plotWaterPressure.Name = "plotWaterPressure";
            this.plotWaterPressure.ShowLegend = false;
            this.plotWaterPressure.Size = new System.Drawing.Size(855, 295);
            this.plotWaterPressure.TabIndex = 0;
            this.plotWaterPressure.Title = "供水压力 (kPa)";
            // 
            // plotWaterFlow
            // 
            this.plotWaterFlow.BackColor = System.Drawing.Color.White;
            this.plotWaterFlow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotWaterFlow.Location = new System.Drawing.Point(0, 303);
            this.plotWaterFlow.Margin = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.plotWaterFlow.Name = "plotWaterFlow";
            this.plotWaterFlow.ShowLegend = false;
            this.plotWaterFlow.Size = new System.Drawing.Size(855, 295);
            this.plotWaterFlow.TabIndex = 1;
            this.plotWaterFlow.Title = "动态流量数据 (L/min)";
            // 
            // plotHistoryWater
            // 
            this.plotHistoryWater.BackColor = System.Drawing.Color.White;
            this.plotHistoryWater.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plotHistoryWater.Location = new System.Drawing.Point(0, 0);
            this.plotHistoryWater.Name = "plotHistoryWater";
            this.plotHistoryWater.ShowLegend = false;
            this.plotHistoryWater.Size = new System.Drawing.Size(855, 598);
            this.plotHistoryWater.TabIndex = 1;
            this.plotHistoryWater.Title = "每日耗水量 (m³)";
            this.plotHistoryWater.Visible = false;
            // 
            // refresh
            // 
            this.refresh.Interval = 1000;
            this.refresh.Tick += new System.EventHandler(this.refresh_Tick);
            // 
            // PageEnergy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.root);
            this.Name = "PageEnergy";
            this.Size = new System.Drawing.Size(1180, 660);
            this.root.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabPower.ResumeLayout(false);
            this.powerBody.ResumeLayout(false);
            this.powerSide.ResumeLayout(false);
            this.powerMode.ResumeLayout(false);
            this.powerContent.ResumeLayout(false);
            this.realPower.ResumeLayout(false);
            this.tabAir.ResumeLayout(false);
            this.airBody.ResumeLayout(false);
            this.airSide.ResumeLayout(false);
            this.airMode.ResumeLayout(false);
            this.airContent.ResumeLayout(false);
            this.realAir.ResumeLayout(false);
            this.tabWater.ResumeLayout(false);
            this.waterBody.ResumeLayout(false);
            this.waterSide.ResumeLayout(false);
            this.waterMode.ResumeLayout(false);
            this.waterContent.ResumeLayout(false);
            this.realWater.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel root;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPower;
        private System.Windows.Forms.TableLayoutPanel powerBody;
        private System.Windows.Forms.TableLayoutPanel powerSide;
        private System.Windows.Forms.TableLayoutPanel powerMode;
        private System.Windows.Forms.Button btnPowerLive;
        private System.Windows.Forms.Button btnPowerHistory;
        private System.Windows.Forms.Label voltageCaption;
        private Mes.Hmi.GaugeBox gaugeVoltage;
        private System.Windows.Forms.Label voltageValue;
        private System.Windows.Forms.Label currentCaption;
        private Mes.Hmi.GaugeBox gaugeCurrent;
        private System.Windows.Forms.Label currentValue;
        private System.Windows.Forms.Label energyCaption;
        private System.Windows.Forms.Label energyBox;
        private System.Windows.Forms.Label todayCaption;
        private System.Windows.Forms.Label todayValue;
        private System.Windows.Forms.Panel powerContent;
        private System.Windows.Forms.TableLayoutPanel realPower;
        private Mes.Hmi.PlotBox plotVoltage;
        private Mes.Hmi.PlotBox plotCurrent;
        private Mes.Hmi.PlotBox plotPower;
        private Mes.Hmi.PlotBox plotHistoryPower;
        private System.Windows.Forms.TabPage tabAir;
        private System.Windows.Forms.TableLayoutPanel airBody;
        private System.Windows.Forms.TableLayoutPanel airSide;
        private System.Windows.Forms.TableLayoutPanel airMode;
        private System.Windows.Forms.Button btnAirLive;
        private System.Windows.Forms.Button btnAirHistory;
        private System.Windows.Forms.Label airPressureCaption;
        private Mes.Hmi.GaugeBox airGaugePressure;
        private System.Windows.Forms.Label airPressureValue;
        private System.Windows.Forms.Label airFlowCaption;
        private Mes.Hmi.GaugeBox airGaugeFlow;
        private System.Windows.Forms.Label airFlowValue;
        private System.Windows.Forms.Label airEnergyCaption;
        private System.Windows.Forms.Label airEnergyBox;
        private System.Windows.Forms.Panel airContent;
        private System.Windows.Forms.TableLayoutPanel realAir;
        private Mes.Hmi.PlotBox plotAirPressure;
        private Mes.Hmi.PlotBox plotAirFlow;
        private Mes.Hmi.PlotBox plotHistoryAir;
        private System.Windows.Forms.TabPage tabWater;
        private System.Windows.Forms.TableLayoutPanel waterBody;
        private System.Windows.Forms.TableLayoutPanel waterSide;
        private System.Windows.Forms.TableLayoutPanel waterMode;
        private System.Windows.Forms.Button btnWaterLive;
        private System.Windows.Forms.Button btnWaterHistory;
        private System.Windows.Forms.Label waterPressureCaption;
        private Mes.Hmi.GaugeBox waterGaugePressure;
        private System.Windows.Forms.Label waterPressureValue;
        private System.Windows.Forms.Label waterFlowCaption;
        private Mes.Hmi.GaugeBox waterGaugeFlow;
        private System.Windows.Forms.Label waterFlowValue;
        private System.Windows.Forms.Label waterEnergyCaption;
        private System.Windows.Forms.Label waterEnergyBox;
        private System.Windows.Forms.Panel waterContent;
        private System.Windows.Forms.TableLayoutPanel realWater;
        private Mes.Hmi.PlotBox plotWaterPressure;
        private Mes.Hmi.PlotBox plotWaterFlow;
        private Mes.Hmi.PlotBox plotHistoryWater;
        private System.Windows.Forms.Timer refresh;
    }
}
