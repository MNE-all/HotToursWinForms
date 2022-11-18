using Microsoft.EntityFrameworkCore.Design;

namespace Hot_tours
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        => new ApplicationContext(DataBaseHelper.Options());
    }
}
