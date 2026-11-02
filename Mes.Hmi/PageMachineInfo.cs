using Mes.Business;
using Mes.Common;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 设备信息（《Automation UI V3.11》P41）：上面两张卡片是硬件与软件版本，
    /// 下面整块是程序更新记录。
    ///
    /// 软件框架版本不写在 数据\设备信息.csv 里——那一行只有和真正跑着的程序一致才有意义，
    /// 所以直接读程序集版本；改版本号时 AssemblyInfo 和这张画面一起变。
    /// </summary>
    public partial class PageMachineInfo : UserControl
    {
        public PageMachineInfo()
        {
            InitializeComponent();
        }

        public PageMachineInfo(StationContext station) : this()
        {
            var hardware = station == null ? new List<DeviceInfo>() : station.Device.Of("硬件");
            if (hardware.Count == 0) Add(hwRows, "未登记：检查 数据\\设备信息.csv 的「硬件」分组");
            foreach (var item in hardware) Add(hwRows, item.Name + "： " + item.Value);

            Add(swRows, "软件框架版本： " + typeof(PageMachineInfo).Assembly.GetName().Version);
            var flow = station == null ? string.Empty : station.Device.Value("流程图版本");
            Add(swRows, "流程图版本： " + (string.IsNullOrEmpty(flow) ? "未登记" : flow));
            Pad(hwRows);
            Pad(swRows);

            ShowChangeLog();
        }

        /// <summary>末尾垫一条百分比空行：TableLayoutPanel 会把多余高度全给最后一行，不垫的话最后一行字会掉到卡片中间。</summary>
        private static void Pad(TableLayoutPanel panel)
        {
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            panel.RowCount = panel.RowCount + 1;
        }

        private void Add(TableLayoutPanel panel, string text)
        {
            var row = panel.RowCount;
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            panel.RowCount = row + 1;
            panel.Controls.Add(new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                Font = new Font("微软雅黑", 9.5F),
                ForeColor = Color.FromArgb(45, 50, 55),
                TextAlign = ContentAlignment.MiddleLeft,
            }, 0, row);
        }

        private void ShowChangeLog()
        {
            var file = Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "CHANGELOG.md");
            var lines = TextFile.ReadAllLines(file, CodePages.Utf8WithBom());
            if (lines.Length == 0)
            {
                logBox.Text = "没读到 " + file + "\r\n更新记录由仓库根目录的 CHANGELOG.md 随程序拷到运行目录，改版本号时一起更新。";
                return;
            }
            var sb = new StringBuilder();
            foreach (var line in lines) sb.AppendLine(line);
            logBox.Text = sb.ToString();
            logBox.SelectionStart = 0;
            logBox.ScrollToCaret();
        }
    }
}
