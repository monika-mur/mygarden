using MyGarden.Domain;
using MyGarden.GardenKnowledge.Domain;
using System;

namespace Garden.Domain.GardenKnowledge.Plants
{
    public class Sowing
    {
        public Guid PlantCharacteristicsId { get; protected set; }
        public GardeningDate SowingDate { get; protected set; }
        public PlantSpacing Spacing { get; protected set; }
        public int Depth { get; protected set; }
    }
}
