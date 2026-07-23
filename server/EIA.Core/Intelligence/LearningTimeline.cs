namespace EIA.Core.Intelligence;

public class LearningTimeline
{
    private readonly List<LearningTimelineEvent> _events;

    public IReadOnlyCollection<LearningTimelineEvent> Events
        => _events
            .OrderBy(e => e.Date)
            .ToList()
            .AsReadOnly();

    public LearningTimeline()
    {
        _events = new();
    }

    public void AddEvent(
        LearningTimelineEvent timelineEvent)
    {
        _events.Add(timelineEvent);
    }
}