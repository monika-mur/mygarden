using Microsoft.AspNetCore.Mvc;
using MyGarden.Domain;
using MyGarden.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGarden.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GardenController
    {
        private readonly IGardenRepository _gardenRepository;

        public GardenController(IGardenRepository gardenService)
        {
            _gardenRepository = gardenService;
        }

        [HttpGet]
        public IEnumerable<Plant> GetAllPlants()
        {
            const int gardenerId = 1;

            return _gardenRepository.GetPlantsForGardener(gardenerId);
        }
    }
}
