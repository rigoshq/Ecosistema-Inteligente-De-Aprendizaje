using EIA.Core.Services.GameFlow.Enums;

namespace EIA.Core.Services.GameFlow;

public class GameStep
{
    public Guid Id { get; }

    public string Name { get; }

    public GameStepType Type { get; }

    public bool Completed { get; private set; }

    public DateTime? StartedAt { get; private set; }

    public DateTime? FinishedAt { get; private set; }

    public GameStep(
        string name,
        GameStepType type)
    {
        Id = Guid.NewGuid();

        Name = name;

        Type = type;

        Completed = false;
    }

    public void Start()
    {
        StartedAt = DateTime.UtcNow;
    }

    public void Complete()
    {
        Completed = true;

        FinishedAt = DateTime.UtcNow;
    }

    public TimeSpan? Duration()
    {
        if (StartedAt == null || FinishedAt == null)
            return null;

        return FinishedAt - StartedAt;
    }
}