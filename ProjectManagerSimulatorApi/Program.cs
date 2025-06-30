using ProjectManagerSimulatorApi.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSingleton<EstimateRepository>();
builder.Services.AddSingleton<DeadlineRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
