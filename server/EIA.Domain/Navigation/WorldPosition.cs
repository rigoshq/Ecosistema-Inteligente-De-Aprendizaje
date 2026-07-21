namespace EIA.Domain.Navigation;

public class WorldPosition
{
    public WorldLocation CurrentLocation { get; private set; }

    public DateTime LastUpdate { get; private set; }

    public WorldPosition(WorldLocation location)
    {
        CurrentLocation = location;

        LastUpdate = DateTime.UtcNow;
    }

    public void MoveTo(WorldLocation location)
    {
        CurrentLocation = location;

        LastUpdate = DateTime.UtcNow;
    }
}