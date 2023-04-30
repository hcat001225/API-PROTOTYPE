using Server.Implementation;
using Server.Models;
using Server.Controllers;

var builder = WebApplication.CreateBuilder(args);

CEPersona cEPersona = new CEPersona();
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/",  () =>
{
    List<EPersona> lstPersona = new();
    try
    {
        lstPersona = cEPersona.GetAll();
    }catch(Exception ex)
    {
        Results.NotFound("Error In to Database");
    }
    return Results.Ok(lstPersona);
});

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
