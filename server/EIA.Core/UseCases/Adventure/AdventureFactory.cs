using EIA.Domain.Entities.Explorer;

namespace EIA.Core.UseCases.Adventure;

public static class AdventureFactory
{
    public static AdventureContext Create(
        Explorer explorer)
    {
        return new AdventureContext(explorer);
    }
}