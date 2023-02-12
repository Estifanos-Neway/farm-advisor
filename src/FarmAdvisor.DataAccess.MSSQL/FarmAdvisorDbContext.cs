using Microsoft.EntityFrameworkCore;
using FarmAdvisor.Models;
using System;
using System.IO;

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
        Console.WriteLine("connectionString");
        string connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING")!;
        Console.WriteLine(connectionString);
        optionsBuilder.UseSqlServer(connectionString);
    }
}