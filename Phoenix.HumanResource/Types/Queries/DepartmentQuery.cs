using Infrastructure;
using Infrastructure.Models;
using Phoenix.HumanResource.Infrastracture;

namespace Phoenix.HumanResource.Types.Queries
{
    [QueryType]
    public class Query
    {
        public IQueryable<Department> GetDepartments(HumanResourceDbContext applicationDbcontext)
        {
            return applicationDbcontext.Departments;
        }
    }
}
