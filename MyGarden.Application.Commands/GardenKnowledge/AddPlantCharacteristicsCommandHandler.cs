using System.Threading;
using System.Threading.Tasks;
using CommandBase;
using Garden.Contract.Commands.GardenKnowledge;
using MediatR;
using MyGarden.Domain;
using AutoMapper;

namespace Garden.Application.Commands.GardenKnowledge
{
    public class AddPlantCharacteristicsCommandHandler : ICommandHandler<AddPlantCharacteristicsCommand>
    {
        private readonly IMapper _mapper;

        public AddPlantCharacteristicsCommandHandler(IMapper mapper)
        {
            _mapper = mapper;
        }

        public Task<Unit> Handle(AddPlantCharacteristicsCommand command, CancellationToken cancellationToken)
        {
            // var sowingDate = _mapper.Map();
            //var plantCharacteristics = new PlantCharacteristics(command.Name, command.LatinName, ...)
            throw new System.NotImplementedException();
        }
    }
}
