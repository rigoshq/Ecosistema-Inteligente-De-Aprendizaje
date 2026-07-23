namespace EIA.Core.UseCases.Laboratory;

public class LaboratoryEvaluationResult
{
    public int Score { get; }

    public bool Approved { get; }

    public double AverageVelocity { get; }

    public double AverageDistance { get; }

    public double AverageTime { get; }

    public LaboratoryEvaluationResult(
        int score,
        bool approved,
        double averageVelocity,
        double averageDistance,
        double averageTime)
    {
        Score = score;

        Approved = approved;

        AverageVelocity = averageVelocity;

        AverageDistance = averageDistance;

        AverageTime = averageTime;
    }
}