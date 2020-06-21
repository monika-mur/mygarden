using Garden.Domain.GardenKnowledge.Plants;
using MyGarden.GardenKnowledge.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyGarden.Domain
{
    public class PlantCharacteristics : Entity<Guid>
    {
        public IEnumerable<string> Names { get; protected set; }
        public string LatinName { get; protected set; }
        public IEnumerable<GardenAction> GardenActions { get; protected set; }
        public Sowing Sowing { get; protected set; }
        public GardeningDate FloweringTime { get; protected set; }
        public string Name => Names.FirstOrDefault();

        protected PlantCharacteristics() { }

        public PlantCharacteristics(
            IEnumerable<string> names,
            string latinName,
            Sowing sowing,
            GardeningDate floweringTime)
        {
            Names = names;
            LatinName = latinName;
            Sowing = sowing;
            FloweringTime = floweringTime;
        }
    }
}
