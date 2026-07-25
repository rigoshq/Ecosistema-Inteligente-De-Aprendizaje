using EIA.Domain.Entities.Explorer.Enums;

namespace EIA.Domain.Entities.Explorer;

public class TimelineEntry
{
    public Guid Id { get; }

    public DateTime Date { get; }

    public TimelineEntryType Type { get; }

    public string Title { get; }

    public string Description { get; }

    public TimelineEntry(
        TimelineEntryType type,
        string title,
        string description)
    {
        Id = Guid.NewGuid();

        Date = DateTime.UtcNow;

        Type = type;

        Title = title;

        Description = description;
    }
}
