using Garden.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using MyGarden.Domain;
using MyGarden.Domain.Garden;
using MyGarden.Infrastructure.Configurations;

namespace MyGarden.Infrastructure
{
    public class GardenDbContext : DbContext
    {
        public GardenDbContext(DbContextOptions<GardenDbContext> options) : base(options)
        {
        }

        public DbSet<GardenModel> Gardens { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<PlantCharacteristics> Plants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PlantCharacteristicsConfiguration());
            builder.ApplyConfiguration(new GardenConfiguration());
            builder.ApplyConfiguration(new GardenActionConfiguration());
            builder.ApplyConfiguration(new SowingConfiguration());
            builder.ApplyConfiguration(new NameConfiguration());

            builder.Entity<User>().ToTable("Users");
        }
    }
}
