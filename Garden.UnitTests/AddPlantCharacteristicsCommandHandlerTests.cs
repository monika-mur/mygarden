using AutoMapper;
using Garden.Application.Commands.GardenKnowledge;
using Garden.Contract.Commands.GardenKnowledge;
using Garden.Gateway;
using MyGarden.GardenKnowledge.Domain;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Garden.UnitTests
{
    public class AddPlantCharacteristicsCommandHandlerTests
    {
        [Fact]
        public async Task PlantIsSuccessfullySaved()
        {
            var command = new AddPlantCharacteristicsCommand
            {
                Names = new List<string> { "Marchew", "Marchewka" },
                LatinName = "Daucus carota",
                GardenActions = new List<GardenActionDto>
                {
                    new GardenActionDto
                    {
                        ActionType = ActionType.Planting,
                        Time = new GardeningDateDto
                        {
                            Seasons = new List<Season> { Season.Spring },
                            Months = new List<Month> { Month.November, Month.December },
                            Duration = new DurationDto { TimeUnit = TimeUnit.Week, Quantity = 2 }
                        },
                        Description = "This is just test for carrot"
                    },
                },
                FloweringTime = new GardeningDateDto { Seasons = new List<Season> { Season.Summer } },
                Sowing = new SowingDto
                {
                    Depth = 20,
                    Spacing = new PlantSpacingDto { Minimal = 5, Maximal = 10, Measure = MyGarden.Domain.Measure.Centimeter },
                    SowingDate = new GardeningDateDto { Seasons = new List<Season> { Season.Spring } }
                },
            };

            var configuration = new MapperConfiguration(cfg => cfg.AddProfile(new GardenMappingProfile()));

            using var dbContext = InMemoryTestsHelper.DbContext();

            var handler = new AddPlantCharacteristicsCommandHandler(new Mapper(configuration), dbContext);

            await handler.Handle(command, default);

            var result = dbContext.Plants;

            Assert.Equal(1, result.Count());
        }
    }
}