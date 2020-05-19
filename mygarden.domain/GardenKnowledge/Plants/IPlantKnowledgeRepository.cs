using System.Collections.Generic;

namespace MyGarden.Domain.GardenKnowledge.Plants
{
    public interface IPlantKnowledgeRepository
    {
        IEnumerable<PlantCharacteristics> GetAllPlants();
    }
}
