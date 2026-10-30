using Mes.Data;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Mes.Business
{
    /// <summary>一批次（开机或按"重置批次统计数据"之后）的产能摘要。</summary>
    public class BatchNumbers
    {
        public int Input;
        public int Completed;
        public int Passed;
        public int Ng;
        public double AverageCt;

        /// <summary>良率按"走完流程的片子里第一遍就 OK 的比例"算，和 RFP 的 1stPassYield 同口径。</summary>
        public double Yield
        {
            get { return Completed <= 0 ? 0 : Passed * 100D / Completed; }
        }
    }

    /// <summary>
    /// 批次统计：区域9 那五行数字的来源。
    ///
    /// 只记一个"起算时刻"，数字每次现从追溯表算：
    /// 自己再维护一套计数器，程序一崩就对不上表，重启后界面显示的比实际多——
    /// 现场最烦的就是"屏幕说 100 片、导出只有 97 片"。
    /// </summary>
    public class BatchSummary
    {
        private readonly ProductLogTable log;
        private DateTime since = DateTime.Now;

        public BatchSummary(ProductLogTable log)
        {
            this.log = log;
        }

        public DateTime Since { get { return since; } }

        public void Reset()
        {
            since = DateTime.Now;
        }

        public BatchNumbers Read()
        {
            var n = new BatchNumbers();
            double ctSum = 0;
            var ctCount = 0;
            // 只统计不取快照：All() 会先把整张表逐行复制一遍，界面每半秒调一次，
            // 记录上千条就是每半秒 new 上千个字典。Scan 在表内直接过一遍。
            log.Scan(row =>
            {
                DateTime at;
                if (!DateTime.TryParse(row.Get("生产时间"), out at) || at < since) return;
                n.Input++;
                if (!string.IsNullOrEmpty(row.Get("流程结束时间"))) n.Completed++;
                var verdict = row.Get("结果");
                if (verdict == "OK") n.Passed++;
                else if (verdict.EndsWith("NG")) n.Ng++;
                double ct;
                if (double.TryParse(row.Get("CT"), NumberStyles.Float, CultureInfo.InvariantCulture, out ct))
                {
                    ctSum += ct;
                    ctCount++;
                }
            });
            n.AverageCt = ctCount == 0 ? 0 : ctSum / ctCount;
            return n;
        }
    }
}
