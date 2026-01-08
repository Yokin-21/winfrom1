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
using static Sunny.UI.UITextBox;

namespace Yale.SprayProcessSCADASystem
{
    public partial class UserSetValue : UIUserControl
    {
        public UserSetValue()
        {
            InitializeComponent();
        }
        private string deviceVarName = "名称";

        [Description("设备变量名称")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string DeviceVarName
        {
            get { return deviceVarName; }
            set
            {
                deviceVarName = value;
                this.lbl_Name.Text = deviceVarName;
            }
        }

        private string varValue = "";
        [Description("变量值")]
        [Category("自定义属性")]
        [Browsable(true)]
        public string VarValue
        {
            get { return varValue; }
            set
            {
                varValue = value;
                this.txt_Value.Text = varValue;
            }
        }

        private UIEditType dataType = UIEditType.Double;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("数值类型")]
        public UIEditType DataType
        {
            get { return dataType; }
            set
            {
                dataType = value;
                this.txt_Value.Type = dataType;
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

        private void txt_Value_TextChanged(object sender, EventArgs e)
        {
            VarValue = this.txt_Value.Text;
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
