using EIA.Domain.Navigation.Enums;

namespace EIA.Domain.Navigation;

public class Portal
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public PortalType Type { get; private set; }

    public WorldLocation Origin { get; private set; }

    public WorldLocation Destination { get; private set; }

    public bool Enabled { get; private set; }

    public Portal(
        string name,
        PortalType type,
        WorldLocation origin,
        WorldLocation destination)
    {
        Id = Guid.NewGuid();

        Name = name;

        Type = type;

        Origin = origin;

        Destination = destination;

        Enabled = true;
    }

    public void Enable()
    {
        Enabled = true;
    }

    public void Disable()
    {
        Enabled = false;
    }
}