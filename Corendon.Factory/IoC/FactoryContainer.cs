using Corendon.Data.Entity.Abstract.Announcement;
using Corendon.Data.Entity.Concrate.Announcement;
using Corendon.Data.Entity.Concrate.User;
using Corendon.Factory.Abstract.Announcement;
using Corendon.Factory.Abstract.Company;
using Corendon.Factory.Abstract.User;
using Corendon.Factory.Concrate.Announcement;
using Corendon.Factory.Concrate.Company;
using Corendon.Factory.Concrate.User;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corendon.Factory.IoC
{
    public static class FactoryContainer
    {
        public static void RegisterAnnouncementFactories(this IServiceCollection services)
        {
            services.AddScoped<IAnnouncementAbstractFactory, AnnouncementFactory>();
        }

        public static void RegisterCompanyFactories(this IServiceCollection services)
        {
            services.AddScoped<ICompanyAbstractFactory, CompanyFactory>();
            services.AddScoped<ICompanyDepartmentAbstractFactory, CompanyDepartmentFactory>();
        }

        public static void RegisterUserFactories(this IServiceCollection services)
        {
            services.AddScoped<IUserAbstractFactory, UserFactory>();
            services.AddScoped<IUserNotificationAbstractFactory, UserNotificationFactory>();
            services.AddScoped<IUserAnnouncementCommentAbstractFactory, UserAnnouncementCommentFactory>();
            services.AddScoped<IUserAnnouncementVoteAbstractFactory, UserAnnouncementVoteFactory>();
        }
    }
}
