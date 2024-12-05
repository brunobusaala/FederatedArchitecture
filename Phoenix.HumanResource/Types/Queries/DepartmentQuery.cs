using Infrastructure;
using Phoenix.Infrastructure.Models.HumanResourceModels;

namespace Phoenix.HumanResource.Types.Queries
{
    [QueryType]
    public class Query
    {
        public IQueryable<Department> GetDepartments(ApplicationDbcontext applicationDbcontext)
        {
            return applicationDbcontext.Departments;
        }
    }
}
