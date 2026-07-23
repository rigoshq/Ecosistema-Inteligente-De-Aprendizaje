namespace EIA.Domain.Learning.Competencies;

public class LearningCompetency
{
    public Guid Id { get; }

    public string Code { get; }

    public string Name { get; }

    public string Description { get; }

    public LearningCompetency(
        string code,
        string name,
        string description)
    {
        Id = Guid.NewGuid();

        Code = code;

        Name = name;

        Description = description;
    }
}