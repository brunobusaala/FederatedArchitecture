namespace Phoenix.Registry.Types
{
    [QueryType]
    public static class Query
    {
        public static Customer GetCustomers()
        {
            return new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = "Timothy",
                LastName = "Kelvin"
            };
        }
    }
}
