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
            
            builder.OwnsOne(x => x.Sowing).OwnsOne(x => x.Spacing);
            builder.OwnsOne(x => x.FloweringTime);

            builder.HasMany(x => x.GardenActions);
        }
    }
}
