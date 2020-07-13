using Garden.Domain.GardenKnowledge.Plants;
using MyGarden.GardenKnowledge.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyGarden.Domain
{
    public class PlantCharacteristics : Entity<Guid>
    {
        public ICollection<PlantName> Names { get; protected set; }
        public string LatinName { get; protected set; }
        public IEnumerable<GardenAction> GardenActions { get; protected set; }
        public Sowing Sowing { get; protected set; }
        public GardeningDate FloweringTime { get; protected set; }
        public string Name => Names.FirstOrDefault().ToString();

        protected PlantCharacteristics() { }

        public PlantCharacteristics(
            ICollection<string> names,
            string latinName,
            Sowing sowing,
            GardeningDate floweringTime)
        {
            Names = names.Select(name => new PlantName(name)).ToList();
            LatinName = latinName;
            Sowing = sowing;
            FloweringTime = floweringTime;
        }
    }
}
