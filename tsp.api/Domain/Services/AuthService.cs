using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;
using tsp.api.Domain.Core.Entities.Users;

namespace tsp.api.Domain.Services
{
    public class AuthService
    {
        public string GenerateToken(User user)
        {
            var handler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("1");
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(key),
                SecurityAlgorithms.HmacSha256Signature);
            var tokenDescriptor = new Securi
            return "";
        }
    }
}
