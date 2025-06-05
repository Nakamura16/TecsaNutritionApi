using Microsoft.EntityFrameworkCore;
using TecsaNutrition.Data.Entity;

namespace TecsaNutrition.Data;

public class TecsaNutritionContext : DbContext
{
    public TecsaNutritionContext(DbContextOptions<TecsaNutritionContext> options) : base(options) { }

    public DbSet<PatientEntity> Patients { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
