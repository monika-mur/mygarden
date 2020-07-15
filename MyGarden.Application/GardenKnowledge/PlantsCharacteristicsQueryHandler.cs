using Garden.Contract.Queries.GardenKnowledge;
using CommandBase;
using Garden.Contract.Dtos;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using MyGarden.Domain.GardenKnowledge.Plants;
using AutoMapper;

namespace Garden.Application.Queries.GardenKnowledge
{
    public class PlantsCharacteristicsQueryHandler : IQueryHandler<PlantsCharacteristicsQuery, IList<PlantCharacteristicsDto>>
    {
        private readonly IPlantKnowledgeRepository _repository;
        private readonly IMapper _mapper;

        public PlantsCharacteristicsQueryHandler(IPlantKnowledgeRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IList<PlantCharacteristicsDto>> Handle(PlantsCharacteristicsQuery query, CancellationToken cancellationToken)
        {
            var plants = _repository.GetPlants();
            return _mapper.Map<IList<PlantCharacteristicsDto>>(plants);
        }
    }
}
