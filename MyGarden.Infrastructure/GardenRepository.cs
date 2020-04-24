using MyGarden.Domain.Garden;
using MyGarden.Identifiers;
using System.Collections.Generic;

namespace MyGarden.Infrastructure
{
    public class GardenRepository : IGardenRepository
    {
        public IEnumerable<Plant> GetPlantsForGardener(UserId gardenerId)
        {
            throw new System.NotImplementedException();
        }
    }
}
