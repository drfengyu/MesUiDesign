using Mes.Business;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 上传设置（《Automation UI V3.11》P30）：Trace / PDCA / OEE 三个分组，每组一个专案下的键值表。
    ///
    /// 文档里这份配置写在 Config\ParamPage.ini，本机没有那个 ini，改成读写同一结构的
    /// 数据\上传设置.csv——键、分组、专案都在表里，现场加一路上传只加行不改代码。
    /// </summary>
    public partial class PageUploadSetting : UserControl
    {
        private static readonly Color ReadBack = Color.FromArgb(246, 248, 250);
        private static readonly Color EditBack = Color.White;

        private readonly StationContext station;
        private readonly string file;
        private bool editing;

        public PageUploadSetting()
        {
            InitializeComponent();
        }

        public PageUploadSetting(StationContext station) : this()
        {
            this.station = station;
            this.file = Path.Combine(station.DataFolder, "上传设置.csv");
            foreach (var project in station.Upload.Projects) comboProject.Items.Add(project);
            if (comboProject.Items.Count > 0) comboProject.SelectedIndex = 0;
            Fill();
        }

        private string Group { get { return tabs.SelectedTab != null ? tabs.SelectedTab.Text : "Trace"; } }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill();
        }

        private void comboProject_SelectedIndexChanged(object sender, EventArgs e)
        {
            Fill();
        }

        private void Fill()
        {
            var project = Convert.ToString(comboProject.SelectedItem);
            grid.SuspendLayout();
            grid.Rows.Clear();
            foreach (var item in station.Upload.Of(project, Group))
            {
                grid.Rows.Add(item.Key, item.Value);
            }
            grid.ClearSelection();
            grid.ResumeLayout();
            ApplyEditing();
        }

        private void ApplyEditing()
        {
            grid.ReadOnly = !editing;
            colValue.DefaultCellStyle.BackColor = editing ? EditBack : ReadBack;
            btnModify.Text = editing ? "保存修改" : "修改";
        }

        /// <summary>文档里那颗绿色"设置"按钮：从表里重读一遍，丢弃界面上没保存的改动。</summary>
        private void btnLoad_Click(object sender, EventArgs e)
        {
            station.Upload.Load(file);
            var keep = Convert.ToString(comboProject.SelectedItem);
            comboProject.Items.Clear();
            foreach (var project in station.Upload.Projects) comboProject.Items.Add(project);
            var index = comboProject.Items.IndexOf(keep);
            comboProject.SelectedIndex = index >= 0 ? index : (comboProject.Items.Count > 0 ? 0 : -1);
            editing = false;
            Fill();
            station.Say("已重新载入上传设置");
        }

        /// <summary>文档里那颗黄色"修改"按钮：第一次点开允许改值，再点把改动写回表并记日志。</summary>
        private void btnModify_Click(object sender, EventArgs e)
        {
            if (!editing)
            {
                if (station.Level < LoginLevel.Administrator)
                {
                    station.Say("需要管理员以上权限才能修改上传设置");
                    return;
                }
                editing = true;
                ApplyEditing();
                station.Say("已进入修改状态，改完再点一次保存");
                return;
            }

            var project = Convert.ToString(comboProject.SelectedItem);
            var changed = 0;
            foreach (DataGridViewRow row in grid.Rows)
            {
                if (row.IsNewRow) continue;
                var key = Convert.ToString(row.Cells[colKey.Index].Value);
                var value = Convert.ToString(row.Cells[colValue.Index].Value);
                if (key.Length == 0) continue;
                if (!station.Upload.SetValue(project, Group, key, value)) continue;
                changed++;
                station.Log.Write(station.User, "上传设置修改", project + "/" + Group + "/" + key,
                    value, string.Empty);
            }
            if (changed == 0)
            {
                editing = false;
                ApplyEditing();
                station.Say("没有需要保存的改动");
                return;
            }
            if (!station.Upload.Save(file))
            {
                station.Say("写入失败：" + file);
                return;
            }
            editing = false;
            ApplyEditing();
            station.Say("已保存 " + changed.ToString(System.Globalization.CultureInfo.InvariantCulture)
                + " 项上传设置到 " + file);
        }
    }
}
