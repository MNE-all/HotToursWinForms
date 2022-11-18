﻿using Hot_tours.Models;
using Microsoft.EntityFrameworkCore;

namespace Hot_tours
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Tour> Tours { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tour>().HasKey(x => x.Guid);
        }
    }
}
