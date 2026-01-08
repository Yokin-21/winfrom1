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
    public partial class UserCounterButton : UIUserControl
    {
        private UIStyle Style;
        private Color defaultFillColor;
        private Color defaultRectColor;

        public UserCounterButton()
        {
            InitializeComponent();
            this.Load += UserCounterButton_Load;
        }

        // 用户按钮加载事件
        private void UserCounterButton_Load(object? sender, EventArgs e)
        {
            UIExtension.SetStyleManager = SetStyle; // 设置样式管理器
                                                    //80, 160, 255
            defaultFillColor = this.btn_Counter.FillColor;
            defaultRectColor = this.btn_Counter.RectColor;
        }

        // 设置样式的方法
        private void SetStyle(UIStyleManager manager)
        {
            this.btn_Counter.Style = manager.Style;
            Style = manager.Style;
            if (CounterButtonState)
            {
                this.btn_Counter.FillColor = this.btn_Counter.FillPressColor;
                this.btn_Counter.FillColor2 = this.btn_Counter.FillPressColor;
                this.RectColor = this.btn_Counter.RectPressColor;
            }
        }

        // 定义一个私有变量，用于存储按钮的符号
        private int counterButtonSymbol = 61452;
        [Browsable(true)] // 使属性可以在属性窗口中编辑
        [Category("自定义属性")] // 分类属性
        [Description("取反按钮标签")] // 描述属性的用途
        public int CounterButtonSymbol
        {
            get { return counterButtonSymbol; }
            set
            {
                counterButtonSymbol = value;
                this.btn_Counter.Symbol = counterButtonSymbol;
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

        private bool counterButtonState;
        [Browsable(true)]
        [Category("自定义属性")]
        [Description("取反按钮状态")]
        public bool CounterButtonState
        {
            get { return counterButtonState; }
            set
            {
                counterButtonState = value;
                if (counterButtonState == true)
                {
                    this.btn_Counter.FillColor = this.btn_Counter.FillPressColor;
                    this.btn_Counter.FillColor2 = this.btn_Counter.FillPressColor;
                    this.RectColor = this.btn_Counter.RectPressColor;
                }
                else
                {
                    if (this.btn_Counter.Style != Style)
                    {
                        this.btn_Counter.Style = Style;
                    }
                    else
                    {
                        this.btn_Counter.FillColor = defaultFillColor;
                        this.btn_Counter.FillColor2 = defaultFillColor;
                        this.btn_Counter.RectColor = defaultRectColor;
                    }
                }
            }
        }

        [Browsable(true)]
        [Category("自定义事件")]
        [Description("点击事件")]
        public event EventHandler ClickEvent;
        private void btn_Counter_Click(object sender, EventArgs e)
        {
            ClickEvent?.Invoke(this, e);
        }

    }
}
