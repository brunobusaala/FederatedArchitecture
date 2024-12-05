using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Phoenix.Registry.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RegistryDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RegistryDefaultConnection"));
});

builder
    .AddGraphQL()
    .AddRegistryTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
