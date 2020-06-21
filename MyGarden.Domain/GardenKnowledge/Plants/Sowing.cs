using MyGarden.Domain;
using MyGarden.GardenKnowledge.Domain;

namespace Garden.Domain.GardenKnowledge.Plants
{
    public class Sowing
    {
        public GardeningDate SowingDate { get; protected set; }
        public PlantSpacing Spacing { get; protected set; }
        public int Depth { get; protected set; }
    }
}
