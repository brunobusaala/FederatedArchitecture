using Infrastructure;
using Phoenix.Infrastructure.Models.RegistryModels;

namespace Phoenix.Registry.Types
{
    [QueryType]
    public static class Query
    {
        [UseOffsetPaging(IncludeTotalCount = true)]
        public static IQueryable<Customer?> GetCustomers(ApplicationDbcontext db)
        {
            return db.Customers;
        }
    }
}
