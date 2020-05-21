using System.Collections.Generic;
using MyGarden.Domain;

namespace MyGarden.GardenKnowledge.Domain
{
    public class GardenAction : ValueObject
    {
        public GardeningDate Time { get; set; }
        public string Description {get; set;}
        public ActionType ActionType { get; set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Time;
            yield return Description;
            yield return ActionType;
        }
    }
}
