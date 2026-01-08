using Microsoft.Extensions.DependencyInjection;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yale.DAL
{
    public static class DB
    {
        public static ISqlSugarClient SqlSugarClient { get; set; }

        public static void AddSqlSugarSetup(this IServiceCollection services,SqlSugar.DbType dataType,string conn)
        {
            services.AddSingleton<ISqlSugarClient>(s =>
            {
                SqlSugarClient = new SqlSugarScope(new ConnectionConfig()
                {
                    DbType = dataType,
                    ConnectionString = conn,
                    IsAutoCloseConnection = true,
                });
                return SqlSugarClient;
            });
        }

    }
}
