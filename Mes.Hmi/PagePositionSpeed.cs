using Mes.Business;
using Mes.Devices;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 位置速度（《Automation UI V3.11》P27）：上面是轴/马达的点动与状态，下面是参数表；
    /// 顶部换成 IO 页签时，左右两张表就是输入/输出点位，输出可以直接强制。
    ///
    /// 轴的位置、状态都从 PLC 读，读在后台线程；界面只写两种东西——点动脉冲位和速度字，
    /// 走不走、走到哪由机台侧算（见 MachineSimulator.SimulateAxes）。
    /// </summary>
    public partial class PagePositionSpeed : UserControl
    {
        private static readonly Color LampOn = Color.FromArgb(0, 150, 80);
        private static readonly Color LampOff = Color.FromArgb(235, 238, 242);
        private static readonly Color LampOffText = Color.FromArgb(150, 156, 164);
        private static readonly Color LampOnText = Color.White;

        private readonly StationContext station;
        private readonly object gate = new object();
        private List<AxisDefinition> axes = new List<AxisDefinition>();
        private Snapshot snapshot;
        private volatile bool pumping;
        private int revision;
        private int shownRevision = -1;
        private int positionStart = -1;
        private int positionWords;
        private int statusStart = -1;
        private int statusWords;

        private AxisDefinition jogging;
        private string jogBit;
        private int jogMode;             // 0 没有，1 寸动按时长停，2 点位移动按目标停
        private DateTime jogDeadline;
        private double moveTarget;

        /// <summary>IO 页签才读点位状态；地址表由界面线程整组换，读取线程只读引用。</summary>
        private volatile bool ioVisible;
        private volatile string[] pumpInputs = new string[0];
        private volatile string[] pumpOutputs = new string[0];

        public PagePositionSpeed()
        {
            InitializeComponent();
            Disposed += delegate
            {
                pumping = false;
                ReleaseJog();
            };
        }

        public PagePositionSpeed(StationContext station) : this()
        {
            this.station = station;
            BuildParamTabs();
            foreach (var group in station.Axes.Groups) comboGroup.Items.Add(group);
            if (comboGroup.Items.Count > 0) comboGroup.SelectedIndex = 0;
            BuildIoModules();
            FillAxes();
            FillParams();
            paramGrid.ReadOnly = !CanWrite;
            axisGrid.Resize += (s, e) => FitAxisRows();
            refresh.Enabled = true;
            pumping = true;
            var thread = new Thread(PumpLoop);
            thread.IsBackground = true;
            thread.Name = "轴与参数读取";
            thread.Start();
        }

        private bool CanWrite
        {
            get { return station != null && station.Level >= LoginLevel.Engineer; }
        }

        // ── 轴马达 ────────────────────────────────────────────────────────

        private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            axes = station.Axes.OfGroup(Convert.ToString(comboGroup.SelectedItem));
            positionStart = int.MaxValue;
            statusStart = int.MaxValue;
            var positionEnd = 0;
            var statusEnd = 0;
            foreach (var axis in axes)
            {
                positionStart = Math.Min(positionStart, axis.PositionAddress);
                positionEnd = Math.Max(positionEnd, axis.PositionAddress + 1);
                statusStart = Math.Min(statusStart, axis.StatusAddress);
                statusEnd = Math.Max(statusEnd, axis.StatusAddress);
            }
            if (axes.Count > 0)
            {
                positionWords = positionEnd - positionStart + 1;
                statusWords = statusEnd - statusStart + 1;
            }
            FillAxes();
        }

        private void FillAxes()
        {
            axisGrid.SuspendLayout();
            axisGrid.Rows.Clear();
            foreach (var axis in axes)
            {
                var row = axisGrid.Rows.Add("位置(mm)", "--", axis.Name + "+", axis.Name + "-");
                for (var s = 0; s < AxisCatalog.StatusNames.Length; s++)
                {
                    axisGrid.Rows[row].Cells[4 + s].Value = AxisCatalog.StatusNames[s];
                }
                PaintLamp(axisGrid.Rows[row], 4, false);
            }
            axisGrid.ClearSelection();
            axisGrid.ResumeLayout();
            FitAxisRows();
        }

        /// <summary>八根轴铺满表格高度，别在底下留一段空白（文档那一屏就是八行满格）。</summary>
        private void FitAxisRows()
        {
            if (axisGrid.Rows.Count == 0) return;
            var height = Math.Max(26, (axisGrid.ClientSize.Height - axisGrid.ColumnHeadersHeight - 2) / axisGrid.Rows.Count);
            foreach (DataGridViewRow row in axisGrid.Rows) row.Height = height;
        }

        private void radio_CheckedChanged(object sender, EventArgs e)
        {
            if (station == null) return;
            axisPanel.Visible = radioAxis.Checked;
            ioPanel.Visible = !radioAxis.Checked;
            ioVisible = !radioAxis.Checked;
            if (ioVisible) FillIo();
        }

        private void PumpLoop()
        {
            var tick = 0;
            while (pumping)
            {
                try
                {
                    double[] positions = null;
                    short[] statuses = null;
                    double[] parameters = null;
                    if (axes.Count > 0 && positionStart < int.MaxValue)
                    {
                        positions = station.Plc.ReadFloatArray(PlcAddresses.Mw(positionStart), (ushort)positionWords);
                        statuses = station.Plc.Read(PlcAddresses.Mw(statusStart), (ushort)statusWords);
                    }
                    if (tick % 3 == 0)
                    {
                        parameters = station.Plc.ReadFloatArray(
                            PlcAddresses.Mw(PlcAddresses.ParamBlockStart), PlcAddresses.ParamBlockWords);
                    }
                    bool[] inputs = null;
                    bool[] outputs = null;
                    if (ioVisible)
                    {
                        var inAddresses = pumpInputs;
                        var outAddresses = pumpOutputs;
                        if (inAddresses.Length > 0) inputs = station.Plc.ReadBits(inAddresses);
                        if (outAddresses.Length > 0) outputs = station.Plc.ReadBits(outAddresses);
                    }
                    lock (gate)
                    {
                        snapshot = new Snapshot
                        {
                            Revision = ++revision,
                            Positions = positions,
                            Statuses = statuses,
                            Parameters = parameters,
                            Inputs = inputs,
                            Outputs = outputs,
                        };
                    }
                }
                catch (Exception ex)
                {
                    lock (gate) { snapshot = new Snapshot { Revision = ++revision, Error = ex.Message }; }
                }
                tick++;
                Thread.Sleep(400);
            }
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            Snapshot frame;
            lock (gate) { frame = snapshot; }
            if (frame == null) return;
            if (frame.Error != null)
            {
                station.Say("轴/参数读取失败：" + frame.Error);
                return;
            }
            if (frame.Revision == shownRevision) return;
            shownRevision = frame.Revision;
            if (frame.Positions != null) PaintAxes(frame);
            if (frame.Parameters != null) PaintParams(frame);
            if (ioVisible) PaintIoState(frame);
        }

        private void PaintAxes(Snapshot frame)
        {
            for (var i = 0; i < axes.Count && i < axisGrid.Rows.Count; i++)
            {
                var axis = axes[i];
                var row = axisGrid.Rows[i];
                var index = (axis.PositionAddress - positionStart) / 2;
                var position = index >= 0 && frame.Positions != null && index < frame.Positions.Length
                    ? frame.Positions[index] : double.NaN;
                row.Cells[colPos.Index].Value = double.IsNaN(position)
                    ? "--" : position.ToString("0.000", CultureInfo.InvariantCulture);

                var slot = axis.StatusAddress - statusStart;
                var status = slot >= 0 && frame.Statuses != null && slot < frame.Statuses.Length ? frame.Statuses[slot] : (short)0;
                for (var s = 0; s < AxisCatalog.StatusNames.Length; s++)
                {
                    PaintLamp(row, 4 + s, (status & (1 << s)) != 0);
                }
            }
        }

        private static void PaintLamp(DataGridViewRow row, int column, bool on)
        {
            row.Cells[column].Style.BackColor = on ? LampOn : LampOff;
            row.Cells[column].Style.ForeColor = on ? LampOnText : LampOffText;
        }

        // ── 点动 ──────────────────────────────────────────────────────────

        private void axisGrid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (e.ColumnIndex != colPlus.Index && e.ColumnIndex != colMinus.Index) return;
            axisGrid.CurrentCell = axisGrid.Rows[e.RowIndex].Cells[colPos.Index];
            StartJog(axes[e.RowIndex], e.ColumnIndex == colPlus.Index, 0, DateTime.MaxValue);
        }

        private void axisGrid_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != colPlus.Index && e.ColumnIndex != colMinus.Index) return;
            if (jogMode == 0) ReleaseJog();
        }

        private void btnJog_MouseDown(object sender, MouseEventArgs e)
        {
            var axis = SelectedAxis();
            if (axis == null) return;
            var forward = jogging == axis ? !(jogBit == axis.JogForwardBit) : true;
            StartJog(axis, forward, 0, DateTime.MaxValue);
        }

        private void jog_MouseUp(object sender, MouseEventArgs e)
        {
            if (jogMode == 0) ReleaseJog();
        }

        private void jog_MouseLeave(object sender, EventArgs e)
        {
            if (jogMode == 0) ReleaseJog();
        }

        private void btnInch_Click(object sender, EventArgs e)
        {
            var axis = SelectedAxis();
            if (axis == null) return;
            double distance;
            if (!TryValue(distanceBox.Text, out distance) || distance <= 0)
            {
                station.Say("手动距离要大于 0");
                return;
            }
            var speed = Speed();
            // 按"走这么远要多久"给一个时限，时间到松脉冲——真机是轴卡自己减速停，这里按匀速近似。
            var ms = (int)Math.Ceiling(distance / speed * 1000D);
            StartJog(axis, LastDirectionForward(axis), 1, DateTime.Now.AddMilliseconds(ms + 200));
            jogTimer.Enabled = true;
        }

        private void btnMovePoint_Click(object sender, EventArgs e)
        {
            var axis = SelectedAxis();
            if (axis == null) return;
            double target;
            if (!SelectedParamValue(out target)) return;
            double current;
            if (!SelectedAxisPosition(out current)) return;
            var delta = target - current;
            if (Math.Abs(delta) < 0.05)
            {
                station.Say(axis.Name + " 已经在 " + target.ToString("0.000", CultureInfo.InvariantCulture) + " mm");
                return;
            }
            var speed = Speed();
            var ms = (int)Math.Ceiling(Math.Abs(delta) / speed * 1000D);
            moveTarget = target;
            StartJog(axis, delta > 0, 2, DateTime.Now.AddMilliseconds(ms + 1500));
            jogTimer.Enabled = true;
        }

        private void jogTimer_Tick(object sender, EventArgs e)
        {
            if (jogging == null || jogMode == 0)
            {
                jogTimer.Enabled = false;
                return;
            }
            if (DateTime.Now >= jogDeadline)
            {
                ReleaseJog();
                jogTimer.Enabled = false;
                return;
            }
            if (jogMode == 2)
            {
                double current;
                if (SelectedAxisPosition(out current) && Math.Abs(current - moveTarget) <= 0.05)
                {
                    ReleaseJog();
                    jogTimer.Enabled = false;
                    station.Say("点位移动到位");
                }
            }
        }

        private void StartJog(AxisDefinition axis, bool forward, int mode, DateTime deadline)
        {
            if (!CanWrite)
            {
                station.Say("需要工程师以上权限才能点动");
                return;
            }
            if (jogging != null && jogging != axis) ReleaseJog();
            var bit = forward ? axis.JogForwardBit : axis.JogBackwardBit;
            var other = forward ? axis.JogBackwardBit : axis.JogForwardBit;
            try
            {
                station.Plc.WriteFloatChecked(PlcAddresses.Mw(axis.SpeedAddress), Speed());
                station.Plc.WriteBitChecked(other, false);
                station.Plc.WriteBitChecked(bit, true);
            }
            catch (Exception ex)
            {
                station.Say("点动下发失败：" + ex.Message);
                return;
            }
            jogging = axis;
            jogBit = bit;
            jogMode = mode;
            jogDeadline = deadline;
        }

        private void ReleaseJog()
        {
            if (jogging == null || jogBit == null) return;
            try
            {
                station.Plc.WriteBitChecked(jogBit, false);
            }
            catch (Exception ex)
            {
                station.Say("松开点动脉冲失败：" + ex.Message);
            }
            jogging = null;
            jogBit = null;
            jogMode = 0;
        }

        private bool LastDirectionForward(AxisDefinition axis)
        {
            return jogging != axis || jogBit == axis.JogForwardBit;
        }

        private AxisDefinition SelectedAxis()
        {
            if (axisGrid.CurrentRow == null || axisGrid.CurrentRow.Index < 0) return null;
            var index = axisGrid.CurrentRow.Index;
            return index < axes.Count ? axes[index] : null;
        }

        private bool SelectedAxisPosition(out double position)
        {
            position = double.NaN;
            var axis = SelectedAxis();
            if (axis == null) return false;
            Snapshot frame;
            lock (gate) { frame = snapshot; }
            var index = (axis.PositionAddress - positionStart) / 2;
            if (frame == null || frame.Positions == null || index >= frame.Positions.Length) return false;
            position = frame.Positions[index];
            return !double.IsNaN(position);
        }

        private double Speed()
        {
            double speed;
            if (!TryValue(speedBox.Text, out speed) || speed <= 0 || speed > 500) return 10D;
            return speed;
        }

        private static bool TryValue(string text, out double value)
        {
            return double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out value)
                || double.TryParse(text, NumberStyles.Float, CultureInfo.CurrentCulture, out value);
        }

        // ── 参数表 ────────────────────────────────────────────────────────

        /// <summary>文档那六个页签里，码表没有对应参数的就撤掉，不留空页。</summary>
        private void BuildParamTabs()
        {
            var hidden = new List<TabPage>();
            foreach (TabPage page in paramTabs.TabPages)
            {
                var any = false;
                foreach (var param in station.Params.Items)
                {
                    if (param.Group == page.Text) { any = true; break; }
                }
                if (!any) hidden.Add(page);
            }
            foreach (var page in hidden) paramTabs.TabPages.Remove(page);
        }

        private void paramTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillParams();
        }

        private string GroupOfTab()
        {
            return paramTabs.SelectedTab != null ? paramTabs.SelectedTab.Text : "系统参数";
        }

        private void FillParams()
        {
            var group = GroupOfTab();
            paramGrid.SuspendLayout();
            paramGrid.Rows.Clear();
            foreach (var param in station.Params.Items)
            {
                if (param.Group != group) continue;
                paramGrid.Rows.Add(param.Name,
                    param.Lower.ToString("0.###", CultureInfo.InvariantCulture),
                    param.Upper.ToString("0.###", CultureInfo.InvariantCulture),
                    "--");
            }
            paramGrid.ClearSelection();
            paramGrid.ResumeLayout();
            Snapshot frame;
            lock (gate) { frame = snapshot; }
            if (frame != null && frame.Parameters != null) PaintParams(frame);
        }

        private void PaintParams(Snapshot frame)
        {
            var group = GroupOfTab();
            var row = 0;
            foreach (var param in station.Params.Items)
            {
                if (param.Group != group) continue;
                if (row >= paramGrid.Rows.Count) break;
                var index = param.Index(PlcAddresses.ParamBlockStart);
                var value = index >= 0 && index < frame.Parameters.Length ? frame.Parameters[index] : double.NaN;
                if (!IsEditingParamCell(row))
                {
                    paramGrid.Rows[row].Cells[colParamValue.Index].Value = double.IsNaN(value)
                        ? "--" : value.ToString("0.###", CultureInfo.InvariantCulture);
                }
                row++;
            }
        }

        /// <summary>正在敲的那一格别被刷新覆盖，否则改到一半数字就跳回机台值。</summary>
        private bool IsEditingParamCell(int row)
        {
            return paramGrid.IsCurrentCellInEditMode
                && paramGrid.CurrentCell != null
                && paramGrid.CurrentCell.RowIndex == row
                && paramGrid.CurrentCell.ColumnIndex == colParamValue.Index;
        }

        private bool SelectedParamValue(out double value)
        {
            value = 0;
            var row = paramGrid.CurrentRow;
            if (row == null || row.Index < 0 || row.Index >= paramGrid.Rows.Count)
            {
                station.Say("先在参数表里选一行");
                return false;
            }
            if (!TryValue(Convert.ToString(row.Cells[colParamValue.Index].Value), out value))
            {
                station.Say("该行的参数值不是数字");
                return false;
            }
            return true;
        }

        /// <summary>点位保存：把当前选中轴的实测位置写进选中参数行的"参数"列（还没下发）。</summary>
        private void btnTeachPoint_Click(object sender, EventArgs e)
        {
            double position;
            if (!SelectedAxisPosition(out position))
            {
                station.Say("先选一根轴");
                return;
            }
            var row = paramGrid.CurrentRow;
            if (row == null || row.Index < 0)
            {
                station.Say("先在参数表里选一行");
                return;
            }
            row.Cells[colParamValue.Index].Value = position.ToString("0.000", CultureInfo.InvariantCulture);
            station.Say("已取 " + Convert.ToString(row.Cells[colParamName.Index].Value) + " = "
                + position.ToString("0.000", CultureInfo.InvariantCulture) + "，点参数保存才下发");
        }

        private void btnSaveParam_Click(object sender, EventArgs e)
        {
            if (!CanWrite)
            {
                station.Say("需要工程师以上权限才能保存参数");
                return;
            }
            var group = GroupOfTab();
            var row = 0;
            var written = 0;
            foreach (var param in station.Params.Items)
            {
                if (param.Group != group) continue;
                if (row >= paramGrid.Rows.Count) break;
                var text = Convert.ToString(paramGrid.Rows[row].Cells[colParamValue.Index].Value);
                row++;
                double value;
                if (!TryValue(text, out value))
                {
                    station.Say(param.Name + " 的值不是数字，已跳过");
                    continue;
                }
                if (value < param.Lower || value > param.Upper)
                {
                    station.Say(param.Name + " 超出管控上下限，已跳过");
                    continue;
                }
                try
                {
                    station.Plc.WriteFloatChecked(PlcAddresses.Mw(param.Address), value);
                }
                catch (Exception ex)
                {
                    station.Say("写 " + param.Name + " 失败：" + ex.Message);
                    continue;
                }
                written++;
                station.Log.Write(station.User, "参数下发", param.Name,
                    value.ToString("0.###", CultureInfo.InvariantCulture), PlcAddresses.Mw(param.Address));
            }
            station.Say(written > 0 ? "已下发 " + written.ToString(CultureInfo.InvariantCulture) + " 项参数" : "没有需要下发的参数");
        }

        // ── IO 页签 ───────────────────────────────────────────────────────

        private readonly List<List<IoPoint>> inputModules = new List<List<IoPoint>>();
        private readonly List<List<IoPoint>> outputModules = new List<List<IoPoint>>();

        private void BuildIoModules()
        {
            AddModules(comboIn, inputModules, station.Io.Inputs, "IO卡模块输入::");
            AddModules(comboOut, outputModules, station.Io.Outputs, "IO卡模块输出::");
            if (comboIn.Items.Count > 0) comboIn.SelectedIndex = 0;
            if (comboOut.Items.Count > 0) comboOut.SelectedIndex = 0;
        }

        /// <summary>文档里一个模块 16 个点（DIM0~DIM15），所以按点位表顺序每 16 个切一块。</summary>
        private const int ModuleSize = 16;

        private static void AddModules(ComboBox combo, List<List<IoPoint>> modules, List<IoPoint> points, string prefix)
        {
            for (var start = 0; start < points.Count; start += ModuleSize)
            {
                var module = new List<IoPoint>();
                for (var i = start; i < points.Count && i < start + ModuleSize; i++) module.Add(points[i]);
                modules.Add(module);
                combo.Items.Add(prefix + (modules.Count - 1).ToString(CultureInfo.InvariantCulture));
            }
        }

        private void comboIo_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillIo();
        }

        private static string[] AddressesOf(List<IoPoint> points)
        {
            var addresses = new string[points.Count];
            for (var i = 0; i < points.Count; i++) addresses[i] = points[i].Address;
            return addresses;
        }

        private List<IoPoint> Module(List<List<IoPoint>> modules, ComboBox combo)
        {
            var index = combo.SelectedIndex;
            return index >= 0 && index < modules.Count ? modules[index] : new List<IoPoint>();
        }

        private void FillIo()
        {
            var inputs = Module(inputModules, comboIn);
            var outputs = Module(outputModules, comboOut);
            pumpInputs = AddressesOf(inputs);
            pumpOutputs = AddressesOf(outputs);
            FillIoGrid(gridIn, inputs);
            FillIoGrid(gridOut, outputs);
        }

        private void FillIoGrid(DataGridView grid, List<IoPoint> points)
        {
            grid.SuspendLayout();
            grid.Rows.Clear();
            var states = points.Count > 0 ? station.Plc.ReadBits(AddressesOf(points)) : new bool[0];
            for (var i = 0; i < points.Count; i++)
            {
                var row = grid.Rows.Add(points[i].Address, string.Empty, points[i].Name);
                PaintIoRow(grid, row, states[i]);
                points[i].On = states[i];
            }
            grid.ClearSelection();
            grid.ResumeLayout();
        }

        private void PaintIoState(Snapshot frame)
        {
            ApplyIoStates(gridIn, frame.Inputs);
            ApplyIoStates(gridOut, frame.Outputs);
        }

        private static void ApplyIoStates(DataGridView grid, bool[] states)
        {
            if (states == null) return;
            for (var i = 0; i < states.Length && i < grid.Rows.Count; i++)
            {
                PaintIoRow(grid, i, states[i]);
            }
        }

        private static void PaintIoRow(DataGridView grid, int index, bool on)
        {
            var cell = grid.Rows[index].Cells[1];
            cell.Value = on ? "ON" : "OFF";
            cell.Style.BackColor = on ? LampOn : LampOff;
            cell.Style.ForeColor = on ? LampOnText : LampOffText;
        }

        /// <summary>输出表点一行 = 把那个输出点强制取反（文档 #3"IO点位实际操作"）。</summary>
        private void gridOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var points = Module(outputModules, comboOut);
            if (e.RowIndex < 0 || e.RowIndex >= points.Count) return;
            if (!CanWrite)
            {
                station.Say("需要工程师以上权限才能强制输出");
                return;
            }
            var point = points[e.RowIndex];
            var target = !point.On;
            try
            {
                station.Plc.WriteBitChecked(point.Address, target);
            }
            catch (Exception ex)
            {
                station.Say("强制输出失败：" + ex.Message);
                return;
            }
            point.On = target;
            PaintIoRow(gridOut, e.RowIndex, target);
            station.Log.Write(station.User, "IO强制", point.Address, target ? "ON" : "OFF", point.Name);
            station.Say(point.Address + " 强制为 " + (target ? "ON" : "OFF"));
        }

        private sealed class Snapshot
        {
            public int Revision;
            public double[] Positions;
            public short[] Statuses;
            public double[] Parameters;
            public bool[] Inputs;
            public bool[] Outputs;
            public string Error;
        }
    }
}
