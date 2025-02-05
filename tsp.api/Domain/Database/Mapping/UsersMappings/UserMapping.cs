using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.api.Domain.Core.Entities.Users;

namespace tsp.api.Domain.Database.Mapping.UsersMappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(User());
        }

        private User User()
        {
            var user = new User
            {
                Id = Guid.Parse("FF4DBF3C-CE20-4E35-BEFD-1F1D89BD56D5"),
                Email = "stoy@windowslive.com",
                NormalizedEmail = "STOY@WINDOWSLIVE.COM",
                Name = "Serkan",
                SurName = "TOY",
                UserName = "stoy",
                NormalizedUserName = "STOY",
                PhoneNumber = "0(533) 656 30 95",
                SecurityStamp = Guid.NewGuid().ToString()
            };
            user.PasswordHash = CreatePasswordHash(user, "Qwe123");
            return user;
        }

        private string CreatePasswordHash(User user, string password)
        {
            var passwordHash = new PasswordHasher<User>();
            return passwordHash.HashPassword(user, password);
        }
    }
}