using Mes.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mes.Business
{
    /// <summary>
    /// 登录用的密码表（数据\权限密码.csv）。
    ///
    /// 现场这五个值在 setting.ini 的 [PassWord] 段（Operator_pwd / Technician_pwd / Engineer_pwd /
    /// Administrator_pwd / SuperAdministrator_pwd，主项目 MainFrm.cs:386 开机读进 Global）。
    /// 本机另存一张 csv，列是 等级,密码,现场对应项,说明，编码沿用现场的 GBK。
    ///
    /// 和主项目同一件事：密码不写死在代码里，改它不用重新编译。
    /// 密码修改页（UI 文档 P36 区域2）改完是整表重写：只留 等级→密码 一个字典的话，
    /// "现场对应项"和"说明"两列会在第一次改密码时被抹掉，而这两列正是审核时对到 setting.ini 的依据。
    ///
    /// 做成实例而不是 static：静态的密码表看不出是谁在什么时候 Load 的，
    /// 而它必须等 StationContext 把 数据\ 目录读出来之后才有效，所以跟着上下文走。
    /// </summary>
    public class PasswordStore
    {
        private static readonly string[] Header = { "等级", "密码", "现场对应项", "说明" };

        private readonly List<string[]> rows = new List<string[]>();
        private string path;

        /// <summary>读到的条数，启动自检用：表缺失时登录页要能提示"密码表没读到"，而不是默认放行。</summary>
        public int Count { get { return rows.Count; } }

        /// <summary>等级显示名，顺序就是表里的行序；登录页的"用户名"下拉直接用它。</summary>
        public List<string> Names
        {
            get
            {
                var names = new List<string>();
                foreach (var row in rows) names.Add(row[0]);
                return names;
            }
        }

        public void Load(string file)
        {
            path = file;
            rows.Clear();
            var lines = TextFile.ReadAllLines(file, CodePages.Gbk());
            for (var i = 1; i < lines.Length; i++)      // 第 0 行是表头
            {
                var cols = lines[i].Split(',');
                if (cols.Length < 2) continue;
                rows.Add(new[]
                {
                    cols[0].Trim(),
                    cols[1].Trim(),
                    cols.Length > 2 ? cols[2].Trim() : string.Empty,
                    cols.Length > 3 ? cols[3].Trim() : string.Empty,
                });
            }
        }

        /// <summary>这一级的密码。</summary>
        public string Of(LoginLevel level)
        {
            return Of(AccessPolicy.Title(level));
        }

        /// <summary>
        /// 表里没这一级就退回"等级名就是密码"，
        /// 免得因为一个 csv 缺行而谁都登不进去（现场进不去的代价是整台机停线等人）。
        /// </summary>
        public string Of(string title)
        {
            var row = Row(title);
            return row == null ? title : row[1];
        }

        /// <summary>这一行属于第几级；表里没有返回 -1，调用方据此把等级下拉停住。</summary>
        public int IndexOf(string title)
        {
            for (var i = 0; i < rows.Count; i++)
            {
                if (string.Equals(rows[i][0], title, StringComparison.OrdinalIgnoreCase)) return i;
            }
            return -1;
        }

        public bool Matches(string title, string password)
        {
            return Of(title) == (password ?? string.Empty);
        }

        /// <summary>改内存里那一行的密码；表里没这一级返回 false，不凭空加一行。</summary>
        public bool Change(string title, string password)
        {
            var row = Row(title);
            if (row == null) return false;
            row[1] = password ?? string.Empty;
            return true;
        }

        /// <summary>写回原来那张 csv。写不进（文件被 Excel 占着）返回 false，界面据此报错。</summary>
        public bool Save()
        {
            if (string.IsNullOrEmpty(path) || rows.Count == 0) return false;
            var sb = new StringBuilder();
            sb.AppendLine(string.Join(",", Header));
            foreach (var row in rows) sb.AppendLine(string.Join(",", row));
            return TextFile.WriteAllText(path, sb.ToString(), CodePages.Gbk());
        }

        private string[] Row(string title)
        {
            foreach (var row in rows)
            {
                if (string.Equals(row[0], title, StringComparison.OrdinalIgnoreCase)) return row;
            }
            return null;
        }
    }
}
