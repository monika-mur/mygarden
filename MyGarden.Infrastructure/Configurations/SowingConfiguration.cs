using Garden.Domain.GardenKnowledge.Plants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Garden.Infrastructure.Configurations
{
    public class SowingConfiguration : IEntityTypeConfiguration<Sowing>
    {
        public void Configure(EntityTypeBuilder<Sowing> builder)
        {
            builder.ToTable("Sowing");

            builder.HasKey(x => x.PlantCharacteristicsId);

            builder.OwnsOne(x => x.SowingDate,
                y => y.Property(p => p.MonthsSummary));

            builder.OwnsOne(x => x.Spacing);
        }
    }
}
