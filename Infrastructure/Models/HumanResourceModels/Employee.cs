﻿using Infrastructure.Models.RegistryModels;

namespace Infrastructure.Models.HumanResourceModels
{
    public class Employee : Entity
    {
        public Guid CustomerId { get; set; }

        public Customer? Customer { get; set; }

        public Guid DepartmentId { get; set; }

        public Department? Department { get; set; }

        public decimal Salary { get; set; }
    }
}
