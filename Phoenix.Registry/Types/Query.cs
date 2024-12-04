using HotChocolate.Fusion.SourceSchema.Types;
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

    public static class CustomerOperations
    {
        [Query]
        [Lookup]
        //[Internal]
        public static Customer? GetCustomerById(ApplicationDbcontext db, Guid id)
        {
            return db.Customers.FirstOrDefault(x => x.Id == id);
        }
    }
}
