using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using tsp.Domain.Entities;

namespace tsp.Persistence.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            //builder.HasData(User());
        }
        private User User()
        {
            var user = new User
            {
                Email = "stoy@windowslive.com",
                PhoneNumber = "0(533) 656 30 95",
                LastName = "Serkan",
                FirstName = "TOY",
                Salt = CreatePasswordHash("Qwe123").Item2,
                Password = CreatePasswordHash("Qwe123").Item1
            };
            return user;
        }

        private Tuple<string,string> CreatePasswordHash(string password)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(128 / 8);
            string hashed = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password!,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: 100000,
                numBytesRequested: 256 / 8));
            return Tuple.Create(hashed, salt.ToString())!;
        }

    }
}
