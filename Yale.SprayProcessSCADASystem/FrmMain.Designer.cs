using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Yale.SprayProcessSCADASystem
{
    partial class FrmMain
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
            components = new System.ComponentModel.Container();
            uiPanel1 = new Sunny.UI.UIPanel();
            lbl_Exit = new Sunny.UI.UISymbolLabel();
            lbl_Min = new Sunny.UI.UISymbolLabel();
            lbl_Time = new Sunny.UI.UILabel();
            lbl_Humidness = new Sunny.UI.UILabel();
            lbl_Temperature = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            st_AlarmInfo = new Sunny.UI.UIScrollingText();
            lbl_User = new Sunny.UI.UILabel();
            lbl_Subhead = new Sunny.UI.UILabel();
            lbl_Title = new Sunny.UI.UILabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            uiLabel3 = new Sunny.UI.UILabel();
            lbl_ProducteCount = new Sunny.UI.UILedLabel();
            uiLabel4 = new Sunny.UI.UILabel();
            lbl_BadCount = new Sunny.UI.UILedLabel();
            uiLabel5 = new Sunny.UI.UILabel();
            lbl_Beat = new Sunny.UI.UILedLabel();
            uiLabel6 = new Sunny.UI.UILabel();
            lbl_TotalAlarm = new Sunny.UI.UILedLabel();
            uiLabel7 = new Sunny.UI.UILabel();
            led_ProducteState = new Sunny.UI.UILedBulb();
            uiLabel8 = new Sunny.UI.UILabel();
            led_PlcState = new Sunny.UI.UILedBulb();
            uiLabel9 = new Sunny.UI.UILabel();
            lbl_CPUInformation = new Sunny.UI.UILabel();
            uiLabel10 = new Sunny.UI.UILabel();
            lbl_MemoryInformation = new Sunny.UI.UILabel();
            uiLabel11 = new Sunny.UI.UILabel();
            lbl_SoftwareVersion = new Sunny.UI.UILabel();
            uiLabel12 = new Sunny.UI.UILabel();
            uiLabel13 = new Sunny.UI.UILabel();
            uiLabel14 = new Sunny.UI.UILabel();
            lbl_Deadline = new Sunny.UI.UILabel();
            StyleManager = new Sunny.UI.UIStyleManager(components);
            Footer.SuspendLayout();
            Header.SuspendLayout();
            uiPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Footer
            // 
            Footer.Controls.Add(lbl_Deadline);
            Footer.Controls.Add(uiLabel13);
            Footer.Controls.Add(lbl_SoftwareVersion);
            Footer.Controls.Add(lbl_MemoryInformation);
            Footer.Controls.Add(lbl_CPUInformation);
            Footer.Controls.Add(led_PlcState);
            Footer.Controls.Add(uiLabel14);
            Footer.Controls.Add(uiLabel12);
            Footer.Controls.Add(uiLabel11);
            Footer.Controls.Add(uiLabel10);
            Footer.Controls.Add(uiLabel9);
            Footer.Controls.Add(uiLabel8);
            Footer.Location = new Point(195, 664);
            Footer.Size = new Size(1085, 56);
            Footer.Text = "";
            // 
            // Aside
            // 
            Aside.Location = new Point(0, 115);
            Aside.Size = new Size(195, 605);
            Aside.BeforeExpand += Aside_BeforeExpand;
            // 
            // Header
            // 
            Header.Controls.Add(led_ProducteState);
            Header.Controls.Add(lbl_TotalAlarm);
            Header.Controls.Add(lbl_Beat);
            Header.Controls.Add(lbl_BadCount);
            Header.Controls.Add(lbl_ProducteCount);
            Header.Controls.Add(uiLabel7);
            Header.Controls.Add(uiLabel6);
            Header.Controls.Add(uiLabel5);
            Header.Controls.Add(uiLabel4);
            Header.Controls.Add(uiLabel3);
            Header.Controls.Add(uiPanel1);
            Header.Location = new Point(0, 0);
            Header.NodeInterval = 0;
            Header.NodeSize = new Size(70, 50);
            Header.Size = new Size(1280, 115);
            Header.MenuItemClick += Header_MenuItemClick;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(lbl_Exit);
            uiPanel1.Controls.Add(lbl_Min);
            uiPanel1.Controls.Add(lbl_Time);
            uiPanel1.Controls.Add(lbl_Humidness);
            uiPanel1.Controls.Add(lbl_Temperature);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(st_AlarmInfo);
            uiPanel1.Controls.Add(lbl_User);
            uiPanel1.Controls.Add(lbl_Subhead);
            uiPanel1.Controls.Add(lbl_Title);
            uiPanel1.Controls.Add(pictureBox2);
            uiPanel1.Controls.Add(pictureBox1);
            uiPanel1.FillColor = Color.Transparent;
            uiPanel1.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiPanel1.Location = new Point(4, 5);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1272, 58);
            uiPanel1.TabIndex = 0;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiPanel1.MouseDown += Panel_MouseDown;
            uiPanel1.MouseMove += Panel_MouseMove;
            // 
            // lbl_Exit
            // 
            lbl_Exit.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Exit.Location = new Point(1220, 4);
            lbl_Exit.MinimumSize = new Size(1, 1);
            lbl_Exit.Name = "lbl_Exit";
            lbl_Exit.Size = new Size(49, 35);
            lbl_Exit.Symbol = 61453;
            lbl_Exit.SymbolSize = 45;
            lbl_Exit.TabIndex = 32;
            lbl_Exit.Click += lbl_Exit_Click;
            // 
            // lbl_Min
            // 
            lbl_Min.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Min.Location = new Point(1165, 4);
            lbl_Min.MinimumSize = new Size(1, 1);
            lbl_Min.Name = "lbl_Min";
            lbl_Min.Size = new Size(49, 35);
            lbl_Min.Symbol = 61544;
            lbl_Min.SymbolSize = 45;
            lbl_Min.TabIndex = 32;
            lbl_Min.Click += lbl_Min_Click;
            // 
            // lbl_Time
            // 
            lbl_Time.BackColor = Color.Transparent;
            lbl_Time.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Time.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Time.Location = new Point(881, 29);
            lbl_Time.Name = "lbl_Time";
            lbl_Time.Size = new Size(199, 23);
            lbl_Time.TabIndex = 31;
            lbl_Time.Text = "2024-10-12 23:05:23";
            // 
            // lbl_Humidness
            // 
            lbl_Humidness.BackColor = Color.Transparent;
            lbl_Humidness.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Humidness.ForeColor = Color.Green;
            lbl_Humidness.Location = new Point(1063, 10);
            lbl_Humidness.Name = "lbl_Humidness";
            lbl_Humidness.Size = new Size(51, 21);
            lbl_Humidness.TabIndex = 30;
            lbl_Humidness.TagString = "厂内湿度";
            lbl_Humidness.Text = "25℃";
            // 
            // lbl_Temperature
            // 
            lbl_Temperature.BackColor = Color.Transparent;
            lbl_Temperature.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Temperature.ForeColor = Color.Green;
            lbl_Temperature.Location = new Point(931, 10);
            lbl_Temperature.Name = "lbl_Temperature";
            lbl_Temperature.Size = new Size(51, 21);
            lbl_Temperature.TabIndex = 30;
            lbl_Temperature.TagString = "厂内温度";
            lbl_Temperature.Text = "25℃";
            // 
            // uiLabel2
            // 
            uiLabel2.BackColor = Color.Transparent;
            uiLabel2.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Image = Properties.Resources.湿度;
            uiLabel2.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel2.Location = new Point(977, 1);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(84, 32);
            uiLabel2.TabIndex = 29;
            uiLabel2.Text = "厂房湿度";
            uiLabel2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel1
            // 
            uiLabel1.BackColor = Color.Transparent;
            uiLabel1.Font = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Image = Properties.Resources.温度;
            uiLabel1.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel1.Location = new Point(845, 1);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(84, 32);
            uiLabel1.TabIndex = 29;
            uiLabel1.Text = "厂房温度";
            uiLabel1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // st_AlarmInfo
            // 
            st_AlarmInfo.Active = true;
            st_AlarmInfo.BackColor = Color.Transparent;
            st_AlarmInfo.FillColor = Color.Transparent;
            st_AlarmInfo.Font = new Font("微软雅黑", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            st_AlarmInfo.Location = new Point(496, 8);
            st_AlarmInfo.MinimumSize = new Size(1, 1);
            st_AlarmInfo.Name = "st_AlarmInfo";
            st_AlarmInfo.Size = new Size(318, 41);
            st_AlarmInfo.TabIndex = 28;
            st_AlarmInfo.Text = "系统正常";
            // 
            // lbl_User
            // 
            lbl_User.BackColor = Color.Transparent;
            lbl_User.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_User.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_User.Location = new Point(403, 11);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new Size(87, 37);
            lbl_User.TabIndex = 27;
            lbl_User.Text = "伊然";
            // 
            // lbl_Subhead
            // 
            lbl_Subhead.BackColor = Color.Transparent;
            lbl_Subhead.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Subhead.ForeColor = SystemColors.Highlight;
            lbl_Subhead.Location = new Point(82, 36);
            lbl_Subhead.Name = "lbl_Subhead";
            lbl_Subhead.Size = new Size(232, 23);
            lbl_Subhead.TabIndex = 1;
            lbl_Subhead.Text = "Spray Process SCADA System";
            // 
            // lbl_Title
            // 
            lbl_Title.BackColor = Color.Transparent;
            lbl_Title.Font = new Font("宋体", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Title.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Title.Location = new Point(63, 2);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(279, 35);
            lbl_Title.TabIndex = 1;
            lbl_Title.Text = "喷涂工艺SCADA系统";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.用户;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(348, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(49, 48);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.喷涂生产;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 48);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // uiLabel3
            // 
            uiLabel3.BackColor = Color.Transparent;
            uiLabel3.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Image = Properties.Resources.产量;
            uiLabel3.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel3.Location = new Point(4, 70);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(134, 32);
            uiLabel3.TabIndex = 1;
            uiLabel3.Text = "生产计数";
            uiLabel3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_ProducteCount
            // 
            lbl_ProducteCount.BackColor = Color.Transparent;
            lbl_ProducteCount.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ProducteCount.ForeColor = Color.DeepSkyBlue;
            lbl_ProducteCount.Location = new Point(138, 69);
            lbl_ProducteCount.MinimumSize = new Size(1, 1);
            lbl_ProducteCount.Name = "lbl_ProducteCount";
            lbl_ProducteCount.Size = new Size(107, 35);
            lbl_ProducteCount.TabIndex = 2;
            lbl_ProducteCount.TagString = "生产计数";
            lbl_ProducteCount.Text = "5000";
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Transparent;
            uiLabel4.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Image = Properties.Resources.产量;
            uiLabel4.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel4.Location = new Point(245, 70);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(134, 32);
            uiLabel4.TabIndex = 1;
            uiLabel4.Text = "不良计数";
            uiLabel4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_BadCount
            // 
            lbl_BadCount.BackColor = Color.Transparent;
            lbl_BadCount.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_BadCount.ForeColor = Color.DeepSkyBlue;
            lbl_BadCount.Location = new Point(376, 69);
            lbl_BadCount.MinimumSize = new Size(1, 1);
            lbl_BadCount.Name = "lbl_BadCount";
            lbl_BadCount.Size = new Size(93, 35);
            lbl_BadCount.TabIndex = 2;
            lbl_BadCount.TagString = "不良计数";
            lbl_BadCount.Text = "5000";
            // 
            // uiLabel5
            // 
            uiLabel5.BackColor = Color.Transparent;
            uiLabel5.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Image = Properties.Resources.生产节拍;
            uiLabel5.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel5.Location = new Point(469, 72);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(134, 32);
            uiLabel5.TabIndex = 1;
            uiLabel5.Text = "生产节拍";
            uiLabel5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Beat
            // 
            lbl_Beat.BackColor = Color.Transparent;
            lbl_Beat.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Beat.ForeColor = Color.DeepSkyBlue;
            lbl_Beat.Location = new Point(598, 71);
            lbl_Beat.MinimumSize = new Size(1, 1);
            lbl_Beat.Name = "lbl_Beat";
            lbl_Beat.Size = new Size(93, 35);
            lbl_Beat.TabIndex = 2;
            lbl_Beat.TagString = "生产节拍";
            lbl_Beat.Text = "10";
            // 
            // uiLabel6
            // 
            uiLabel6.BackColor = Color.Transparent;
            uiLabel6.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Image = Properties.Resources.报警数;
            uiLabel6.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel6.Location = new Point(691, 72);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(134, 32);
            uiLabel6.TabIndex = 1;
            uiLabel6.Text = "累计报警";
            uiLabel6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_TotalAlarm
            // 
            lbl_TotalAlarm.BackColor = Color.Transparent;
            lbl_TotalAlarm.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_TotalAlarm.ForeColor = Color.DeepSkyBlue;
            lbl_TotalAlarm.Location = new Point(820, 71);
            lbl_TotalAlarm.MinimumSize = new Size(1, 1);
            lbl_TotalAlarm.Name = "lbl_TotalAlarm";
            lbl_TotalAlarm.Size = new Size(93, 35);
            lbl_TotalAlarm.TabIndex = 2;
            lbl_TotalAlarm.TagString = "累计报警";
            lbl_TotalAlarm.Text = "5000";
            // 
            // uiLabel7
            // 
            uiLabel7.BackColor = Color.Transparent;
            uiLabel7.Font = new Font("宋体", 15F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Image = Properties.Resources.系统状态;
            uiLabel7.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel7.Location = new Point(919, 71);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(117, 32);
            uiLabel7.TabIndex = 1;
            uiLabel7.Text = "系统状态";
            uiLabel7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // led_ProducteState
            // 
            led_ProducteState.BackColor = Color.Transparent;
            led_ProducteState.Location = new Point(1042, 71);
            led_ProducteState.Name = "led_ProducteState";
            led_ProducteState.Size = new Size(32, 32);
            led_ProducteState.TabIndex = 3;
            led_ProducteState.Text = "uiLedBulb1";
            // 
            // uiLabel8
            // 
            uiLabel8.BackColor = Color.Transparent;
            uiLabel8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.Image = Properties.Resources.连接状态;
            uiLabel8.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel8.Location = new Point(17, 14);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(134, 32);
            uiLabel8.TabIndex = 0;
            uiLabel8.Text = "PLC连接状态";
            uiLabel8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // led_PlcState
            // 
            led_PlcState.BackColor = Color.Transparent;
            led_PlcState.Location = new Point(157, 14);
            led_PlcState.Name = "led_PlcState";
            led_PlcState.Size = new Size(32, 32);
            led_PlcState.TabIndex = 1;
            led_PlcState.Text = "uiLedBulb1";
            // 
            // uiLabel9
            // 
            uiLabel9.BackColor = Color.Transparent;
            uiLabel9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel9.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel9.Image = Properties.Resources.CPU信息;
            uiLabel9.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel9.Location = new Point(202, 14);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(107, 32);
            uiLabel9.TabIndex = 0;
            uiLabel9.Text = "CPU信息";
            uiLabel9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_CPUInformation
            // 
            lbl_CPUInformation.BackColor = Color.Transparent;
            lbl_CPUInformation.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_CPUInformation.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_CPUInformation.Location = new Point(306, 14);
            lbl_CPUInformation.Name = "lbl_CPUInformation";
            lbl_CPUInformation.Size = new Size(52, 32);
            lbl_CPUInformation.TabIndex = 2;
            lbl_CPUInformation.Text = "58％";
            lbl_CPUInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel10
            // 
            uiLabel10.BackColor = Color.Transparent;
            uiLabel10.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel10.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel10.Image = Properties.Resources.内存信息;
            uiLabel10.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel10.Location = new Point(364, 14);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new Size(107, 32);
            uiLabel10.TabIndex = 0;
            uiLabel10.Text = "内存信息";
            uiLabel10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_MemoryInformation
            // 
            lbl_MemoryInformation.BackColor = Color.Transparent;
            lbl_MemoryInformation.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MemoryInformation.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_MemoryInformation.Location = new Point(468, 14);
            lbl_MemoryInformation.Name = "lbl_MemoryInformation";
            lbl_MemoryInformation.Size = new Size(52, 32);
            lbl_MemoryInformation.TabIndex = 2;
            lbl_MemoryInformation.Text = "58％";
            lbl_MemoryInformation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel11
            // 
            uiLabel11.BackColor = Color.Transparent;
            uiLabel11.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel11.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel11.Image = Properties.Resources.软件版本;
            uiLabel11.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel11.Location = new Point(516, 14);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new Size(107, 32);
            uiLabel11.TabIndex = 0;
            uiLabel11.Text = "软件版本";
            uiLabel11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_SoftwareVersion
            // 
            lbl_SoftwareVersion.BackColor = Color.Transparent;
            lbl_SoftwareVersion.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_SoftwareVersion.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_SoftwareVersion.Location = new Point(620, 14);
            lbl_SoftwareVersion.Name = "lbl_SoftwareVersion";
            lbl_SoftwareVersion.Size = new Size(52, 32);
            lbl_SoftwareVersion.TabIndex = 2;
            lbl_SoftwareVersion.Text = "V1.0";
            lbl_SoftwareVersion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel12
            // 
            uiLabel12.BackColor = Color.Transparent;
            uiLabel12.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel12.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel12.Image = Properties.Resources.授权;
            uiLabel12.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel12.Location = new Point(678, 14);
            uiLabel12.Name = "uiLabel12";
            uiLabel12.Size = new Size(107, 32);
            uiLabel12.TabIndex = 0;
            uiLabel12.Text = "是否授权";
            uiLabel12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // uiLabel13
            // 
            uiLabel13.BackColor = Color.Transparent;
            uiLabel13.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel13.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel13.Location = new Point(782, 14);
            uiLabel13.Name = "uiLabel13";
            uiLabel13.Size = new Size(52, 32);
            uiLabel13.TabIndex = 2;
            uiLabel13.Text = "否";
            uiLabel13.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // uiLabel14
            // 
            uiLabel14.BackColor = Color.Transparent;
            uiLabel14.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel14.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel14.Image = Properties.Resources.期限;
            uiLabel14.ImageAlign = ContentAlignment.MiddleLeft;
            uiLabel14.Location = new Point(847, 14);
            uiLabel14.Name = "uiLabel14";
            uiLabel14.Size = new Size(107, 32);
            uiLabel14.TabIndex = 0;
            uiLabel14.Text = "使用期限";
            uiLabel14.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_Deadline
            // 
            lbl_Deadline.BackColor = Color.Transparent;
            lbl_Deadline.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_Deadline.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Deadline.Location = new Point(951, 14);
            lbl_Deadline.Name = "lbl_Deadline";
            lbl_Deadline.Size = new Size(101, 32);
            lbl_Deadline.TabIndex = 2;
            lbl_Deadline.Text = "试用五分钟";
            lbl_Deadline.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StyleManager
            // 
            StyleManager.DPIScale = true;
            StyleManager.GlobalFont = true;
            // 
            // FrmMain
            // 
            AllowShowTitle = false;
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1280, 720);
            CloseAskString = "是否关闭系统";
            EscClose = true;
            Name = "FrmMain";
            Padding = new Padding(0);
            ShowTitle = false;
            Text = "Form1";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Shown += FrmMain_Shown;
            Footer.ResumeLayout(false);
            Header.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILabel lbl_Subhead;
        private Sunny.UI.UILabel lbl_Title;
        private PictureBox pictureBox1;
        private Sunny.UI.UIScrollingText st_AlarmInfo;
        private Sunny.UI.UILabel lbl_User;
        private PictureBox pictureBox2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lbl_Temperature;
        private Sunny.UI.UILabel lbl_Time;
        private Sunny.UI.UILabel lbl_Humidness;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UISymbolLabel lbl_Exit;
        private Sunny.UI.UISymbolLabel lbl_Min;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILedLabel lbl_TotalAlarm;
        private Sunny.UI.UILedLabel lbl_Beat;
        private Sunny.UI.UILedLabel lbl_BadCount;
        private Sunny.UI.UILedLabel lbl_ProducteCount;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILedBulb led_ProducteState;
        private Sunny.UI.UILabel uiLabel7;
        private Sunny.UI.UILedBulb led_PlcState;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel lbl_CPUInformation;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel lbl_Deadline;
        private Sunny.UI.UILabel uiLabel13;
        private Sunny.UI.UILabel lbl_SoftwareVersion;
        private Sunny.UI.UILabel lbl_MemoryInformation;
        private Sunny.UI.UILabel uiLabel14;
        private Sunny.UI.UILabel uiLabel12;
        private Sunny.UI.UILabel uiLabel11;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UIStyleManager StyleManager;
    }
}