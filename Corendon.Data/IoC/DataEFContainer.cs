using Corendon.Common.Settings.Data;
using Corendon.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Data.IoC
{
    public static class DataEFContainer
    {
        public static void AddBackendDataEF<TContext>(this IServiceCollection services, string connectionKey, IConfiguration configuration) where TContext : DbContextBase
        {
            services.AddDbContext<TContext>(optionsBuilder =>
            {
                var dbConfiguration = configuration.GetSection($"Databases:{connectionKey}").Get<DatabaseSettings>();
                switch (dbConfiguration.DatabaseType)
                {
                    case DatabaseType.SqlServer:
                        optionsBuilder.UseSqlServer(dbConfiguration.ConnectionString);
                        break;
                    case DatabaseType.SqlLite:
                        //optionsBuilder.UseSqlite(dbConfiguration.ConnectionString);
                        throw new NotSupportedException($"Name {dbConfiguration.DatabaseType}:is not supported");
                    case DatabaseType.Postgre:
                        //optionsBuilder.UseNpgsql(dbConfiguration.ConnectionString);
                        throw new NotSupportedException($"Name {dbConfiguration.DatabaseType}:is not supported");
                    default:
                        throw new NotSupportedException($"Name {dbConfiguration.DatabaseType}:is not supported");
                }
            }).AddScoped<DbContextBase, TContext>();
        }
    }
}
