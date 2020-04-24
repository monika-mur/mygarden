using MyGarden.Identifiers;
using System.Collections.Generic;

namespace MyGarden.Domain.Garden
{
    public interface IGardenRepository
    {
        IEnumerable<Plant> GetPlantsForGardener(UserId gardenerId);
    }
}
