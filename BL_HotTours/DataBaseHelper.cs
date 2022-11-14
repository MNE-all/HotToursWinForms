using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BL_HotTours
{
    public class DataBaseHelper
    {
       public static DbContextOptions<ApplicationContext> Options()
        {
            var builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");

            var config = builder.Build();
            string conString = config.GetConnectionString("MSDB");
            var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            var options = optionBuilder.UseSqlServer(conString).Options;
            return options;
        }
    }
}
