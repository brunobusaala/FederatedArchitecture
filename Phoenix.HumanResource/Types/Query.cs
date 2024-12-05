using Infrastructure;
using Infrastructure.Models;
using Phoenix.HumanResource.Infrastracture;

namespace Phoenix.HumanResource.Types
{
    [QueryType]
    public static class Query
    {
        [UseOffsetPaging(IncludeTotalCount = true)]
        public static IQueryable<Employee?> GetEmployees(HumanResourceDbContext db)
        {
            return db.Employees;
        }

        [UseOffsetPaging(IncludeTotalCount = true)]
        public static IQueryable<Department?> GetDepartments(HumanResourceDbContext db)
        {
            return db.Departments;
        }
    }
}
