using AutoMapper;
using Excercise1_API.Modelos;
using Excercise1_API.Modelos.Dto;

namespace Excercise1_API
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<CatalogItem, CatalogItemDto>();
            CreateMap<CatalogItemDto, CatalogItem>();

            CreateMap<CatalogItem, CatalogItemCreateDto>().ReverseMap();
            CreateMap<CatalogItem, CatalogItemUpdateDto>().ReverseMap();

        }
    }
}
