using JwtRsaHmacSample.Api.Models;
using Microsoft.IdentityModel.Tokens;

namespace JwtRsaHmacSample.Api.Services
{
    public interface IJwtHandler
    {
        JWT Create(string userId);
        TokenValidationParameters Parameters { get;}    
    }
}