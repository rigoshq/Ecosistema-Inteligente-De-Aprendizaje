namespace EIA.Core.Services.WorldEngine;

public class WorldEvent
{
    public Guid Id { get; }

    public string Description { get; }

    public DateTime OccurredAt { get; }

    public WorldEvent(string description)
    {
        Id = Guid.NewGuid();

        Description = description;

        OccurredAt = DateTime.UtcNow;
    }
}