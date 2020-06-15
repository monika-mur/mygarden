using System.Threading;
using System.Threading.Tasks;
using CommandBase;
using Garden.Contract.Commands.GardenKnowledge;
using MediatR;
using MyGarden.Domain;
using AutoMapper;
using MyGarden.GardenKnowledge.Domain;
using Microsoft.EntityFrameworkCore;

namespace Garden.Application.Commands.GardenKnowledge
{
    public class AddPlantCharacteristicsCommandHandler : ICommandHandler<AddPlantCharacteristicsCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly DbContext _dbContext;

        public AddPlantCharacteristicsCommandHandler(IMapper mapper, DbContext dbContext)
        {
            _mapper = mapper;
            _dbContext = dbContext;
        }

        public async Task<int> Handle(AddPlantCharacteristicsCommand command, CancellationToken cancellationToken)
        {
            var sowingDate = _mapper.Map<GardeningDate>(command.SowingDate);
            var spacing = _mapper.Map<PlantSpacing>(command.Spacing);
            var floweringTime = _mapper.Map<GardeningDate>(command.FloweringTime);
            var plantCharacteristics = new PlantCharacteristics(command.Name, command.LatinName, sowingDate, spacing, floweringTime);

            _dbContext.Add(plantCharacteristics);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
