using CommandBase;
using Garden.Contract.Dtos;
using System.Collections.Generic;

namespace Garden.Contract.Queries.GardenKnowledge
{
    public class PlantsCharacteristicsQuery : IQuery<IList<PlantCharacteristicsDto>>
    {
        public string Name { get; set; }
    }
}
