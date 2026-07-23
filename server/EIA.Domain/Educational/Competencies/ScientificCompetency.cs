namespace EIA.Domain.Educational.Competencies;

public class ScientificCompetency
{
    public Guid Id { get; }

    public string Name { get; }

    public string Description { get; }

    public ScientificCompetency(
        string name,
        string description)
    {
        Id = Guid.NewGuid();

        Name = name;

        Description = description;
    }
}