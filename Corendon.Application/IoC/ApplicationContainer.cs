using Corendon.Application.Result.Factory;
using Corendon.Application.Result.Model;
using Corendon.Application.Services.Announcement.AnnouncementEntityServices;
using Corendon.Application.Services.Company.CompanyDepartmentEntityServices;
using Corendon.Application.Services.Company.CompanyEntityServices;
using Corendon.Application.Services.User.UserAnnouncementCommentEntityServices;
using Corendon.Application.Services.User.UserAnnouncementVoteEntityServices;
using Corendon.Application.Services.User.UserEntityServices;
using Corendon.Application.Services.User.UserNotificationEntityServices;
using Corendon.ViewModels.Abstract.User;
using Corendon.ViewModels.Concrate.User;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Corendon.Application.IoC
{
    public static class ApplicationContainer
    {
        public static void RegisterAnnouncementServices(this IServiceCollection services)
        {
            services.AddScoped<IAnnouncementEntityService, AnnouncementEntityService>();
        }

        public static void RegisterCompanyServices(this IServiceCollection services)
        {
            services.AddScoped<ICompanyEntityService, CompanyEntityService>();
            services.AddScoped<ICompanyDepartmentEntityService, CompanyDepartmentEntityService>();
        }

        public static void RegisterUserServices(this IServiceCollection services)
        {
            services.AddScoped<IUserEntityService, UserEntityService>();
            services.AddScoped<IUserNotificationEntityService, UserNotificationEntityService>();
            services.AddScoped<IUserAnnouncementVoteEntityService, UserAnnouncementVoteEntityService>();
            services.AddScoped<IUserAnnouncementCommentEntityService, UserAnnouncementCommentEntityService>();
        }

        public static void RegisterResultModels(this IServiceCollection services)
        {
            services.AddScoped<IServiceResultAbstractFactory<IUserEntityModel>, IServiceResultAbstractFactory<IUserEntityModel>>();
            services.AddScoped<IServiceResult<IUserEntityModel>, ServiceResult<IUserEntityModel>>();
        }

    }
}
