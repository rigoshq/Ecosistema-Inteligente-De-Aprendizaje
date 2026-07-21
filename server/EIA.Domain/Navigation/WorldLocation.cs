using EIA.Domain.Navigation.Enums;

namespace EIA.Domain.Navigation;

public class WorldLocation
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public LocationType Type { get; private set; }

    public WorldLocation(
        string name,
        LocationType type)
    {
        Id = Guid.NewGuid();

        Name = name;

        Type = type;
    }
}