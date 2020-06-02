using MyGarden.GardenKnowledge.Domain;
using System;
using System.Collections.Generic;

namespace MyGarden.Domain
{
    public class PlantCharacteristics : Entity<Guid>
    {
        public string Name { get; protected set; }
        public string LatinName { get; protected set; }
        public IEnumerable<GardenAction> GardenActions { get; protected set; }
        public GardeningDate SowingDate { get; protected set; }
        public PlantSpacing Spacing { get; protected set; }
        public GardeningDate FloweringTime { get; protected set; }

        protected PlantCharacteristics() { }

        public PlantCharacteristics(
            string name,
            string latinName,
            GardeningDate sowingDate,
            PlantSpacing spacing,
            GardeningDate floweringTime)
        {
            Name = name;
            LatinName = latinName;
            SowingDate = sowingDate;
            Spacing = spacing;
            FloweringTime = floweringTime;
        }
    }
}
