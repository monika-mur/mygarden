using Garden.Contract.Commands.GardenKnowledge;
using MyGarden.GardenKnowledge.Domain;

namespace Garden.Contract.Dtos
{
    public class GardenActionDto
    {
        public GardeningDateDto Time { get; set; }
        public string Description { get; set; }
        public ActionType ActionType { get; set; }
    }
}
