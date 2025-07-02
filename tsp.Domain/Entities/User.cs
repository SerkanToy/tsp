using tsp.Domain.Common;

namespace tsp.Domain.Entities
{
    public class User: BaseEntity
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Salt { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateOnly DateOfBirth { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
