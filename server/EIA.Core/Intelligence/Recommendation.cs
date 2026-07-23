namespace EIA.Core.Intelligence;

public class Recommendation
{
    public string Title { get; }

    public string Description { get; }

    public int Priority { get; }

    public Recommendation(
        string title,
        string description,
        int priority)
    {
        Title = title;

        Description = description;

        Priority = priority;
    }
}