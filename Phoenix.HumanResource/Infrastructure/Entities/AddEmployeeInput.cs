using Infrastructure.Models;
using Phoenix.HumanResource.Types;

namespace Infrastracture.Entities
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
