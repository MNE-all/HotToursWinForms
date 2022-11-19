using Microsoft.EntityFrameworkCore.Design;

namespace HotTours
{
    public class SampleContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        => new ApplicationContext(DataBaseHelper.Options());
    }
}
