using AutoMapper;
using YuChingECommerce.Services.CouponAPI.Models;
using YuChingECommerce.Services.CouponAPI.Models.Dto;

namespace YuChingECommerce.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
