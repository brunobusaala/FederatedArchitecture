using Phoenix.Infrastructure.Models.HumanResourceModels;
using Phoenix.Infrastructure.Models.RegistryModels;

namespace Phoenix.HumanResource.Entities
{
    public class AddEmployeeInput
    {
        public Guid CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public Guid DepartmentId { get; set; }

        public Department? Department { get; set; }

        public decimal Salary { get; set; }
    }
}
