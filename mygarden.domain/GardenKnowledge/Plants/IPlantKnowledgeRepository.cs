using System.Collections.Generic;

namespace MyGarden.Domain.GardenKnowledge.Plants
{
    public interface IPlantKnowledgeRepository
    {
        IList<PlantCharacteristics> GetPlants();
    }
}
