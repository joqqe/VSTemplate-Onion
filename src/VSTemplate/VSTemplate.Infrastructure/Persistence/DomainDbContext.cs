using Microsoft.EntityFrameworkCore;
using $ext_safeprojectname$.Business.Common.Interfaces;

namespace $ext_safeprojectname$.Infrastructure.Persistence
{
    public class DomainDbContext : DbContext, IDomainDbContext
    {
        //public DbSet<Domain.Model> Todos => Set<Domain.Model>();

        public DomainDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            Database.EnsureCreated();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder
            //    .Entity<Domain.Model>()
            //    .HasKey(t => t.Id);

            //modelBuilder
            //    .Entity<Domain.Model>()
            //    .Property(t => t.Id)
            //    .ValueGeneratedOnAdd();

            base.OnModelCreating(modelBuilder);
        }
    }
}
