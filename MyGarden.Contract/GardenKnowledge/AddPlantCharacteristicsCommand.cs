using CommandBase;
using System.Collections.Generic;

namespace Garden.Contract.Commands.GardenKnowledge
{
    public class AddPlantCharacteristicsCommand : ICommand<int>
    {
        public ICollection<string> Names { get; set; }
        public string LatinName { get; set; }
        public IEnumerable<GardenActionDto> GardenActions { get; set; }
        public SowingDto Sowing { get; set; }
        public GardeningDateDto FloweringTime { get; set; }
    }
}
