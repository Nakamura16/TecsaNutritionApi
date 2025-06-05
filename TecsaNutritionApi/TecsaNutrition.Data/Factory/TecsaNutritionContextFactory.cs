using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TecsaNutrition.Data
{
    public class TecsaNutritionContextFactory : IDesignTimeDbContextFactory<TecsaNutritionContext>
    {
        public TecsaNutritionContext CreateDbContext(string[] args)
        {
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), "..", "TecsaNutritionApi");

            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<TecsaNutritionContext>();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            optionsBuilder.UseSqlServer(connectionString);

            return new TecsaNutritionContext(optionsBuilder.Options);
        }
    }
}
