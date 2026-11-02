using Mes.Business;
using System;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 报警历史（《Automation UI V3.11》P32）：按起止时间查机台报过的警，
    /// 一行"时刻,代码,描述"。数据取 Uptime 台账里 类型=故障 的流水，不再另存一份历史。
    /// </summary>
    public partial class PageAlarmHistory : UserControl
    {
        private readonly StationContext station;

        public PageAlarmHistory()
        {
            InitializeComponent();
        }

        public PageAlarmHistory(StationContext station) : this()
        {
            this.station = station;
            var now = DateTime.Now;
            fromPicker.Value = now.AddHours(-24);
            toPicker.Value = now;
            Query();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            Query();
        }

        private void Query()
        {
            if (station == null) return;
            var from = fromPicker.Value;
            var to = toPicker.Value;
            if (to <= from)
            {
                station.Say("结束时间必须晚于起始时间，请重新选择");
                return;
            }
            var records = AlarmReport.FromUptime(station.Uptime.All(), station.Alarms, from, to);
            list.BeginUpdate();
            list.Items.Clear();
            foreach (var record in records)
            {
                var line = new StringBuilder();
                line.Append(record.Start.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));
                line.Append(',').Append(record.Code);
                line.Append(',').Append(record.Text);
                if (record.Minutes > 0)
                {
                    line.Append("（").Append(record.Minutes.ToString("0.###", CultureInfo.InvariantCulture))
                        .Append(" 分钟）");
                }
                list.Items.Add(line.ToString());
            }
            list.EndUpdate();
            if (records.Count == 0) list.Items.Add("所选时间段没有报警记录");
        }
    }
}
