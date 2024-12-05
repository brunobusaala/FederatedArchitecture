var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHttpClient("Fusion");

builder.Services
    .AddFusionGatewayServer()
    .ConfigureFromFile("./Phoenix.Gateway.fgp");

var app = builder.Build();

app.MapGraphQL();

app.RunWithGraphQLCommands(args);
