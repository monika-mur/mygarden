using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyGarden.Domain;

namespace mygarden.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GardenController : ControllerBase
    {
        private readonly ILogger<GardenController> _logger;

        public GardenController(ILogger<GardenController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Plant> GetAvailablePlants()
        {
            return new List<Plant>
            {
                new Plant(
                    "Chaber bławatek",
                    Language.Polish,
                    "Centaurea cyanus",
                    new GardeningDate(new [] {Month.March, Month.April}),
                    new PlantSpacing(20, 30, Measure.Centimeter),
                    new GardeningDate(new Duration(10, TimeUnit.Week))
                ),
                new Plant(
                    "Czarnuszka damasceńska",
                    Language.Polish,
                    "Nigella damascena",
                    new GardeningDate(new [] {Season.EarlySpring, Season.Autumn}),
                    null,
                    null
                ),
                new Plant(
                    "Dynia ozdobna",
                    Language.Polish,
                    "Cucurbita pepo",
                    null,
                    null,
                    null
                )
            };
        }
    }
}
