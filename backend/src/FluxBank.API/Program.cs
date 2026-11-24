using FluxBank.Application;
using FluxBank.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Serviços da aplicação
builder.Services.AddApplication();

// Serviços de infraestrutura
builder.Services.AddInfrastructure();

// OpenAPI
builder.Services.AddOpenApi();

var app = builder.Build();

// Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

// Endpoint inicial de verificação
app.MapGet("/health", () =>
    {
        return Results.Ok(new
        {
            status = "Healthy",
            service = "FluxBank.API"
        });
    })
    .WithName("HealthCheck");

app.Run();