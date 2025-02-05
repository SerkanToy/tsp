using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.api.Domain.Core.Entities.Users;
using tsp.api.Domain.Database.Context;

namespace tsp.api.Domain.Database.Mapping.UsersMappings
{
    public class UserRoleMapping : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            //builder.HasKey(x => new { x.RoleId, x.UserId });
            builder.HasData(UserRole());
            
        }

        private List<UserRole> UserRole()
        {
            return new List<UserRole>
            {
                new UserRole { RoleId = Guid.Parse("A37170B1-88CB-476D-A6A5-04733E2D6134"), UserId = Guid.Parse("FF4DBF3C-CE20-4E35-BEFD-1F1D89BD56D5") },
                new UserRole { RoleId = Guid.Parse("A94D44F9-50D3-436B-A44C-54F8ADE3E196"), UserId = Guid.Parse("FF4DBF3C-CE20-4E35-BEFD-1F1D89BD56D5") }
            };
        }

    }
}
