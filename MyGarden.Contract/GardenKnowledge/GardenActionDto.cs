using MyGarden.GardenKnowledge.Domain;

namespace Garden.Contract.Commands.GardenKnowledge
{
    public class GardenActionDto
    {
        public GardeningDateDto Time { get; set; }
        public string Description { get; set; }
        public ActionType ActionType { get; set; }
    }
}
