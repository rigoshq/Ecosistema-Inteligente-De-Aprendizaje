using EIA.Core.Repositories;
using EIA.Core.Services;
using EIA.Core.World;
using EIA.Infrastructure.Seed;
using EIA.Domain.Entities;
using EIA.Core.Missions;
using EIA.Core.Engine;

//----------------------------------------------------
// Kernel del Ecosistema Inteligente de Aprendizaje
//----------------------------------------------------

using EIA.Core.Cognitive;
using EIA.Core.Memory;
using EIA.Core.Mastery;
using EIA.Core.Meta;
using EIA.Core.Pipeline;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddOpenApi();

//----------------------------------------------------
// Repositorios
//----------------------------------------------------

builder.Services.AddSingleton<IExplorerRepository, ExplorerRepository>();

//----------------------------------------------------
// Servicios
//----------------------------------------------------

builder.Services.AddScoped<ExplorerService>();

//----------------------------------------------------
// Mundo
//----------------------------------------------------

LearningWorld world = WorldSeeder.Create();

builder.Services.AddSingleton(world);

builder.Services.AddSingleton<WorldService>();

//----------------------------------------------------
// Misiones
//----------------------------------------------------

var missionService = new MissionService();

missionService.Load(MissionSeeder.Create());

builder.Services.AddSingleton<ExplorerEngine>();

builder.Services.AddSingleton(missionService);

//----------------------------------------------------
// Kernel del Ecosistema Inteligente de Aprendizaje
//----------------------------------------------------

builder.Services.AddSingleton<CognitiveTwinEngine>();

builder.Services.AddSingleton<EducationalMemoryEngine>();

builder.Services.AddSingleton<ConceptMasteryEngine>();

builder.Services.AddSingleton<MetaEngine>();

builder.Services.AddSingleton<ExplorerIntelligencePipeline>();

missionService.Load(MissionSeeder.Create());

builder.Services.AddSingleton(missionService);

//----------------------------------------------------
// Aplicación
//----------------------------------------------------

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();