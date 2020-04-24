using MyGarden.Identifiers;
using System;
using System.Collections.Generic;

namespace MyGarden.Domain.Garden
{
    public class Garden : Entity<Guid>
    {
        public UserId UserId { get; set; }
        public ISet<Plant> Plants {get; set;}

        public void AddPlant(Plant plant)
        {
            Plants.Add(plant);
        }
    }
}
