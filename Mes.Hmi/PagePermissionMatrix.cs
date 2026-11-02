using Mes.Business;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 权限说明（《Automation UI V3.11》P38）：功能模块 × 五个等级的勾选矩阵。
    ///
    /// 矩阵不是再抄一份表，而是拿 AccessPolicy.Rules 现算：文档这一页要的就是"显示各用户等级对应操作权限"，
    /// 界面上另存一份的话，改权限时两边必然对不上，而这一页恰恰是审核时拿来对的东西。
    /// </summary>
    public partial class PagePermissionMatrix : UserControl
    {
        /// <summary>文档这一排从右往左是按等级从高到低写的，这里照它排。</summary>
        private static readonly string[] ColumnTitles = { "超级管理员", "管理员", "工程师", "技术员", "作业员" };

        private static readonly LoginLevel[] ColumnLevels =
        {
            LoginLevel.SuperAdministrator, LoginLevel.Administrator,
            LoginLevel.Engineer, LoginLevel.Technician, LoginLevel.Operator,
        };

        /// <summary>文档预留的两个模块位，本机没有对应页面，整行不勾。</summary>
        private static readonly string[] ReservedModules = { "备用1", "备用2" };

        private readonly StationContext station;

        public PagePermissionMatrix()
        {
            InitializeComponent();
        }

        public PagePermissionMatrix(StationContext station) : this()
        {
            this.station = station;
            Build();
        }

        private void Build()
        {
            matrix.Controls.Clear();
            matrix.RowStyles.Clear();
            matrix.RowCount = 0;
            AddHeader();
            foreach (var entry in NavEntry.Entries)
            {
                AddRow(entry.Title, entry.Prefix, DetailOf(entry.Prefix));
            }
            foreach (var name in ReservedModules)
            {
                AddRow(name, null, "文档预留的模块位，本机没有对应页面");
            }
            // 末尾垫一条百分比空行：TableLayoutPanel 会把多余高度全塞给最后一行，
            // 不垫这一行，"备用2"那格会被拉到两三百像素高，勾就跑到了行中间。
            matrix.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            matrix.RowCount = matrix.RowCount + 1;
        }

        private void AddHeader()
        {
            var row = NewRow(40F);
            matrix.Controls.Add(Header("功能模块", Color.FromArgb(240, 242, 245), Color.FromArgb(60, 66, 72)), 0, row);
            for (var c = 0; c < ColumnTitles.Length; c++)
            {
                matrix.Controls.Add(Header(ColumnTitles[c], Color.FromArgb(198, 200, 248), Color.FromArgb(40, 45, 60)), c + 1, row);
            }
        }

        /// <summary>加一行并把行高定死：勾是画在格子里的，行高随内容变会看着像没对齐。</summary>
        private int NewRow(float height)
        {
            var row = matrix.RowCount;
            matrix.RowStyles.Add(new RowStyle(SizeType.Absolute, height));
            matrix.RowCount = row + 1;
            return row;
        }

        private void AddRow(string module, string prefix, string detail)
        {
            var row = NewRow(34F);
            var name = new Label
            {
                Text = module,
                Dock = DockStyle.Fill,
                Font = new Font("微软雅黑", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(45, 50, 55),
                TextAlign = ContentAlignment.MiddleCenter,
            };
            matrix.Controls.Add(name, 0, row);
            for (var c = 0; c < ColumnLevels.Length; c++)
            {
                var box = new CheckBox
                {
                    Checked = prefix != null && Allowed(prefix, ColumnLevels[c]),
                    Enabled = false,
                    TabStop = false,
                    Dock = DockStyle.Fill,
                    CheckAlign = ContentAlignment.MiddleCenter,
                };
                matrix.Controls.Add(box, c + 1, row);
            }
            if (!string.IsNullOrEmpty(detail)) toolTip.SetToolTip(name, detail);
        }

        private static Label Header(string text, Color back, Color fore)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                BackColor = back,
                ForeColor = fore,
                Font = new Font("微软雅黑", 9.5F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
            };
        }

        /// <summary>这一模块下有没有该等级能进的页。</summary>
        private static bool Allowed(string prefix, LoginLevel level)
        {
            foreach (var rule in AccessPolicy.Rules)
            {
                if (!rule.Page.StartsWith(prefix)) continue;
                if ((int)level >= (int)rule.Minimum) return true;
            }
            return false;
        }

        /// <summary>鼠标停在模块名上：这一模块每一页要求哪一级，现场对表时只看这一行就够。</summary>
        private static string DetailOf(string prefix)
        {
            var sb = new StringBuilder();
            var rows = new List<string>();
            foreach (var rule in AccessPolicy.Rules)
            {
                if (!rule.Page.StartsWith(prefix)) continue;
                rows.Add(rule.Page.Substring(prefix.Length) + " = " + AccessPolicy.Title(rule.Minimum));
            }
            if (rows.Count == 0) return string.Empty;
            foreach (var line in rows)
            {
                if (sb.Length > 0) sb.Append("\r\n");
                sb.Append(line);
            }
            return sb.ToString();
        }
    }
}
