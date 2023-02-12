using Microsoft.EntityFrameworkCore;
using FarmAdvisor.Models;

namespace FarmAdvisor.DataAccess.MSSQL;

public class FarmAdvisorDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    public DbSet<Farm> Farms { get; set; } = null!;
    public DbSet<Field> Fields { get; set; } = null!;
    public DbSet<Sensor> Sensors { get; set; } = null!;
    public DbSet<SensorGddReset> SensorGddResets { get; set; } = null!;
    public DbSet<SensorStatistic> SensorStatistics { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connectionString = "Server=localhost,5500;Database=FarmAdvisor;User Id=SA;Password=Pass_Word;MultipleActiveResultSets=true;TrustServerCertificate=true";
        optionsBuilder.UseSqlServer(connectionString);
    }
}