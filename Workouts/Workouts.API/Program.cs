using Azure.Core.Pipeline;
using Microsoft.EntityFrameworkCore;
using Workouts.Data;
using Workout.Models;
using Microsoft.AspNetCore.Mvc;
using Workouts.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddDbContext<WorkoutsDbContext>(options => options.
    UseSqlServer(builder.Configuration["dbconnectionstr"]));
builder.Services.AddScoped<IRepository, WorkoutsRepository>();
builder.Services.AddScoped<IWorkoutsServices, WorkoutsService>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers()
.AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.ReferenceHandler = System.Text.Json.Serialization.ReferenceHandler.IgnoreCycles;
        });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

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

app.MapGet("/exercises", (IRepository repo) => {
    return repo.GetAllExercises();
})
.WithName("Get All Workouts")
.WithOpenApi();

app.MapGet("/user", (IRepository repo) => {
    return repo.GetAllUsers();
})
.WithName("Get All Users")
.WithOpenApi();

app.MapPost("/user", ([FromServices] IRepository repo, [FromBody] Users userToCreate) => {
    return repo.CreateNewUser(userToCreate);
})
.WithName("Create New User")
.WithOpenApi();

app.MapPost("/exercises", ([FromServices] IRepository repo, [FromBody] Exercises exerciseToAdd) => {
    return repo.AddNewExercise(exerciseToAdd);
})
.WithName("Add exercise to table")
.WithOpenApi();;

app.MapControllers();

app.Run();

record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
