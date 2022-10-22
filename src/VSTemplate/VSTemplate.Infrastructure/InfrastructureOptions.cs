namespace $ext_safeprojectname$.Infrastructure
{
    public class InfrastructureOptions
    {
        public Action<DbContextOptionsBuilder> DbContextOptionsBuilder { get; set; } = default!;
    }
}
