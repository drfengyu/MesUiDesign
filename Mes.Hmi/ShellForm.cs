using Mes.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Mes.Hmi
{
    /// <summary>
    /// 触摸屏外壳，版面照《Automation UI V3.11》P4 的标准 UI：
    /// 区域1 一级入口（只放图标，按下态用绿底那张）、区域2 设备名称、区域3 设备操作按钮（启动/暂停/停止）、
    /// 左侧二级页签、中间页面宿主、区域6 状态条（登陆用户、连接状态、机台状态、时间）。
    /// 这个文件只做状态与跳转，所有控件都在 ShellForm.Designer.cs 里声明。
    /// </summary>
    public partial class ShellForm : Form
    {
        private static readonly Color TabNormal = Color.FromArgb(240, 242, 245);
        private static readonly Color TabSelected = Color.FromArgb(0, 160, 70);
        private static readonly Color Ok = Color.FromArgb(0, 170, 70);
        private static readonly Color Ng = Color.FromArgb(200, 40, 40);
        private static readonly Color Paused = Color.FromArgb(40, 120, 200);

        private enum MachineState { Stopped, Running, Paused }

        private readonly ComponentResourceManager resources = new ComponentResourceManager(typeof(ShellForm));
        private readonly Dictionary<string, Button> pageButtons = new Dictionary<string, Button>();
        private ToolStripButton[] navButtons;
        private NavEntry[] navEntries;
        private MachineState machineState = MachineState.Stopped;

        private StationContext station;
        private int currentEntry = -1;
        private string currentPage;

        /// <summary>
        /// 页面注册表：页键 → 怎么建这一页。没登记的页键一律落到占位页，
        /// 这样"导航先跑通、页面一块一块补"不会变成点了没反应。
        /// </summary>
        private readonly Dictionary<string, Func<StationContext, Control>> pages =
            new Dictionary<string, Func<StationContext, Control>>
            {
                { StationPage.Home, station => new PageHome(station) },
                { StationPage.UptimeLog, station => new PageUptime(station) },
                { StationPage.ParamChart, station => new PageParamChart(station) },
                { StationPage.PartLife, station => new PagePartLife(station) },
                { StationPage.FixtureLife, station => new PageFixtureLife(station) },
                { StationPage.ParamControl, station => new PageParamControl(station) },
                { StationPage.TimeDetail, station => new PageTimeDetail(station) },
                { StationPage.EnergyMonitor, station => new PageEnergy(station) },
                { StationPage.Login, station => new PageLogin(station) },
                { StationPage.IoInput, station => new PageIoMonitor(station, 'I') },
                { StationPage.IoOutput, station => new PageIoMonitor(station, 'Q') },
                {
                    StationPage.ManualSpec,
                    station => new PagePlaceholder("模组规格",
                        "本机 IO 表里没有伺服轴，没有加减速、速度、负载这类轴参数可显示。\r\n"
                        + "接真机轴参数后在这一页接上（《Automation UI V3.11》P25）。")
                },
                { StationPage.ManualOperation, station => new PageManualOperation(station) },
                { StationPage.SimulatedMachine, station => new PageMachineSimulator(station) },
            };

        public ShellForm() : this(StationContext.Create())
        {
        }

        public ShellForm(StationContext station)
        {
            InitializeComponent();
            this.station = station;
            this.station.Activity += OnActivity;

            BindNavButtons();
            ShowStartupState();
            SelectEntry(0);
        }

        /// <summary>按钮和设计器里的顺序一一对应，入口表就是同一顺序。</summary>
        private void BindNavButtons()
        {
            navButtons = new[] { btnHome, btnStatistics, btnIo, btnManual, btnSetting, btnAlarm, btnUser, btnHelp };
            navEntries = new NavEntry[navButtons.Length];
            for (var i = 0; i < navButtons.Length; i++)
            {
                navEntries[i] = NavEntry.Entries[i];
                navButtons[i].Image = NavIcon(navEntries[i].IconKey, false);
                navButtons[i].ToolTipText = navEntries[i].Title;
            }
            btnRun.Image = NavIcon("run", false);
            btnPause.Image = NavIcon("pause", false);
            btnStop.Image = NavIcon("stop", true);
        }

        private Image NavIcon(string key, bool pressed)
        {
            return (Image)resources.GetObject((pressed ? key + "On" : key) + ".Image");
        }

        // ── 一级入口 ──────────────────────────────────────────────────────

        private void btnHome_Click(object sender, EventArgs e) { SelectEntry(0); }
        private void btnStatistics_Click(object sender, EventArgs e) { SelectEntry(1); }
        private void btnIo_Click(object sender, EventArgs e) { SelectEntry(2); }
        private void btnManual_Click(object sender, EventArgs e) { SelectEntry(3); }
        private void btnSetting_Click(object sender, EventArgs e) { SelectEntry(4); }
        private void btnAlarm_Click(object sender, EventArgs e) { SelectEntry(5); }
        private void btnUser_Click(object sender, EventArgs e) { SelectEntry(6); }
        private void btnHelp_Click(object sender, EventArgs e) { SelectEntry(7); }

        /// <summary>切换一级入口：图标换按下态、左侧页签重排、进入这一入口下第一张能进的页。</summary>
        private void SelectEntry(int index)
        {
            currentEntry = index;
            for (var i = 0; i < navButtons.Length; i++)
            {
                navButtons[i].Image = NavIcon(navEntries[i].IconKey, i == index);
                navButtons[i].Enabled = FirstAllowedPage(navEntries[i]) != null;
            }
            BuildPageTabs(navEntries[index]);
        }

        /// <summary>这一入口下当前等级能进的第一页；一页都进不去返回 null（入口按钮要灰掉）。</summary>
        private string FirstAllowedPage(NavEntry entry)
        {
            foreach (var rule in AccessPolicy.Rules)
            {
                if (rule.Page.StartsWith(entry.Prefix) && IsAllowed(rule.Page)) return rule.Page;
            }
            return null;
        }

        /// <summary>
        /// 左侧二级页签是这里唯一在代码里生成控件的地方：列哪几页由 AccessPolicy.Rules
        /// 和当前登录等级决定，同一入口在不同等级下页数不同，设计器摆不出来。
        /// 除此之外（外壳版面、页面本身）一律走 Designer 文件。
        /// </summary>
        private void BuildPageTabs(NavEntry entry)
        {
            pageButtons.Clear();
            navPages.Controls.Clear();

            foreach (var rule in AccessPolicy.Rules)
            {
                if (!rule.Page.StartsWith(entry.Prefix)) continue;
                var page = rule.Page;
                var button = new Button
                {
                    Text = PageTitle(page),
                    TextAlign = ContentAlignment.MiddleLeft,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(160, 50),
                    Margin = new Padding(4, 4, 0, 0),
                    Font = new Font("微软雅黑", 10F),
                    BackColor = TabNormal,
                    Enabled = IsAllowed(page),
                };
                button.FlatAppearance.BorderColor = Color.FromArgb(210, 214, 220);
                button.Click += delegate { ShowPage(page); };
                pageButtons[page] = button;
                navPages.Controls.Add(button);
            }

            var first = FirstAllowedPage(entry);
            if (first != null) ShowPage(first);
            else ShowNotice(entry.Title + "：当前等级下没有可进的页面");
        }

        // ── 页面宿主 ──────────────────────────────────────────────────────

        private void ShowPage(string page)
        {
            if (!IsAllowed(page))
            {
                ShowNotice(page + "：需要 " + AccessPolicy.Title(Need(page)) + " 以上等级");
                return;
            }
            if (page == currentPage && contentHost.Controls.Count > 0)
            {
                HighlightTab(page);
                return;
            }
            currentPage = page;
            HighlightTab(page);
            var builder = pages.ContainsKey(page) ? pages[page] : null;
            var content = builder != null
                ? builder(station)
                : new PagePlaceholder(PageTitle(page), Need(page), station.Level);
            if (content is PageLogin) ((PageLogin)content).AccessChanged += RefreshAccess;
            if (content is PageHome) ((PageHome)content).NavigateRequested += ShowPage;
            ReplaceContent(content);
            activityLabel.ForeColor = SystemColors.ControlText;
            activityLabel.Text = page;
        }

        private void ShowNotice(string text)
        {
            currentPage = null;
            HighlightTab(null);
            ReplaceContent(new PagePlaceholder("提示", text));
            activityLabel.Text = text;
        }

        /// <summary>
        /// 换页。旧页面必须 Dispose：主界面里有一条 500ms 定时器和一条后台刷新线程，
        /// 只从 Controls 里摘掉不 Dispose，它们会一直跑着，切几次页就是几份同时在读 PLC，
        /// 越用越卡。
        ///
        /// Dispose 推到消息队列尾部再执行：登录页是在自己的按钮事件里触发换页的，
        /// 它的事件处理还没返回就把控件销毁，WinForms 回到那个按钮的窗口过程时会碰到已释放的句柄。
        /// </summary>
        private void ReplaceContent(Control content)
        {
            content.Dock = DockStyle.Fill;
            var previous = contentHost.Controls.Count > 0 ? contentHost.Controls[0] : null;
            contentHost.Controls.Clear();
            contentHost.Controls.Add(content);
            if (previous == null) return;
            if (IsHandleCreated) BeginInvoke(new Action(previous.Dispose));
            else previous.Dispose();
        }

        private void HighlightTab(string page)
        {
            foreach (var pair in pageButtons)
            {
                var on = pair.Key == page;
                pair.Value.BackColor = on ? TabSelected : TabNormal;
                pair.Value.ForeColor = on ? Color.White : SystemColors.ControlText;
            }
        }

        /// <summary>"主界面/Uptime记录" → "Uptime记录"。</summary>
        private static string PageTitle(string page)
        {
            var at = page.IndexOf('/');
            return at >= 0 && at < page.Length - 1 ? page.Substring(at + 1) : page;
        }

        // ── 设备操作按钮（区域3） ─────────────────────────────────────────

        private void btnRun_Click(object sender, EventArgs e)
        {
            station.Machine.Start();
            station.Machine.Running = true;
            machineState = MachineState.Running;
            station.Say("机台启动");
            RefreshMachineButtons();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (machineState == MachineState.Stopped) return;
            station.Machine.Running = false;
            machineState = MachineState.Paused;
            station.Say("机台暂停");
            RefreshMachineButtons();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            station.Machine.Stop();
            machineState = MachineState.Stopped;
            station.Say("机台停止");
            RefreshMachineButtons();
        }

        private void RefreshMachineButtons()
        {
            btnRun.Image = NavIcon("run", machineState == MachineState.Running);
            btnPause.Image = NavIcon("pause", machineState == MachineState.Paused);
            btnStop.Image = NavIcon("stop", machineState == MachineState.Stopped);
        }

        // ── 登录与权限 ────────────────────────────────────────────────────

        /// <summary>等级变了就重算一遍：入口灰不灰、页签列哪几页、当前页还能不能留。</summary>
        private void RefreshAccess()
        {
            ShowUserState();
            var keep = currentPage;
            if (currentEntry >= 0) SelectEntry(currentEntry);
            if (keep != null && IsAllowed(keep) && keep != StationPage.Login) ShowPage(keep);
        }

        private bool IsAllowed(string page)
        {
            return AccessPolicy.Allowed(station.Level, page);
        }

        private LoginLevel Need(string page)
        {
            return (LoginLevel)AccessPolicy.MinimumValue(page);
        }

        // ── 状态条（区域6） ───────────────────────────────────────────────

        /// <summary>
        /// 启动自检：码表读没读到、连上的是模拟机还是真机，开机第一件事就该看见。
        /// 现场"界面全是空的"十有八九是 数据\ 目录没拷过去。
        /// </summary>
        private void ShowStartupState()
        {
            if (!station.CatalogsReady)
            {
                PaintStatus(plcLabel, false, "PLC:NG 码表没读到");
                activityLabel.Text = "检查输出目录下的 数据\\报警目录.csv、参数名称.csv";
            }
            else
            {
                activityLabel.Text = string.Format("报警 {0} 条　参数 {1} 条　IO {2} 点　治具 {3} 副",
                    station.Alarms.Count,
                    station.Params.Items.Count,
                    station.Io.Inputs.Count + station.Io.Outputs.Count,
                    station.Ledger.Fixtures.Count);
            }
            ShowUserState();
            RefreshMachineButtons();
            clock_Tick(this, EventArgs.Empty);
        }

        private void ShowUserState()
        {
            var logged = station.User != "NULL";
            userLabel.Text = logged
                ? "当前用户：" + station.User + "（" + AccessPolicy.Title(station.Level) + "）"
                : "未登录（操作员可见范围）";
        }

        /// <summary>
        /// 连接状态三色块：绿=OK、红=NG。RFP 要求这一栏是"一眼能看出好/坏"，
        /// 所以用底色而不是只改文字。
        /// </summary>
        private void clock_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            var connected = station.Plc.IsConnected;
            PaintStatus(plcLabel, connected, "PLC:" + (connected ? "OK" : "NG"));
            // 没有真 MES 时 MW62071=1 是预期状态，报站直接放行；只有"接了 MES"这一栏才该是绿的。
            // 取值来自过站线程的缓存，界面线程不在这里读 PLC——一次往返几毫秒，每秒卡一下也是卡。
            var mesOnline = connected && station.MesDisabled == 0;
            PaintStatus(mesLabel, mesOnline, "MES:" + (mesOnline ? "OK" : "离线"));
            var writable = Directory.Exists(station.RecordFolder);
            PaintStatus(storeLabel, writable, "记录:" + (writable ? "OK" : "NG"));
            PaintStatus(runLabel, machineState == MachineState.Running,
                machineState == MachineState.Running ? "运行"
                    : machineState == MachineState.Paused ? "暂停" : "停止");
            runLabel.BackColor = machineState == MachineState.Running ? Ok
                : machineState == MachineState.Paused ? Paused : Ng;
        }

        private static void PaintStatus(ToolStripStatusLabel label, bool good, string text)
        {
            label.Text = text;
            label.BackColor = good ? Ok : Ng;
            label.ForeColor = Color.White;
        }

        private void OnActivity(string text)
        {
            // 机台线程/轮询线程会直接 raise 这个事件，界面控件只能在界面线程上改。
            if (InvokeRequired)
            {
                BeginInvoke(new Action<string>(OnActivity), text);
                return;
            }
            activityLabel.Text = text;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            station.Activity -= OnActivity;
            station.Machine.Stop();
            base.OnFormClosed(e);
        }
    }
}
