using YuChingECommerce.Services.ShoppingCartAPI.Models.Dto;

namespace YuChingECommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface ICouponService
    {
        Task<CouponDto> GetCoupon(string couponCode);
    }
}
