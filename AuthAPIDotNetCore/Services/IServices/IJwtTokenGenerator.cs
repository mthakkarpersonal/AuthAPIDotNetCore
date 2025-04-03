using AuthAPIDotNetCore.Models;

namespace AuthAPIDotNetCore.Services.IServices
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
