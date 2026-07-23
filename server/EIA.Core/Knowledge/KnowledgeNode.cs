namespace EIA.Core.Knowledge;

public class KnowledgeNode
{
    public Guid Id { get; }

    public string Name { get; }

    public string Description { get; }

    public KnowledgeNode(
        string name,
        string description)
    {
        Id = Guid.NewGuid();

        Name = name;

        Description = description;
    }
}