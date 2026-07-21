namespace EIA.Domain.Entities.World;

public class TeleportPortal
{
    public Guid Id { get; }

    public string Name { get; }

    public Guid DestinationId { get; }

    public TeleportPortal(
        string name,
        Guid destinationId)
    {
        Id = Guid.NewGuid();

        Name = name;

        DestinationId = destinationId;
    }
}