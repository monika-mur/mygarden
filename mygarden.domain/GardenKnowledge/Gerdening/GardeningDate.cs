using MyGarden.Domain;
using System.Collections.Generic;

namespace MyGarden.GardenKnowledge.Domain
{
    public class GardeningDate : ValueObject
    {
        protected GardeningDate() { }

        public IEnumerable<Month> Months { get; }

        public IEnumerable<Season> Seasons { get; }

        public Duration Duration { get; }

        public GardeningDate(IEnumerable<Month> months)
        {
            Months = months;
        }

        public GardeningDate(IEnumerable<Season> seasons)
        {
            Seasons = seasons;
        }

        public GardeningDate(Duration duration)
        {
            Duration = duration;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Months;
            yield return Seasons;
            yield return Duration;
        }
    }

    public class Duration : ValueObject
    {
        public int Quantity { get; }
        public TimeUnit TimeUnit { get; }

        public Duration(int quantity, TimeUnit timeUnit)
        {
            Quantity = quantity;
            TimeUnit = timeUnit;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Quantity;
            yield return TimeUnit;
        }
    }

    public enum Month
    {
        January = 1,
        February,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        October,
        November,
        December
    }

    public enum Season
    {
        EarlySpring = 1,
        Spring,
        Summer,
        Autumn
    }

    public enum TimeUnit
    {
        Week = 1
    }
}