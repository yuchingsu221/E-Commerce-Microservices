using YuChingECommerce.Services.AuthAPI.Models;

namespace YuChingECommerce.Services.AuthAPI.Service.IService
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
