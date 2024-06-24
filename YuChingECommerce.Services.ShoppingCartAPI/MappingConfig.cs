﻿using AutoMapper;
using YuChingECommerce.Services.ShoppingCartAPI.Models.Dto;
using YuChingECommerce.Services.ShoppingCartAPI.Models;

namespace YuChingECommerce.Services.ShoppingCartAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CartHeader, CartHeaderDto>().ReverseMap();
                config.CreateMap<CartDetails, CartDetailsDto>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
