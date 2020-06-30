using MyGarden.Domain;

namespace Garden.Contract.Commands.GardenKnowledge
{
    public class PlantSpacingDto
    {
        public int Minimal { get; set; }
        public int Maximal { get; set; }
        public Measure Measure { get; set; }
    }
}
