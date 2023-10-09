using Corendon.Repository.Repositories.Announcement.AnnouncementEntityRepositories;
using Corendon.Repository.Repositories.Company.CompanyDepartmentEntityRepositories;
using Corendon.Repository.Repositories.Company.CompanyEntityRepositories;
using Corendon.Repository.Repositories.User.UserAnnouncementCommentEntityRepositories;
using Corendon.Repository.Repositories.User.UserAnnouncementVoteEntityRepositories;
using Corendon.Repository.Repositories.User.UserEntityRepositories;
using Corendon.Repository.Repositories.User.UserNotificationEntityRepositories;
using Microsoft.Extensions.DependencyInjection;

namespace Corendon.Repository.IoC
{
    public static class RepositoryContainer
    {
        public static void RegisterAnnouncementRepositories(this IServiceCollection services)
        {
            services.AddScoped<IAnnouncementEntityRepository, AnnouncementEntityRepository>();
        }

        public static void RegisterCompanyRepositories(this IServiceCollection services)
        {
            services.AddScoped<ICompanyEntityRepository, CompanyEntityRepository>();
            services.AddScoped<ICompanyDepartmentEntityRepository, CompanyDepartmentEntityRepository>();
        }
        public static void RegisterUserRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUserEntityRepository, UserEntityRepository>();
            services.AddScoped<IUserNotificationEntityRepository, UserNotificationEntityRepository>();
            services.AddScoped<IUserAnnouncementVoteEntityRepository, UserAnnouncementVoteEntityRepository>();
            services.AddScoped<IUserAnnouncementCommentEntityRepository, UserAnnouncementCommentEntityRepository>();
        }
    }
}
