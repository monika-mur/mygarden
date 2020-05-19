using Microsoft.EntityFrameworkCore;
using MyGarden.Domain;
using MyGarden.Domain.Garden;

namespace MyGarden.Infrastructure
{
    public class GardenDbContext : DbContext
    {
        public GardenDbContext(DbContextOptions<GardenDbContext> options) : base(options)
        {
        }

        public DbSet<Garden> Gardens { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Garden>().ToTable("Garden");
            builder.Entity<User>().ToTable("Users");
        }
    }
}
