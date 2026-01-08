using YR.FrameWork.DependencyInjection;
using IoTClient.Enums;
using Mapster;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MiniExcelLibs;
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
using Yale.BLL;
using Yale.Helper;

namespace Yale.SprayProcessSCADASystem
{
    public partial class PageRecipeManage : UIPage, ISingletonSelfDependency
    {
        private readonly RecipeManager _recipeManager;
        public PageRecipeManage(RecipeManager recipeManager)
        {
            InitializeComponent();
            this._recipeManager = recipeManager;
            this.dgv_Recipe.AutoGenerateColumns = false;
            this.Load += PageRecipeManage_Load;
        }

        private async void PageRecipeManage_Load(object? sender, EventArgs e)
        {
            await LoadRecipe();
        }

        private async Task LoadRecipe()
        {
            var res = await _recipeManager.GetRecipeListAsync();
            if (res.Status == SystemEnums.Result.Success)
            {
                this.dgv_Recipe.DataSource = null;
                this.dgv_Recipe.DataSource = res.Data;
            }
            else
            {
                LogExtension.ShowMesssage(res.Msg, Microsoft.Extensions.Logging.LogLevel.Error);
            }
        }

        private async void btn_AddRecipe_Click(object sender, EventArgs e)
        {
            if (this.txt_ProductType.Text.IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("请输入产品类型");
                return;
            }

            AddRecipeDto addDto = new AddRecipeDto()
            {
                产品类型 = this.txt_ProductType.Text
            };

            foreach (var item in this.uiTitlePanel1.Controls)
            {
                if (item is UserSetValue usv)
                {
                    addDto.GetType().GetProperty(usv.VariableName).SetValue(addDto, usv.VarValue);
                }
            }

            var res = await _recipeManager.AddRecipeAsync(addDto);
            if (res.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("添加配方成功");
                await LoadRecipe();
            }
            else
            {
                LogExtension.ShowMesssage(res.Msg, Microsoft.Extensions.Logging.LogLevel.Error);
                UIMessageTip.ShowError(res.Msg);

            }

        }

        private async void btn_DelRecipe_Click(object sender, EventArgs e)
        {
            if (this.dgv_Recipe.CurrentRow == null)
            {
                UIMessageTip.ShowWarning("请选择一行");
                return;
            }

            var id = this.dgv_Recipe.CurrentRow.Cells["Id"].Value.ToString().ToInt();

            var res = await _recipeManager.DeleteRecipeAsync(new DelRecipeDto() { Id = id });

            if (res.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("删除配方成功");
                await LoadRecipe();
            }
            else
            {
                LogExtension.ShowMesssage(res.Msg, Microsoft.Extensions.Logging.LogLevel.Error);
                UIMessageTip.ShowError(res.Msg);

            }
        }

        private async void dgv_Recipe_SelectIndexChange(object sender, int index)
        {
            var id = this.dgv_Recipe.Rows[index].Cells["Id"].Value.ToString().ToInt();
            var res = await _recipeManager.GetRecipeAsyncById(new GetRecipeByIdDto() { Id = id });
            if (res.Status == SystemEnums.Result.Success)
            {
                foreach (var item in this.uiTitlePanel1.Controls)
                {
                    if (item is UserSetValue usv)
                    {
                        var value = res.Data[0].GetType().GetProperty(usv.VariableName).GetValue(res.Data[0]);
                        usv.VarValue = value.ToString();
                    }
                }
                this.txt_ProductType.Text = res.Data[0].产品类型;
            }
        }

        private async void btn_UpdateRecipe_Click(object sender, EventArgs e)
        {
            if (this.dgv_Recipe.CurrentRow == null)
            {
                UIMessageTip.ShowWarning("请选择一行");
                return;
            }
            UpdateRecipeDto updateDto = new UpdateRecipeDto();
            var id = this.dgv_Recipe.CurrentRow.Cells["Id"].Value.ToString().ToInt();
            updateDto.Id = id;
            updateDto.产品类型 = this.txt_ProductType.Text;

            foreach (var item in this.uiTitlePanel1.Controls)
            {
                if (item is UserSetValue usv)
                {
                    updateDto.GetType().GetProperty(usv.VariableName).SetValue(updateDto, usv.VarValue);
                }
            }

            var res = await _recipeManager.UpdateRecipeAsync(updateDto);
            if (res.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("修改配方成功");
                await LoadRecipe();
            }
            else
            {
                UIMessageTip.ShowError(res.Msg);
                LogExtension.ShowMesssage(res.Msg, Microsoft.Extensions.Logging.LogLevel.Error);
            }
        }

        private async void btn_QueryRecipe_Click(object sender, EventArgs e)
        {
            await LoadRecipe();
        }

        private void btn_ExportRecipe_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var rows = this.dgv_Recipe.DataSource as List<QueryRecipeResultDto>;
                    var filePath = saveFileDialog.FileName;
                    MiniExcel.SaveAs(filePath, rows);
                }
                catch (Exception ex)
                {
                    UIMessageTip.ShowError("导出失败");
                    LogExtension.ShowMesssage(ex.Message, Microsoft.Extensions.Logging.LogLevel.Error);
                }

            }

        }

        private async void btn_ImportRecipe_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = fileDialog.FileName;
                    var rows = MiniExcel.Query<QueryRecipeResultDto>(filePath).ToList();

                    //查询数据库的配方，如果导入的配方名称数据库没有，那就添加，如果有 就更新
                    var res = await _recipeManager.GetRecipeListAsync();
                    if (res.Status == SystemEnums.Result.Success)
                    {
                        var dbRows = res.Data;
                        foreach (var row in rows)
                        {
                            var dbRow = dbRows.FirstOrDefault(x => x.产品类型 == row.产品类型);
                            if (dbRow != null)
                            {
                                //更新
                                var updateDto = row.Adapt<UpdateRecipeDto>();
                                updateDto.Id = dbRow.Id;
                                var res1 = await _recipeManager.UpdateRecipeAsync(updateDto);
                                if (res1.Status != SystemEnums.Result.Success)
                                {
                                    UIMessageTip.ShowError("导入失败:" + res1.Msg);
                                    return;
                                }
                            }
                            else
                            {
                                //添加
                                var addDto = row.Adapt<AddRecipeDto>();

                                var res2 = await _recipeManager.AddRecipeAsync(addDto);
                                if (res2.Status != SystemEnums.Result.Success)
                                {
                                    UIMessageTip.ShowError("导入失败:" + res2.Msg);
                                    return;
                                }
                            }
                        }
                        UIMessageTip.ShowOk("导入成功");
                        await LoadRecipe();
                    }
                    else
                    {
                        UIMessageTip.ShowError("导入失败:" + res.Msg);
                    }
                }
                catch (Exception ex)
                {
                    UIMessageTip.ShowError("导入失败");
                }
            }
        }

        private void btn_DownloadRecipe_Click(object sender, EventArgs e)
        {
            if (!Globals.SiemensClient.Connected)
            {
                UIMessageTip.ShowWarning("请先连接西门子客户端");
                return;
            }

            var res = UIMessageBox.ShowAsk("是否要下载到PLC");
            if(res)
            {
                foreach(var item in this.uiTitlePanel1.Controls)
                {
                    if(item is UserSetValue usv)
                    {
                        if(usv.VarValue==string.Empty)
                        {
                            usv.VarValue = "0";
                        }
                        if(!Globals.PlcWrite(usv.VariableName,usv.VarValue,DataTypeEnum.Float))
                        {
                            new UIMessageForm().ShowErrorDialog($"{usv.VariableName}下载失败");
                            return;
                        }
                    }
                }
                UIMessageTip.ShowOk("下载成功");
            }


        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams paras = base.CreateParams;
                paras.ExStyle |= 0x02000000;
                return paras;
            }
        }
    }
}
