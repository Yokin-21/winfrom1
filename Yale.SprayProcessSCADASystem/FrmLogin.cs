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
    public partial class FrmLogin : UILoginForm, ISingletonSelfDependency
    {
        private readonly UserManager _userManager;
        public FrmLogin(UserManager userManager)
        {
            InitializeComponent();
            this._userManager = userManager;
        }

        private async void FrmLogin_ButtonLoginClick(object sender, EventArgs e)
        {
            var res =await _userManager.LoginAsync(new UserLoginDto() { UserName = UserName, UserPassword = Password });

            if(res.Status==SystemEnums.Result.Success)
            {
                IsLogin = true;
                this.ShowSuccessTip("登录成功");
                Close();
            }
            else
            {
                this.ShowErrorTip(res.Msg);
            }
      
        }
    }
}
