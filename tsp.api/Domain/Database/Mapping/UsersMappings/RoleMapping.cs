using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using tsp.api.Domain.Core.Entities.Users;

namespace tsp.api.Domain.Database.Mapping.UsersMappings
{
    public class RoleMapping : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasData(Role());
        }
        private List<Role> Role()
        {
            return new List<Role>
            {
                new Role { Id = Guid.Parse("A37170B1-88CB-476D-A6A5-04733E2D6134"), Name = "superuser", NormalizedName = "SUPERUSER", ConcurrencyStamp = Guid.NewGuid().ToString() },
                new Role { Id = Guid.Parse("A94D44F9-50D3-436B-A44C-54F8ADE3E196"), Name = "admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() }
            };
        }

    }
}
