using Garden.Domain.GardenKnowledge.Plants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Garden.Infrastructure.Configurations
{
    public class NameConfiguration : IEntityTypeConfiguration<PlantName>
    {
        public void Configure(EntityTypeBuilder<PlantName> builder)
        {
            builder.ToTable("PlantNames");
            builder.HasKey(x => x.PlantCharacteristicsId);
        }
    }
}
