namespace EIA.Core.Services.NarrativeEngine;

public class NarrativeEvent
{
    public Guid Id { get; }

    public string Description { get; }

    public DateTime OccurredAt { get; }

    public NarrativeEvent(string description)
    {
        Id = Guid.NewGuid();

        Description = description;

        OccurredAt = DateTime.UtcNow;
    }
}