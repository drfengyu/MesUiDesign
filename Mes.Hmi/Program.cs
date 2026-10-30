using Mes.Business;
using System;
using System.Threading;
using System.Windows.Forms;

namespace Mes.Hmi
{
    internal static class Program
    {
        /// <summary>
        /// 主入口：建一台机器的上下文（PLC + 码表 + 记录），交给外壳界面。
        /// 页面要什么就从签名上收什么，不去读全局静态。
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var station = StationContext.Create();

            // 触摸屏上没人看控制台，崩掉的那一次如果不落到操作日志，第二天就查不到发生过什么。
            Application.ThreadException += delegate(object sender, ThreadExceptionEventArgs e)
            {
                station.Log.WriteCrash("界面线程", e.Exception);
            };
            AppDomain.CurrentDomain.UnhandledException += delegate(object sender, UnhandledExceptionEventArgs e)
            {
                station.Log.WriteCrash("后台线程", e.ExceptionObject as Exception);
            };

            Application.Run(new ShellForm(station));
            station.Machine.Stop();
        }
    }
}
