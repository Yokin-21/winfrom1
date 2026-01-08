using Microsoft.Extensions.DependencyInjection;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Yale.Helper;
using YR.FrameWork.DependencyInjection;
using MiniExcelLibs;
using Yale.Model;
using IoTClient.Common.Enums;
using IoTClient.Enums;
using Microsoft.Extensions.Logging;
using Sunny.UI.Win32;
using Yale.BLL;
using System.Timers;
using Microsoft.Win32;

namespace Yale.SprayProcessSCADASystem
{
    public partial class FrmMain : UIHeaderAsideMainFooterFrame, ISingletonSelfDependency
    {
        #region 成员变量

        private bool plcIsConnected = false;
        private CancellationTokenSource cts = new CancellationTokenSource();

        private readonly ILogger<FrmMain> _logger;
        private readonly UserManager _userManager;
        private readonly AuthManager _authManager;
        private readonly DataManager _dataManager;

        private bool isFirst=true;

        private bool isConnectFirst=true;

        private System.Timers.Timer timer = new System.Timers.Timer();

        private Dictionary<string, Control> pageControls = new Dictionary<string, Control>
{
    { "控制模块", Globals.ServiceProvider.GetRequiredService<PageTotalEquipmentControl>() },
    { "用户模块", Globals.ServiceProvider.GetRequiredService<PageUserManage>() },
    { "权限模块", Globals.ServiceProvider.GetRequiredService<PageAuthManage>() },
    { "监控模块", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor>() },
    { "监控模块1", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor1>() },
    { "监控模块2", Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor2>() },
    { "配方模块", Globals.ServiceProvider.GetRequiredService<PageRecipeManage>() },
    { "日志模块", Globals.ServiceProvider.GetRequiredService<PageLogManage>() },
    { "报表模块", Globals.ServiceProvider.GetRequiredService<PageReportManage>() },
    { "图表模块", Globals.ServiceProvider.GetRequiredService<PageChartManage>() },
    { "参数模块", Globals.ServiceProvider.GetRequiredService<PageSystemParameterSet>() }
};

        private List<string> AlarmList = new List<string>();
        #endregion

        #region 初始化

        public FrmMain(ILogger<FrmMain> _logger, UserManager userManager, AuthManager authManager, DataManager dataManager)
        {
            InitializeComponent();

            this._logger = _logger;
            this._userManager = userManager;
            this._authManager = authManager;
            this._dataManager = dataManager;

            this.lbl_User.Text = "访客";
            //Init();


            this.Closed += (s, e) =>
            {
                Globals.SiemensClient.Close();
            };

        }
        public override void Init()
        {

            InitConfig();
            InitAsideUI();
            InitHeaderUI();
            IniPlcClient();
            IniOther();

        }

        private void IniOther()
        {
            if (Globals.SaveDay != "不清理")
            {
                DelFile.DeleteFolder(Globals.DelFilePath, Globals.SaveDay.ToInt());

            }
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            if (Globals.SiemensClient.Connected)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(async () =>
                    {

                        this.lbl_Temperature.Text = Globals.DataDic[this.lbl_Temperature.TagString].ToString() + "℃";
                        this.lbl_Humidness.Text = Globals.DataDic[this.lbl_Humidness.TagString].ToString() + "%";
                        this.lbl_ProducteCount.Text = Globals.DataDic[this.lbl_ProducteCount.TagString].ToString();
                        this.lbl_BadCount.Text = Globals.DataDic[this.lbl_BadCount.TagString].ToString();
                        this.lbl_Beat.Text = Globals.DataDic[this.lbl_Beat.TagString].ToString();
                        this.lbl_TotalAlarm.Text = Globals.DataDic[this.lbl_TotalAlarm.TagString].ToString();

                        //CPU和内存
                        string CPUstr = RuntimeStatusHelper.DataManager.GetCpuUtilization();
                        string MemoryStr = RuntimeStatusHelper.DataManager.GetMemoryUtilization().Replace("G", "");
                        string NeiResult = (double.Parse(MemoryStr.Split('/')[0]) / double.Parse(MemoryStr.Split('/')[1]) * 100).ToString("f1") + "%";
                        this.lbl_CPUInformation.Text = double.Parse(CPUstr).ToString("f1") + "%";
                        this.lbl_MemoryInformation.Text = NeiResult;

                        //时间

                        //报警
                        List<string> alarmInfos = CheckAlarms(AlarmList);

                        string alarmInfo = string.Join(",", alarmInfos);

                        if (string.IsNullOrEmpty(alarmInfo))
                        {
                            this.st_AlarmInfo.Text = "系统正常";
                            this.st_AlarmInfo.ForeColor = Color.Green;
                            this.led_ProducteState.On = true;
                            this.led_ProducteState.Color = Color.Green;
                            this.led_ProducteState.Blink = false;
                        }
                        else
                        {
                            this.st_AlarmInfo.Text = alarmInfo;
                            this.st_AlarmInfo.ForeColor = Color.Red;
                            this.led_ProducteState.BlinkInterval = 500;
                            this.led_ProducteState.Blink = true;
                        }

                        //保存数据
                        AddDataDto addDataDto = new AddDataDto();
                        addDataDto.InsertTime = DateTime.Now;

                        foreach (var item in Globals.SaveList)
                        {
                            var type = typeof(AddDataDto).GetProperty(item).PropertyType.Name;
                            if (type == "String")
                            {
                                addDataDto.GetType().GetProperty(item).SetValue(addDataDto, Globals.DataDic[item].ToString());
                            }
                        }

                        var res = await _dataManager.AddDataAsync(addDataDto);
                        if (res.Status == SystemEnums.Result.Fail)
                        {
                            LogExtension.ShowMesssage("保存数据失败", Microsoft.Extensions.Logging.LogLevel.Error);
                        }
                    });
                }
                else
                {
                    this.lbl_Temperature.Text = Globals.DataDic[this.lbl_Temperature.TagString].ToString() + "℃";
                    this.lbl_Humidness.Text = Globals.DataDic[this.lbl_Humidness.TagString].ToString() + "%";

                    this.lbl_ProducteCount.Text = Globals.DataDic[this.lbl_ProducteCount.TagString].ToString();
                    this.lbl_BadCount.Text = Globals.DataDic[this.lbl_BadCount.TagString].ToString();
                    this.lbl_Beat.Text = Globals.DataDic[this.lbl_Beat.TagString].ToString();
                    this.lbl_TotalAlarm.Text = Globals.DataDic[this.lbl_TotalAlarm.TagString].ToString();
                }
                if(isFirst)
                {
                    isFirst = false;
                    Globals.ServiceProvider.GetRequiredService<FromStartLoad>().CloseFormThread();
                }
            }

            this.Invoke(() => {
            this.lbl_Time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            });
        }

        private List<string> CheckAlarms(List<string> alarmList)
        {
            List<string> alarmInfos = new List<string>();
            foreach (var item in alarmList)
            {
                if (Globals.DataDic[item].ToString() == "1")
                {
                    alarmInfos.Add(item);
                }
            }
            return alarmInfos;
        }



        private void InitConfig()
        {
            //读取表格的路径
            Globals.PlcVarConfigPath = Globals.IniFile.ReadString("PLC参数", "变量表地址", Application.StartupPath + "\\PLC_Var_Config.xlsx");

            //读取PLC的IP地址
            Globals.IpAddress = Globals.IniFile.ReadString("PLC参数", "PLC地址", "127.0.0.1");
            //读取PLC的端口号
            Globals.Port = Globals.IniFile.ReadInt("PLC参数", "PLC端口", 102);
            //读取PLC的CPU类型
            Globals.CpuType = Enum.Parse<SiemensVersion>(Globals.IniFile.ReadString("PLC参数", "CPU类型", "S7_1200"));
            //读取PLC机架号
            Globals.Rack = Globals.IniFile.ReadByte("PLC参数", "机架号", 0);
            //读取PLC插槽号
            Globals.Slot = Globals.IniFile.ReadByte("PLC参数", "插槽号", 0);

            //读取PLC超时时间
            Globals.ConnectTimeOut = Globals.IniFile.ReadInt("PLC参数", "超时时间", 3000);
            //读取PLC数据循环时间
            Globals.ReadTimeInterval = Globals.IniFile.ReadInt("PLC参数", "循环读取时间", 500);
            //读取PLC重连时间
            Globals.ReConnectTimeInterval = Globals.IniFile.ReadInt("PLC参数", "重连时间", 3000);

            //删除文件夹
            Globals.DelFilePath = Globals.IniFile.ReadString("系统参数", "删除文件夹路径", Path.Combine(Application.StartupPath, "Logs"));
            Globals.SaveDay = Globals.IniFile.ReadString("系统参数", "保存文件夹天数", "7天");

            //软件版本
            Globals.SoftwareVersion = Globals.IniFile.ReadString("软件参数", "软件版本", "V1.0");
            //软件试用时长
            Globals.SYTime = Globals.IniFile.ReadString("软件参数", "试用时间", "100");

            _logger.LogInformation("读取配置文件成功");

        }

        private void IniPlcClient()
        {


            //导入PLC变量
            var plcVarList = MiniExcel.Query<PLCVarConfigModel>(Globals.PlcVarConfigPath).ToList();

            //初始化PLC客户端   西门子
            Globals.SiemensClient = new IoTClient.Clients.PLC.SiemensClient(Globals.CpuType, Globals.IpAddress, Globals.Port, Globals.Slot, Globals.Rack, Globals.ConnectTimeOut);

            //第一次尝试链接PLC
            var connectResult = Globals.SiemensClient.Open();

            if (connectResult.IsSucceed)
            {
                //设置一下状态
                plcIsConnected = true;
                this.led_PlcState.On = true;
            }
            else
            {
                plcIsConnected = false;
                this.led_PlcState.On = false;
            }

            for (int i = 0; i < plcVarList.Count; i++)
            {
                //初始化PLC变量地址字典 地址-类型
                Globals.ReadDic.Add(plcVarList[i].PLC地址, Enum.Parse<DataTypeEnum>(plcVarList[i].变量类型, true));//忽略大小写
                //初始化PLC变量写入  名称-地址
                Globals.WriteDic.Add(plcVarList[i].名称, plcVarList[i].PLC地址);
                //初始化PLC变量值读取字典  名称-值
                Globals.DataDic.Add(plcVarList[i].名称, "NA");
                if (plcVarList[i].是否保存.ToLower() == "true")
                {
                    Globals.SaveList.Add(plcVarList[i].名称);
                }

                //添加报警
                if (plcVarList[i].名称.EndsWith("报警") && !plcVarList[i].名称.Contains("累计"))
                {
                    AlarmList.Add(plcVarList[i].名称);
                }


            }

            _logger.LogInformation("初始化PLC客户端成功");

            try
            {
                Task.Run(async () =>
                {

                    while (!cts.IsCancellationRequested)
                    {
                        if (plcIsConnected)
                        {
                            var readResult = Globals.SiemensClient.BatchRead(Globals.ReadDic);
                            if (readResult.IsSucceed)
                            {
                                //赋值
                                for (int i = 0; i < plcVarList.Count; i++)
                                {
                                    Globals.DataDic[plcVarList[i].名称] = readResult.Value[plcVarList[i].PLC地址];
                                }

                            }
                            else
                            {
                                Globals.SiemensClient.Close();
                                plcIsConnected = false;

                                this.Invoke(() =>
                                {
                                    this.led_PlcState.On = false;
                                });

                            }
                            await Task.Delay(Globals.ReadTimeInterval);

                        }
                        else
                        {
                            if(isConnectFirst)
                            {
                                isConnectFirst = false;
                                Globals.ServiceProvider.GetRequiredService<FromStartLoad>().CloseFormThread();
                            }
                            //重连PLC
                            var reConnectResult = Globals.SiemensClient.Open();
                            if (reConnectResult.IsSucceed)
                            {
                                plcIsConnected = true;
                                this.Invoke(() =>
                                {
                                    this.led_PlcState.On = true;
                                });
                            }
                            else
                            {
                                plcIsConnected = false;

                                this.Invoke(() =>
                                {
                                    this.led_PlcState.On = false;
                                });

                                //等待一段时间尝试重连
                                await Task.Delay(Globals.ReConnectTimeInterval);

                            }
                        }
                    }

                });
            }
            catch (Exception)
            {
                throw;
            }








        }

        private void InitAsideUI()
        {

            //设置关联
            Aside.TabControl = MainTabControl;
            int pageIndex = 1000;
            TreeNode parent0 = Aside.CreateNode("控制模块", 361461, 34, pageIndex);
            Aside.CreateChildNode(parent0, AddPage(Globals.ServiceProvider.GetRequiredService<PageTotalEquipmentControl>(), ++pageIndex));

            TreeNode parent1 = Aside.CreateNode("用户模块", 61447, 34, pageIndex);
            Aside.CreateChildNode(parent1, AddPage(Globals.ServiceProvider.GetRequiredService<PageUserManage>(), ++pageIndex));
            Aside.CreateChildNode(parent1, AddPage(Globals.ServiceProvider.GetRequiredService<PageAuthManage>(), ++pageIndex));

            TreeNode parent2 = Aside.CreateNode("监控模块", 560066, 34, pageIndex);
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor>(), ++pageIndex));
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor1>(), ++pageIndex));
            Aside.CreateChildNode(parent2, AddPage(Globals.ServiceProvider.GetRequiredService<PageEquipmentMonitor2>(), ++pageIndex));

            TreeNode parent3 = Aside.CreateNode("配方模块", 162677, 34, pageIndex);
            Aside.CreateChildNode(parent3, AddPage(Globals.ServiceProvider.GetRequiredService<PageRecipeManage>(), ++pageIndex));

            TreeNode parent4 = Aside.CreateNode("日志模块", 57557, 34, pageIndex);
            Aside.CreateChildNode(parent4, AddPage(Globals.ServiceProvider.GetRequiredService<PageLogManage>(), ++pageIndex));

            TreeNode parent5 = Aside.CreateNode("报表模块", 57586, 34, pageIndex);
            Aside.CreateChildNode(parent5, AddPage(Globals.ServiceProvider.GetRequiredService<PageReportManage>(), ++pageIndex));

            TreeNode parent6 = Aside.CreateNode("图表模块", 61950, 34, pageIndex);
            Aside.CreateChildNode(parent6, AddPage(Globals.ServiceProvider.GetRequiredService<PageChartManage>(), ++pageIndex));

            TreeNode parent7 = Aside.CreateNode("参数模块", 559576, 34, pageIndex);
            Aside.CreateChildNode(parent7, AddPage(Globals.ServiceProvider.GetRequiredService<PageSystemParameterSet>(), ++pageIndex));

            _logger.LogInformation("初始化侧边栏菜单成功");

        }

        private void InitHeaderUI()
        {
            //设置关联
            Header.TabControl = MainTabControl;

            Header.Nodes.Add("");
            Header.Nodes.Add("");
            Header.Nodes.Add("");
            Header.SetNodeSymbol(Header.Nodes[0], 558295, 34);
            Header.SetNodeSymbol(Header.Nodes[1], 61489, 34);
            Header.SetNodeSymbol(Header.Nodes[2], 557925, 34);
            var styles = UIStyles.PopularStyles();
            foreach (UIStyle style in styles)
            {
                Header.CreateChildNode(Header.Nodes[0], style.DisplayText(), style.Value());
            }

            //获取枚举FontsType的所有字体名称
            for (int i = 0; i < Enum.GetValues(typeof(SystemEnums.FontsType)).Length; i++)
            {
                Header.CreateChildNode(Header.Nodes[1], Enum.GetName(typeof(SystemEnums.FontsType), i), i + 1);
            }

            //获取枚举FontSize的所有字体大小  75-125的范围 75 80 85 90 95 100 105 110 115 120 125
            for (int i = 75; i <= 125; i += 5)
            {
                Header.CreateChildNode(Header.Nodes[2], i.ToString(), i);
            }

            _logger.LogInformation("初始化头部菜单成功");
        }
        #endregion

        #region 主题管理
        private void Header_MenuItemClick(string itemText, int menuIndex, int pageIndex)
        {
            switch (menuIndex)
            {
                case 0:
                    UIStyle style = (UIStyle)pageIndex;
                    if (pageIndex < UIStyle.Colorful.Value())
                    {
                        StyleManager.Style = style;
                        if (UIExtension.SetStyleManager != null)
                        {
                            UIExtension.SetStyleManager(StyleManager);
                        }
                    }
                    break;

                case 1:
                    UIStyles.DPIScale = true;
                    UIStyles.GlobalFont = true;
                    UIStyles.GlobalFontName = itemText;

                    UIStyles.GlobalFontScale = SystemConsts.DefaultFontScale;
                    UIStyles.SetDPIScale();
                    break;

                case 2:
                    UIStyles.GlobalFontScale = int.Parse(itemText);
                    UIStyles.SetDPIScale();
                    break;

                default:

                    break;
            }
        }

        #endregion

        #region 关闭和最小化

        private void lbl_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lbl_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region 无边框拖动

        private Point mPoint;

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }

        private void Panel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //把Aside折叠起来
            Aside.CollapseAll();
            Aside.SelectFirst();

            var frmLogin = Globals.ServiceProvider.GetRequiredService<FrmLogin>();
            frmLogin.ShowDialog();
            if (frmLogin.IsLogin)
            {
                //更新登录用户
                this.lbl_User.Text = frmLogin.UserName;
                foreach (var control in pageControls.Values)
                {
                    control.Enabled = true;
                }
            }


        }

        private async void Aside_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            string moduleName = e.Node.Text;

            string user = this.lbl_User.Text;
            var roleRes = await _userManager.GetUserAuthAsync(new QueryUserAuthDto { UserName = user });
            if (roleRes.Status == SystemEnums.Result.Success)
            {
                if (roleRes.Data[0].Role != "管理员")
                {
                    var authRes = await _authManager.GetAuthAsync(new QueryAuthDto() { Role = roleRes.Data[0].Role });
                    if (authRes.Status == SystemEnums.Result.Success)
                    {
                        UpdateControlAccess(moduleName, authRes.Data[0], pageControls);
                    }
                }
            }

        }

        private void UpdateControlAccess(string moduleName, QueryAuthResultDto authDto, Dictionary<string, Control> pageControls)
        {
            switch (moduleName)
            {
                case "控制模块":
                    pageControls["控制模块"].Enabled = authDto.ControlModule;
                    break;

                case "用户模块":
                    pageControls["用户模块"].Enabled = false;
                    pageControls["权限模块"].Enabled = false;
                    break;

                case "监控模块":
                    pageControls["监控模块"].Enabled = authDto.MonitorModule;
                    pageControls["监控模块1"].Enabled = authDto.MonitorModule;
                    pageControls["监控模块2"].Enabled = authDto.MonitorModule;
                    break;

                case "配方模块":
                    pageControls["配方模块"].Enabled = authDto.RecipeModule;
                    break;

                case "日志模块":
                    pageControls["日志模块"].Enabled = authDto.LogModule;
                    break;

                case "报表模块":
                    pageControls["报表模块"].Enabled = authDto.ReportModule;
                    break;

                case "图表模块":
                    pageControls["图表模块"].Enabled = authDto.ChartModule;
                    break;

                case "参数模块":
                    pageControls["参数模块"].Enabled = authDto.ParamModule;
                    break;

                default:
                    break;
            }
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            Globals.ServiceProvider.GetRequiredService<FromStartLoad>().OpenFormThread();
            Init();
            
        }
        #region 窗体切换卡顿处理
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
        #endregion

    }
}
