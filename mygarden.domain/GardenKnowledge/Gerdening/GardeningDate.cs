using MyGarden.Domain;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace MyGarden.GardenKnowledge.Domain
{
    public class GardeningDate : ValueObject
    {
        protected GardeningDate() {
            Months = new List<Month>();
        }

        public IList<Month> Months { get; }

        public IList<Season> Seasons { get; }

        public int MonthsSummary
        {
            get => GetMonthsSummary(Months);
            set => SetMonths(value);
        }

        private int GetMonthsSummary(IEnumerable<Month> months)
        {
            var result = 0.0;
            foreach (var month in months)
                result += Math.Pow(2, (double)(month - 1));
            return (int)result;
        }

        private void SetMonths(int monthsSummary)
        {
            var months = Convert.ToString(monthsSummary, 2);
            for (int i = months.Length - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(Char.GetNumericValue(months[i])))
                    Months.Add((Month)(months.Length - i));
            }
        }

        public Duration Duration { get; }

        public GardeningDate(IList<Month> months)
        {
            Months = months;
        }

        public GardeningDate(IList<Season> seasons)
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
        Day = 1,
        Week = 2,
        Month
    }
}