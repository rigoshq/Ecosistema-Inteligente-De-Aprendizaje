using EIA.Domain.Entities;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.Services.Adventure;

public class AdventureContext
{
    public Explorer Explorer { get; }

    public LearningWorld World { get; }

    public AdventureContext(
        Explorer explorer,
        LearningWorld world)
    {
        Explorer = explorer;

        World = world;
    }
}