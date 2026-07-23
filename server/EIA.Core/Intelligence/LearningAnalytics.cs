namespace EIA.Core.Intelligence;

public class LearningAnalytics
{
    public double AverageScore { get; }

    public double AverageTime { get; }

    public int TotalActivities { get; }

    public int TotalHelpRequests { get; }

    public int TotalIndependentSolutions { get; }

    public LearningAnalytics(
        double averageScore,
        double averageTime,
        int totalActivities,
        int totalHelpRequests,
        int totalIndependentSolutions)
    {
        AverageScore = averageScore;

        AverageTime = averageTime;

        TotalActivities = totalActivities;

        TotalHelpRequests = totalHelpRequests;

        TotalIndependentSolutions = totalIndependentSolutions;
    }
}