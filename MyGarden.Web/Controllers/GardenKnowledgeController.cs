using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Garden.Contract.Commands.GardenKnowledge;
using MediatR;
using Microsoft.AspNetCore.Http;
using Garden.Contract.Dtos;
using Garden.Contract.Queries.GardenKnowledge;

namespace MyGarden.Web.Controllers
{
    [Route("[controller]/[action]")]
    public class GardenKnowledgeController
    {
        private readonly IMediator _mediator;

        public GardenKnowledgeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IList<PlantCharacteristicsDto>> GetPlants(PlantsCharacteristicsQuery query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task AddPlantCharacteristics([FromBody]AddPlantCharacteristicsCommand command)
        {
            await _mediator.Send(command);
        }
    }
}

