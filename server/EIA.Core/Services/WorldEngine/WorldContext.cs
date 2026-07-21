using EIA.Domain.Entities;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.Services.WorldEngine;

public class WorldContext
{
    public Explorer Explorer { get; }

    public LearningWorld World { get; }

    public WorldContext(
        Explorer explorer,
        LearningWorld world)
    {
        Explorer = explorer;
        World = world;
    }
}