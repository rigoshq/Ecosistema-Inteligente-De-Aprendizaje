namespace EIA.Domain.Entities.LearningExperiences;

public class LearningStage
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public int Order { get; private set; }

    public LearningStage(
        string name,
        int order)
    {
        Id = Guid.NewGuid();

        Name = name;

        Order = order;
    }
}