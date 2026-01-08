namespace Yale.SprayProcessSCADASystem
{
    partial class PageLogManage
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            uiTitlePanel1 = new Sunny.UI.UITitlePanel();
            btn_ExportExcel = new Sunny.UI.UISymbolButton();
            btn_ShowToTXT = new Sunny.UI.UISymbolButton();
            btn_ShowToDgv = new Sunny.UI.UISymbolButton();
            btn_OpenDire = new Sunny.UI.UISymbolButton();
            lb_Files = new Sunny.UI.UIListBox();
            cb_LogLev = new Sunny.UI.UIComboBox();
            cb_Date = new Sunny.UI.UIComboBox();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            txt_ShowLog = new Sunny.UI.UITextBox();
            uiTitlePanel3 = new Sunny.UI.UITitlePanel();
            dgv_ShowLog = new Sunny.UI.UIDataGridView();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            uiTitlePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_ShowLog).BeginInit();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(btn_ExportExcel);
            uiTitlePanel1.Controls.Add(btn_ShowToTXT);
            uiTitlePanel1.Controls.Add(btn_ShowToDgv);
            uiTitlePanel1.Controls.Add(btn_OpenDire);
            uiTitlePanel1.Controls.Add(lb_Files);
            uiTitlePanel1.Controls.Add(cb_LogLev);
            uiTitlePanel1.Controls.Add(cb_Date);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(4, 3);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(329, 542);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "选择等级";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // btn_ExportExcel
            // 
            btn_ExportExcel.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ExportExcel.Location = new Point(15, 461);
            btn_ExportExcel.MinimumSize = new Size(1, 1);
            btn_ExportExcel.Name = "btn_ExportExcel";
            btn_ExportExcel.Size = new Size(308, 67);
            btn_ExportExcel.Symbol = 361891;
            btn_ExportExcel.TabIndex = 2;
            btn_ExportExcel.Text = "日志导出Excel";
            btn_ExportExcel.Click += btn_ExportExcel_Click;
            // 
            // btn_ShowToTXT
            // 
            btn_ShowToTXT.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ShowToTXT.Location = new Point(15, 388);
            btn_ShowToTXT.MinimumSize = new Size(1, 1);
            btn_ShowToTXT.Name = "btn_ShowToTXT";
            btn_ShowToTXT.Size = new Size(308, 67);
            btn_ShowToTXT.Symbol = 57381;
            btn_ShowToTXT.TabIndex = 2;
            btn_ShowToTXT.Text = "日志导出TXT";
            btn_ShowToTXT.Click += btn_ShowToTXT_Click;
            // 
            // btn_ShowToDgv
            // 
            btn_ShowToDgv.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ShowToDgv.Location = new Point(15, 315);
            btn_ShowToDgv.MinimumSize = new Size(1, 1);
            btn_ShowToDgv.Name = "btn_ShowToDgv";
            btn_ShowToDgv.Size = new Size(308, 67);
            btn_ShowToDgv.Symbol = 57381;
            btn_ShowToDgv.TabIndex = 2;
            btn_ShowToDgv.Text = "显示到表格";
            btn_ShowToDgv.Click += btn_ShowToDgv_Click;
            // 
            // btn_OpenDire
            // 
            btn_OpenDire.Font = new Font("微软雅黑", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_OpenDire.Location = new Point(15, 242);
            btn_OpenDire.MinimumSize = new Size(1, 1);
            btn_OpenDire.Name = "btn_OpenDire";
            btn_OpenDire.Size = new Size(308, 67);
            btn_OpenDire.Symbol = 261564;
            btn_OpenDire.TabIndex = 2;
            btn_OpenDire.Text = "打开日志目录";
            btn_OpenDire.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_OpenDire.Click += btn_OpenDire_Click;
            // 
            // lb_Files
            // 
            lb_Files.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Files.HoverColor = Color.FromArgb(155, 200, 255);
            lb_Files.ItemSelectForeColor = Color.White;
            lb_Files.Location = new Point(15, 82);
            lb_Files.Margin = new Padding(4, 5, 4, 5);
            lb_Files.MinimumSize = new Size(1, 1);
            lb_Files.Name = "lb_Files";
            lb_Files.Padding = new Padding(2);
            lb_Files.ShowText = false;
            lb_Files.Size = new Size(308, 152);
            lb_Files.TabIndex = 1;
            lb_Files.Text = "uiListBox1";
            lb_Files.SelectedIndexChanged += lb_Files_SelectedIndexChanged;
            // 
            // cb_LogLev
            // 
            cb_LogLev.DataSource = null;
            cb_LogLev.FillColor = Color.White;
            cb_LogLev.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_LogLev.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cb_LogLev.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cb_LogLev.Location = new Point(175, 42);
            cb_LogLev.Margin = new Padding(4, 5, 4, 5);
            cb_LogLev.MinimumSize = new Size(63, 0);
            cb_LogLev.Name = "cb_LogLev";
            cb_LogLev.Padding = new Padding(0, 0, 30, 2);
            cb_LogLev.Size = new Size(150, 29);
            cb_LogLev.SymbolSize = 24;
            cb_LogLev.TabIndex = 0;
            cb_LogLev.TextAlignment = ContentAlignment.MiddleLeft;
            cb_LogLev.Watermark = "选择等级";
            cb_LogLev.SelectedIndexChanged += cb_LogLev_SelectedIndexChanged;
            // 
            // cb_Date
            // 
            cb_Date.DataSource = null;
            cb_Date.FillColor = Color.White;
            cb_Date.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cb_Date.ItemHoverColor = Color.FromArgb(155, 200, 255);
            cb_Date.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            cb_Date.Location = new Point(4, 42);
            cb_Date.Margin = new Padding(4, 5, 4, 5);
            cb_Date.MinimumSize = new Size(63, 0);
            cb_Date.Name = "cb_Date";
            cb_Date.Padding = new Padding(0, 0, 30, 2);
            cb_Date.Size = new Size(150, 29);
            cb_Date.SymbolSize = 24;
            cb_Date.TabIndex = 0;
            cb_Date.TextAlignment = ContentAlignment.MiddleLeft;
            cb_Date.Watermark = "选择日期";
            cb_Date.SelectedIndexChanged += cb_Date_SelectedIndexChanged;
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(txt_ShowLog);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(335, 3);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(293, 542);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "文本显示";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // txt_ShowLog
            // 
            txt_ShowLog.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ShowLog.Location = new Point(4, 42);
            txt_ShowLog.Margin = new Padding(4, 5, 4, 5);
            txt_ShowLog.MinimumSize = new Size(1, 16);
            txt_ShowLog.Multiline = true;
            txt_ShowLog.Name = "txt_ShowLog";
            txt_ShowLog.Padding = new Padding(5);
            txt_ShowLog.ShowText = false;
            txt_ShowLog.Size = new Size(285, 495);
            txt_ShowLog.TabIndex = 0;
            txt_ShowLog.TextAlignment = ContentAlignment.MiddleLeft;
            txt_ShowLog.Watermark = "";
            // 
            // uiTitlePanel3
            // 
            uiTitlePanel3.Controls.Add(dgv_ShowLog);
            uiTitlePanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel3.Location = new Point(630, 3);
            uiTitlePanel3.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel3.MinimumSize = new Size(1, 1);
            uiTitlePanel3.Name = "uiTitlePanel3";
            uiTitlePanel3.ShowText = false;
            uiTitlePanel3.Size = new Size(453, 542);
            uiTitlePanel3.TabIndex = 2;
            uiTitlePanel3.Text = "表格显示";
            uiTitlePanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgv_ShowLog
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgv_ShowLog.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_ShowLog.BackgroundColor = Color.White;
            dgv_ShowLog.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_ShowLog.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_ShowLog.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_ShowLog.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_ShowLog.EnableHeadersVisualStyles = false;
            dgv_ShowLog.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_ShowLog.GridColor = Color.FromArgb(80, 160, 255);
            dgv_ShowLog.Location = new Point(0, 41);
            dgv_ShowLog.Name = "dgv_ShowLog";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_ShowLog.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_ShowLog.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_ShowLog.RowTemplate.Height = 25;
            dgv_ShowLog.SelectedIndex = -1;
            dgv_ShowLog.Size = new Size(451, 496);
            dgv_ShowLog.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgv_ShowLog.TabIndex = 0;
            // 
            // PageLogManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel3);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageLogManage";
            Symbol = 162333;
            Text = "日志管理";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            uiTitlePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_ShowLog).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private Sunny.UI.UISymbolButton btn_OpenDire;
        private Sunny.UI.UIListBox lb_Files;
        private Sunny.UI.UIComboBox cb_LogLev;
        private Sunny.UI.UIComboBox cb_Date;
        private Sunny.UI.UISymbolButton btn_ExportExcel;
        private Sunny.UI.UISymbolButton btn_ShowToTXT;
        private Sunny.UI.UISymbolButton btn_ShowToDgv;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UITextBox txt_ShowLog;
        private Sunny.UI.UITitlePanel uiTitlePanel3;
        private Sunny.UI.UIDataGridView dgv_ShowLog;
    }
}