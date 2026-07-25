namespace EIA.Domain.Entities.Explorer;

public class LearningHistory
{
    public List<Guid> LearningExperienceIds { get; }

    public LearningHistory()
    {
        LearningExperienceIds = new();
    }

    public void Register(
        Guid learningExperienceId)
    {
        if (!LearningExperienceIds.Contains(
            learningExperienceId))
        {
            LearningExperienceIds.Add(
                learningExperienceId);
        }
    }
}