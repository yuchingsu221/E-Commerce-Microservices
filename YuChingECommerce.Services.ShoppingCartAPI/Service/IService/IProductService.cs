using YuChingECommerce.Services.ShoppingCartAPI.Models.Dto;

namespace YuChingECommerce.Services.ShoppingCartAPI.Service.IService
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetProducts();
    }
}
