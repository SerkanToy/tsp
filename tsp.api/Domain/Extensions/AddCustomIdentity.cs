using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using tsp.api.Domain.Core.Entities.Users;
using tsp.api.Domain.Database.Context;

namespace tsp.api.Domain.Extensions
{
    public static class AddCustomIdentity
    {
        public static void IdentityAdd(this IServiceCollection services, WebApplicationBuilder? builder = null)
        {            
            services.AddIdentity<User, Role>()                
                .AddEntityFrameworkStores<CommerceContext>()
                .AddDefaultTokenProviders();
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(jwt =>
            {
                jwt.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true
                };
            });
        }
    }
}
