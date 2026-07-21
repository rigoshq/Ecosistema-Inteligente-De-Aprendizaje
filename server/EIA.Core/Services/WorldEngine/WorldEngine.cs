using EIA.Core.Services.WorldEngine.Enums;
using EIA.Domain.Entities;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.Services.WorldEngine;

public class WorldEngine
{
    public WorldContext CreateContext(
        Explorer explorer,
        LearningWorld world)
    {
        return new WorldContext(
            explorer,
            world);
    }

    public WorldState InitializeWorld()
    {
        var state = new WorldState();

        state.Set(WorldStateType.Loaded);

        return state;
    }

    public WorldResult EnterWorld(
        WorldContext context)
    {
        if (context.World.Cities.Count == 0)
        {
            return WorldResult.Fail(
                "The learning world has no knowledge cities.");
        }

        return WorldResult.Ok(
            $"Explorer entered '{context.World.Name}'.");
    }

    public WorldEvent RegisterEvent(
        string description)
    {
        return new WorldEvent(description);
    }
}