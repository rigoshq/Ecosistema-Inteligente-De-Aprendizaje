namespace EIA.Core.Memory;

public class LearningMemory
{
    public Guid Id { get; }

    public DateTime Date { get; }

    public string Event { get; }

    public string Concept { get; }

    public string Summary { get; }

    public LearningMemory(
        string @event,
        string concept,
        string summary)
    {
        Id = Guid.NewGuid();

        Date = DateTime.UtcNow;

        Event = @event;

        Concept = concept;

        Summary = summary;
    }
}