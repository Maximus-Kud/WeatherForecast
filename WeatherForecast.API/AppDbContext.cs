using Microsoft.EntityFrameworkCore;

namespace WeatherForecast.API
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<WeatherForecast> Weather { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WeatherForecast>().HasData(
                new WeatherForecast
                {
                    Id = 1,
                    Date = DateOnly.MaxValue,
                    TemperatureC = 24,
                    Summary = "Warm"
                });
        }
    }
}
