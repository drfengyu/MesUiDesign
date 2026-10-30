using System;
using System.IO;
using System.Text;

namespace Mes.Common
{
    /// <summary>
    /// 文本文件读写的统一入口。单独拿出来是因为两类现场情况：
    /// 程序可能装在 U 盘/移动硬盘上（路径随时断），也可能有人正用 Excel 开着这些 csv
    /// （文件被占用）。这两种都只该丢掉这一次写入，绝不能把生产停掉。
    /// </summary>
    public static class TextFile
    {
        public static bool Exists(string path)
        {
            return File.Exists(path);
        }

        /// <summary>读整表。文件被占用或不存在时返回空数组，由调用方决定"这张表算没有"。</summary>
        public static string[] ReadAllLines(string path, Encoding encoding)
        {
            try
            {
                return File.Exists(path) ? File.ReadAllLines(path, encoding) : new string[0];
            }
            catch (IOException)
            {
                return new string[0];
            }
            catch (UnauthorizedAccessException)
            {
                return new string[0];
            }
        }

        public static bool AppendAllText(string path, string text, Encoding encoding)
        {
            return Write(path, text, encoding, false);
        }

        public static bool WriteAllText(string path, string text, Encoding encoding)
        {
            return Write(path, text, encoding, true);
        }

        private static bool Write(string path, string text, Encoding encoding, bool overwrite)
        {
            try
            {
                var dir = Path.GetDirectoryName(path);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                if (overwrite) File.WriteAllText(path, text, encoding);
                else File.AppendAllText(path, text, encoding);
                return true;
            }
            catch (IOException)
            {
                return false;
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }
    }
}
