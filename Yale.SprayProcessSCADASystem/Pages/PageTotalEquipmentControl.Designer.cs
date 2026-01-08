namespace Yale.SprayProcessSCADASystem
{
    partial class PageTotalEquipmentControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            btn_DryRun = new UserCounterButton();
            btn_AlarmReset = new Sunny.UI.UISymbolButton();
            btn_MachineReset = new Sunny.UI.UISymbolButton();
            btn_Stop = new Sunny.UI.UISymbolButton();
            btn_Start = new Sunny.UI.UISymbolButton();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userDeviceUnitControl8 = new UserDeviceUnitControl();
            userDeviceUnitControl4 = new UserDeviceUnitControl();
            userDeviceUnitControl7 = new UserDeviceUnitControl();
            userDeviceUnitControl3 = new UserDeviceUnitControl();
            userDeviceUnitControl6 = new UserDeviceUnitControl();
            userDeviceUnitControl2 = new UserDeviceUnitControl();
            userDeviceUnitControl5 = new UserDeviceUnitControl();
            userDeviceUnitControl1 = new UserDeviceUnitControl();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            txt_Log = new Sunny.UI.UITextBox();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(btn_DryRun);
            uiTitlePanel1.Controls.Add(btn_AlarmReset);
            uiTitlePanel1.Controls.Add(btn_MachineReset);
            uiTitlePanel1.Controls.Add(btn_Stop);
            uiTitlePanel1.Controls.Add(btn_Start);
            uiTitlePanel1.Font = new Font("宋体", 12F);
            uiTitlePanel1.Location = new Point(7, 4);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1065, 157);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "产线总控制";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btn_DryRun
            // 
            btn_DryRun.BackColor = Color.Transparent;
            btn_DryRun.CounterButtonState = false;
            btn_DryRun.CounterButtonSymbol = 61452;
            btn_DryRun.FillColor = Color.Transparent;
            btn_DryRun.Font = new Font("宋体", 12F);
            btn_DryRun.Location = new Point(849, 46);
            btn_DryRun.MinimumSize = new Size(1, 1);
            btn_DryRun.Name = "btn_DryRun";
            btn_DryRun.RectColor = Color.Transparent;
            btn_DryRun.Size = new Size(184, 84);
            btn_DryRun.TabIndex = 4;
            btn_DryRun.Text = "userCounterButton1";
            btn_DryRun.TextAlignment = ContentAlignment.MiddleCenter;
            btn_DryRun.VariableName = "空运行";
            btn_DryRun.ClickEvent += btn_DryRun_ClickEvent;
            // 
            // btn_AlarmReset
            // 
            btn_AlarmReset.Font = new Font("微软雅黑", 21.75F);
            btn_AlarmReset.Location = new Point(641, 46);
            btn_AlarmReset.MinimumSize = new Size(1, 1);
            btn_AlarmReset.Name = "btn_AlarmReset";
            btn_AlarmReset.Radius = 10;
            btn_AlarmReset.Size = new Size(181, 84);
            btn_AlarmReset.Symbol = 61473;
            btn_AlarmReset.SymbolSize = 55;
            btn_AlarmReset.TabIndex = 3;
            btn_AlarmReset.TagString = "报警复位";
            btn_AlarmReset.Text = "报警复位";
            btn_AlarmReset.TipsFont = new Font("微软雅黑", 21.75F);
            btn_AlarmReset.Click += btn_Control_Common_Click;
            // 
            // btn_MachineReset
            // 
            btn_MachineReset.Font = new Font("微软雅黑", 21.75F);
            btn_MachineReset.Location = new Point(432, 46);
            btn_MachineReset.MinimumSize = new Size(1, 1);
            btn_MachineReset.Name = "btn_MachineReset";
            btn_MachineReset.Radius = 10;
            btn_MachineReset.Size = new Size(181, 84);
            btn_MachineReset.Symbol = 61473;
            btn_MachineReset.SymbolSize = 55;
            btn_MachineReset.TabIndex = 2;
            btn_MachineReset.TagString = "机械复位";
            btn_MachineReset.Text = "机械复位";
            btn_MachineReset.TipsFont = new Font("微软雅黑", 21.75F);
            btn_MachineReset.Click += btn_Control_Common_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.Font = new Font("微软雅黑", 21.75F);
            btn_Stop.Location = new Point(223, 46);
            btn_Stop.MinimumSize = new Size(1, 1);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Radius = 10;
            btn_Stop.Size = new Size(181, 84);
            btn_Stop.Symbol = 62093;
            btn_Stop.SymbolSize = 55;
            btn_Stop.TabIndex = 1;
            btn_Stop.TagString = "总停止";
            btn_Stop.Text = "总停止";
            btn_Stop.TipsFont = new Font("微软雅黑", 21.75F);
            btn_Stop.Click += btn_Control_Common_Click;
            // 
            // btn_Start
            // 
            btn_Start.Font = new Font("微软雅黑", 21.75F);
            btn_Start.Location = new Point(14, 46);
            btn_Start.MinimumSize = new Size(1, 1);
            btn_Start.Name = "btn_Start";
            btn_Start.Radius = 10;
            btn_Start.Size = new Size(181, 84);
            btn_Start.Symbol = 561649;
            btn_Start.SymbolSize = 55;
            btn_Start.TabIndex = 0;
            btn_Start.TagString = "总启动";
            btn_Start.Text = "总启动";
            btn_Start.TipsFont = new Font("微软雅黑", 21.75F);
            btn_Start.Click += btn_Control_Common_Click;
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userDeviceUnitControl8);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl4);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl7);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl3);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl6);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl2);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl5);
            uiTitlePanel2.Controls.Add(userDeviceUnitControl1);
            uiTitlePanel2.Font = new Font("宋体", 12F);
            uiTitlePanel2.Location = new Point(7, 169);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(602, 374);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "产线总控制";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userDeviceUnitControl8
            // 
            userDeviceUnitControl8.CloseVariableName = "输送机工位关";
            userDeviceUnitControl8.EquipmentUnitName = "输送机工位";
            userDeviceUnitControl8.Font = new Font("宋体", 12F);
            userDeviceUnitControl8.Location = new Point(304, 287);
            userDeviceUnitControl8.MinimumSize = new Size(1, 1);
            userDeviceUnitControl8.Name = "userDeviceUnitControl8";
            userDeviceUnitControl8.OpenVariableName = "输送机工位开";
            userDeviceUnitControl8.RectColor = Color.Transparent;
            userDeviceUnitControl8.Size = new Size(250, 60);
            userDeviceUnitControl8.State = false;
            userDeviceUnitControl8.TabIndex = 0;
            userDeviceUnitControl8.Text = "userDeviceUnitControl1";
            userDeviceUnitControl8.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl8.ClickEvent += device_Common_ClickEvent;
            // 
            // userDeviceUnitControl4
            // 
            userDeviceUnitControl4.CloseVariableName = "精洗工位关";
            userDeviceUnitControl4.EquipmentUnitName = "精洗工位";
            userDeviceUnitControl4.Font = new Font("宋体", 12F);
            userDeviceUnitControl4.Location = new Point(14, 287);
            userDeviceUnitControl4.MinimumSize = new Size(1, 1);
            userDeviceUnitControl4.Name = "userDeviceUnitControl4";
            userDeviceUnitControl4.OpenVariableName = "精洗工位开";
            userDeviceUnitControl4.RectColor = Color.Transparent;
            userDeviceUnitControl4.Size = new Size(250, 60);
            userDeviceUnitControl4.State = false;
            userDeviceUnitControl4.TabIndex = 0;
            userDeviceUnitControl4.Text = "userDeviceUnitControl1";
            userDeviceUnitControl4.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl4.ClickEvent += device_Common_ClickEvent;
            // 
            // userDeviceUnitControl7
            // 
            userDeviceUnitControl7.CloseVariableName = "固化炉工位关";
            userDeviceUnitControl7.EquipmentUnitName = "固化炉工位";
            userDeviceUnitControl7.Font = new Font("宋体", 12F);
            userDeviceUnitControl7.Location = new Point(304, 208);
            userDeviceUnitControl7.MinimumSize = new Size(1, 1);
            userDeviceUnitControl7.Name = "userDeviceUnitControl7";
            userDeviceUnitControl7.OpenVariableName = "固化炉工位开";
            userDeviceUnitControl7.RectColor = Color.Transparent;
            userDeviceUnitControl7.Size = new Size(250, 60);
            userDeviceUnitControl7.State = false;
            userDeviceUnitControl7.TabIndex = 0;
            userDeviceUnitControl7.Text = "userDeviceUnitControl1";
            userDeviceUnitControl7.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl7.ClickEvent += device_Common_ClickEvent;
            // 
            // userDeviceUnitControl3
            // 
            userDeviceUnitControl3.CloseVariableName = "陶化工位关";
            userDeviceUnitControl3.EquipmentUnitName = "陶化工位";
            userDeviceUnitControl3.Font = new Font("宋体", 12F);
            userDeviceUnitControl3.Location = new Point(14, 208);
            userDeviceUnitControl3.MinimumSize = new Size(1, 1);
            userDeviceUnitControl3.Name = "userDeviceUnitControl3";
            userDeviceUnitControl3.OpenVariableName = "陶化工位开";
            userDeviceUnitControl3.RectColor = Color.Transparent;
            userDeviceUnitControl3.Size = new Size(250, 60);
            userDeviceUnitControl3.State = false;
            userDeviceUnitControl3.TabIndex = 0;
            userDeviceUnitControl3.Text = "userDeviceUnitControl1";
            userDeviceUnitControl3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl3.ClickEvent += device_Common_ClickEvent;
            // 
            // userDeviceUnitControl6
            // 
            userDeviceUnitControl6.CloseVariableName = "冷却室工位关";
            userDeviceUnitControl6.EquipmentUnitName = "冷却室工位";
            userDeviceUnitControl6.Font = new Font("宋体", 12F);
            userDeviceUnitControl6.Location = new Point(304, 129);
            userDeviceUnitControl6.MinimumSize = new Size(1, 1);
            userDeviceUnitControl6.Name = "userDeviceUnitControl6";
            userDeviceUnitControl6.OpenVariableName = "冷却室工位开";
            userDeviceUnitControl6.RectColor = Color.Transparent;
            userDeviceUnitControl6.Size = new Size(250, 60);
            userDeviceUnitControl6.State = false;
            userDeviceUnitControl6.TabIndex = 0;
            userDeviceUnitControl6.Text = "userDeviceUnitControl1";
            userDeviceUnitControl6.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl6.ClickEvent += device_Common_ClickEvent;
            // 
            // userDeviceUnitControl2
            // 
            userDeviceUnitControl2.CloseVariableName = "粗洗工位关";
            userDeviceUnitControl2.EquipmentUnitName = "粗洗工位";
            userDeviceUnitControl2.Font = new Font("宋体", 12F);
            userDeviceUnitControl2.Location = new Point(14, 129);
            userDeviceUnitControl2.MinimumSize = new Size(1, 1);
            userDeviceUnitControl2.Name = "userDeviceUnitControl2";
            userDeviceUnitControl2.OpenVariableName = "粗洗工位开";
            userDeviceUnitControl2.RectColor = Color.Transparent;
            userDeviceUnitControl2.Size = new Size(250, 60);
            userDeviceUnitControl2.State = false;
            userDeviceUnitControl2.TabIndex = 0;
            userDeviceUnitControl2.Text = "userDeviceUnitControl1";
            userDeviceUnitControl2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl2.ClickEvent += device_Common_ClickEvent;
            // 
            // userDeviceUnitControl5
            // 
            userDeviceUnitControl5.CloseVariableName = "水分炉工位关";
            userDeviceUnitControl5.EquipmentUnitName = "水分炉工位";
            userDeviceUnitControl5.Font = new Font("宋体", 12F);
            userDeviceUnitControl5.Location = new Point(304, 50);
            userDeviceUnitControl5.MinimumSize = new Size(1, 1);
            userDeviceUnitControl5.Name = "userDeviceUnitControl5";
            userDeviceUnitControl5.OpenVariableName = "水分炉工位开";
            userDeviceUnitControl5.RectColor = Color.Transparent;
            userDeviceUnitControl5.Size = new Size(250, 60);
            userDeviceUnitControl5.State = false;
            userDeviceUnitControl5.TabIndex = 0;
            userDeviceUnitControl5.Text = "userDeviceUnitControl1";
            userDeviceUnitControl5.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl5.ClickEvent += device_Common_ClickEvent;
            // 
            // userDeviceUnitControl1
            // 
            userDeviceUnitControl1.CloseVariableName = "脱脂工位关";
            userDeviceUnitControl1.EquipmentUnitName = "脱脂工位";
            userDeviceUnitControl1.Font = new Font("宋体", 12F);
            userDeviceUnitControl1.Location = new Point(14, 50);
            userDeviceUnitControl1.MinimumSize = new Size(1, 1);
            userDeviceUnitControl1.Name = "userDeviceUnitControl1";
            userDeviceUnitControl1.OpenVariableName = "脱脂工位开";
            userDeviceUnitControl1.RectColor = Color.Transparent;
            userDeviceUnitControl1.Size = new Size(250, 60);
            userDeviceUnitControl1.State = false;
            userDeviceUnitControl1.TabIndex = 0;
            userDeviceUnitControl1.Text = "userDeviceUnitControl1";
            userDeviceUnitControl1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceUnitControl1.ClickEvent += device_Common_ClickEvent;
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(txt_Log);
            uiTitlePanel3.Font = new Font("宋体", 12F);
            uiTitlePanel3.Location = new Point(617, 171);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(455, 372);
            uiTitlePanel3.TabIndex = 2;
            uiTitlePanel3.Text = "日志栏";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_Log
            // 
            txt_Log.Dock = DockStyle.Fill;
            txt_Log.Font = new Font("宋体", 12F);
            txt_Log.Location = new Point(0, 0);
            txt_Log.Margin = new Padding(4, 5, 4, 5);
            txt_Log.MinimumSize = new Size(1, 16);
            txt_Log.Multiline = true;
            txt_Log.Name = "txt_Log";
            txt_Log.Padding = new Padding(5);
            txt_Log.ShowText = false;
            txt_Log.Size = new Size(455, 372);
            txt_Log.TabIndex = 0;
            txt_Log.TextAlignment = ContentAlignment.MiddleLeft;
            txt_Log.Watermark = "";
            // 
            // PageTotalEquipmentControl
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageTotalEquipmentControl";
            Symbol = 57397;
            Text = "设备总控";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UISymbolButton btn_AlarmReset;
        private Sunny.UI.UISymbolButton btn_MachineReset;
        private Sunny.UI.UISymbolButton btn_Stop;
        private Sunny.UI.UISymbolButton btn_Start;
        private UserCounterButton btn_DryRun;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserDeviceUnitControl device_SSJ;
        private UserDeviceUnitControl device_JX;
        private UserDeviceUnitControl device_GHL;
        private UserDeviceUnitControl device_TH;
        private UserDeviceUnitControl device_LQS;
        private UserDeviceUnitControl device_CX;
        private UserDeviceUnitControl device_SFL;
        private UserDeviceUnitControl device_TZ;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UITextBox txt_Log;
        private UserDeviceUnitControl userDeviceUnitControl1;
        private UserDeviceUnitControl userDeviceUnitControl8;
        private UserDeviceUnitControl userDeviceUnitControl4;
        private UserDeviceUnitControl userDeviceUnitControl7;
        private UserDeviceUnitControl userDeviceUnitControl3;
        private UserDeviceUnitControl userDeviceUnitControl6;
        private UserDeviceUnitControl userDeviceUnitControl2;
        private UserDeviceUnitControl userDeviceUnitControl5;
    }
}