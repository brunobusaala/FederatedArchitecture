using Infrastructure;
using Phoenix.Infrastructure.Models.RegistryModels;

namespace Phoenix.Registry.Types
{
    [QueryType]
    public static class Query
    {
        public static Customer? GetCustomers(ApplicationDbcontext db)
        {
            return db.Customers.FirstOrDefault();
        }
    }
}
