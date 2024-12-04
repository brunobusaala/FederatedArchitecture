using Phoenix.Infrastructure.Models.HumanResourceModels;

public class DepartmentNode: ObjectTypeExtension<Department>
{
    protected override void Configure(IObjectTypeDescriptor<Department> descriptor)
    {
        descriptor.Field(e => e.Id)
            .Resolve(ctx => ctx.Parent<Department>().Id);
    }
}
