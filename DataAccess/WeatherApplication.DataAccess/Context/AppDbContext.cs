using System;
using Microsoft.EntityFrameworkCore;
using WeatherApplication.Entities.Concrete.TableModels;

namespace WeatherApplication.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        //{
        //}
        public DbSet<District> Districts { get; set; }
        public DbSet<WeatherReport> WeatherReports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;database=WeatherBaseApplication;Trusted_Connection=false;User id=sa;password=reallyStrongPwd123;TrustServerCertificate=True;", b => b.MigrationsAssembly("WeatherApplication.DataAccess"));
        }
    }
}