using Mes.Business;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 整机视图（UI 文档 P31 区域2 / P34 区域3）：把 数据\机台区域.csv 的部位摆成一块块标记，
    /// 报警命中哪个模组，哪个标记就闪红灯。
    ///
    /// 做成静态帮助类而不是控件：两个页面都要用，但版面各摆各的，
    /// 帮助类只负责"往给定面板里放标记、按报警改颜色"，不新增一层控件。
    /// </summary>
    internal static class MachineMap
    {
        private const int MarkerWidth = 116;
        private const int MarkerHeight = 34;

        private static readonly Color IdleBack = Color.FromArgb(226, 231, 237);
        private static readonly Color IdleText = Color.FromArgb(70, 78, 88);
        private static readonly Color LitStrong = Color.FromArgb(214, 45, 45);
        private static readonly Color LitDim = Color.FromArgb(140, 30, 30);
        private static readonly Color SelectedBack = Color.FromArgb(250, 190, 40);

        public static void Build(Panel host, ZoneCatalog zones)
        {
            host.Controls.Clear();
            host.BackColor = Color.FromArgb(240, 243, 246);
            foreach (var zone in zones.Items)
            {
                var marker = new Label
                {
                    Name = "zone." + zone.Module,
                    Text = zone.Name,
                    Tag = zone,
                    BorderStyle = BorderStyle.None,
                    TextAlign = ContentAlignment.MiddleCenter,
                    Font = new Font("微软雅黑", 9F, FontStyle.Bold),
                    Size = new Size(MarkerWidth, MarkerHeight),
                };
                host.Controls.Add(marker);
            }
            Layout(host);
        }

        /// <summary>按百分比坐标重摆一遍：面板尺寸随窗口变，标记要跟着走。</summary>
        public static void Layout(Panel host)
        {
            var w = System.Math.Max(1, host.ClientSize.Width);
            var h = System.Math.Max(1, host.ClientSize.Height);
            foreach (Control control in host.Controls)
            {
                var zone = control.Tag as MachineZone;
                if (zone == null) continue;
                var x = (int)(w * zone.X / 100D) - MarkerWidth / 2;
                var y = (int)(h * zone.Y / 100D) - MarkerHeight / 2;
                control.Location = new Point(
                    System.Math.Max(2, System.Math.Min(w - control.Width - 2, x)),
                    System.Math.Max(2, System.Math.Min(h - control.Height - 2, y)));
            }
        }

        public static void Paint(Panel host, ICollection<string> litModules, string selected, bool blink)
        {
            foreach (Control control in host.Controls)
            {
                var zone = control.Tag as MachineZone;
                if (zone == null) continue;
                var lit = litModules != null && litModules.Contains(zone.Module);
                var isSelected = selected != null && selected == zone.Module;
                if (lit)
                {
                    control.BackColor = blink ? LitStrong : LitDim;
                    control.ForeColor = Color.White;
                    control.Text = "● " + zone.Name;
                }
                else
                {
                    control.BackColor = isSelected ? SelectedBack : IdleBack;
                    control.ForeColor = IdleText;
                    control.Text = zone.Name;
                }
            }
        }

        /// <summary>当前点亮了哪些模组代码。</summary>
        public static List<string> LitOf(IEnumerable<AlarmRecord> records)
        {
            var modules = new List<string>();
            foreach (var record in records)
            {
                if (string.IsNullOrEmpty(record.Module) || modules.Contains(record.Module)) continue;
                modules.Add(record.Module);
            }
            return modules;
        }
    }
}
