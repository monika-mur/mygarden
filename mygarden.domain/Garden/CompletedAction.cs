using MyGarden.GardenKnowledge.Domain;
using System;

namespace MyGarden.Domain.Garden
{
    public class CompletedAction
    {
        protected CompletedAction() { }

        public GardenAction Action { get; set; }
        public DateTime ActionDate { get; set; }
    }
}
