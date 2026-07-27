namespace EIA.Domain.Entities.World;

public class WorldConnection
{
    public Guid Id { get; }

    public Guid OriginBuildingId { get; }

    public Guid DestinationBuildingId { get; }

    public bool IsUnlocked { get; private set; }

    public double Distance { get; }

    public string PathName { get; }

    public WorldConnection(
        Guid originBuildingId,
        Guid destinationBuildingId,
        string pathName,
        double distance)
    {
        Id = Guid.NewGuid();

        OriginBuildingId = originBuildingId;

        DestinationBuildingId = destinationBuildingId;

        PathName = pathName;

        Distance = distance;

        IsUnlocked = true;
    }

    public void Lock()
    {
        IsUnlocked = false;
    }

    public void Unlock()
    {
        IsUnlocked = true;
    }
}