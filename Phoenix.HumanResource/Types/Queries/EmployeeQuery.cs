using Infrastructure;
using Phoenix.Infrastructure.Models.HumanResourceModels;

namespace Phoenix.HumanResource.Types.Queries
{
    [QueryType]
    public class EmployeeQuery
    {
        public IQueryable<Employee> GetEmployees(ApplicationDbcontext context)
        {
            return context.Employees;
        }
    }
}
