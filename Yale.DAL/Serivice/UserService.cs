using YR.FrameWork.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yale.Helper;
using Yale.Model;

namespace Yale.DAL
{
    public class UserService : BaseService<UserEntity>, IScopedSelfDependency
    {
        public async Task<BaseResult<UserEntity>> LoginAsync(UserEntity entity)
        {
            BaseResult<UserEntity> result = new BaseResult<UserEntity>();

            var res = await DB.SqlSugarClient.Queryable<UserEntity>().Where(e => e.UserName == entity.UserName && e.UserPassword == entity.UserPassword).FirstAsync();

            if (res == null)
            {
                result.Status = SystemEnums.Result.Fail;
                result.Msg = "用户名或密码错误";
                return result;
            }
            result.Data = new List<UserEntity>() { res };
            return result;
        }
    }
}
