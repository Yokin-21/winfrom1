namespace Yale.SprayProcessSCADASystem
{
    partial class PageRecipeManage
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
            userSetValue20 = new UserSetValue();
            userSetValue8 = new UserSetValue();
            userSetValue19 = new UserSetValue();
            userSetValue4 = new UserSetValue();
            userSetValue18 = new UserSetValue();
            userSetValue7 = new UserSetValue();
            userSetValue2 = new UserSetValue();
            userSetValue17 = new UserSetValue();
            userSetValue6 = new UserSetValue();
            userSetValue16 = new UserSetValue();
            userSetValue15 = new UserSetValue();
            userSetValue3 = new UserSetValue();
            userSetValue5 = new UserSetValue();
            userSetValue1 = new UserSetValue();
            uiTitlePanel2 = new Sunny.UI.UITitlePanel();
            dgv_Recipe = new Sunny.UI.UIDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            btn_DownloadRecipe = new Sunny.UI.UISymbolButton();
            btn_ExportRecipe = new Sunny.UI.UISymbolButton();
            btn_QueryRecipe = new Sunny.UI.UISymbolButton();
            btn_DelRecipe = new Sunny.UI.UISymbolButton();
            btn_ImportRecipe = new Sunny.UI.UISymbolButton();
            btn_UpdateRecipe = new Sunny.UI.UISymbolButton();
            btn_AddRecipe = new Sunny.UI.UISymbolButton();
            txt_ProductType = new Sunny.UI.UITextBox();
            uiLabel1 = new Sunny.UI.UILabel();
            uiTitlePanel1.SuspendLayout();
            uiTitlePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Recipe).BeginInit();
            SuspendLayout();
            // 
            // uiTitlePanel1
            // 
            uiTitlePanel1.Controls.Add(userSetValue20);
            uiTitlePanel1.Controls.Add(userSetValue8);
            uiTitlePanel1.Controls.Add(userSetValue19);
            uiTitlePanel1.Controls.Add(userSetValue4);
            uiTitlePanel1.Controls.Add(userSetValue18);
            uiTitlePanel1.Controls.Add(userSetValue7);
            uiTitlePanel1.Controls.Add(userSetValue2);
            uiTitlePanel1.Controls.Add(userSetValue17);
            uiTitlePanel1.Controls.Add(userSetValue6);
            uiTitlePanel1.Controls.Add(userSetValue16);
            uiTitlePanel1.Controls.Add(userSetValue15);
            uiTitlePanel1.Controls.Add(userSetValue3);
            uiTitlePanel1.Controls.Add(userSetValue5);
            uiTitlePanel1.Controls.Add(userSetValue1);
            uiTitlePanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel1.Location = new Point(4, 2);
            uiTitlePanel1.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel1.MinimumSize = new Size(1, 1);
            uiTitlePanel1.Name = "uiTitlePanel1";
            uiTitlePanel1.ShowText = false;
            uiTitlePanel1.Size = new Size(810, 541);
            uiTitlePanel1.TabIndex = 0;
            uiTitlePanel1.Text = "配方参数";
            uiTitlePanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // userSetValue20
            // 
            userSetValue20.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue20.DeviceVarName = "输送机设定频率";
            userSetValue20.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue20.Location = new Point(419, 461);
            userSetValue20.MinimumSize = new Size(1, 1);
            userSetValue20.Name = "userSetValue20";
            userSetValue20.Size = new Size(337, 46);
            userSetValue20.TabIndex = 0;
            userSetValue20.Text = "userSetValue1";
            userSetValue20.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue20.Unit = "HZ";
            userSetValue20.VariableName = "输送机设定频率";
            userSetValue20.VarValue = "0";
            // 
            // userSetValue8
            // 
            userSetValue8.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue8.DeviceVarName = "固化炉温度上限值";
            userSetValue8.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue8.Location = new Point(419, 257);
            userSetValue8.MinimumSize = new Size(1, 1);
            userSetValue8.Name = "userSetValue8";
            userSetValue8.Size = new Size(337, 46);
            userSetValue8.TabIndex = 0;
            userSetValue8.Text = "userSetValue1";
            userSetValue8.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue8.Unit = "℃";
            userSetValue8.VariableName = "固化炉温度上限值";
            userSetValue8.VarValue = "0";
            // 
            // userSetValue19
            // 
            userSetValue19.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue19.DeviceVarName = "固化炉温度下限值";
            userSetValue19.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue19.Location = new Point(419, 325);
            userSetValue19.MinimumSize = new Size(1, 1);
            userSetValue19.Name = "userSetValue19";
            userSetValue19.Size = new Size(337, 46);
            userSetValue19.TabIndex = 0;
            userSetValue19.Text = "userSetValue1";
            userSetValue19.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue19.Unit = "℃";
            userSetValue19.VariableName = "固化炉温度下限值";
            userSetValue19.VarValue = "0";
            // 
            // userSetValue4
            // 
            userSetValue4.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue4.DeviceVarName = "水分炉温度下限值";
            userSetValue4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue4.Location = new Point(419, 121);
            userSetValue4.MinimumSize = new Size(1, 1);
            userSetValue4.Name = "userSetValue4";
            userSetValue4.Size = new Size(337, 46);
            userSetValue4.TabIndex = 0;
            userSetValue4.Text = "userSetValue1";
            userSetValue4.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue4.Unit = "℃";
            userSetValue4.VariableName = "水分炉温度下限值";
            userSetValue4.VarValue = "0";
            // 
            // userSetValue18
            // 
            userSetValue18.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue18.DeviceVarName = "输送机设定速度";
            userSetValue18.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue18.Location = new Point(419, 393);
            userSetValue18.MinimumSize = new Size(1, 1);
            userSetValue18.Name = "userSetValue18";
            userSetValue18.Size = new Size(337, 46);
            userSetValue18.TabIndex = 0;
            userSetValue18.Text = "userSetValue1";
            userSetValue18.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue18.Unit = "m/s";
            userSetValue18.VariableName = "输送机设定速度";
            userSetValue18.VarValue = "0";
            // 
            // userSetValue7
            // 
            userSetValue7.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue7.DeviceVarName = "离心风机过载上限值";
            userSetValue7.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue7.Location = new Point(419, 189);
            userSetValue7.MinimumSize = new Size(1, 1);
            userSetValue7.Name = "userSetValue7";
            userSetValue7.Size = new Size(337, 46);
            userSetValue7.TabIndex = 0;
            userSetValue7.Text = "userSetValue1";
            userSetValue7.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue7.Unit = "Mpa";
            userSetValue7.VariableName = "冷却室离心风机过载上限值";
            userSetValue7.VarValue = "0";
            // 
            // userSetValue2
            // 
            userSetValue2.DataType = Sunny.UI.UITextBox.UIEditType.Integer;
            userSetValue2.DeviceVarName = "水分炉温度上限值";
            userSetValue2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue2.Location = new Point(419, 53);
            userSetValue2.MinimumSize = new Size(1, 1);
            userSetValue2.Name = "userSetValue2";
            userSetValue2.Size = new Size(337, 46);
            userSetValue2.TabIndex = 0;
            userSetValue2.Text = "userSetValue1";
            userSetValue2.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue2.Unit = "℃";
            userSetValue2.VariableName = "水分炉温度上限值";
            userSetValue2.VarValue = "0";
            // 
            // userSetValue17
            // 
            userSetValue17.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue17.DeviceVarName = "精洗液位下限值";
            userSetValue17.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue17.Location = new Point(8, 461);
            userSetValue17.MinimumSize = new Size(1, 1);
            userSetValue17.Name = "userSetValue17";
            userSetValue17.Size = new Size(360, 46);
            userSetValue17.TabIndex = 0;
            userSetValue17.Text = "userSetValue1";
            userSetValue17.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue17.Unit = "m³";
            userSetValue17.VariableName = "精洗液位下限值";
            userSetValue17.VarValue = "0";
            // 
            // userSetValue6
            // 
            userSetValue6.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue6.DeviceVarName = "粗洗液位下限值";
            userSetValue6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue6.Location = new Point(8, 257);
            userSetValue6.MinimumSize = new Size(1, 1);
            userSetValue6.Name = "userSetValue6";
            userSetValue6.Size = new Size(360, 46);
            userSetValue6.TabIndex = 0;
            userSetValue6.Text = "userSetValue1";
            userSetValue6.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue6.Unit = "m³";
            userSetValue6.VariableName = "粗洗液位下限值";
            userSetValue6.VarValue = "0";
            // 
            // userSetValue16
            // 
            userSetValue16.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue16.DeviceVarName = "陶化喷淋泵过载上限值";
            userSetValue16.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue16.Location = new Point(8, 325);
            userSetValue16.MinimumSize = new Size(1, 1);
            userSetValue16.Name = "userSetValue16";
            userSetValue16.Size = new Size(360, 46);
            userSetValue16.TabIndex = 0;
            userSetValue16.Text = "userSetValue1";
            userSetValue16.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue16.Unit = "Mpa";
            userSetValue16.VariableName = "陶化喷淋泵过载上限值";
            userSetValue16.VarValue = "0";
            // 
            // userSetValue15
            // 
            userSetValue15.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue15.DeviceVarName = "精洗喷淋泵过载上限值";
            userSetValue15.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue15.Location = new Point(8, 393);
            userSetValue15.MinimumSize = new Size(1, 1);
            userSetValue15.Name = "userSetValue15";
            userSetValue15.Size = new Size(360, 46);
            userSetValue15.TabIndex = 0;
            userSetValue15.Text = "userSetValue1";
            userSetValue15.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue15.Unit = "Mpa";
            userSetValue15.VariableName = "精洗喷淋泵过载上限值";
            userSetValue15.VarValue = "0";
            // 
            // userSetValue3
            // 
            userSetValue3.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue3.DeviceVarName = "脱脂设定压力下限值";
            userSetValue3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue3.Location = new Point(8, 121);
            userSetValue3.MinimumSize = new Size(1, 1);
            userSetValue3.Name = "userSetValue3";
            userSetValue3.Size = new Size(360, 46);
            userSetValue3.TabIndex = 0;
            userSetValue3.Text = "userSetValue1";
            userSetValue3.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue3.Unit = "Mpa";
            userSetValue3.VariableName = "脱脂设定压力下限值";
            userSetValue3.VarValue = "0";
            // 
            // userSetValue5
            // 
            userSetValue5.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue5.DeviceVarName = "粗洗喷淋泵过载上限值";
            userSetValue5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue5.Location = new Point(8, 189);
            userSetValue5.MinimumSize = new Size(1, 1);
            userSetValue5.Name = "userSetValue5";
            userSetValue5.Size = new Size(360, 46);
            userSetValue5.TabIndex = 0;
            userSetValue5.Text = "userSetValue1";
            userSetValue5.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue5.Unit = "Mpa";
            userSetValue5.VariableName = "粗洗喷淋泵过载上限值";
            userSetValue5.VarValue = "0";
            // 
            // userSetValue1
            // 
            userSetValue1.DataType = Sunny.UI.UITextBox.UIEditType.Double;
            userSetValue1.DeviceVarName = "脱脂设定压力上限值";
            userSetValue1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userSetValue1.Location = new Point(8, 53);
            userSetValue1.MinimumSize = new Size(1, 1);
            userSetValue1.Name = "userSetValue1";
            userSetValue1.Size = new Size(360, 46);
            userSetValue1.TabIndex = 0;
            userSetValue1.Text = "userSetValue1";
            userSetValue1.TextAlignment = ContentAlignment.MiddleCenter;
            userSetValue1.Unit = "Mpa";
            userSetValue1.VariableName = "脱脂设定压力上限值";
            userSetValue1.VarValue = "0";
            // 
            // uiTitlePanel2
            // 
            uiTitlePanel2.Controls.Add(dgv_Recipe);
            uiTitlePanel2.Controls.Add(btn_DownloadRecipe);
            uiTitlePanel2.Controls.Add(btn_ExportRecipe);
            uiTitlePanel2.Controls.Add(btn_QueryRecipe);
            uiTitlePanel2.Controls.Add(btn_DelRecipe);
            uiTitlePanel2.Controls.Add(btn_ImportRecipe);
            uiTitlePanel2.Controls.Add(btn_UpdateRecipe);
            uiTitlePanel2.Controls.Add(btn_AddRecipe);
            uiTitlePanel2.Controls.Add(txt_ProductType);
            uiTitlePanel2.Controls.Add(uiLabel1);
            uiTitlePanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiTitlePanel2.Location = new Point(812, 2);
            uiTitlePanel2.Margin = new Padding(4, 5, 4, 5);
            uiTitlePanel2.MinimumSize = new Size(1, 1);
            uiTitlePanel2.Name = "uiTitlePanel2";
            uiTitlePanel2.ShowText = false;
            uiTitlePanel2.Size = new Size(271, 541);
            uiTitlePanel2.TabIndex = 1;
            uiTitlePanel2.Text = "配方控制台";
            uiTitlePanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // dgv_Recipe
            // 
            dgv_Recipe.AllowUserToAddRows = false;
            dgv_Recipe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgv_Recipe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv_Recipe.BackgroundColor = Color.White;
            dgv_Recipe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_Recipe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_Recipe.ColumnHeadersHeight = 32;
            dgv_Recipe.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_Recipe.Columns.AddRange(new DataGridViewColumn[] { Column1, Id });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv_Recipe.DefaultCellStyle = dataGridViewCellStyle3;
            dgv_Recipe.EnableHeadersVisualStyles = false;
            dgv_Recipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_Recipe.GridColor = Color.FromArgb(80, 160, 255);
            dgv_Recipe.Location = new Point(12, 316);
            dgv_Recipe.Name = "dgv_Recipe";
            dgv_Recipe.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv_Recipe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dgv_Recipe.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv_Recipe.RowTemplate.Height = 25;
            dgv_Recipe.SelectedIndex = -1;
            dgv_Recipe.Size = new Size(256, 219);
            dgv_Recipe.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgv_Recipe.TabIndex = 3;
            dgv_Recipe.SelectIndexChange += dgv_Recipe_SelectIndexChange;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "产品类型";
            Column1.HeaderText = "产品类型";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 200;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Visible = false;
            // 
            // btn_DownloadRecipe
            // 
            btn_DownloadRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DownloadRecipe.Location = new Point(12, 260);
            btn_DownloadRecipe.MinimumSize = new Size(1, 1);
            btn_DownloadRecipe.Name = "btn_DownloadRecipe";
            btn_DownloadRecipe.Size = new Size(249, 50);
            btn_DownloadRecipe.Symbol = 61465;
            btn_DownloadRecipe.TabIndex = 2;
            btn_DownloadRecipe.Text = "下载配方";
            btn_DownloadRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DownloadRecipe.Click += btn_DownloadRecipe_Click;
            // 
            // btn_ExportRecipe
            // 
            btn_ExportRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ExportRecipe.Location = new Point(144, 204);
            btn_ExportRecipe.MinimumSize = new Size(1, 1);
            btn_ExportRecipe.Name = "btn_ExportRecipe";
            btn_ExportRecipe.Size = new Size(121, 50);
            btn_ExportRecipe.Symbol = 362831;
            btn_ExportRecipe.TabIndex = 2;
            btn_ExportRecipe.Text = "导出配方";
            btn_ExportRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ExportRecipe.Click += btn_ExportRecipe_Click;
            // 
            // btn_QueryRecipe
            // 
            btn_QueryRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QueryRecipe.Location = new Point(144, 148);
            btn_QueryRecipe.MinimumSize = new Size(1, 1);
            btn_QueryRecipe.Name = "btn_QueryRecipe";
            btn_QueryRecipe.Size = new Size(121, 50);
            btn_QueryRecipe.Symbol = 559520;
            btn_QueryRecipe.TabIndex = 2;
            btn_QueryRecipe.Text = "查询配方";
            btn_QueryRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_QueryRecipe.Click += btn_QueryRecipe_Click;
            // 
            // btn_DelRecipe
            // 
            btn_DelRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DelRecipe.Location = new Point(144, 92);
            btn_DelRecipe.MinimumSize = new Size(1, 1);
            btn_DelRecipe.Name = "btn_DelRecipe";
            btn_DelRecipe.Size = new Size(121, 50);
            btn_DelRecipe.Symbol = 362810;
            btn_DelRecipe.TabIndex = 2;
            btn_DelRecipe.Text = "删除配方";
            btn_DelRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_DelRecipe.Click += btn_DelRecipe_Click;
            // 
            // btn_ImportRecipe
            // 
            btn_ImportRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ImportRecipe.Location = new Point(9, 204);
            btn_ImportRecipe.MinimumSize = new Size(1, 1);
            btn_ImportRecipe.Name = "btn_ImportRecipe";
            btn_ImportRecipe.Size = new Size(121, 50);
            btn_ImportRecipe.Symbol = 362831;
            btn_ImportRecipe.TabIndex = 2;
            btn_ImportRecipe.Text = "导入配方";
            btn_ImportRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ImportRecipe.Click += btn_ImportRecipe_Click;
            // 
            // btn_UpdateRecipe
            // 
            btn_UpdateRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateRecipe.Location = new Point(9, 148);
            btn_UpdateRecipe.MinimumSize = new Size(1, 1);
            btn_UpdateRecipe.Name = "btn_UpdateRecipe";
            btn_UpdateRecipe.Size = new Size(121, 50);
            btn_UpdateRecipe.Symbol = 558087;
            btn_UpdateRecipe.TabIndex = 2;
            btn_UpdateRecipe.Text = "修改配方";
            btn_UpdateRecipe.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_UpdateRecipe.Click += btn_UpdateRecipe_Click;
            // 
            // btn_AddRecipe
            // 
            btn_AddRecipe.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_AddRecipe.Location = new Point(9, 92);
            btn_AddRecipe.MinimumSize = new Size(1, 1);
            btn_AddRecipe.Name = "btn_AddRecipe";
            btn_AddRecipe.Size = new Size(121, 50);
            btn_AddRecipe.Symbol = 557670;
            btn_AddRecipe.TabIndex = 2;
            btn_AddRecipe.Text = "添加配方";
            btn_AddRecipe.Click += btn_AddRecipe_Click;
            // 
            // txt_ProductType
            // 
            txt_ProductType.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ProductType.Location = new Point(97, 46);
            txt_ProductType.Margin = new Padding(4, 5, 4, 5);
            txt_ProductType.MinimumSize = new Size(1, 16);
            txt_ProductType.Name = "txt_ProductType";
            txt_ProductType.Padding = new Padding(5);
            txt_ProductType.ShowText = false;
            txt_ProductType.Size = new Size(150, 29);
            txt_ProductType.TabIndex = 1;
            txt_ProductType.TextAlignment = ContentAlignment.MiddleLeft;
            txt_ProductType.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(9, 53);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(86, 23);
            uiLabel1.TabIndex = 0;
            uiLabel1.Text = "产品类型";
            // 
            // PageRecipeManage
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1085, 549);
            Controls.Add(uiTitlePanel2);
            Controls.Add(uiTitlePanel1);
            Name = "PageRecipeManage";
            Symbol = 162333;
            Text = "配方管理";
            uiTitlePanel1.ResumeLayout(false);
            uiTitlePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Recipe).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UITitlePanel uiTitlePanel1;
        private UserSetValue userSetValue1;
        private UserSetValue userSetValue20;
        private UserSetValue userSetValue8;
        private UserSetValue userSetValue19;
        private UserSetValue userSetValue4;
        private UserSetValue userSetValue18;
        private UserSetValue userSetValue7;
        private UserSetValue userSetValue2;
        private UserSetValue userSetValue17;
        private UserSetValue userSetValue6;
        private UserSetValue userSetValue16;
        private UserSetValue userSetValue15;
        private UserSetValue userSetValue3;
        private UserSetValue userSetValue5;
        private Sunny.UI.UITitlePanel uiTitlePanel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UISymbolButton btn_DownloadRecipe;
        private Sunny.UI.UISymbolButton btn_ExportRecipe;
        private Sunny.UI.UISymbolButton btn_QueryRecipe;
        private Sunny.UI.UISymbolButton btn_DelRecipe;
        private Sunny.UI.UISymbolButton btn_ImportRecipe;
        private Sunny.UI.UISymbolButton btn_UpdateRecipe;
        private Sunny.UI.UISymbolButton btn_AddRecipe;
        private Sunny.UI.UITextBox txt_ProductType;
        private Sunny.UI.UIDataGridView dgv_Recipe;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Id;
    }
}