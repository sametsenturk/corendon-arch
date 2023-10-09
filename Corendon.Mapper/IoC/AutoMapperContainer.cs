using AutoMapper;
using Corendon.Mapper.Profiles.User;
using Microsoft.Extensions.DependencyInjection;

namespace Corendon.Mapper.IoC
{
    public static class AutoMapperContainer
    {
        public static void ConfigureAutoMapperProfiles(this IServiceCollection services)
        {
            services.AddSingleton<IMapper>(new MapperConfiguration(config =>
            {
                #region Announcement Profiles


                #endregion

                #region Company Profiles


                #endregion

                #region User Profiles

                config.AddProfile<UserEntityMapperProfile>();

                #endregion
            }).CreateMapper());
        }
    }
}
