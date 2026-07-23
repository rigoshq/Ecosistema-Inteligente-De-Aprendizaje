namespace EIA.Core.Intelligence;

public class LearningEvidence
{
    public Guid Id { get; }

    public DateTime CreatedAt { get; }

    public string Source { get; }

    public string Competency { get; }

    public double Score { get; }

    public double TimeSpentMinutes { get; }

    public int Attempts { get; }

    public bool NeededHelp { get; }

    public string Observation { get; }

    public LearningEvidence(
        string source,
        string competency,
        double score,
        double timeSpentMinutes,
        int attempts,
        bool neededHelp,
        string observation)
    {
        Id = Guid.NewGuid();

        CreatedAt = DateTime.UtcNow;

        Source = source;

        Competency = competency;

        Score = score;

        TimeSpentMinutes = timeSpentMinutes;

        Attempts = attempts;

        NeededHelp = neededHelp;

        Observation = observation;
    }
}