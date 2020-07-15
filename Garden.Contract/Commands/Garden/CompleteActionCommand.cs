using CommandBase;
using MyGarden.Identifiers;
using System;

namespace MyGarden.Contract.Commands
{
    public class CompleteActionCommand : ICommand<int>
    {
        public UserId UserId { get; set; }

        public Guid GardenActionId { get; set; }

        public int PlantId { get; set; }
    }
}
