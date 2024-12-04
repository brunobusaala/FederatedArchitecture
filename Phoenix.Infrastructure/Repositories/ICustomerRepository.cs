using Phoenix.Infrastructure.Models.RegistryModels;

public interface ICustomerRepository
{
    Task<Customer> FindCustomerById(Guid id);

    Task<Customer> FindCustomerByBranchId(Guid branchId);

    Task<Customer> CreateCustomer(Customer customer);

    Task<Customer> UpdateCustomer(Customer customer);

    Task<List<Customer>> FindCustomers();
}
