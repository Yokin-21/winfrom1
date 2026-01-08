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

    public partial class UserAlarmState : UIUserControl
    {
        public UserAlarmState()
        {
            InitializeComponent();
        }
        private string deviceAlarmName = "报警名称";

        [Description("设置或获取设备报警名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string DeviceName
        {
            get { return deviceAlarmName; }
            set
            {
                deviceAlarmName = value;
                this.lbl_StateName.Text = value;
            }
        }

        // 设备状态属性
        private bool state = true;

        [Browsable(true)]
        [Category("自定义属性")]
        [Description("设置或获取设备报警的状态")]
        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                if (state)
                {
                    this.lbl_AlarmState.SymbolColor = Color.Red;
                }
                else
                {
                    this.lbl_AlarmState.SymbolColor = Color.LimeGreen;
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
