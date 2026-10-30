using System;
using System.Collections.Concurrent;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using log4net;
using log4net.Config;

namespace Mes.Common
{
    /// <summary>
    /// log4net 门面：所有类共用一组扩展方法，日志器按调用类型分名，配置文件只需改 appender。
    ///
    /// 两条规矩：
    /// 1) 初始化失败绝不能抛。静态构造函数一炸，整个上位机连窗口都出不来——
    ///    日志坏了要继续生产，不是停机；失败原因留在 ConfigurationError 里给启动自检看。
    /// 2) 配置和日志路径都从 exe 目录算，不写相对路径也不写死盘符。
    ///    快捷方式启动时工作目录不是 exe 目录，现场路径换一台机器就不存在。
    /// </summary>
    public static class LogHelper
    {
        private static readonly ConcurrentDictionary<Type, ILog> loggers = new ConcurrentDictionary<Type, ILog>();

        private static bool initialized;

        /// <summary>配置没读到时的原因，界面/启动自检要能看见，而不是藏在异常里。</summary>
        public static string ConfigurationError { get; private set; }

        /// <summary>实际生效的配置文件路径；null 表示没用上任何配置。</summary>
        public static string ConfigFile { get; private set; }

        static LogHelper()
        {
            Initialize();
        }

        public static void Initialize()
        {
            if (initialized) return;
            var file = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "log4net.config");
            try
            {
                if (!File.Exists(file))
                {
                    ConfigurationError = "找不到日志配置：" + file;
                    return;
                }
                // 日志目录由代码给出，配置里用 %property{LogDir} 取。
                // 配置里写死绝对路径（D:\HG\…）换一台机器就全写不出去，
                // 而 log4net 写不出去是一句不响的——现场以为有日志，出事后才发现是空的。
                GlobalContext.Properties["LogDir"] = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Logs");
                XmlConfigurator.Configure(LogManager.GetRepository(Assembly.GetEntryAssembly()), new FileInfo(file));
                ConfigFile = file;
            }
            catch (Exception ex)
            {
                ConfigurationError = "日志配置加载失败：" + ex.Message;
            }
            finally
            {
                // 不管成没成都只试一次，避免每次打日志都重读配置
                initialized = true;
            }
        }

        public static ILog GetLogger<T>() where T : class
        {
            return loggers.GetOrAdd(typeof(T), LogManager.GetLogger);
        }

        public static void Debug<T>(this T sender, object message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0) where T : class
        {
            var log = GetLogger<T>();
            if (log.IsDebugEnabled) log.Debug(Head(sourceFilePath, sourceLineNumber, memberName) + message);
        }

        public static void Info<T>(this T sender, object message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0) where T : class
        {
            var log = GetLogger<T>();
            if (log.IsInfoEnabled) log.Info(Head(sourceFilePath, sourceLineNumber, memberName) + message);
        }

        public static void Warn<T>(this T sender, object message,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0) where T : class
        {
            var log = GetLogger<T>();
            if (log.IsWarnEnabled) log.Warn(Head(sourceFilePath, sourceLineNumber, memberName) + message);
        }

        public static void Error<T>(this T sender, object message, Exception ex = null,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0) where T : class
        {
            var log = GetLogger<T>();
            if (!log.IsErrorEnabled) return;
            var text = Head(sourceFilePath, sourceLineNumber, memberName) + message;
            if (ex == null) log.Error(text);
            else log.Error(text, ex);
        }

        public static void Fatal<T>(this T sender, object message, Exception ex = null,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0) where T : class
        {
            var log = GetLogger<T>();
            if (!log.IsFatalEnabled) return;
            var text = Head(sourceFilePath, sourceLineNumber, memberName) + message;
            if (ex == null) log.Fatal(text);
            else log.Fatal(text, ex);
        }

        /// <summary>
        /// PLC 读写流水。单独一个方法是因为它量最大：排查"这个地址到底发没发出去"时，
        /// 要能把通讯流水从操作日志里分出来看。走 Info 级，配合 log4net 里的 PlcFileAppender。
        /// </summary>
        public static void PlcTrace<T>(this T sender, string address, object value, bool isRead,
            [CallerMemberName] string memberName = "",
            [CallerFilePath] string sourceFilePath = "",
            [CallerLineNumber] int sourceLineNumber = 0) where T : class
        {
            var log = GetLogger<T>();
            if (!log.IsInfoEnabled) return;
            log.Info(Head(sourceFilePath, sourceLineNumber, memberName)
                + (isRead ? "PLC读 " : "PLC写 ") + address + " = " + Text(value));
        }

        private static string Head(string sourceFilePath, int sourceLineNumber, string memberName)
        {
            return "[" + Path.GetFileName(sourceFilePath) + ":" + sourceLineNumber + " " + memberName + "] ";
        }

        /// <summary>数组直接 ToString 只会得到类型名，日志里等于没写，所以逐个拼。</summary>
        private static string Text(object value)
        {
            var words = value as short[];
            if (words != null) return "[" + string.Join(",", words) + "]";
            var numbers = value as double[];
            if (numbers != null) return "[" + string.Join(",", numbers) + "]";
            var bytes = value as byte[];
            if (bytes != null) return "[" + string.Join(",", bytes) + "]";
            return Convert.ToString(value, CultureInfo.InvariantCulture);
        }
    }
}
