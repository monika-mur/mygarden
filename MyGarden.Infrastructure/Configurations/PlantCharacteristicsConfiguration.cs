using Garden.Domain.GardenKnowledge.Plants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGarden.Domain;

namespace MyGarden.Infrastructure.Configurations
{
    public class PlantCharacteristicsConfiguration : IEntityTypeConfiguration<PlantCharacteristics>
    {
        public void Configure(EntityTypeBuilder<PlantCharacteristics> builder)
        {
            builder.ToTable("PlantCharacteristics");

            builder.HasOne(x => x.Sowing).WithOne().HasForeignKey<Sowing>(x => x.PlantChracteristicsId);

            builder.OwnsOne(x => x.FloweringTime);

            builder.HasMany(x => x.GardenActions);
        }
    }
}
