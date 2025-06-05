using Microsoft.EntityFrameworkCore;
using TecsaNutrition.Data.Entity;
using TecsaNutrition.Models;

namespace TecsaNutrition.Data;

public class TecsaNutritionContext : DbContext
{
    public TecsaNutritionContext(DbContextOptions<TecsaNutritionContext> options) : base(options) { }

    public DbSet<PatientEntity> Patients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PatientEntity>().HasData(
            new PatientEntity("André", "email", "234", "Male", 11, 12) { Id = 1});
    }
}
