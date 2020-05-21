using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyGarden.Identifiers;

namespace MyGarden.Infrastructure
{
    public static class Converters
    {
        public static ValueConverter<UserId, int> UserIdConverter 
           => new ValueConverter<UserId, int>(
               v => v.Id,
                v => new UserId(v));
    }
}
