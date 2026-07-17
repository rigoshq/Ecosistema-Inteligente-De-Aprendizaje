using EIA.Domain.Entities;

namespace EIA.Core.World;

public class WorldService
{
    public LearningWorld World { get; }

    public WorldService(LearningWorld world)
    {
        World = world;
    }
}