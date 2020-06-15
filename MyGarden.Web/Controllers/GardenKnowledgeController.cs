using System.Collections.Generic;
using MyGarden.Domain.GardenKnowledge.Plants;
using MyGarden.Domain;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Garden.Contract.Commands.GardenKnowledge;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace MyGarden.Web.Controllers
{
    [Route("[controller]")]
    public class GardenKnowledgeController
    {
        private readonly IPlantKnowledgeRepository _plantKnowledgeRepository;
        private readonly IMediator _mediator;

        public GardenKnowledgeController(IPlantKnowledgeRepository plantKnowledgeRepository, IMediator mediator)
        {
            _plantKnowledgeRepository = plantKnowledgeRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public IEnumerable<PlantCharacteristics> GetAllPlants()
        {
            return _plantKnowledgeRepository.GetAllPlants();
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddPlantCharacteristics([FromBody]AddPlantCharacteristicsCommand command)
        {
            var commandResult = await _mediator.Send(command);
            return commandResult > 0 ? (IActionResult)new OkObjectResult(commandResult) : new BadRequestResult();
        }
    }
}

