using System;
using System.Collections.Generic;

namespace MyGarden.Domain.Garden
{
    public class Plant : Entity<int>
    {
        public PlantCharacteristics PlantCharacteristicsId { get; set; }
        public DateTime PlantingDate { get; set; }
        public IEnumerable<CompletedAction> CompletedActions { get; set; } 
    }
}
