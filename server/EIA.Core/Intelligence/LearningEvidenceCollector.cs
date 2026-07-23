namespace EIA.Core.Intelligence;

public class LearningEvidenceCollector
{
    private readonly List<LearningEvidence> _evidences;

    public LearningEvidenceCollector()
    {
        _evidences = new();
    }

    public void Collect(
        LearningEvidence evidence)
    {
        _evidences.Add(evidence);
    }

    public IReadOnlyCollection<LearningEvidence> GetAll()
    {
        return _evidences.AsReadOnly();
    }

    public IReadOnlyCollection<LearningEvidence> GetBySource(
        string source)
    {
        return _evidences
            .Where(x => x.Source == source)
            .ToList()
            .AsReadOnly();
    }

    public IReadOnlyCollection<LearningEvidence> GetByCompetency(
        string competency)
    {
        return _evidences
            .Where(x => x.Competency == competency)
            .ToList()
            .AsReadOnly();
    }

    public void Clear()
    {
        _evidences.Clear();
    }
}