namespace Yale.SprayProcessSCADASystem
{
    partial class UserDeviceState
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            lbl_StateName = new Sunny.UI.UILabel();
            light_State = new Sunny.UI.UILight();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            uiTableLayoutPanel1.Controls.Add(lbl_StateName, 0, 0);
            uiTableLayoutPanel1.Controls.Add(light_State, 1, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(250, 60);
            uiTableLayoutPanel1.TabIndex = 0;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lbl_StateName
            // 
            lbl_StateName.Dock = DockStyle.Fill;
            lbl_StateName.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_StateName.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_StateName.Location = new Point(3, 0);
            lbl_StateName.Name = "lbl_StateName";
            lbl_StateName.Size = new Size(184, 60);
            lbl_StateName.TabIndex = 0;
            lbl_StateName.Text = "状态名称";
            lbl_StateName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // light_State
            // 
            light_State.Dock = DockStyle.Fill;
            light_State.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            light_State.Location = new Point(193, 3);
            light_State.MinimumSize = new Size(1, 1);
            light_State.Name = "light_State";
            light_State.OffColor = Color.Red;
            light_State.Radius = 54;
            light_State.Size = new Size(54, 54);
            light_State.TabIndex = 1;
            light_State.Text = "uiLight1";
            // 
            // UserDeviceState
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(uiTableLayoutPanel1);
            Name = "UserDeviceState";
            RectColor = Color.Transparent;
            Size = new Size(250, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UILabel lbl_StateName;
        private Sunny.UI.UILight light_State;
    }
}
