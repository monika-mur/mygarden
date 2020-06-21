using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MyGarden.Domain;
using MyGarden.GardenKnowledge.Domain;

namespace MyGarden.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlantsController
    {
        [HttpGet]
        public IEnumerable<PlantCharacteristics> GetAvailablePlants()
        {
            return new List<PlantCharacteristics>
            {
                //new PlantCharacteristics(
                //    "Chaber bławatek",
                //    "Centaurea cyanus",
                //    new GardeningDate(new [] {Month.March, Month.April}),
                //    new PlantSpacing(20, 30, Measure.Centimeter),
                //    new GardeningDate(new Duration(10, TimeUnit.Week))
                //),
                //new PlantCharacteristics(
                //    "Czarnuszka damasceńska",
                //    "Nigella damascena",
                //    new GardeningDate(new [] {Season.EarlySpring, Season.Autumn}),
                //    null,
                //    null
                //),
                //new PlantCharacteristics(
                //    "Dynia ozdobna",
                //    "Cucurbita pepo",
                //    null,
                //    null,
                //    null
                //)
            };
        }
    }
}
