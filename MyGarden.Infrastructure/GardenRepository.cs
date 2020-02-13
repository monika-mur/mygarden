using MyGarden.Domain;
using System.Collections.Generic;

namespace MyGarden.Infrastructure
{
    public interface IGardenRepository
    {
        IEnumerable<Plant> GetPlantsForGardener(int gardenerId);
    }

    public class GardenRepository : IGardenRepository
    {
        public IEnumerable<Plant> GetPlantsForGardener(int gardenerId)
        {
            throw new System.NotImplementedException();
        }
    }
}
