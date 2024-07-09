using YuChingECommerce.Services.EmailAPI.Message;
using YuChingECommerce.Services.EmailAPI.Models.Dto;

namespace YuChingECommerce.Services.EmailAPI.Services
{
    public interface IEmailService
    {
        Task EmailCartAndLog(CartDto cartDto);
        Task RegisterUserEmailAndLog(string email);
        Task LogOrderPlaced(RewardsMessage rewardsDto);
    }
}
