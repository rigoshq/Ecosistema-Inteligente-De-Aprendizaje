namespace EIA.Core.Intelligence;

public class LearningAnalyticsEngine
{
    public LearningAnalytics Analyze(
        ExplorerAcademicRecord record)
    {
        return new LearningAnalytics(
            record.LearningProfile.AverageScore,
            record.LearningProfile.AverageTimeMinutes,
            record.LearningProfile.CompletedActivities,
            record.LearningProfile.HelpRequests,
            record.LearningProfile.IndependentSolutions);
    }
}