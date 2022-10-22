using Microsoft.EntityFrameworkCore;

namespace $ext_safeprojectname$.Application.Common.Interfaces
{
    public interface IDomainDbContext
    {
        //DbSet<Domain.Model> Todos { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
