using Mes.Common;
using System;
using System.IO;

namespace Mes.Data
{
    /// <summary>
    /// 操作日志：一天一个文件，制表符分隔，表头 UTF-8 带 BOM（BOM 决定 Excel 双击打开不是乱码）。
    /// 主项目落数据库，这里落文件；字段顺序固定，方便事后用 Excel 透视。
    ///
    /// 它记的是"谁在什么时候改了什么"（登录、改参数、手动点动），
    /// 和 LogHelper 那条通讯流水是两本账，不要混：审核时看的是这本。
    /// </summary>
    public class OperationLog
    {
        private readonly object gate = new object();

        public OperationLog(string folder)
        {
            Folder = folder;
        }

        public readonly string Folder;

        public void Write(string who, string action, string target, string before, string after)
        {
            var line = string.Format("{0:yyyy-MM-dd HH:mm:ss.fff}\t{1}\t{2}\t{3}\t{4}\t{5}",
                DateTime.Now, who, action, target, before, after);
            var file = Path.Combine(Folder, "记录 " + DateTime.Now.ToString("yyyyMMdd") + ".csv");
            lock (gate)
            {
                if (!TextFile.Exists(file))
                {
                    TextFile.WriteAllText(file, "时刻\t操作人\t动作\t对象\t原值\t新值\r\n", CodePages.Utf8WithBom());
                }
                // 日志写失败绝不能影响生产：目录被删、文件被 Excel 占着都会走到这里
                TextFile.AppendAllText(file, line + "\r\n", CodePages.Utf8NoBom());
            }
        }

        /// <summary>界面线程外的异常也要留痕：崩掉的那一次如果没有这行，第二天没人知道发生过什么。</summary>
        public void WriteCrash(string source, Exception error)
        {
            if (error == null) return;
            Write("系统", "异常", source, error.GetType().Name,
                error.Message.Replace("\r", " ").Replace("\n", " "));
        }
    }
}
