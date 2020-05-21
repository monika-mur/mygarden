using System.Collections.Generic;

namespace MyGarden.Domain
{
    public class PlantSpacing : ValueObject
    {
        public int Minimal { get; set; }
        public int Maximal { get; set; }
        public Measure Measure { get; set; }

        public PlantSpacing(int minimal, int maximal, Measure measure)
        {
            Minimal = minimal;
            Maximal = maximal;
            Measure = measure;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Minimal;
            yield return Maximal;
            yield return Measure;
        }
    }

    public enum Measure
    {
        Centimeter = 1
    }
}