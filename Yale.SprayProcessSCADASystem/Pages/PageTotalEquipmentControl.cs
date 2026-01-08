using YR.FrameWork.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sunny.UI;
using LogLevel = Microsoft.Extensions.Logging.LogLevel;

namespace Yale.SprayProcessSCADASystem
{
    public partial class PageTotalEquipmentControl : UIPage, ISingletonSelfDependency
    {
        private readonly ILogger<PageTotalEquipmentControl> _logger;
        public PageTotalEquipmentControl(ILogger<PageTotalEquipmentControl> _logger)
        {
            InitializeComponent();
            this._logger = _logger;
            LogExtension.ShowMesssage = ShowLog;
        }

        private void btn_Control_Common_Click(object sender, EventArgs e)
        {
            UISymbolButton btn = sender as UISymbolButton;

            if (!Globals.SiemensClient.Connected)
            {
                UIMessageTip.ShowError("请先连接西门子PLC");
                return;
            }

            if (Globals.PlcWrite(btn.TagString, true))
            {
                UIMessageTip.ShowOk("写入成功");
                ShowLog($"写入{btn.TagString}成功");
            }
            else
            {
                UIMessageTip.ShowError($"写入{btn.TagString}失败");
                ShowLog($"写入{btn.TagString}失败");
            }

        }

        private void btn_DryRun_ClickEvent(object sender, EventArgs e)
        {
            if (!Globals.SiemensClient.Connected)
            {
                UIMessageTip.ShowError("请先连接西门子PLC");
                return;
            }

            if (Globals.PlcWrite(this.btn_DryRun.VariableName, !this.btn_DryRun.CounterButtonState))
            {
                this.btn_DryRun.CounterButtonState = !this.btn_DryRun.CounterButtonState;
                UIMessageTip.ShowOk("写入成功");
                ShowLog($"写入{this.btn_DryRun.VariableName}成功");
            }
            else
            {
                UIMessageTip.ShowOk("写入失败");
                ShowLog($"写入{this.btn_DryRun.VariableName}失败");
            }
        }

        private void device_Common_ClickEvent(object sender, EventArgs e)
        {
            UserDeviceUnitControl userDeviceUnit=sender as UserDeviceUnitControl;
            if (!Globals.SiemensClient.Connected)
            {
                userDeviceUnit.State = false;
                UIMessageTip.ShowError("请先连接西门子PLC");
                return;
            }

            bool state = userDeviceUnit.State;
            string variableName = state ? userDeviceUnit.CloseVariableName : userDeviceUnit.OpenVariableName;
            if(Globals.PlcWrite(variableName,true))
            {
                UIMessageTip.ShowOk("写入成功");
                ShowLog($"{variableName} 写入成功");
            }
            else
            {
                UIMessageTip.ShowError("写入失败");
                ShowLog($"{variableName} 写入失败");
            }
        }

        private void ShowLog(string log,LogLevel logLevel=LogLevel.Information)
        {
            this.txt_Log.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "=>" + log + Environment.NewLine);

            switch (logLevel)
            {
                case LogLevel.Information:
                    _logger.LogInformation(log);
                    break;
                case LogLevel.Warning:
                    _logger.LogWarning(log);
                    break;
                case LogLevel.Error:
                    _logger.LogError(log);
                    break;
            }
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }


    }
}
