using Mes.Common;
using System;
using System.Collections.Generic;

namespace Mes.Data
{
    /// <summary>
    /// 生产追溯表（ProductLog）。列名与主项目 MainFrm.cs 里那几条 SQL 一字不差：
    ///
    ///   insert into ProductLog([生产时间],[产品码],[流程开始时间]) values(...)        ← PLC_CheckIn1 @2065
    ///   update ProductLog set [治具号]='…' where [产品码]='…'                          ← PLC_SendSN  @2164
    ///   update ProductLog set [结果]='…',[流程结束时间]='…' where [产品码]='…'          ← PLC_ProductLog@1431
    ///   update ProductLog set [结果]='OK',[焊接开始时间]=…,[焊接结束时间]=…,CT=…,Height=… ← PLC_PDCA @2817
    ///
    /// [结果] 的取值也是抄真的：左扫码NG / 左工位焊前校验NG / CCD1拍照NG / 左CCD2拍照NG /
    /// 左焊前确认NG / 左焊接NG / 左焊后过站NG / 左探高NG（右侧同理），OK 才放行。
    ///
    /// 列名保持中文是刻意的：它们对应现场数据库的列，不是代码标识符；
    /// 改成英文就对不上真项目的那几条 SQL，上传追溯时两边数据接不起来。
    /// </summary>
    public class ProductLogTable : RecordTable
    {
        public static readonly string[] Columns =
        {
            "生产时间", "产品码", "结果", "流程开始时间", "流程结束时间",
            "治具号", "焊接开始时间", "焊接结束时间", "CT", "Height",
            // 下面这八列是主项目 PLC_CheckOut1 @2455 那条 update 里原样出现的列名，
            // 值分别来自 MC 区(6 个浮点)、BOSS 区(6 个浮点)、WD 区(4 个浮点)的前几个。
            "MC纠偏X", "MC纠偏Y", "MC纠偏R", "贴合纠偏X", "贴合纠偏Y", "贴合纠偏R", "微动补偿X", "微动补偿Y",
        };

        public ProductLogTable(string folder) : base(folder, "ProductLog", Columns)
        {
        }

        /// <summary>报站：产品码进机台，先落一条空结果记录。</summary>
        public void ReportArrival(string productCode)
        {
            var now = Now();
            Insert(new Record
            {
                ["生产时间"] = now,
                ["产品码"] = productCode,
                ["流程开始时间"] = now,
            });
        }

        public void AttachFixture(string productCode, string fixtureNo)
        {
            Update(r => r.Get("产品码") == productCode, r => r["治具号"] = fixtureNo);
        }

        /// <summary>流程结束：结果写 OK 或上面那串 NG 名。</summary>
        public void Complete(string productCode, string result)
        {
            Update(r => r.Get("产品码") == productCode && string.IsNullOrEmpty(r.Get("流程结束时间")),
                r =>
                {
                    r["结果"] = result;
                    r["流程结束时间"] = Now();
                });
        }

        /// <summary>
        /// 回填三块测量区读回来的尺寸。对应主项目 PLC_CheckOut1 @2455 那条 update：
        /// MC 区给 纠偏X/Y/R，BOSS 区给 贴合纠偏X/Y/R，WD 区给 微动补偿X/Y。
        /// Height 取 BOSS 的第一个浮点（柱高就是贴合高度的基准）。
        /// </summary>
        public void WriteDimensions(string productCode, double[] mc, double[] boss, double[] wd)
        {
            Update(r => r.Get("产品码") == productCode, r =>
            {
                r["MC纠偏X"] = NumberText.Format(mc[0]);
                r["MC纠偏Y"] = NumberText.Format(mc[1]);
                r["MC纠偏R"] = NumberText.Format(mc[2]);
                r["贴合纠偏X"] = NumberText.Format(boss[0]);
                r["贴合纠偏Y"] = NumberText.Format(boss[1]);
                r["贴合纠偏R"] = NumberText.Format(boss[2]);
                r["微动补偿X"] = NumberText.Format(wd[0]);
                r["微动补偿Y"] = NumberText.Format(wd[1]);
                r["Height"] = NumberText.Format(boss[0]);
            });
        }

        /// <summary>
        /// 焊完回填焊接起止与 CT，对应主项目 PLC_CheckOut1 @2487 那条 update。
        /// 结果不在这里写：结果由 Complete 按判定写，判 NG 的料不能因为回填就变成 OK。
        /// </summary>
        public void WriteWelding(string productCode, string weldStart, string weldEnd, double ct)
        {
            Update(r => r.Get("产品码") == productCode, r =>
            {
                r["焊接开始时间"] = weldStart;
                r["焊接结束时间"] = weldEnd;
                r["CT"] = NumberText.Format(ct);
            });
        }

        /// <summary>按条码追溯：一片料可能有两条（返工重投），所以返回列表不是单个。</summary>
        public List<Record> FindByProductCode(string productCode)
        {
            var hits = new List<Record>();
            Scan(r =>
            {
                if (r.Get("产品码") == productCode) hits.Add(new Record(r));
            });
            return hits;
        }

        private static string Now()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
