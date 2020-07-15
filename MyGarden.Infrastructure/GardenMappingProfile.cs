using AutoMapper;
using Garden.Domain.GardenKnowledge.Plants;
using Garden.Contract.Dtos;
using MyGarden.GardenKnowledge.Domain;
using MyGarden.Domain;

namespace Garden.Gateway
{
    public class GardenMappingProfile : Profile
    {
        public GardenMappingProfile()
        {
            CreateMap<PlantCharacteristics, PlantCharacteristicsDto>();
            CreateMap<GardeningDate, GardeningDateDto>();
            CreateMap<PlantSpacing, PlantSpacingDto>();
            CreateMap<Sowing, SowingDto>();
            CreateMap<GardeningDateDto, GardeningDate>();
            CreateMap<PlantSpacingDto, PlantSpacing>();
            CreateMap<SowingDto, Sowing>();
        }
    }
}
