using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Yale.Model;

namespace Yale.DAL
{
    public class BaseService<T> where T : BaseEntity, new()
    {
        public virtual async Task<int> InsertAsync(T model)
        {
            var runsql = DB.SqlSugarClient.Insertable<T>(model);
            var rows = await runsql.ExecuteCommandAsync();
            return rows;
        }

        public virtual async Task<bool> UpdateAsync(T model)
        {
            var runsql = DB.SqlSugarClient.Updateable(model);
            var rows = await runsql.ExecuteCommandAsync();
            return rows > 0;
        }

        public virtual async Task<bool> DeleteAsync(T model)
        {
            var runsql = DB.SqlSugarClient.Deleteable(model);
            var rows=await runsql.ExecuteCommandAsync();
            return rows > 0;
        }

        public virtual async Task<T> GetByOneAsync(Expression<Func<T,bool>> where)
        {
            var runsql = DB.SqlSugarClient.Queryable<T>().Where(where);
            return await runsql.FirstAsync();
        }

        public virtual async Task<List<T>>GetListAsync(Expression<Func<T, bool>> where)
        {
            var runsql = DB.SqlSugarClient.Queryable<T>().Where(where);
            return await runsql.ToListAsync();
        }

        public virtual async Task<bool> ExistAsync(Expression<Func<T, bool>> where)
        {
            return await DB.SqlSugarClient.Queryable<T>()
                .Where(where)
                .AnyAsync();
        }

    }
}
