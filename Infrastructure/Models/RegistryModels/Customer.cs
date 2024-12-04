#nullable disable

namespace Infrastructure.Models.RegistryModels
{
    public class Customer : Entity
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
    }
}
