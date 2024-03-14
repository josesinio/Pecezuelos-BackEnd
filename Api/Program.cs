using Api.Funcionalidades;
using Carter;
using Api.Persistencia;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddServiceManager();
builder.Services.AddCarter();



var  connectionString = builder.Configuration.GetConnectionString("aplicacion_db");

builder.Services.AddDbContext<PecezuelosDbContext>(Option =>
    Option.UseMySql(connectionString, new MySqlServerVersion( new Version(8,0,34))));

builder.Services.AddDbContext<PecezuelosDbContext>();

var opciones = new DbContextOptionsBuilder<PecezuelosDbContext>();

opciones.UseMySql(connectionString, new MySqlServerVersion(new Version(8,0,30)));

var contexto= new PecezuelosDbContext(opciones.Options);

contexto.Database.EnsureCreated();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapCarter();
//app.MapCarritoEndPoint();
//app.MapClienteEndPoint();
//app.MapComentarioEndPoint();
//app.MapProductoEndPoint();
//app.MapPromocionEndPoint();
//app.MapVendedorEndPoint();

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
