using YR.FrameWork.DependencyInjection;
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
    public partial class PageReportManage : UIPage, ISingletonSelfDependency
    {
        private readonly DataManager _dataManager;
        public PageReportManage(DataManager dataManager)
        {
            InitializeComponent();
            this._dataManager = dataManager;

            this.dtp_Start.Value = DateTime.Now.AddDays(-1);
            this.dtp_End.Value = DateTime.Now;

            this.dgv_Data.AutoGenerateColumns = false;
        }

        private BaseResult<QueryDataResultDto> res;
        private async void btn_QueryData_Click(object sender, EventArgs e)
        {
            DateTime t1 = this.dtp_Start.Value;
            DateTime t2 = this.dtp_End.Value;
            if (t1 >= t2)
            {
                UIMessageTip.ShowWarning("开始时间不可以大于结束时间");
                return;
            }

            QueryDataDto queryDataDto = new QueryDataDto() { StartTime = t1, EndTime = t2 };

            res = await _dataManager.GetDataListByTimeAsync(queryDataDto);

            if (res.Status == SystemEnums.Result.Success)
            {
                //设置分页的总数
                pgn_Data.TotalCount = res.Data.Count;
                //设置每页的数量
                pgn_Data.PageSize = 15;
                pgn_Data.ActivePage = 1;
            }

        }

        private void pgn_Data_PageChanged(object sender, object pagingSource, int pageIndex, int count)
        {
            var data = res.Data.Skip(pageIndex * count).Take(count).ToList();

            this.dgv_Data.DataSource = null;
            this.dgv_Data.DataSource = data;
        }

        private void btn_ExportData_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 文件(*.xlsx)|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var filePath = saveFileDialog.FileName;
                    var rows = this.dgv_Data.DataSource as List<QueryDataResultDto>;

                    MiniExcel.SaveAs(filePath, rows);
                }
                catch (Exception ex)
                {
                    UIMessageTip.ShowError("导出失败：" + ex.Message);
                    LogExtension.ShowMesssage("导出失败：" + ex.Message,Microsoft.Extensions.Logging.LogLevel.Error);
                }
                

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
