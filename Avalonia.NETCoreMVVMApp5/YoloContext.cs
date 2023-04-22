using Avalonia.NETCoreMVVMApp5.Models;
using Microsoft.EntityFrameworkCore;

namespace Avalonia.NETCoreMVVMApp5;

public class YoloContext : DbContext
{
    public DbSet<Students> students { get; set; }
    public DbSet<Subject> subject { get; set; }
    public DbSet<Grade> grade { get; set; }

    public YoloContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(
            "Host=localhost;Port=5432;Database=trpo_yolo_db;Username=postgres;Password=vlad2004");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Models.Grade>().HasOne(x => x.student).WithMany(t => t.grades)
            .HasForeignKey(x => x.idstudents).OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Models.Grade>().HasOne(x => x.subject).WithMany(t => t.grades)
            .HasForeignKey(x => x.idsubject).OnDelete(DeleteBehavior.Restrict);

    }
}