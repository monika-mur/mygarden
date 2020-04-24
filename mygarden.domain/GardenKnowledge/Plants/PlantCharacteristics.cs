using MyGarden.GardenKnowledge.Domain;
using System;

namespace MyGarden.Domain
{
    public class PlantCharacteristics : Entity<Guid>
    {
        public string Name { get;}
        public Language LanguageId { get; }
        public string LatinName { get; }
        public GardeningDate SowingDate { get; }
        public PlantSpacing Spacing { get; }
        public GardeningDate FloweringTime { get; }

        public PlantCharacteristics(string name, Language languageId, string latinName, GardeningDate sowingDate, PlantSpacing spacing, GardeningDate floweringTime)
        {
            Name = name;
            LanguageId = languageId;
            LatinName = latinName;
            SowingDate = sowingDate;
            Spacing = spacing;
            FloweringTime = floweringTime;
        }
    }
}
