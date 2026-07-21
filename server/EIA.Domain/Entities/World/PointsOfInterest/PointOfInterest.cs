using EIA.Domain.Entities.World.PointsOfInterest.Enums;

namespace EIA.Domain.Entities.World.PointsOfInterest;

public class PointOfInterest
{
    public Guid Id { get; }

    public string Name { get; }

    public PointType Type { get; }

    public InteractionRadius Radius { get; }

    public bool Enabled { get; private set; }

    public PointOfInterest(
        string name,
        PointType type,
        InteractionRadius radius)
    {
        Id = Guid.NewGuid();

        Name = name;

        Type = type;

        Radius = radius;

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