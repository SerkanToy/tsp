using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace tsp.api.Domain.Core.Entities.Users
{
    public class User : IdentityUser<Guid>
    {
        public User()
        {
            Id = Guid.NewGuid();
        }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
}
