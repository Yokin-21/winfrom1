using YR.FrameWork.DependencyInjection;
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
    public partial class PageUserManage : UIPage, ISingletonSelfDependency
    {
        private readonly UserManager _userManager;
        public PageUserManage(UserManager userManager)
        {
            InitializeComponent();
            _userManager = userManager;

            this.cb_Auth.Items.AddRange(Enum.GetNames(typeof(SystemEnums.UserRole)));
            this.cb_Auth.SelectedIndex = -1;

            this.Load += PageUserManage_Load;
        }

        private async void PageUserManage_Load(object? sender, EventArgs e)
        {
            await LoadData();
        }

        private async Task LoadData()
        {
            var res = await _userManager.GetUserListAsync();
            if (res.Status == SystemEnums.Result.Success)
            {
                this.dgv_User.DataSource = res.Data;
                this.dgv_User.Refresh();
            }
        }
        /// <summary>
        /// 添加用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btn_AddUser_Click(object sender, EventArgs e)
        {
            //验证
            if (!VaildInput())
            {
                return;
            }

            UserAddDto addDto = new UserAddDto()
            {
                UserName = this.txt_UserName.Text,
                UserPassword = this.txt_Password.Text,
                Role = this.cb_Auth.SelectedItem.ToString()
            };

            var result = await _userManager.AddUserAsync(addDto);
            if (result.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("添加成功!");
                LogExtension.ShowMesssage("添加用户成功", Microsoft.Extensions.Logging.LogLevel.Information);
                await LoadData();


            }
            else
            {
                UIMessageTip.ShowError(result.Msg);
                LogExtension.ShowMesssage("添加用户失败", Microsoft.Extensions.Logging.LogLevel.Information);

            }
        }

        private async void btn_Update_Click(object sender, EventArgs e)
        {
            //验证
            if (!VaildInput())
            {
                return;
            }

            UserUpdateDto updateDto = new UserUpdateDto()
            {
                Id = int.Parse(this.dgv_User.CurrentRow.Cells["Id"].Value.ToString()),
                UserName = this.txt_UserName.Text,
                UserPassword = this.txt_Password.Text,
                Role = this.cb_Auth.SelectedItem.ToString()
            };

            var res = await _userManager.UpdateUserAsync(updateDto);
            if (res.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("更新成功!");
                LogExtension.ShowMesssage("更新用户成功", Microsoft.Extensions.Logging.LogLevel.Information);
                await LoadData();
            }
            else
            {
                UIMessageTip.ShowError(res.Msg);
                LogExtension.ShowMesssage("更新用户失败", Microsoft.Extensions.Logging.LogLevel.Information);
            }


        }

        private async void btn_Delete_Click(object sender, EventArgs e)
        {
            //判断是否选中行
            if (this.dgv_User.CurrentRow == null)
            {
                UIMessageTip.ShowWarning("请先选择一行");
                return;
            }

            UserDeleteDto deleteDto = new UserDeleteDto()
            {
                Id = int.Parse(this.dgv_User.CurrentRow.Cells["Id"].Value.ToString()),
            };

            var res = await _userManager.DeleteUserAsync(deleteDto);
            if (res.Status == SystemEnums.Result.Success)
            {
                UIMessageTip.ShowOk("删除成功!");
                LogExtension.ShowMesssage("删除用户成功", Microsoft.Extensions.Logging.LogLevel.Information);
                await LoadData();
            }
            else
            {
                UIMessageTip.ShowError(res.Msg);
                LogExtension.ShowMesssage("删除用户失败", Microsoft.Extensions.Logging.LogLevel.Information);
            }

        }
        private bool VaildInput()
        {
            if (this.txt_UserName.Text.IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("用户名不能为空!");
                return false;
            }
            if (this.txt_Password.Text.IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("密码不能为空!");
                return false;
            }
            if (this.txt_EnterPassword.Text.IsNullOrEmpty())
            {
                UIMessageTip.ShowWarning("确认密码不能为空!");
                return false;
            }
            if (this.txt_Password.Text != this.txt_EnterPassword.Text)
            {
                UIMessageTip.ShowWarning("两次密码输入不一致!");
                return false;
            }
            if (this.cb_Auth.SelectedIndex == -1)
            {
                UIMessageTip.ShowWarning("请选择用户权限!");
                return false;
            }
            return true;
        }

        private void dgv_User_SelectIndexChange(object sender, int index)
        {
            var row = this.dgv_User.Rows[index];
            this.txt_UserName.Text = row.Cells["UserName"].Value.ToString();
            this.txt_Password.Text = row.Cells["UserPassword"].Value.ToString();
            this.txt_EnterPassword.Text = row.Cells["UserPassword"].Value.ToString();
            this.cb_Auth.SelectedItem = row.Cells["Role"].Value.ToString();
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
