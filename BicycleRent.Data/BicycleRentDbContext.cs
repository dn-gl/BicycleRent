using BicycleRent.DAL.Configurations;
using BicycleRent.DAL.DataSeeding;
using BicycleRent.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BicycleRent.DAL
{
    public class BicycleRentDbContext : DbContext
    {
        public BicycleRentDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BicycleConfiguration())
                        .ApplyConfiguration(new BicycleTypeConfiguration());

            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<BicycleType> Types { get; set; }
    }
}
