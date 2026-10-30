using Mes.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Mes.Business
{
    /// <summary>
    /// 登录用的密码表。
    ///
    /// 现场这五个值在 setting.ini 的 [PassWord] 段（Operator_pwd / Technician_pwd / Engineer_pwd /
    /// Administrator_pwd / SuperAdministrator_pwd，主项目 MainFrm.cs:386 开机读进 Global）。
    /// 本机另存一张 数据\权限密码.csv，第一列是等级的中文显示名。
    ///
    /// 和主项目同一件事：密码不写死在代码里，改它不用重新编译。
    ///
    /// 做成实例而不是 static：静态的密码表看不出是谁在什么时候 Load 的，
    /// 而它必须等 StationContext 把 数据\ 目录读出来之后才有效，所以跟着上下文走。
    /// </summary>
    public class PasswordStore
    {
        private readonly Dictionary<string, string> table =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>读到的条数，启动自检用：表缺失时登录页要能提示"密码表没读到"，而不是默认放行。</summary>
        public int Count { get { return table.Count; } }

        public void Load(string file)
        {
            table.Clear();
            var lines = TextFile.ReadAllLines(file, CodePages.Gbk());
            for (var i = 1; i < lines.Length; i++)      // 第 0 行是表头：等级,密码,现场对应项,说明
            {
                var cols = lines[i].Split(',');
                if (cols.Length < 2) continue;
                table[cols[0].Trim()] = cols[1].Trim();
            }
        }

        /// <summary>
        /// 这一级的密码。表里没这一级就退回"等级名就是密码"，
        /// 免得因为一个 csv 缺行而谁都登不进去（现场进不去的代价是整台机停线等人）。
        /// </summary>
        public string Of(LoginLevel level)
        {
            var title = AccessPolicy.Title(level);
            string password;
            return table.TryGetValue(title, out password) ? password : title;
        }

        private static string[] CsvRead(string line)
        {
            return line.Split(',');
        }
    }
}
