using Mes.Common;
using System;
using System.Collections.Generic;
using System.IO;

namespace Mes.Data
{
    /// <summary>
    /// 一张落在本地 CSV 上的"表"，接口按 SQL 的样子设计：Insert / Update / 查询。
    ///
    /// 为什么不用数据库：现场不保证有 SQL Server，装一个 Express 要吃掉半小时。
    /// 但表名和列名必须和真项目一致（ProductLog / OEE_DT / PLCData_Modi），
    /// 换到真项目时只需要把这里的 Insert/Update 换成一条 SQL，业务代码一行不动——
    /// 这也正是"数据访问要抽一层"的理由。将来 MES 上传的队列/重试同样落在这个工程里。
    ///
    /// 文件用 UTF-8 带 BOM 写表头：没有 BOM 的话 Excel 双击打开是乱码，
    /// 而现场工程师十有八九是用 Excel 看这些记录的。
    /// </summary>
    public class RecordTable
    {
        private readonly object gate = new object();
        private readonly object diskGate = new object();
        private readonly List<Record> rows = new List<Record>();
        private readonly string[] columns;
        private int version;
        private int persistedVersion;

        public RecordTable(string folder, string tableName, string[] columns)
        {
            this.columns = columns;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            FilePath = Path.Combine(folder, tableName + ".csv");
            Load();
        }

        /// <summary>这张表落在磁盘上的完整路径（记录\表名.csv）</summary>
        public string FilePath { get; private set; }

        public int Count
        {
            get { lock (gate) return rows.Count; }
        }

        /// <summary>对应 SQL 的 insert into …</summary>
        public void Insert(Record row)
        {
            lock (gate)
            {
                rows.Add(new Record(row));
                version++;
            }
            Persist();
        }

        /// <summary>对应 SQL 的 update … where …；返回被改掉的行数</summary>
        public int Update(Func<Record, bool> where, Action<Record> set)
        {
            int hit = 0;
            lock (gate)
            {
                foreach (var row in rows)
                {
                    if (!where(row)) continue;
                    set(row);
                    hit++;
                }
                if (hit > 0) version++;
            }
            if (hit > 0) Persist();
            return hit;
        }

        /// <summary>对应 SQL 的 select … order by 时间倒序取前 n 条</summary>
        public List<Record> Tail(int n)
        {
            lock (gate)
            {
                var result = new List<Record>();
                for (var i = rows.Count - 1; i >= 0 && result.Count < n; i--)
                {
                    result.Add(new Record(rows[i]));
                }
                return result;
            }
        }

        /// <summary>整表快照。每半秒统计一次别用这个，用 Scan。</summary>
        public List<Record> All()
        {
            lock (gate)
            {
                var result = new List<Record>();
                foreach (var row in rows) result.Add(new Record(row));
                return result;
            }
        }

        /// <summary>
        /// 锁内一行一行过，不复制。主界面每 500ms 要数一遍"投入/合格/NG"，
        /// 用 All() 先把整张表复制一份再扫——跑下来记录上千条，就是每半秒 new 上千个字典，纯浪费。
        /// 只要统计不要快照的用这个；传进来的委托别去改行，也别碰界面控件。
        /// </summary>
        public void Scan(Action<Record> visit)
        {
            lock (gate)
            {
                for (var i = 0; i < rows.Count; i++) visit(rows[i]);
            }
        }

        /// <summary>
        /// 最后一条满足条件的行，对应 SQL 的 top 1 … order by 时间倒序；没有返回 null。
        /// 主界面每半秒要取"当前治具"，用 Tail(20) 先复制 20 行再筛，表一大就是白分配的字典。
        /// </summary>
        public Record Last(Func<Record, bool> where)
        {
            lock (gate)
            {
                for (var i = rows.Count - 1; i >= 0; i--)
                {
                    if (where(rows[i])) return new Record(rows[i]);
                }
                return null;
            }
        }

        private void Load()
        {
            var lines = TextFile.ReadAllLines(FilePath, CodePages.Utf8WithBom());
            if (lines.Length == 0) return;
            var header = lines[0].Split(',');
            for (var i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrEmpty(lines[i])) continue;
                var cols = Csv.Split(lines[i]);
                var row = new Record();
                for (var c = 0; c < header.Length && c < cols.Length; c++)
                {
                    row[header[c]] = cols[c];
                }
                rows.Add(row);
            }
        }

        /// <summary>
        /// 落盘。数据锁只用来把内存拼成整张表，磁盘写放在锁外：
        /// 以前 Update 是在数据锁里整表重写的，界面每半秒一次的统计要拿同一把锁，
        /// 记录越多、写一次越久，界面就跟着一起卡住。
        /// 写盘本身用 diskGate 串行，version/persistedVersion 保证晚到的旧快照不会覆盖新数据。
        /// 写不进盘不能把生产停掉：真项目这里是 try{执行SQL}catch{界面标红}。
        /// </summary>
        private void Persist()
        {
            lock (diskGate)
            {
                int current;
                string text;
                lock (gate)
                {
                    current = version;
                    if (current <= persistedVersion) return;
                    text = Serialize();
                    persistedVersion = current;
                }
                TextFile.WriteAllText(FilePath, text, CodePages.Utf8WithBom());
            }
        }

        private string Serialize()
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine(string.Join(",", columns));
            foreach (var row in rows) sb.AppendLine(Join(row));
            return sb.ToString();
        }

        private string Join(Record row)
        {
            var cells = new string[columns.Length];
            for (var i = 0; i < columns.Length; i++)
            {
                cells[i] = Csv.Escape(row.Get(columns[i]));
            }
            return string.Join(",", cells);
        }
    }
}
