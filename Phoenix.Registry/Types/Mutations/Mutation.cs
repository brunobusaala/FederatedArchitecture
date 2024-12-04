using Infrastructure;
using Phoenix.Infrastructure.Models.RegistryModels;

namespace Phoenix.Registry.Types.Mutations
{
    [MutationType]
    public static class Mutation
    {
        public static bool CreateCustomer(ApplicationDbcontext db, string firstName, string lastName, string email, string address)
        {
            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                Address = address
            };

            db.Customers.Add(customer);

            return db.SaveChanges() > 0;
        }
    }
}

