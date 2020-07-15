using System.Collections.Generic;
using System.Linq;
using MyGarden.Domain;
using MyGarden.Domain.GardenKnowledge.Plants;
using MyGarden.Infrastructure;

namespace Garden.Infrastructure
{
    public class PlantKnowledgeRepository : IPlantKnowledgeRepository
    {
        private readonly GardenDbContext _dbContext;

        public PlantKnowledgeRepository(GardenDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IList<PlantCharacteristics> GetPlants()
        {
            return _dbContext.Plants.ToList();
        }
    }
}
