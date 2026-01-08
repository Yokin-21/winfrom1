using YR.FrameWork.DependencyInjection;
using MiniExcelLibs;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yale.SprayProcessSCADASystem
{
    public partial class PageLogManage : UIPage, ISingletonSelfDependency
    {
        public PageLogManage()
        {
            InitializeComponent();
            InitCbData();
        }

        private void InitCbData()
        {
            string logPath = Path.Combine(Application.StartupPath, "Logs");
            if (!Directory.Exists(logPath))
            {
                Directory.CreateDirectory(logPath);
            }

            string[] dirNames = Directory.GetDirectories(logPath);
            dirNames.ForEach(x =>
            {
                this.cb_Date.Items.Add(Path.GetFileName(x));
            });
        }

        private void cb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            string logPath = Path.Combine(Application.StartupPath, "Logs", cb_Date.SelectedItem.ToString());

            string[] dirNames = Directory.GetDirectories(logPath);
            this.cb_LogLev.Items.Clear();

            dirNames.ForEach(x =>
            {
                this.cb_LogLev.Items.Add(Path.GetFileName(x));
            });
        }

        private void cb_LogLev_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_Date.SelectedItem == null)
            {
                UIMessageTip.ShowError("请先选择日期");
                return;
            }
            if (this.cb_LogLev.SelectedItem == null)
            {
                UIMessageTip.ShowError("请先选择日志级别");
                return;
            }

            string logPath = Path.Combine(Application.StartupPath, "Logs", cb_Date.SelectedItem.ToString(), cb_LogLev.SelectedItem.ToString());
            this.lb_Files.Items.Clear();

            string[] fileNames = Directory.GetFiles(logPath, "*.log");

            fileNames.OrderBy(x => x).ToList().ForEach(x =>
            {
                this.lb_Files.Items.Add(Path.GetFileName(x));
            });
        }

        private async void lb_Files_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cb_Date.SelectedItem == null)
            {
                UIMessageTip.ShowError("请先选择日期");
                return;
            }
            if (this.cb_LogLev.SelectedItem == null)
            {
                UIMessageTip.ShowError("请先选择日志级别");
                return;
            }
            if (this.lb_Files.SelectedItem == null)
            {
                UIMessageTip.ShowError("请先选择日志文件");
                return;
            }
            try
            {
                string logPath = Path.Combine(Application.StartupPath, "Logs", cb_Date.SelectedItem.ToString(), cb_LogLev.SelectedItem.ToString(), lb_Files.SelectedItem.ToString());

                string content = string.Empty;

                this.txt_ShowLog.Text = "";

                using (StreamReader sr = new StreamReader(logPath))
                {
                    content = await sr.ReadToEndAsync();
                }

                this.txt_ShowLog.Text = content;
            }
            catch (Exception ex)
            {

                LogExtension.ShowMesssage(ex.Message, Microsoft.Extensions.Logging.LogLevel.Error);
            }



        }

        private void btn_OpenDire_Click(object sender, EventArgs e)
        {
            string logPath = Path.Combine(Application.StartupPath, "Logs");

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = logPath,
                UseShellExecute = true
            };

            Process process = new Process
            {
                StartInfo = startInfo
            };

            process.Start();

        }

        private void btn_ShowToDgv_Click(object sender, EventArgs e)
        {
            if (this.txt_ShowLog.Text.Length == 0)
            {
                UIMessageTip.ShowWarning("请先选择日志文件");
                return;
            }

            string[] lines = this.txt_ShowLog.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            DataTable dt = new DataTable();
            dt.Columns.Add("时间");
            dt.Columns.Add("日志等级");
            dt.Columns.Add("日志来源");
            dt.Columns.Add("日志内容");

            lines.ToList().ForEach(x =>
            {

                string[] items = x.Split(new string[] { "|" }, StringSplitOptions.None);

                if (items.Length == 4)
                {
                    DataRow dr = dt.NewRow();
                    dr["时间"] = items[0];
                    dr["日志等级"] = items[1];
                    dr["日志来源"] = items[2];
                    dr["日志内容"] = items[3];
                    dt.Rows.Add(dr);
                }
            });

            this.dgv_ShowLog.DataSource = dt;


        }

        private void btn_ShowToTXT_Click(object sender, EventArgs e)
        {
            if (this.txt_ShowLog.Text == string.Empty)
            {
                UIMessageTip.ShowWarning("请选择日志文件");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "文本文件|*.txt";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.Write(this.txt_ShowLog.Text);
                    }

                    LogExtension.ShowMesssage("日志导出成功", Microsoft.Extensions.Logging.LogLevel.Information);

                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true
                    };

                    Process process = new Process
                    {
                        StartInfo = startInfo
                    };

                    process.Start();
                }
                catch (Exception ex)
                {
                    UIMessageTip.ShowError(ex.Message);
                    LogExtension.ShowMesssage(ex.Message, Microsoft.Extensions.Logging.LogLevel.Error);
                }

            }

        }

        private async void btn_ExportExcel_Click(object sender, EventArgs e)
        {
            if (this.dgv_ShowLog.DataSource == null)
            {
                UIMessageTip.ShowWarning("请先选择日志文件");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel文件|*.xlsx";
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dt = this.dgv_ShowLog.DataSource as DataTable;

                    await MiniExcel.SaveAsAsync(sfd.FileName, dt);
                    LogExtension.ShowMesssage("日志导出成功", Microsoft.Extensions.Logging.LogLevel.Information);
                    ProcessStartInfo startInfo = new ProcessStartInfo
                    {
                        FileName = sfd.FileName,
                        UseShellExecute = true
                    };

                    Process process = new Process
                    {
                        StartInfo = startInfo
                    };

                    process.Start();
                }
                catch (Exception ex)
                {
                    UIMessageTip.ShowError(ex.Message);
                    LogExtension.ShowMesssage(ex.Message, Microsoft.Extensions.Logging.LogLevel.Error);
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
