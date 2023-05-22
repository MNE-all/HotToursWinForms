using HotTours.Models;
using Microsoft.EntityFrameworkCore;

namespace HotTours
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Tour> Tours { get; set; }
        public DbSet<User> Users { get; set; }
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().HasKey(x => x.Guid);
            modelBuilder.Entity<User>().HasKey(x => x.Id);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HotToursLocalDB;Trusted_Connection=True;");
        }
    }
}
