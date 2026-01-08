namespace Yale.SprayProcessSCADASystem
{
    partial class PageChartManage
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
            btn_QueryData = new Sunny.UI.UISymbolButton();
            dtp_End = new Sunny.UI.UIDatetimePicker();
            uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            dtp_Start = new Sunny.UI.UIDatetimePicker();
            uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            lc_Chart = new Sunny.UI.UILineChart();
            SuspendLayout();
            // 
            // btn_QueryData
            // 
            btn_QueryData.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QueryData.Location = new Point(814, 8);
            btn_QueryData.MinimumSize = new Size(1, 1);
            btn_QueryData.Name = "btn_QueryData";
            btn_QueryData.Size = new Size(132, 38);
            btn_QueryData.Symbol = 559520;
            btn_QueryData.TabIndex = 7;
            btn_QueryData.Text = "查询数据";
            btn_QueryData.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QueryData.Click += btn_QueryData_Click;
            // 
            // dtp_End
            // 
            dtp_End.FillColor = Color.White;
            dtp_End.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_End.Location = new Point(571, 14);
            dtp_End.Margin = new Padding(4, 5, 4, 5);
            dtp_End.MaxLength = 19;
            dtp_End.MinimumSize = new Size(63, 0);
            dtp_End.Name = "dtp_End";
            dtp_End.Padding = new Padding(0, 0, 30, 2);
            dtp_End.Size = new Size(200, 29);
            dtp_End.SymbolDropDown = 61555;
            dtp_End.SymbolNormal = 61555;
            dtp_End.SymbolSize = 24;
            dtp_End.TabIndex = 5;
            dtp_End.Text = "2024-11-11 16:28:09";
            dtp_End.TextAlignment = ContentAlignment.MiddleLeft;
            dtp_End.Value = new DateTime(2024, 11, 11, 16, 28, 9, 341);
            dtp_End.Watermark = "";
            // 
            // uiSymbolLabel2
            // 
            uiSymbolLabel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiSymbolLabel2.Location = new Point(423, 11);
            uiSymbolLabel2.MinimumSize = new Size(1, 1);
            uiSymbolLabel2.Name = "uiSymbolLabel2";
            uiSymbolLabel2.Size = new Size(133, 35);
            uiSymbolLabel2.Symbol = 62067;
            uiSymbolLabel2.TabIndex = 3;
            uiSymbolLabel2.Text = "结束时间";
            // 
            // dtp_Start
            // 
            dtp_Start.FillColor = Color.White;
            dtp_Start.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtp_Start.Location = new Point(212, 14);
            dtp_Start.Margin = new Padding(4, 5, 4, 5);
            dtp_Start.MaxLength = 19;
            dtp_Start.MinimumSize = new Size(63, 0);
            dtp_Start.Name = "dtp_Start";
            dtp_Start.Padding = new Padding(0, 0, 30, 2);
            dtp_Start.Size = new Size(200, 29);
            dtp_Start.SymbolDropDown = 61555;
            dtp_Start.SymbolNormal = 61555;
            dtp_Start.SymbolSize = 24;
            dtp_Start.TabIndex = 6;
            dtp_Start.Text = "2024-11-11 16:28:09";
            dtp_Start.TextAlignment = ContentAlignment.MiddleLeft;
            dtp_Start.Value = new DateTime(2024, 11, 11, 16, 28, 9, 341);
            dtp_Start.Watermark = "";
            // 
            // uiSymbolLabel1
            // 
            uiSymbolLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiSymbolLabel1.Location = new Point(58, 12);
            uiSymbolLabel1.MinimumSize = new Size(1, 1);
            uiSymbolLabel1.Name = "uiSymbolLabel1";
            uiSymbolLabel1.Size = new Size(147, 35);
            uiSymbolLabel1.Symbol = 62067;
            uiSymbolLabel1.TabIndex = 4;
            uiSymbolLabel1.Text = "开始时间";
            // 
            // lc_Chart
            // 
            lc_Chart.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lc_Chart.LegendFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lc_Chart.Location = new Point(21, 53);
            lc_Chart.MinimumSize = new Size(1, 1);
            lc_Chart.MouseDownType = Sunny.UI.UILineChartMouseDownType.Zoom;
            lc_Chart.Name = "lc_Chart";
            lc_Chart.Size = new Size(1045, 484);
            lc_Chart.SubFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lc_Chart.TabIndex = 8;
            lc_Chart.Text = "uiLineChart1";
            // 
            // PageChartManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(lc_Chart);
            Controls.Add(btn_QueryData);
            Controls.Add(dtp_End);
            Controls.Add(uiSymbolLabel2);
            Controls.Add(dtp_Start);
            Controls.Add(uiSymbolLabel1);
            Name = "PageChartManage";
            Symbol = 61950;
            Text = "图表管理";
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UISymbolButton btn_QueryData;
        private Sunny.UI.UIDatetimePicker dtp_End;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UIDatetimePicker dtp_Start;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UILineChart lc_Chart;
    }
}