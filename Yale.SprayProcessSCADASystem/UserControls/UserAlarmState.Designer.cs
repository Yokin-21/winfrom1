namespace Yale.SprayProcessSCADASystem
{
    partial class UserAlarmState
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
            lbl_StateName = new Sunny.UI.UILabel();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            lbl_AlarmState = new Sunny.UI.UISymbolLabel();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            lbl_StateName.Text = "报警名称";
            lbl_StateName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 2;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            uiTableLayoutPanel1.Controls.Add(lbl_StateName, 0, 0);
            uiTableLayoutPanel1.Controls.Add(lbl_AlarmState, 1, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 1;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Size = new Size(250, 60);
            uiTableLayoutPanel1.TabIndex = 1;
            uiTableLayoutPanel1.TagString = null;
            // 
            // lbl_AlarmState
            // 
            lbl_AlarmState.Dock = DockStyle.Fill;
            lbl_AlarmState.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_AlarmState.Location = new Point(193, 3);
            lbl_AlarmState.MinimumSize = new Size(1, 1);
            lbl_AlarmState.Name = "lbl_AlarmState";
            lbl_AlarmState.Size = new Size(54, 54);
            lbl_AlarmState.Symbol = 61683;
            lbl_AlarmState.SymbolColor = Color.Red;
            lbl_AlarmState.SymbolSize = 54;
            lbl_AlarmState.TabIndex = 1;
            // 
            // UserAlarmState
            // 
            AutoScaleMode = AutoScaleMode.None;
            Controls.Add(uiTableLayoutPanel1);
            Name = "UserAlarmState";
            Size = new Size(250, 60);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UILabel lbl_StateName;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UISymbolLabel lbl_AlarmState;
    }
}
