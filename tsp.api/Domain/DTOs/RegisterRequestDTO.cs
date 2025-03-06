using System.ComponentModel.DataAnnotations.Schema;
using tsp.api.Domain.Core.Entities.Users;

namespace tsp.api.Domain.DTOs
{
    public class RegisterRequestDTO
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public ICollection<Role> Roles { get; set; }
    }
}
