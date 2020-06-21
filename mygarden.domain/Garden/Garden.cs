using MyGarden.Identifiers;
using System;
using System.Collections.Generic;

namespace MyGarden.Domain.Garden
{
    public class GardenModel : Entity<Guid>
    {
        public UserId UserId { get; protected set; }
        public ISet<Plant> Plants {get; protected set;}

        public void AddPlant(Plant plant)
        {
            Plants.Add(plant);
        }
    }
}
