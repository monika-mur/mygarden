using System;
using MyGarden.Domain;

namespace MyGarden.GardenKnowledge.Domain
{
    public class GardenAction : Entity<Guid>
    {
        public GardeningDate Time { get; set; }
        public string Description {get; set;}
        public ActionType ActionType { get; set; }
    }
}
