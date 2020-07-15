using MyGarden.GardenKnowledge.Domain;
using System.Collections.Generic;
using Xunit;

namespace Garden.Tests
{
    public class GardeningDateTests
    {
        [Theory]
        [InlineData(new Month[] { Month.May }, 16)]
        [InlineData(new Month[] { Month.January, Month.February}, 3)]
        [InlineData(new Month[] { Month.February, Month.June, Month.July, Month.December }, 2146)]
        [InlineData(new Month[] { }, 0)]
        public void GetMonthsSummaryTests(IList<Month> months, int monthsSummary)
        {
            var gardeningDate = new GardeningDate(months);
            Assert.Equal(monthsSummary, gardeningDate.MonthsSummary);
        }

        [Theory]
        [InlineData(new Month[] { Month.January }, 1)]
        [InlineData(new Month[] { Month.May }, 16)]
        [InlineData(new Month[] { Month.January, Month.February }, 3)]
        [InlineData(new Month[] { Month.February, Month.June, Month.July, Month.December }, 2146)]
        [InlineData(new Month[] { }, 0)]
        public void SetMonthsSummaryTests(Month[] months, int monthsSummary)
        {
            var gardeningDate = new GardeningDate(new List<Month>())
            {
                MonthsSummary = monthsSummary
            };

            Assert.Equal(months, gardeningDate.Months);
        }
    }
}
