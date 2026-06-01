var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => new
{
    service = "BankSystem.Api",
    status = "running",
    databaseTarget = "PostgreSQL"
});

app.Run();
