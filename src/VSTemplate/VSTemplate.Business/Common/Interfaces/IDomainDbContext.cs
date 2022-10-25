namespace $ext_safeprojectname$.Business.Common.Interfaces
{
    public interface IDomainDbContext
    {
        //DbSet<Domain.Model> Todos { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
