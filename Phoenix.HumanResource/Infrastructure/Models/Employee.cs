namespace Infrastructure.Models
{
    public class Employee : Entity
    {
        public Guid CustomerId { get; set; }

        public string CustomerName {  get; set; }

        public Guid DepartmentId { get; set; }

        public Department? Department { get; set; }

        public decimal Salary { get; set; }
    }
}
