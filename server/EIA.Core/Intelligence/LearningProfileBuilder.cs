namespace EIA.Core.Intelligence;

public class LearningProfileBuilder
{
    public ExplorerLearningProfile Build(
        IEnumerable<LearningEvidence> evidences)
    {
        var profile = new ExplorerLearningProfile();

        foreach (var evidence in evidences)
        {
            profile.RegisterEvidence(evidence);
        }

        return profile;
    }
}