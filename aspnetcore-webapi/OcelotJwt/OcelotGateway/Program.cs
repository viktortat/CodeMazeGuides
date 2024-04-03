using JwtTokenAuthentication;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

// https://code-maze.com/dotnetcore-secure-microservices-jwt-ocelot/
var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile("ocelot.json", false, false);

builder.Services.AddOcelot(builder.Configuration);
builder.Services.AddJwtAuthentication();

var app = builder.Build();

await app.UseOcelot();

app.UseAuthentication();
app.UseAuthorization();

app.Run();
