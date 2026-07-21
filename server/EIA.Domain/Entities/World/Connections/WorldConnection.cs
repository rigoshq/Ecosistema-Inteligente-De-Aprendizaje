using EIA.Domain.Entities.World.Connections.Enums;

namespace EIA.Domain.Entities.World.Connections;

public class WorldConnection
{
    public Guid Id { get; }

    public Guid OriginId { get; }

    public Guid DestinationId { get; }

    public ConnectionType Type { get; }

    public TravelCost Cost { get; }

    public bool Locked { get; private set; }

    public WorldConnection(
        Guid originId,
        Guid destinationId,
        ConnectionType type,
        TravelCost cost)
    {
        Id = Guid.NewGuid();

        OriginId = originId;

        DestinationId = destinationId;

        Type = type;

        Cost = cost;

        Locked = false;
    }

    public void Lock()
    {
        Locked = true;
    }

    public void Unlock()
    {
        Locked = false;
    }
}