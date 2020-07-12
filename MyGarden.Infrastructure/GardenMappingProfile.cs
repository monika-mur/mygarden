using AutoMapper;
using Garden.Domain.GardenKnowledge.Plants;
using Garden.Contract.Commands.GardenKnowledge;
using MyGarden.GardenKnowledge.Domain;
using MyGarden.Domain;

namespace Garden.Gateway
{
    public class GardenMappingProfile : Profile
    {
        public GardenMappingProfile()
        {
            CreateMap<GardeningDateDto, GardeningDate>();
            CreateMap<PlantSpacingDto, PlantSpacing>();
            CreateMap<SowingDto, Sowing>();
        }
    }
}
