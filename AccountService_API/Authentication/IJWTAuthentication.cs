using AccountService_API.DTOs;
using System.Security.Claims;

namespace AccountService_API.Authentication
{
    public interface IJWTAuthentication
    {
        string GenerateToken(ApplicationUserDto model);
        string GenerateRefreshToken();
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
