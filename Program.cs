
// Import required namespaces for dependency injection and web application builder
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;


// Create a WebApplicationBuilder instance to configure services and the app
var builder = WebApplication.CreateBuilder(args);


// Register AppDbContext for dependency injection (EF Core database context)
builder.Services.AddDbContext<AppDbContext>();
// Register controller services for API endpoints
builder.Services.AddControllers();


// Build the WebApplication instance
var app = builder.Build();


// Map controller routes (enables API endpoints)
app.MapControllers();


// Start the web application and listen for HTTP requests
app.Run();


// Note:
// WebApplication was on error until I added the using Microsoft.AspNetCore.Builder;
// and changed the dependency from <Project Sdk="Microsoft.NET.Sdk"> to <Project Sdk="Microsoft.NET.Sdk.Web"> in the WebApp.csproj file