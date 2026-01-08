namespace Yale.SprayProcessSCADASystem
{
    partial class PageEquipmentMonitor2
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
            userVarCurrentValue4 = new UserVarCurrentValue();
            userAlarmState1 = new UserAlarmState();
            userAlarmState2 = new UserAlarmState();
            userDeviceState1 = new UserDeviceState();
            userAlarmState4 = new UserAlarmState();
            userDeviceState4 = new UserDeviceState();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            userAlarmState5 = new UserAlarmState();
            userAlarmState3 = new UserAlarmState();
            userDeviceState3 = new UserDeviceState();
            userDeviceState2 = new UserDeviceState();
            timer1 = new System.Windows.Forms.Timer(components);
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userVarCurrentValue4);
            uiTitlePanel1.Controls.Add(userAlarmState1);
            uiTitlePanel1.Controls.Add(userAlarmState2);
            uiTitlePanel1.Controls.Add(userDeviceState1);
            uiTitlePanel1.Controls.Add(userAlarmState4);
            uiTitlePanel1.Controls.Add(userDeviceState4);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(9, 7);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(1059, 167);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "固化炉工位";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userVarCurrentValue4
            // 
            userVarCurrentValue4.DeviceVarName = "固化炉测量温度";
            userVarCurrentValue4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userVarCurrentValue4.Location = new Point(653, 112);
            userVarCurrentValue4.MinimumSize = new Size(1, 1);
            userVarCurrentValue4.Name = "userVarCurrentValue4";
            userVarCurrentValue4.Size = new Size(403, 47);
            userVarCurrentValue4.TabIndex = 12;
            userVarCurrentValue4.Text = "userVarCurrentValue4";
            userVarCurrentValue4.TextAlignment = ContentAlignment.MiddleCenter;
            userVarCurrentValue4.Unit = "℃";
            userVarCurrentValue4.VariableName = "固化炉测量温度";
            userVarCurrentValue4.VarValue = 0F;
            // 
            // userAlarmState1
            // 
            userAlarmState1.DeviceName = "固化炉燃烧机报警";
            userAlarmState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState1.Location = new Point(43, 112);
            userAlarmState1.MinimumSize = new Size(1, 1);
            userAlarmState1.Name = "userAlarmState1";
            userAlarmState1.Size = new Size(270, 52);
            userAlarmState1.State = true;
            userAlarmState1.TabIndex = 12;
            userAlarmState1.Text = "userAlarmState1";
            userAlarmState1.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState1.VariableName = "固化炉燃烧机报警";
            // 
            // userAlarmState2
            // 
            userAlarmState2.DeviceName = "固化炉煤气泄漏报警";
            userAlarmState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState2.Location = new Point(334, 112);
            userAlarmState2.MinimumSize = new Size(1, 1);
            userAlarmState2.Name = "userAlarmState2";
            userAlarmState2.Size = new Size(270, 52);
            userAlarmState2.State = true;
            userAlarmState2.TabIndex = 12;
            userAlarmState2.Text = "userAlarmState2";
            userAlarmState2.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState2.VariableName = "固化炉煤气泄漏报警";
            // 
            // userDeviceState1
            // 
            userDeviceState1.DeviceRunName = "固化炉炉口风帘风机运行状态";
            userDeviceState1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState1.Location = new Point(334, 46);
            userDeviceState1.MinimumSize = new Size(1, 1);
            userDeviceState1.Name = "userDeviceState1";
            userDeviceState1.RectColor = Color.Transparent;
            userDeviceState1.Size = new Size(343, 60);
            userDeviceState1.State = false;
            userDeviceState1.TabIndex = 11;
            userDeviceState1.Text = "userDeviceState1";
            userDeviceState1.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState1.VariableName = "固化炉炉口风帘风机运行状态";
            // 
            // userAlarmState4
            // 
            userAlarmState4.DeviceName = "固化炉煤气泄漏报警";
            userAlarmState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState4.Location = new Point(709, 46);
            userAlarmState4.MinimumSize = new Size(1, 1);
            userAlarmState4.Name = "userAlarmState4";
            userAlarmState4.Size = new Size(260, 60);
            userAlarmState4.State = true;
            userAlarmState4.TabIndex = 11;
            userAlarmState4.Text = "userAlarmState4";
            userAlarmState4.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState4.VariableName = "固化炉煤气泄漏报警";
            // 
            // userDeviceState4
            // 
            userDeviceState4.DeviceRunName = "固化炉变频器运行状态";
            userDeviceState4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState4.Location = new Point(30, 46);
            userDeviceState4.MinimumSize = new Size(1, 1);
            userDeviceState4.Name = "userDeviceState4";
            userDeviceState4.RectColor = Color.Transparent;
            userDeviceState4.Size = new Size(283, 60);
            userDeviceState4.State = false;
            userDeviceState4.TabIndex = 10;
            userDeviceState4.Text = "userDeviceState4";
            userDeviceState4.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState4.VariableName = "固化炉变频器运行状态";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(userAlarmState5);
            uiTitlePanel2.Controls.Add(userAlarmState3);
            uiTitlePanel2.Controls.Add(userDeviceState3);
            uiTitlePanel2.Controls.Add(userDeviceState2);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(9, 189);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(1059, 167);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "输送机工位";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userAlarmState5
            // 
            userAlarmState5.DeviceName = "输送机行程报警";
            userAlarmState5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState5.Location = new Point(593, 107);
            userAlarmState5.MinimumSize = new Size(1, 1);
            userAlarmState5.Name = "userAlarmState5";
            userAlarmState5.Size = new Size(270, 52);
            userAlarmState5.State = true;
            userAlarmState5.TabIndex = 13;
            userAlarmState5.Text = "userAlarmState5";
            userAlarmState5.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState5.VariableName = "输送机行程报警";
            // 
            // userAlarmState3
            // 
            userAlarmState3.DeviceName = "输送机变频器故障报警";
            userAlarmState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAlarmState3.Location = new Point(560, 41);
            userAlarmState3.MinimumSize = new Size(1, 1);
            userAlarmState3.Name = "userAlarmState3";
            userAlarmState3.Size = new Size(303, 52);
            userAlarmState3.State = true;
            userAlarmState3.TabIndex = 13;
            userAlarmState3.Text = "userAlarmState3";
            userAlarmState3.TextAlignment = ContentAlignment.MiddleCenter;
            userAlarmState3.VariableName = "输送机变频器故障报警";
            // 
            // userDeviceState3
            // 
            userDeviceState3.DeviceRunName = "输送机变频器运行状态";
            userDeviceState3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState3.Location = new Point(129, 104);
            userDeviceState3.MinimumSize = new Size(1, 1);
            userDeviceState3.Name = "userDeviceState3";
            userDeviceState3.RectColor = Color.Transparent;
            userDeviceState3.Size = new Size(283, 60);
            userDeviceState3.State = false;
            userDeviceState3.TabIndex = 11;
            userDeviceState3.Text = "userDeviceState3";
            userDeviceState3.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState3.VariableName = "输送机变频器运行状态";
            // 
            // userDeviceState2
            // 
            userDeviceState2.DeviceRunName = "输送机变频器电源状态";
            userDeviceState2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userDeviceState2.Location = new Point(129, 41);
            userDeviceState2.MinimumSize = new Size(1, 1);
            userDeviceState2.Name = "userDeviceState2";
            userDeviceState2.RectColor = Color.Transparent;
            userDeviceState2.Size = new Size(283, 60);
            userDeviceState2.State = false;
            userDeviceState2.TabIndex = 11;
            userDeviceState2.Text = "userDeviceState2";
            userDeviceState2.TextAlignment = ContentAlignment.MiddleCenter;
            userDeviceState2.VariableName = "输送机变频器电源状态";
            // 
            // PageEquipmentMonitor2
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageEquipmentMonitor2";
            Symbol = 57397;
            Text = "设备监控3";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserVarCurrentValue userVarCurrentValue4;
        private UserAlarmState userAlarmState1;
        private UserAlarmState userAlarmState2;
        private UserDeviceState userDeviceState1;
        private UserAlarmState userAlarmState4;
        private UserDeviceState userDeviceState4;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private UserAlarmState userAlarmState5;
        private UserAlarmState userAlarmState3;
        private UserDeviceState userDeviceState3;
        private UserDeviceState userDeviceState2;
        private System.Windows.Forms.Timer timer1;
    }
}