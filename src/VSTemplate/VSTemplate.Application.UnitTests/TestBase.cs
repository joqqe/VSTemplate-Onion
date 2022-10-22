
using Microsoft.Extensions.DependencyInjection;

namespace $ext_safeprojectname$.Application.UnitTests
{
    public abstract class TestBase : IDisposable
    {
        public readonly ServiceProvider serviceProvider;

        public TestBase()
        {
            var services = new ServiceCollection();

            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            services.AddInfrastructure(options =>
            {
                options.DbContextOptionsBuilder = (dbOptions =>
                {
                    dbOptions.UseSqlite(connection);
                });
            });
            services.AddApplication();

            serviceProvider = services.BuildServiceProvider();

            var domainDbContext = GetScopedTodoDbContext();
            domainDbContext.Database.EnsureCreated();
        }

        public void Dispose()
        {
            GetScopedTodoDbContext().Database.EnsureDeleted();
        }

        private DomainDbContext GetScopedTodoDbContext()
        {
            var scopeFactory = serviceProvider.GetRequiredService<IServiceScopeFactory>();
            var scope = scopeFactory.CreateScope();
            return scope.ServiceProvider.GetService<DomainDbContext>()!;
        }
    }
}
