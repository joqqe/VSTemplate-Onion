using Microsoft.Extensions.DependencyInjection;
using $ext_safeprojectname$.Business.Common.Interfaces;

namespace $ext_safeprojectname$.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services, Action<InfrastructureOptions> options)
        {
            var infraOptions = new InfrastructureOptions();
            options(infraOptions);

            services.AddDbContext<DomainDbContext>(infraOptions.DbContextOptionsBuilder);

            services.AddScoped<IDomainDbContext>(collection => collection.GetRequiredService<DomainDbContext>());

            return services;
        }
    }
}
