namespace EIA.Core.Learning;

public class LearningPath
{
    private readonly List<LearningStep> _steps;

    public IReadOnlyCollection<LearningStep> Steps
        => _steps.AsReadOnly();

    public LearningPath()
    {
        _steps = new();
    }

    public void AddStep(
        LearningStep step)
    {
        _steps.Add(step);
    }
}