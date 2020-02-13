namespace MyGarden.Domain
{
    public class Plant : Entity
    {
        public string Name { get;}
        public Language LanguageId { get; }
        public string LatinName { get; }
        public GardeningDate SowingDate { get; }
        public PlantSpacing Spacing { get; }
        public GardeningDate FloweringTime { get; }

        public Plant(string name, Language languageId, string latinName, GardeningDate sowingDate, PlantSpacing spacing, GardeningDate floweringTime)
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
