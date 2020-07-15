using Garden.Contract.Commands.GardenKnowledge;
using System.Collections.Generic;

namespace Garden.Contract.Dtos
{
    public class PlantCharacteristicsDto
    {
        public IList<string> Names { get; set; }
        public string LatinName { get; set; }
        public IList<GardenActionDto> GardenActions { get; set; }
        public SowingDto Sowing { get; set; }
        public GardeningDateDto FloweringTime { get; set; }
    }
}
