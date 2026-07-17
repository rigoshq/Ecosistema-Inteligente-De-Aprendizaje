using EIA.Core.Repositories;
using EIA.Core.Services;
using EIA.Infrastructure.Repositories;
using EIA.Core.World;
using EIA.Infrastructure.Seed;
using EIA.Domain.Entities;
using EIA.Core.Missions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

builder.Services.AddSingleton<IExplorerRepository, ExplorerRepository>();

builder.Services.AddScoped<ExplorerService>();

LearningWorld world = WorldSeeder.Create();

builder.Services.AddSingleton(world);

builder.Services.AddSingleton<WorldService>();

var missionService = new MissionService();

missionService.Load(MissionSeeder.Create());

builder.Services.AddSingleton(missionService);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();


