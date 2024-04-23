using System;
using System.ComponentModel.DataAnnotations;
using TheContactlessStore.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data_Spider_API.DBContext
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // Enable sensitive data logging
            optionsBuilder.EnableSensitiveDataLogging();
        }

        public DbSet<UserType> UserTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Types of Users in the system.
            modelBuilder.Entity<UserType>()
                .HasData(
                new
                {
                    UserTypeId = 1,
                    UserTypeName = "Store"
                }
                );

            modelBuilder.Entity<UserType>()
                .HasData(
                new
                {
                    UserTypeId = 2,
                    UserTypeName = "Client"
                }
                );
        }
    }
}
