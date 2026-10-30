using System.Collections.Generic;

namespace Mes.Business
{
    /// <summary>
    /// 当前报警板：机台报上来的报警在这里排队，直到有人按"复位"。
    ///
    /// 为什么不读完就丢：PLC 的触发字是"有人认领才清"，上位机读了不代表故障消失了。
    /// 现场要的是"这条还挂着"，所以列表留着、复位时一起去清寄存器。
    /// </summary>
    public class AlarmBoard
    {
        /// <summary>界面只显示最近几条，历史那部分由报警历史页从记录里翻。</summary>
        private const int Keep = 50;

        private readonly object gate = new object();
        private readonly List<AlarmEntry> active = new List<AlarmEntry>();
        private readonly Dictionary<string, AlarmEntry> activeByCode =
            new Dictionary<string, AlarmEntry>(System.StringComparer.Ordinal);

        public void Raise(AlarmInfo info)
        {
            if (info == null) return;
            lock (gate)
            {
                if (activeByCode.ContainsKey(info.Code)) return;
                var entry = new AlarmEntry { At = System.DateTime.Now, Code = info.Code, Text = info.Title };
                active.Add(entry);
                activeByCode[entry.Code] = entry;
                if (active.Count > Keep)
                {
                    var dropped = active[0];
                    active.RemoveAt(0);
                    activeByCode.Remove(dropped.Code);
                }
            }
        }

        public void Clear()
        {
            lock (gate)
            {
                active.Clear();
                activeByCode.Clear();
            }
        }

        /// <summary>
        /// 给界面用的快照：报警是过站线程 raise 上来的，直接在界面线程遍历同一张 List
        /// 会撞上它正在增删。界面只拿快照，不碰内部列表。
        /// </summary>
        public List<AlarmEntry> Snapshot()
        {
            lock (gate) return new List<AlarmEntry>(active);
        }
    }
}
