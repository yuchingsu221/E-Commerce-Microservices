using Microsoft.AspNetCore.Identity;

namespace YuChingECommerce.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
