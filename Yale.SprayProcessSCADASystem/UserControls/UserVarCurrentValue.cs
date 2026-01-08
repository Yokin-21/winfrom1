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
    public partial class UserVarCurrentValue : UIUserControl
    {
        public UserVarCurrentValue()
        {
            InitializeComponent();
        }
        // 设置设备名称
        private string deviceVarName = "名称";

        [Description("设置或获取设备变量名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string DeviceVarName
        {
            get { return deviceVarName; }
            set
            {
                deviceVarName = value;
                this.lbl_Name.Text = value;
            }
        }

        private float varValue;
        [Description("设置或获取设备变量值")]
        [Category("自定义属性")]
        [Browsable(true)]
        public float VarValue
        {
            get { return varValue; }
            set
            {
                varValue = value;
                this.dl_Value.Value = varValue;
            }
        }


        private string unit = "单位";
        [Description("设置或获取单位")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string Unit
        {
            get { return unit; }
            set
            {
                unit = value;
                this.lbl_Unit.Text = unit;
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
