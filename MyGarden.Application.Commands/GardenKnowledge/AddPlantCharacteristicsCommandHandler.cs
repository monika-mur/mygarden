using System.Threading;
using System.Threading.Tasks;
using CommandBase;
using Garden.Contract.Commands.GardenKnowledge;
using MyGarden.Domain;
using AutoMapper;
using MyGarden.GardenKnowledge.Domain;
using Garden.Domain.GardenKnowledge.Plants;
using MyGarden.Infrastructure;

namespace Garden.Application.Commands.GardenKnowledge
{
    public class AddPlantCharacteristicsCommandHandler : ICommandHandler<AddPlantCharacteristicsCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly GardenDbContext _dbContext;

        public AddPlantCharacteristicsCommandHandler(IMapper mapper, GardenDbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<int> Handle(AddPlantCharacteristicsCommand command, CancellationToken cancellationToken)
        {
            var sowing = _mapper.Map<Sowing>(command.Sowing);
            var floweringTime = _mapper.Map<GardeningDate>(command.FloweringTime);
            var plantCharacteristics = new PlantCharacteristics(command.Names, command.LatinName, sowing, floweringTime);

            _dbContext.Add(plantCharacteristics);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
