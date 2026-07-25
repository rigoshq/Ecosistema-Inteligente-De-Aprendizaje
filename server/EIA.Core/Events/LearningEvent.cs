namespace EIA.Core.Events;

public abstract class LearningEvent
{
    public Guid Id { get; }

    public DateTime OccurredAt { get; }

    protected LearningEvent()
    {
        Id = Guid.NewGuid();

        OccurredAt = DateTime.UtcNow;
    }
}