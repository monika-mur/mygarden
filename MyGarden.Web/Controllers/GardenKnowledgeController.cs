using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyGarden.Domain.GardenKnowledge.Plants;
using MyGarden.Domain;

namespace MyGarden.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GardenKnowledgeController
    {
        private readonly IPlantKnowledgeRepository _plantKnowledgeRepository;

        public PlantKnowledgeController(IPlantKnowledgeRepository plantKnowledgeRepository)
        {
            _plantKnowledgeRepository = plantKnowledgeRepository;
        }

        [HttpGet]
        public IEnumerable<PlantCharacteristics> GetAllPlants()
        {
            return _plantKnowledgeRepository.GetAllPlants();
        }
    }
}

