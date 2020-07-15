using CommandBase;
using Garden.Contract.Dtos;
using System.Collections.Generic;

namespace Garden.Contract.Commands.GardenKnowledge
{
    public class AddPlantCharacteristicsCommand : ICommand<int>
    {
        public IList<string> Names { get; set; }
        public string LatinName { get; set; }
        public IList<GardenActionDto> GardenActions { get; set; }
        public SowingDto Sowing { get; set; }
        public GardeningDateDto FloweringTime { get; set; }
    }
}
