using Microsoft.AspNetCore.Mvc;
using MyGarden.Domain.Garden;
using System.Collections.Generic;

namespace MyGarden.Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GardenController
    {
        private readonly IGardenRepository _gardenRepository;

        public GardenController(IGardenRepository gardenRepository)
        {
            _gardenRepository = gardenRepository;
        }

        [HttpGet]
        public IEnumerable<Plant> GetAllPlantsForGardener()
        {
            const int gardenerId = 1;

            return _gardenRepository.GetPlantsForGardener(gardenerId);
        }
    }
}
