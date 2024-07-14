using UserIdentityAuthWebAppTemplate.Models;

namespace UserIdentityAuthWebAppTemplate.Services.Interfaces
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
