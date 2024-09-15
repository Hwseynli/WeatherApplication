using Microsoft.EntityFrameworkCore;
using WeatherApplication.Entities.Concrete.TableModels;
using WeatherApplication.Entities.Concrete.TableModels.ModelXml;

namespace WeatherApplication.DataAccess.Context;
public class AppDbContext : DbContext
{
    //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    //{
    //}
    public DbSet<District> Districts { get; set; }
    public DbSet<WeatherReport> WeatherReports { get; set; }
    public DbSet<WeatherReportXml> WeatherReportXmls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost;database=WeatherDB;Trusted_Connection=false;User id=sa;password=reallyStrongPwd123;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<WeatherReport>()
        .HasOne(w => w.District)
        .WithMany(d => d.WeatherReports)
        .HasForeignKey(w => w.DistrictId)
        .OnDelete(DeleteBehavior.Cascade);
    }
}