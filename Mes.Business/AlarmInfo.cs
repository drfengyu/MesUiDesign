namespace Mes.Business
{
    /// <summary>一条报警：来自真"报警目录.csv"的一行。</summary>
    public class AlarmInfo
    {
        /// <summary>表内序号（第 1 列）。PLC 往 MW62001~62005 里写的就是这个数，不是下面的代码。</summary>
        public int Index;

        /// <summary>7 位报警代码，如 6010044</summary>
        public string Code;

        public string Title;
        public int Level;
        public string ModuleCode;

        /// <summary>处理对策全文，现场写得很长，界面上要能滚</summary>
        public string Solution;

        /// <summary>DT 分类：运行 / 机台计划性停机 / 良率非计划性停机 …（算 OEE 靠这一列）</summary>
        public string DtClass;

        public string Category;
        public string TitleEn;
    }
}
