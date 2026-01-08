using YR.FrameWork.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using NLog;
using NLog.Extensions.Logging;
using SqlSugar;
using System.Reflection;
using Yale.BLL;
using Yale.DAL;
using Yale.Model;

namespace Yale.SprayProcessSCADASystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //创建服务容器
            var services = new ServiceCollection();
            //注册服务
            ConfigureService(services);
            //构建服务提供者
            var serviceProvider = services.BuildServiceProvider();

            Globals.ServiceProvider = serviceProvider;

            ApplicationConfiguration.Initialize();

            var frmMain = serviceProvider.GetRequiredService<FrmMain>();

            var db = Globals.ServiceProvider.GetRequiredService<ISqlSugarClient>();



         


#if DEBUG

            db.CodeFirst.SetStringDefaultLength(200)
            .InitTables(typeof(AuthEntity), typeof(DataEntity), typeof(RecipeEntity), typeof(UserEntity));
#endif

            Application.Run(frmMain);
        }

        private static void ConfigureService(ServiceCollection services)
        {
            //注册依赖注入  通过程序集的  某一个类 自动注册程序集内的类。条件是 该类实现了比如说ISingletonDependency 之类的接口
            services.AddDependencyInjection(new List<Assembly>()
            {
                typeof(Program).Assembly,
                typeof(BaseDto).Assembly,
                typeof(DB).Assembly
            });



            //注册json配置
            IConfigurationBuilder cfgBuilder = new ConfigurationBuilder()
                .SetBasePath(Environment.CurrentDirectory)
                .AddJsonFile("appsettings.json");

            //构建json配置
            IConfiguration configuration = cfgBuilder.Build();
            //注入json单例对象
            services.AddSingleton<IConfiguration>(configuration)
                .AddLogging(loggerBuilder =>
                {
                    loggerBuilder.ClearProviders();//清除其他日志的提供者
                    loggerBuilder.SetMinimumLevel(Microsoft.Extensions.Logging.LogLevel.Trace);//设置等级
                    loggerBuilder.AddNLog();
                });
            DbType dbType = Enum.Parse<DbType>(configuration["DbContexts:DbType"]);
            string connectionString = configuration[$"DbContexts:{dbType}:ConnectionString"];

            services.AddSqlSugarSetup(dbType, connectionString);

            //获取NLog配置信息
            var nlogConifg = configuration.GetSection("NLog");

            //设置Nlog配置
            LogManager.Configuration = new NLogLoggingConfiguration(nlogConifg);
        }
    }
}