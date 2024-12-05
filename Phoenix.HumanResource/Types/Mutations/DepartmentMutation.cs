using Infrastructure;
using Phoenix.HumanResource.Entities;
using Phoenix.Infrastructure.Models.HumanResourceModels;

namespace Phoenix.HumanResource.Types.Mutations
{
    [MutationType]
    public class DepartmentMutation
    {
        public async Task<Department> AddDepartment(AddDepartmentInput addDepartmentInput, ApplicationDbcontext context)
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
