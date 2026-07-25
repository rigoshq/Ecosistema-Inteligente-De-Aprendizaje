using EIA.Domain.Entities.Explorer.Enums;

namespace EIA.Domain.Entities.Explorer;

public class ExplorerTimeline
{
    public List<TimelineEntry> Entries { get; }

    public ExplorerTimeline()
    {
        Entries = new();
    }

    public void Register(
        TimelineEntryType type,
        string title,
        string description)
    {
        Entries.Add(
            new TimelineEntry(
                type,
                title,
                description));
    }
}