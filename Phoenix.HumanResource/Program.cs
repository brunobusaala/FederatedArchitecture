using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Phoenix.HumanResource.Infrastracture;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<HumanResourceDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("HumanResourceDefaultConnection")));

builder
    .AddGraphQL()
    .AddHumanResourceTypes();

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
