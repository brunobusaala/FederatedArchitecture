using Phoenix.Infrastructure.Models.HumanResourceModels;

namespace Phoenix.HumanResource.Types
{
    [ObjectType<Employee>]
    public static partial class EmployeeType
    {
        static partial void Configure(IObjectTypeDescriptor<Employee> descriptor)
        {
            descriptor.Ignore(e => e.CustomerId);
        }

        public static Customer GetCustomer([Parent] Employee employee)
        {
            return new(employee.CustomerId);
        }
    }

    public sealed record Customer(Guid Id);
}
