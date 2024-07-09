using AutoMapper;
using YuChingECommerce.Services.ProductAPI.Models;
using YuChingECommerce.Services.ProductAPI.Models.Dto;

namespace YuChingECommerce.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
