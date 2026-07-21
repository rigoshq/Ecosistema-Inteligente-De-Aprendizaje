using EIA.Core.Services.WorldEngine.Enums;

namespace EIA.Core.Services.WorldEngine;

public class WorldState
{
    public WorldStateType State { get; private set; }

    public WorldState()
    {
        State = WorldStateType.Initializing;
    }

    public void Set(WorldStateType state)
    {
        State = state;
    }
}