using Mes.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 时间明细（《Automation UI V3.11》P10）：上方是动作单元耗时卡片，点一张卡片，
    /// 下方列出该组最近样本。颜色按"实际 / 规划"分绿、黄、红，标准来自 数据\时间明细标准.csv。
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
        private string chipsKey = string.Empty;

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

                var isSelected = group == selected;
                cardPanels[i].BackColor = isSelected ? Selected : CardBorder;
                cardPanels[i].Padding = new Padding(isSelected ? 2 : 1);
                cardTitleLabels[i].BackColor = isSelected ? Selected : CardTitle;
                cardTitleLabels[i].ForeColor = isSelected ? Color.White : CardTitleText;
            }
        }

        private void RefreshDetail()
        {
            var samples = station.Timing.Snapshot(selected);
            var standard = station.Timing.Standard(selected);
            detailTitle.Text = selected;

            var key = selected + "|" + standard + "|" + samples.Length + "|"
                + (samples.Length > 0 ? samples[samples.Length - 1].ToString("0.###") : string.Empty);
            if (key == chipsKey) return;
            chipsKey = key;
            chips.SuspendLayout();
            chips.Controls.Clear();
            if (samples.Length == 0)
            {
                chips.Controls.Add(new Label
                {
                    Text = "该组还没有耗时样本；机台走过一次就会出现在这里。",
                    AutoSize = true,
                    Font = new Font("微软雅黑", 10F),
                    ForeColor = Gray,
                    Margin = new Padding(6, 10, 6, 6),
                });
            }
            else
            {
                for (var i = 0; i < samples.Length; i++)
                {
                    chips.Controls.Add(Chip("样本 " + (i + 1), samples[i], standard));
                }
            }
            chips.ResumeLayout();
        }

        private static Control Chip(string caption, double milliseconds, double standardSeconds)
        {
            var panel = new Panel
            {
                Size = new Size(132, 60),
                Margin = new Padding(4, 4, 10, 4),
                BackColor = Color.White,
                Padding = new Padding(1),
            };
            panel.Controls.Add(new Label
            {
                Text = caption,
                Dock = DockStyle.Top,
                Height = 22,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("微软雅黑", 8.5F),
                ForeColor = CardTitleText,
            });
            panel.Controls.Add(new Label
            {
                Text = PercentText(milliseconds, standardSeconds),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("微软雅黑", 10F, FontStyle.Bold),
                ForeColor = Color.White,
                BackColor = ColorFor(milliseconds, standardSeconds),
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
            if (standardSeconds <= 0) return (milliseconds / 1000).ToString("0.000") + "s";
            return (milliseconds / 1000 / standardSeconds * 100).ToString("0.000") + "%";
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
