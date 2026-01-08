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

namespace Yale.SprayProcessSCADASystem
{
    public partial class UserDeviceState : UIUserControl
    {
        public UserDeviceState()
        {
            InitializeComponent();
        }

        private string deviceRunName = "状态名称";

        [Description("设置或获取设备运行状态名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string DeviceRunName
        {
            get { return deviceRunName; }
            set
            {
                deviceRunName = value;
                this.lbl_StateName.Text = value;
            }
        }

        // 设备状态属性
        private bool state = false;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取设备运行状态")]
        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                if (state)
                {
                    this.light_State.State = UILightState.On;
                }
                else
                {
                    this.light_State.State = UILightState.Off;
                }
            }
        }


        private string variableName = "";
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("获取变量名称")]
        public string VariableName
        {
            get { return variableName; }
            set { variableName = value; }
        }
    }
}
