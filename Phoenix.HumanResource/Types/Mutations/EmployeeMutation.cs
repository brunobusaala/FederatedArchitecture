using Infrastracture.Entities;
using Infrastructure;
using Infrastructure.Models;
using Phoenix.Infrastructure.Models.RegistryModels;

namespace Phoenix.HumanResource.Types.Mutations
{
    [MutationType]
    public class EmployeeMutation
    {
        public async Task<Employee> AddEmployee(AddEmployeeInput addEmployeeInput, ApplicationDbcontext context)
        {
            var payload = new Employee
            {
                Id = new Guid(),

                CustomerId = addEmployeeInput.CustomerId,

                DepartmentId = addEmployeeInput.DepartmentId,

                Salary = addEmployeeInput.Salary,
            };

            await context.AddAsync(payload);

            await context.SaveChangesAsync();

            return payload;
        }
    }
}
