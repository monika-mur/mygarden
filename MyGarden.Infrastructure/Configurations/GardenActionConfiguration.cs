using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGarden.GardenKnowledge.Domain;

namespace MyGarden.Infrastructure.Configurations
{
    public class GardenActionConfiguration : IEntityTypeConfiguration<GardenAction>
    {
        public void Configure(EntityTypeBuilder<GardenAction> builder)
        {
            builder.ToTable("GardenAction");
            builder.OwnsOne(t => t.Time);
        }
    }
}
