using System;
using System.Collections.Generic;

namespace MyGarden.Domain.Garden
{
    public class Plant : Entity<int>
    {
        public PlantCharacteristics Characteristics { get; set; }
        DateTime PlantingDate { get; set; }
        IEnumerable<CompletedAction> CompletedActions { get; set; } 
    }
}
