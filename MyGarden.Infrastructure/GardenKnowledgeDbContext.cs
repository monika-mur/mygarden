using Microsoft.EntityFrameworkCore;
using MyGarden.Domain;

namespace MyGarden.Infrastructure
{
    public class GardenKnowledgeDbContext : DbContext
    {
        public GardenKnowledgeDbContext(DbContextOptions<GardenKnowledgeDbContext> options) : base(options)
        {
        }

        public DbSet<PlantCharacteristics> Plants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PlantCharacteristics>().ToTable("PlantCharacteristics");
        }
    }
}
