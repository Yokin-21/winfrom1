namespace Yale.SprayProcessSCADASystem
{
    partial class PageEquipmentMonitor1
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
            components = new System.ComponentModel.Container();
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            userAlarmState1 = new UserAlarmState();
            userVarCurrentValue4 = new UserVarCurrentValue();
            userDeviceState4 = new UserDeviceState();
            userAlarmState4 = new UserAlarmState();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userVarCurrentValue1 = new UserVarCurrentValue();
            userAlarmState5 = new UserAlarmState();
            userAlarmState3 = new UserAlarmState();
            userAlarmState2 = new UserAlarmState();
            userDeviceState2 = new UserDeviceState();
            userDeviceState1 = new UserDeviceState();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            userAlarmState6 = new UserAlarmState();
            userDeviceState3 = new UserDeviceState();
            timer1 = new System.Windows.Forms.Timer(components);
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userAlarmState1);
            uiTitlePanel1.Controls.Add(userVarCurrentValue4);
            uiTitlePanel1.Controls.Add(userDeviceState4);
            uiTitlePanel1.Controls.Add(userAlarmState4);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(9, 7);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1059, 167);
            uiTitlePanel1.TabIndex = 2;
            uiTitlePanel1.Text = "精洗工位";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userAlarmState1
            // 
            userAlarmState1.DeviceName = "精洗喷淋泵过载报警";
            userAlarmState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState1.Location = new Point(760, 48);
            userAlarmState1.MinimumSize = new Size(1, 1);
            userAlarmState1.Name = "userAlarmState1";
            userAlarmState1.Size = new Size(260, 60);
            userAlarmState1.State = true;
            userAlarmState1.TabIndex = 9;
            userAlarmState1.Text = "userAlarmState1";
            userAlarmState1.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState1.VariableName = "精洗喷淋泵过载报警";
            // 
            // userVarCurrentValue4
            // 
            userVarCurrentValue4.DeviceVarName = "精洗喷淋泵压力值";
            userVarCurrentValue4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue4.Location = new Point(335, 117);
            userVarCurrentValue4.MinimumSize = new Size(1, 1);
            userVarCurrentValue4.Name = "userVarCurrentValue4";
            userVarCurrentValue4.Size = new Size(403, 47);
            userVarCurrentValue4.TabIndex = 9;
            userVarCurrentValue4.Text = "userVarCurrentValue4";
            userVarCurrentValue4.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue4.Unit = "Mpa";
            userVarCurrentValue4.VariableName = "精洗喷淋泵压力值";
            userVarCurrentValue4.VarValue = 0F;
            // 
            // userDeviceState4
            // 
            userDeviceState4.DeviceRunName = "精洗洗喷淋泵运行状态";
            userDeviceState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState4.Location = new Point(23, 48);
            userDeviceState4.MinimumSize = new Size(1, 1);
            userDeviceState4.Name = "userDeviceState4";
            userDeviceState4.RectColor = Color.Transparent;
            userDeviceState4.Size = new Size(283, 60);
            userDeviceState4.State = false;
            userDeviceState4.TabIndex = 7;
            userDeviceState4.Text = "userDeviceState4";
            userDeviceState4.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState4.VariableName = "精洗洗喷淋泵运行状态";
            // 
            // userAlarmState4
            // 
            userAlarmState4.DeviceName = "精洗低液位报警";
            userAlarmState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState4.Location = new Point(409, 48);
            userAlarmState4.MinimumSize = new Size(1, 1);
            userAlarmState4.Name = "userAlarmState4";
            userAlarmState4.Size = new Size(260, 60);
            userAlarmState4.State = true;
            userAlarmState4.TabIndex = 8;
            userAlarmState4.Text = "userAlarmState4";
            userAlarmState4.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState4.VariableName = "精洗低液位报警";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userVarCurrentValue1);
            uiTitlePanel2.Controls.Add(userAlarmState5);
            uiTitlePanel2.Controls.Add(userAlarmState3);
            uiTitlePanel2.Controls.Add(userAlarmState2);
            uiTitlePanel2.Controls.Add(userDeviceState2);
            uiTitlePanel2.Controls.Add(userDeviceState1);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(9, 189);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(1059, 167);
            uiTitlePanel2.TabIndex = 3;
            uiTitlePanel2.Text = "水分炉工位";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue1
            // 
            userVarCurrentValue1.DeviceVarName = "水分炉测量温度";
            userVarCurrentValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue1.Location = new Point(651, 107);
            userVarCurrentValue1.MinimumSize = new Size(1, 1);
            userVarCurrentValue1.Name = "userVarCurrentValue1";
            userVarCurrentValue1.Size = new Size(403, 47);
            userVarCurrentValue1.TabIndex = 10;
            userVarCurrentValue1.Text = "userVarCurrentValue1";
            userVarCurrentValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue1.Unit = "℃";
            userVarCurrentValue1.VariableName = "水分炉测量温度";
            userVarCurrentValue1.VarValue = 0F;
            // 
            // userAlarmState5
            // 
            userAlarmState5.DeviceName = "水分炉煤气泄漏报警";
            userAlarmState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState5.Location = new Point(371, 104);
            userAlarmState5.MinimumSize = new Size(1, 1);
            userAlarmState5.Name = "userAlarmState5";
            userAlarmState5.Size = new Size(260, 60);
            userAlarmState5.State = true;
            userAlarmState5.TabIndex = 9;
            userAlarmState5.Text = "userAlarmState5";
            userAlarmState5.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState5.VariableName = "水分炉煤气泄漏报警";
            // 
            // userAlarmState3
            // 
            userAlarmState3.DeviceName = "水分炉燃烧机报警";
            userAlarmState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState3.Location = new Point(46, 104);
            userAlarmState3.MinimumSize = new Size(1, 1);
            userAlarmState3.Name = "userAlarmState3";
            userAlarmState3.Size = new Size(260, 60);
            userAlarmState3.State = true;
            userAlarmState3.TabIndex = 9;
            userAlarmState3.Text = "userAlarmState3";
            userAlarmState3.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState3.VariableName = "水分炉燃烧机报警";
            // 
            // userAlarmState2
            // 
            userAlarmState2.DeviceName = "水分炉温度报警";
            userAlarmState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState2.Location = new Point(759, 39);
            userAlarmState2.MinimumSize = new Size(1, 1);
            userAlarmState2.Name = "userAlarmState2";
            userAlarmState2.Size = new Size(260, 60);
            userAlarmState2.State = true;
            userAlarmState2.TabIndex = 9;
            userAlarmState2.Text = "userAlarmState2";
            userAlarmState2.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState2.VariableName = "水分炉温度报警";
            // 
            // userDeviceState2
            // 
            userDeviceState2.DeviceRunName = "水分炉变频器运行状态";
            userDeviceState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState2.Location = new Point(23, 39);
            userDeviceState2.MinimumSize = new Size(1, 1);
            userDeviceState2.Name = "userDeviceState2";
            userDeviceState2.RectColor = Color.Transparent;
            userDeviceState2.Size = new Size(283, 60);
            userDeviceState2.State = false;
            userDeviceState2.TabIndex = 8;
            userDeviceState2.Text = "userDeviceState2";
            userDeviceState2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState2.VariableName = "水分炉变频器运行状态";
            // 
            // userDeviceState1
            // 
            userDeviceState1.DeviceRunName = "水分炉炉口风帘风机运行状态";
            userDeviceState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState1.Location = new Point(355, 39);
            userDeviceState1.MinimumSize = new Size(1, 1);
            userDeviceState1.Name = "userDeviceState1";
            userDeviceState1.RectColor = Color.Transparent;
            userDeviceState1.Size = new Size(344, 60);
            userDeviceState1.State = false;
            userDeviceState1.TabIndex = 8;
            userDeviceState1.Text = "userDeviceState1";
            userDeviceState1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState1.VariableName = "水分炉炉口风帘风机运行状态";
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(userAlarmState6);
            uiTitlePanel3.Controls.Add(userDeviceState3);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel3.Location = new Point(9, 371);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(1059, 167);
            uiTitlePanel3.TabIndex = 4;
            uiTitlePanel3.Text = "冷却室工位";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userAlarmState6
            // 
            userAlarmState6.DeviceName = "冷却室离心风机过载报警";
            userAlarmState6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState6.Location = new Point(606, 69);
            userAlarmState6.MinimumSize = new Size(1, 1);
            userAlarmState6.Name = "userAlarmState6";
            userAlarmState6.Size = new Size(324, 60);
            userAlarmState6.State = true;
            userAlarmState6.TabIndex = 10;
            userAlarmState6.Text = "userAlarmState6";
            userAlarmState6.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState6.VariableName = "冷却室离心风机过载报警";
            // 
            // userDeviceState3
            // 
            userDeviceState3.DeviceRunName = "冷却室离心风机运行状态";
            userDeviceState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState3.Location = new Point(151, 69);
            userDeviceState3.MinimumSize = new Size(1, 1);
            userDeviceState3.Name = "userDeviceState3";
            userDeviceState3.RectColor = Color.Transparent;
            userDeviceState3.Size = new Size(332, 60);
            userDeviceState3.State = false;
            userDeviceState3.TabIndex = 9;
            userDeviceState3.Text = "userDeviceState3";
            userDeviceState3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState3.VariableName = "冷却室离心风机运行状态";
            // 
            // PageEquipmentMonitor1
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor1";
            Symbol = 57397;
            Text = "设备监控2";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserAlarmState userAlarmState1;
        private UserVarCurrentValue userVarCurrentValue4;
        private UserDeviceState userDeviceState4;
        private UserAlarmState userAlarmState4;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserVarCurrentValue userVarCurrentValue1;
        private UserAlarmState userAlarmState5;
        private UserAlarmState userAlarmState3;
        private UserAlarmState userAlarmState2;
        private UserDeviceState userDeviceState2;
        private UserDeviceState userDeviceState1;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private UserAlarmState userAlarmState6;
        private UserDeviceState userDeviceState3;
        private System.Windows.Forms.Timer timer1;
    }
}