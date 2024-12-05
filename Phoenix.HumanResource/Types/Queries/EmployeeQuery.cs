using Infrastructure;
using Infrastructure.Models;
using Phoenix.HumanResource.Infrastracture;

namespace Phoenix.HumanResource.Types.Queries
{
    [QueryType]
    public class EmployeeQuery
    {
        public IQueryable<Employee> GetEmployees(HumanResourceDbContext context)
        {
            return context.Employees;
        }
    }
}
