using MyGarden.Identifiers;
using System;

namespace MyGarden.Web.Models
{
    public class CompleteActionRequest
    {
        public UserId UserId { get; set; }

        public Guid GardenActionId { get; set; }

        public int PlantId { get; set; }

    }
}
