using MyGarden.Domain;
using System;
using System.Collections;
using System.Collections.Generic;

namespace MyGarden.GardenKnowledge.Domain
{
    public class GardeningDate : ValueObject
    {
        protected GardeningDate() { }

        public IList<Month> Months { get; }

        public IList<Season> Seasons { get; }

        public double MonthsSummary
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

        private void SetMonths(double monthsSummary)
        {
            var monthsSummaryBits = new BitArray(BitConverter.GetBytes(monthsSummary));
            for (int i = monthsSummaryBits.Length - 1; i >= monthsSummaryBits.Length - 13; i--)
            {
                if (monthsSummaryBits[i])
                    Months.Add((Month)(monthsSummaryBits.Length-i));
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