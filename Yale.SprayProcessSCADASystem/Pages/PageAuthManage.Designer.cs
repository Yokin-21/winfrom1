namespace Yale.SprayProcessSCADASystem
{
    partial class PageAuthManage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageAuthManage));
            cbg_Engineer = new Sunny.UI.UICheckBoxGroup();
            cbg_Operator = new Sunny.UI.UICheckBoxGroup();
            cbg_Visitor = new Sunny.UI.UICheckBoxGroup();
            btn_UpdateEngAuth = new Sunny.UI.UIButton();
            btn_UpdateOpAuth = new Sunny.UI.UIButton();
            btn_UpdateVisitorAuth = new Sunny.UI.UIButton();
            SuspendLayout();
            // 
            // cbg_Engineer
            // 
            cbg_Engineer.CheckBoxSize = 25;
            cbg_Engineer.ColumnInterval = 20;
            cbg_Engineer.Font = new Font("宋体", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbg_Engineer.HoverColor = Color.FromArgb(220, 236, 255);
            cbg_Engineer.Items.AddRange(new object[] { "控制模块", "监控模块", "配方模块", "日志模块", "报表模块", "图表模块", "参数模块" });
            cbg_Engineer.Location = new Point(42, 84);
            cbg_Engineer.Margin = new Padding(4, 5, 4, 5);
            cbg_Engineer.MinimumSize = new Size(1, 1);
            cbg_Engineer.Name = "cbg_Engineer";
            cbg_Engineer.Padding = new Padding(0, 46, 0, 0);
            cbg_Engineer.RowInterval = 15;
            cbg_Engineer.SelectedIndexes = (List<int>)resources.GetObject("cbg_Engineer.SelectedIndexes");
            cbg_Engineer.Size = new Size(222, 372);
            cbg_Engineer.StartPos = new Point(30, 30);
            cbg_Engineer.TabIndex = 0;
            cbg_Engineer.Text = "工程师权限";
            cbg_Engineer.TextAlignment = ContentAlignment.MiddleLeft;
            cbg_Engineer.TitleInterval = 35;
            cbg_Engineer.TitleTop = 30;
            // 
            // cbg_Operator
            // 
            cbg_Operator.CheckBoxSize = 25;
            cbg_Operator.ColumnInterval = 20;
            cbg_Operator.Font = new Font("宋体", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbg_Operator.HoverColor = Color.FromArgb(220, 236, 255);
            cbg_Operator.Items.AddRange(new object[] { "控制模块", "监控模块", "配方模块", "日志模块", "报表模块", "图表模块", "参数模块" });
            cbg_Operator.Location = new Point(330, 84);
            cbg_Operator.Margin = new Padding(4, 5, 4, 5);
            cbg_Operator.MinimumSize = new Size(1, 1);
            cbg_Operator.Name = "cbg_Operator";
            cbg_Operator.Padding = new Padding(0, 46, 0, 0);
            cbg_Operator.RowInterval = 15;
            cbg_Operator.SelectedIndexes = (List<int>)resources.GetObject("cbg_Operator.SelectedIndexes");
            cbg_Operator.Size = new Size(222, 372);
            cbg_Operator.StartPos = new Point(30, 30);
            cbg_Operator.TabIndex = 0;
            cbg_Operator.Text = "操作员权限";
            cbg_Operator.TextAlignment = ContentAlignment.MiddleLeft;
            cbg_Operator.TitleInterval = 35;
            cbg_Operator.TitleTop = 30;
            // 
            // cbg_Visitor
            // 
            cbg_Visitor.CheckBoxSize = 25;
            cbg_Visitor.ColumnInterval = 20;
            cbg_Visitor.Font = new Font("宋体", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            cbg_Visitor.HoverColor = Color.FromArgb(220, 236, 255);
            cbg_Visitor.Items.AddRange(new object[] { "控制模块", "监控模块", "配方模块", "日志模块", "报表模块", "图表模块", "参数模块" });
            cbg_Visitor.Location = new Point(616, 84);
            cbg_Visitor.Margin = new Padding(4, 5, 4, 5);
            cbg_Visitor.MinimumSize = new Size(1, 1);
            cbg_Visitor.Name = "cbg_Visitor";
            cbg_Visitor.Padding = new Padding(0, 46, 0, 0);
            cbg_Visitor.RowInterval = 15;
            cbg_Visitor.SelectedIndexes = (List<int>)resources.GetObject("cbg_Visitor.SelectedIndexes");
            cbg_Visitor.Size = new Size(222, 372);
            cbg_Visitor.StartPos = new Point(30, 30);
            cbg_Visitor.TabIndex = 0;
            cbg_Visitor.Text = "访客权限";
            cbg_Visitor.TextAlignment = ContentAlignment.MiddleLeft;
            cbg_Visitor.TitleInterval = 35;
            cbg_Visitor.TitleTop = 30;
            // 
            // btn_UpdateEngAuth
            // 
            btn_UpdateEngAuth.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateEngAuth.Location = new Point(873, 105);
            btn_UpdateEngAuth.MinimumSize = new Size(1, 1);
            btn_UpdateEngAuth.Name = "btn_UpdateEngAuth";
            btn_UpdateEngAuth.Size = new Size(200, 91);
            btn_UpdateEngAuth.TabIndex = 1;
            btn_UpdateEngAuth.Text = "修改工程师权限";
            btn_UpdateEngAuth.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateEngAuth.Click += btn_UpdateEngAuth_Click;
            // 
            // btn_UpdateOpAuth
            // 
            btn_UpdateOpAuth.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateOpAuth.Location = new Point(873, 234);
            btn_UpdateOpAuth.MinimumSize = new Size(1, 1);
            btn_UpdateOpAuth.Name = "btn_UpdateOpAuth";
            btn_UpdateOpAuth.Size = new Size(200, 91);
            btn_UpdateOpAuth.TabIndex = 1;
            btn_UpdateOpAuth.Text = "修改操作员权限";
            btn_UpdateOpAuth.Click += btn_UpdateOpAuth_Click;
            // 
            // btn_UpdateVisitorAuth
            // 
            btn_UpdateVisitorAuth.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateVisitorAuth.Location = new Point(873, 365);
            btn_UpdateVisitorAuth.MinimumSize = new Size(1, 1);
            btn_UpdateVisitorAuth.Name = "btn_UpdateVisitorAuth";
            btn_UpdateVisitorAuth.Size = new Size(200, 91);
            btn_UpdateVisitorAuth.TabIndex = 1;
            btn_UpdateVisitorAuth.Text = "修改访客权限";
            btn_UpdateVisitorAuth.Click += btn_UpdateVisitorAuth_Click;
            // 
            // PageAuthManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(btn_UpdateVisitorAuth);
            Controls.Add(btn_UpdateOpAuth);
            Controls.Add(btn_UpdateEngAuth);
            Controls.Add(cbg_Visitor);
            Controls.Add(cbg_Operator);
            Controls.Add(cbg_Engineer);
            Name = "PageAuthManage";
            Symbol = 362722;
            Text = "权限管理";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UICheckBoxGroup cbg_Engineer;
        private Sunny.UI.UICheckBoxGroup cbg_Operator;
        private Sunny.UI.UICheckBoxGroup cbg_Visitor;
        private Sunny.UI.UIButton btn_UpdateEngAuth;
        private Sunny.UI.UIButton btn_UpdateOpAuth;
        private Sunny.UI.UIButton btn_UpdateVisitorAuth;
    }
}