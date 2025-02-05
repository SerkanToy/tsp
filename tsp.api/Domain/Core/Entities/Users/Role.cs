using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace tsp.api.Domain.Core.Entities.Users
{
    public class Role: IdentityRole<Guid>
    {
        public Role()
        {
            Id = Guid.NewGuid();
        }
        [NotMapped]
        public ICollection<User> Users { get; set; }
    }
}
