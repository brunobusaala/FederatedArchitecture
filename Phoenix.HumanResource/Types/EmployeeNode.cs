
using Phoenix.Infrastructure.Models.HumanResourceModels;

public class EmployeeNode: ObjectTypeExtension<Employee>
{
    protected override void Configure(IObjectTypeDescriptor<Employee> descriptor)
    {
        descriptor.Field(e => e.Id)
            .Resolve(ctx => ctx.Parent<Employee>().Id);
    }
}
