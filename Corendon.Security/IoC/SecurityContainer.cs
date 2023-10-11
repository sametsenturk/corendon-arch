using Corendon.Security.Abstract;
using Corendon.Security.Concrate;
using Microsoft.Extensions.DependencyInjection;

namespace Corendon.Security.IoC
{
    public static class SecurityContainer
    {
        public static void RegisterSecurityServices(this IServiceCollection services)
        {
            services.AddScoped<IJsonWebTokenHelper, JsonWebTokenHelper>();
        }
    }
}
