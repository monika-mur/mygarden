using System.Collections.Generic;
using MyGarden.Domain;
using MyGarden.Domain.GardenKnowledge.Plants;

namespace Garden.Infrastructure
{
    public class PlantKnowledgeRepository : IPlantKnowledgeRepository
    {
        public IEnumerable<PlantCharacteristics> GetAllPlants()
        {
            throw new System.NotImplementedException();
        }
    }
}
