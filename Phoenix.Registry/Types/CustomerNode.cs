using Phoenix.Infrastructure.Models.RegistryModels;

namespace Phoenix.Registry.Types
{
    public class CustomerNode : ObjectTypeExtension<Customer>
    {
        protected override void Configure(IObjectTypeDescriptor<Customer> descriptor)
        {
            descriptor.Field(c => c.Id)
                .Resolve(ctx => ctx.Parent<Customer>().Id);

            descriptor.Field("fullName")
                .Type<StringType>()
                .Resolve(ctx => $"{ctx.Parent<Customer>().FirstName} {ctx.Parent<Customer>().LastName}");
        }
    }
}
