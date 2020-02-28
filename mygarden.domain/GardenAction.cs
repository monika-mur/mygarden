namespace MyGarden.Domain
{
    public class GardenAction
    {
        public GardeningDate Time { get; set; }
        public string Description {get; set;}
        public ActionType ActionType { get; set; }
    }
}
