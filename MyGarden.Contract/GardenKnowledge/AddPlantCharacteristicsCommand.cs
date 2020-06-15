using CommandBase;
using System.Collections.Generic;

namespace Garden.Contract.Commands.GardenKnowledge
{
    public class AddPlantCharacteristicsCommand : ICommand<int>
    {
        public string Name { get; set; }
        public string LatinName { get; set; }
        public IEnumerable<GardenActionDto> GardenActions { get; set; }
        public GardeningDateDto SowingDate { get; set; }
        public PlantSpacingDto Spacing { get; set; }
        public GardeningDateDto FloweringTime { get; set; }
    }
}
