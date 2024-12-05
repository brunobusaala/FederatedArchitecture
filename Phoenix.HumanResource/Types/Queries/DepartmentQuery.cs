using Infrastructure;
using Infrastructure.Models;
using Phoenix.HumanResource.Infrastracture;

namespace Phoenix.HumanResource.Types.Queries
{
    [QueryType]
    public static class Query
    {
        [UseOffsetPaging(IncludeTotalCount = true)]
        public static IQueryable<Department> GetDepartments(HumanResourceDbContext applicationDbcontext)
        {
            return applicationDbcontext.Departments;
        }
    }
}
