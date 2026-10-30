using Mes.Business;
using Mes.Devices;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 参数管控（《Automation UI V3.11》P9）：按工艺/视觉/机械手 ERS 分页显示参数，
    /// 当前值与管控上下限比对，NG 标红。参数块一次块读，读在后台线程。
    /// </summary>
    public partial class PageParamControl : UserControl
    {
        private const string DefaultComm = "本机未接 MES 接口，暂无与服务器的通讯记录。\r\n"
            + "接入后在此显示报站 / 过站的请求与应答（checkIn / checkOut）。";

        private static readonly Color RowNg = Color.FromArgb(250, 216, 216);
        private static readonly Color NgText = Color.FromArgb(200, 40, 40);

        private readonly StationContext station;
        private readonly object gate = new object();
        private Snapshot snapshot;
        private volatile bool pumping;
        private int shownRevision = -1;

        public PageParamControl()
        {
            InitializeComponent();
            Disposed += delegate { pumping = false; };
        }

        public PageParamControl(StationContext station) : this()
        {
            this.station = station;
            refresh.Enabled = true;
            pumping = true;
            var thread = new Thread(PumpLoop);
            thread.IsBackground = true;
            thread.Name = "参数管控读取";
            thread.Start();
            FillGrid();
        }

        private void PumpLoop()
        {
            while (pumping)
            {
                try
                {
                    // 参数块与主项目一样一次块读：index = (地址 - 50000) / 2。
                    var words = station.Plc.ReadFloatArray(
                        PlcAddresses.Mw(PlcAddresses.ParamBlockStart), PlcAddresses.ParamBlockWords);
                    lock (gate)
                    {
                        snapshot = new Snapshot { Revision = ++revision, Values = words };
                    }
                }
                catch (Exception ex)
                {
                    lock (gate) { snapshot = new Snapshot { Revision = ++revision, Error = ex.Message }; }
                }
                Thread.Sleep(1000);
            }
        }

        private int revision;

        private void refresh_Tick(object sender, EventArgs e)
        {
            Snapshot frame;
            lock (gate) { frame = snapshot; }
            if (frame == null) return;
            if (frame.Error != null)
            {
                commNote.Text = "参数块读取失败：" + frame.Error;
                commNote.ForeColor = NgText;
                return;
            }
            if (frame.Revision == shownRevision) return;
            shownRevision = frame.Revision;
            if (commNote.Text.StartsWith("参数块读取失败", StringComparison.Ordinal))
            {
                commNote.Text = DefaultComm;
                commNote.ForeColor = System.Drawing.Color.FromArgb(120, 126, 134);
            }
            FillGrid();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void FillGrid()
        {
            Snapshot frame;
            lock (gate) { frame = snapshot; }
            var category = tabs.SelectedIndex;
            grid.SuspendLayout();
            grid.Rows.Clear();
            var shown = 0;
            foreach (var param in station.Params.Items)
            {
                if (CategoryOf(param.Name) != category) continue;
                shown++;
                var text = "--";
                var result = "—";
                var ng = false;
                if (frame != null && frame.Values != null)
                {
                    var index = param.Index(PlcAddresses.ParamBlockStart);
                    var value = index >= 0 && index < frame.Values.Length ? frame.Values[index] : double.NaN;
                    if (!double.IsNaN(value))
                    {
                        text = value.ToString("0.###");
                        ng = value < param.Lower || value > param.Upper;
                        result = ng ? "NG" : "OK";
                    }
                }
                var row = grid.Rows.Add(shown, "本机", param.Name,
                    param.Lower.ToString("0.###"), param.Upper.ToString("0.###"), text, result);
                if (ng)
                {
                    grid.Rows[row].DefaultCellStyle.BackColor = RowNg;
                    grid.Rows[row].Cells[colResult.Index].Style.ForeColor = NgText;
                }
            }
            grid.ResumeLayout();
        }

        /// <summary>
        /// 参数名称.csv 没有分类列，先按名称关键字归入三页；
        /// 码表补上"分类"列后，把这里换成读列即可，页面其它地方不动。
        /// </summary>
        private static int CategoryOf(string name)
        {
            if (name.IndexOf("CCD", StringComparison.OrdinalIgnoreCase) >= 0
                || name.IndexOf("视觉", StringComparison.Ordinal) >= 0
                || name.IndexOf("曝光", StringComparison.Ordinal) >= 0
                || name.IndexOf("定位", StringComparison.Ordinal) >= 0
                || name.IndexOf("纠偏", StringComparison.Ordinal) >= 0) return 1;
            if (name.IndexOf("送进", StringComparison.Ordinal) >= 0
                || name.IndexOf("回抽", StringComparison.Ordinal) >= 0
                || name.IndexOf("提升", StringComparison.Ordinal) >= 0
                || name.IndexOf("机械手", StringComparison.Ordinal) >= 0) return 2;
            return 0;
        }

        private sealed class Snapshot
        {
            public int Revision;
            public double[] Values;
            public string Error;
        }
    }
}
