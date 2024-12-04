using Infrastructure;
using Phoenix.Infrastructure.Models.HumanResourceModels;

namespace Phoenix.HumanResource.Types
{
    [QueryType]
    public static class Query
    {
        [UseOffsetPaging(IncludeTotalCount = true)]
        public static IQueryable<Employee?> GetEmployees(ApplicationDbcontext db)
        {
            return db.Employees;
        }

        [UseOffsetPaging(IncludeTotalCount = true)]
        public static IQueryable<Department?> GetDepartments(ApplicationDbcontext db)
        {
            return db.Departments;
        }
    }
}
