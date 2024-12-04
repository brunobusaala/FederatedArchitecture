using Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbcontext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder
    .AddGraphQL()
    .AddRegistryTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
