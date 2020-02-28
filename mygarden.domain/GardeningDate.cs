using System.Collections.Generic;

namespace MyGarden.Domain
{
    public class GardeningDate : ValueObject
    {
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
    }

    public class Duration : ValueObject
    {
        public int Quantity { get; set; }
        public TimeUnit TimeUnit { get; set; }

        public Duration(int quantity, TimeUnit timeUnit)
        {
            Quantity = quantity;
            TimeUnit = timeUnit;
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