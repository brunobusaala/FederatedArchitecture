using Infrastructure.Models;
using Phoenix.HumanResource.Infrastracture;

namespace Phoenix.HumanResource.Types.Mutations
{
    [MutationType]
    public static class Mutation
    {
        public static bool CreateEmployee(HumanResourceDbContext db, Guid customerId, Guid departmentId, decimal salary)
        {
            var employee = new Employee
            {
                CustomerId = customerId,
                DepartmentId = departmentId,
                Salary = salary
            };

            db.Employees.Add(employee);

            return db.SaveChanges() > 0;
        }

        public static bool CreateDepartment(HumanResourceDbContext db, string name)
        {
            var department = new Department
            {
                Name = name,
            };

            db.Departments.Add(department);

            return db.SaveChanges() > 0;
        }
    }
}
