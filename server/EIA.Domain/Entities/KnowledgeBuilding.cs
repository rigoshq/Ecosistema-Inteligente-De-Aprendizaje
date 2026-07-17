namespace EIA.Domain.Entities;

public class KnowledgeBuilding
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Subject { get; private set; }

    public string Description { get; private set; }

    public KnowledgeBuilding(
        string name,
        string subject,
        string description)
    {
        Id = Guid.NewGuid();
        Name = name;
        Subject = subject;
        Description = description;
    }
}