namespace EIA.Core.Intelligence;

public class ExplorerAcademicRecord
{
    public ExplorerLearningProfile LearningProfile { get; }

    public LearningTimeline Timeline { get; }
    public IReadOnlyCollection<LearningEvidence> Evidences
        => _evidences.AsReadOnly();

    public IReadOnlyCollection<LearningInsight> Insights
        => _insights.AsReadOnly();

    public IReadOnlyCollection<Recommendation> Recommendations
        => _recommendations.AsReadOnly();

    private readonly List<LearningEvidence> _evidences;

    private readonly List<LearningInsight> _insights;

    private readonly List<Recommendation> _recommendations;

    public ExplorerAcademicRecord()
    {
    LearningProfile = new();

    Timeline = new();

    _evidences = new();

    _insights = new();

    _recommendations = new();
    }

    public void AddEvidence(
        LearningEvidence evidence)
    {
        _evidences.Add(evidence);

        LearningProfile.RegisterEvidence(evidence);
    }

    public void AddInsights(
        IEnumerable<LearningInsight> insights)
    {
        _insights.AddRange(insights);
    }

    public void AddRecommendations(
        IEnumerable<Recommendation> recommendations)
    {
        _recommendations.AddRange(recommendations);
    }
    public void AddTimelineEvent(
    LearningTimelineEvent timelineEvent)
    {
    Timeline.AddEvent(timelineEvent);
    }
}