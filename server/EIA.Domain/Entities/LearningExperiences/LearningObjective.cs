namespace EIA.Domain.Entities.LearningExperiences;

public class LearningObjective
{
    public Guid Id { get; private set; }

    public string Description { get; private set; }

    public bool Completed { get; private set; }

    public LearningObjective(string description)
    {
        Id = Guid.NewGuid();

        Description = description;

        Completed = false;
    }

    public void Complete()
    {
        Completed = true;
    }
}