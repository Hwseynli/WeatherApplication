using System;
using Microsoft.EntityFrameworkCore;

namespace WeatherApplication.DataAccess.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;database=WeatherBase;Trusted_Connection=false;User id=sa;password=reallyStrongPwd123;TrustServerCertificate=True;");
        }
    }
}

