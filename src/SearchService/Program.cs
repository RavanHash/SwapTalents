using MongoDB.Driver;
using MongoDB.Entities;
using SearchService.Data;
using SearchService.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

try
{
    await DbInitializer.InitDb(app);
}
catch (Exception e)
{
    Console.WriteLine(e);
}

app.Run();