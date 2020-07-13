using System;

namespace Garden.Domain.GardenKnowledge.Plants
{
    public class PlantName
    {
        public Guid PlantCharacteristicsId { get; set; }
        public string Name { get; set; }

        public PlantName(string name)
        {
            Name = name;
        }
    }
}
