using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace $ext_safeprojectname$.Business
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services)
        {
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
