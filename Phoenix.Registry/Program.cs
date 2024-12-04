var builder = WebApplication.CreateBuilder(args);

builder
    .AddGraphQL()
    .AddRegistryTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
