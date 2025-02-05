using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace tsp.api.Domain.Core.Entities.Users
{
    public class UserRole : IdentityUserRole<Guid>
    {
        [NotMapped]
        public User User { get; set; }
        [NotMapped]
        public Role Role { get; set; }
    }
}
