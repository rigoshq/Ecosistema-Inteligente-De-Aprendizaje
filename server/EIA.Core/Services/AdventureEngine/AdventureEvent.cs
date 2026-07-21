using EIA.Core.Services.AdventureEngine.Enums;

namespace EIA.Core.Services.AdventureEngine;

public class AdventureEvent
{
    public Guid Id { get; }

    public AdventureEventType Type { get; }

    public DateTime OccurredAt { get; }

    public string Description { get; }

    public AdventureEvent(
        AdventureEventType type,
        string description)
    {
        Id = Guid.NewGuid();

        Type = type;

        Description = description;

        OccurredAt = DateTime.UtcNow;
    }
}