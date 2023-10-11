using Corendon.Data.Entity.Abstract.User;
using Corendon.Data.Entity.Concrate.User;
using Microsoft.Extensions.DependencyInjection;

namespace Corendon.Data.IoC
{
    public static class EntityContainer
    {
        public static void RegisterEntityInheritances(this IServiceCollection services)
        {
            services.AddScoped<IUserEntity, UserEntity>();
        }
    }
}
