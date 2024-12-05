using Infrastracture.Entities;
using Infrastructure;
using Infrastructure.Models;
using Phoenix.HumanResource.Infrastracture;

namespace Phoenix.HumanResource.Types.Mutations
{
    [MutationType]
    public class DepartmentMutation
    {
        public async Task<Department> AddDepartment(AddDepartmentInput addDepartmentInput, HumanResourceDbContext context)
        {
            var payload = new Department
            {
                Id = new Guid(),

                Name = addDepartmentInput.Name
            };

            await context.AddAsync(payload);

            await context.SaveChangesAsync();

            return payload;
        }
    }
}
