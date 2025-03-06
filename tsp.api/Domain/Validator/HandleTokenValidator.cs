using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using tsp.api.Domain.Core.Entities.Users;
using tsp.api.Domain.Models;

namespace tsp.api.Domain.Validator
{
    public static class HandleTokenValidator
    {
        public static async Task<TokenModel> HandleToken(IList<string> roles, User user)
        {           
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            byte[] key = Encoding.ASCII.GetBytes("Yes_No");
            DateTime expiration = DateTime.Now.AddDays(7);
            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(ClaimTypes.Email, user.Email.ToString()),
                    new Claim(ClaimTypes.Name, user.Email.ToString()),
                    new Claim("FullName", $"{user.Name} {user.SurName}")
                }),
                Expires = expiration,
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),SecurityAlgorithms.HmacSha256Signature)
            };

            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            TokenModel tokenModel = new TokenModel { 
                AccessToken = tokenHandler.WriteToken(token),
                Expiration = expiration
            };
            return tokenModel;
        }
    }
}
