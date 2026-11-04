using Mes.Business;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi.Home
{
    /// <summary>
    /// 时间明细（《Automation UI V3.11》P10）：上方一行分组标题栏，点一组，下方列出这一组的各细项
    /// （动作单元、一次通讯操作）耗时占比。颜色按"实际 / 规划"分绿黄红，标准来自 数据\时间明细标准.csv。
    /// </summary>
    public partial class PageTimeDetail : UserControl
    {
        private static readonly Color Green = Color.FromArgb(0, 160, 70);
        private static readonly Color Yellow = Color.FromArgb(235, 175, 20);
        private static readonly Color Red = Color.FromArgb(200, 55, 55);
        private static readonly Color Gray = Color.FromArgb(150, 156, 164);
        private static readonly Color CardBorder = Color.FromArgb(200, 205, 212);
        private static readonly Color CardTitle = Color.FromArgb(228, 231, 235);
        private static readonly Color CardTitleText = Color.FromArgb(60, 66, 72);
        private static readonly Color Selected = Color.FromArgb(25, 90, 175);

        private readonly StationContext station;
        private Panel[] cardPanels;
        private Label[] cardTitleLabels;
        private Label[] cardValueLabels;
        private string selected = TimingBoard.Flow1;
        private readonly List<string> chipItems = new List<string>();
        private readonly List<Label> chipValues = new List<Label>();

        public PageTimeDetail()
        {
            InitializeComponent();
        }

        public PageTimeDetail(StationContext station) : this()
        {
            this.station = station;
            cardPanels = new[] { card1, card2, card3, card4, card5, card6, card7, card8 };
            cardTitleLabels = new[] { cardTitle1, cardTitle2, cardTitle3, cardTitle4, cardTitle5, cardTitle6, cardTitle7, cardTitle8 };
            cardValueLabels = new[] { cardValue1, cardValue2, cardValue3, cardValue4, cardValue5, cardValue6, cardValue7, cardValue8 };
            for (var i = 0; i < cardPanels.Length; i++)
            {
                cardPanels[i].Click += groupCard_Click;
                cardTitleLabels[i].Click += groupCard_Click;
                cardValueLabels[i].Click += groupCard_Click;
            }
            refresh.Enabled = true;
            RefreshCards();
            RefreshDetail();
        }

        private void refresh_Tick(object sender, EventArgs e)
        {
            RefreshCards();
            RefreshDetail();
        }

        private void groupCard_Click(object sender, EventArgs e)
        {
            var control = sender as Control;
            if (control == null || control.Tag == null) return;
            selected = control.Tag.ToString();
            RefreshCards();
            RefreshDetail();
        }

        private void RefreshCards()
        {
            for (var i = 0; i < cardPanels.Length; i++)
            {
                var group = cardPanels[i].Tag.ToString();
                var average = station.Timing.Average(group);
                var standard = station.Timing.Standard(group);
                SetText(cardValueLabels[i], PercentText(average, standard));
                cardValueLabels[i].BackColor = ColorFor(average, standard);

                // 文档 P10 只把选中分组的名字块涂蓝，百分比块始终按绿黄红走
                var isSelected = group == selected;
                cardPanels[i].BackColor = CardBorder;
                cardPanels[i].Padding = new Padding(1);
                cardTitleLabels[i].BackColor = isSelected ? Selected : CardTitle;
                cardTitleLabels[i].ForeColor = isSelected ? Color.White : CardTitleText;
            }
        }

        /// <summary>细项块只在换分组或码表增删细项时重建，平时每秒只改文字和底色，免得闪。</summary>
        private void RefreshDetail()
        {
            var items = station.Timing.ItemNames(selected);
            detailTitle.Text = selected;
            if (!SameItems(items)) Rebuild(items);

            for (var i = 0; i < items.Count; i++)
            {
                var average = station.Timing.ItemAverage(selected, items[i]);
                var standard = station.Timing.ItemStandard(selected, items[i]);
                SetText(chipValues[i], PercentText(average, standard));
                chipValues[i].BackColor = ColorFor(average, standard);
            }
        }

        private bool SameItems(List<string> items)
        {
            if (items.Count != chipItems.Count) return false;
            for (var i = 0; i < items.Count; i++)
            {
                if (items[i] != chipItems[i]) return false;
            }
            return true;
        }

        private void Rebuild(List<string> items)
        {
            chips.SuspendLayout();
            chips.Controls.Clear();
            chipItems.Clear();
            chipValues.Clear();
            if (items.Count == 0)
            {
                chips.Controls.Add(new Label
                {
                    Text = "码表 时间明细标准.csv 里没给「" + selected + "」登记细项。",
                    AutoSize = true,
                    Font = new Font("微软雅黑", 10F),
                    ForeColor = Gray,
                    Margin = new Padding(6, 10, 6, 6),
                });
            }
            for (var i = 0; i < items.Count; i++)
            {
                Label value;
                chips.Controls.Add(Chip(items[i], out value));
                chipItems.Add(items[i]);
                chipValues.Add(value);
            }
            chips.ResumeLayout();
        }

        private static Control Chip(string caption, out Label value)
        {
            var panel = new Panel
            {
                Size = new Size(132, 60),
                Margin = new Padding(4, 4, 10, 4),
                BackColor = Color.White,
                Padding = new Padding(1),
            };
            value = new Label
            {
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("微软雅黑", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = Gray,
            };
            // 后 Add 的先布局：标题条先贴顶占掉 22px，百分比再填满剩下的地方；
            // 反过来加会让 Fill 先吃掉整块，细项名直接被挤没
            panel.Controls.Add(value);
            panel.Controls.Add(new Label
            {
                Text = caption,
                Dock = DockStyle.Top,
                Height = 22,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("微软雅黑", 8.5F),
                ForeColor = CardTitleText,
            });
            return panel;
        }

        private static void SetText(Label label, string text)
        {
            if (label.Text != text) label.Text = text;
        }

        private static string PercentText(double milliseconds, double standardSeconds)
        {
            if (double.IsNaN(milliseconds)) return "--";
            if (standardSeconds <= 0) return (milliseconds / 1000).ToString("0.00") + "s";
            return (milliseconds / 1000 / standardSeconds * 100).ToString("0.00") + "%";
        }

        private static Color ColorFor(double milliseconds, double standardSeconds)
        {
            if (double.IsNaN(milliseconds) || standardSeconds <= 0) return Gray;
            if (milliseconds <= standardSeconds * 1000) return Green;
            if (milliseconds <= standardSeconds * 1500) return Yellow;
            return Red;
        }
    }
}
