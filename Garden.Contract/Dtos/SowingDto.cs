namespace Garden.Contract.Dtos
{
    public class SowingDto
    {
        public GardeningDateDto SowingDate { get; set; }
        public PlantSpacingDto Spacing { get; set; }
        public int Depth { get; set; }
    }
}
