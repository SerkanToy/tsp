using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
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
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = GenericClaim(user: user),
                Expires = DateTime.UtcNow.AddMinutes(15),
                SigningCredentials = credentials
            };
            var token = handler.CreateToken(tokenDescriptor);

            return handler.WriteToken(token);
        }

        private static ClaimsIdentity GenericClaim(User user)
        {
            var claims = new ClaimsIdentity();
            claims.AddClaim(new Claim(ClaimTypes.Name, user.Email));
            foreach (var item in user.Roles)
            {
                claims.AddClaim(new Claim(ClaimTypes.Role, item.Name));
            }
            return claims;
        }
    }
}
