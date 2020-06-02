using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyGarden.Domain.Garden;

namespace MyGarden.Infrastructure.Configurations
{
    public class GardenConfiguration : IEntityTypeConfiguration<Garden>
    {
        public void Configure(EntityTypeBuilder<Garden> builder)
        {
            builder.ToTable("Garden");
            builder.Property(t => t.UserId)
                .HasColumnName("UserId")
                .HasConversion(Converters.UserIdConverter);
            builder.OwnsMany(t => t.Plants, s =>
            {
                s.OwnsMany(t => t.CompletedActions)
                    .HasOne(t => t.Action);
            });
        }
    }
}
