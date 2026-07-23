namespace EIA.Core.Intelligence;

public class LearningTimelineEvent
{
    public Guid Id { get; }

    public DateTime Date { get; }

    public string Title { get; }

    public string Description { get; }

    public string Category { get; }

    public LearningTimelineEvent(
        string title,
        string description,
        string category)
    {
        Id = Guid.NewGuid();

        Date = DateTime.UtcNow;

        Title = title;

        Description = description;

        Category = category;
    }
}