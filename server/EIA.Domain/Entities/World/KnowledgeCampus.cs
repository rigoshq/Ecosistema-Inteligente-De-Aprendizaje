using EIA.Domain.Entities.World.Enums;

namespace EIA.Domain.Entities.World;

public class KnowledgeCampus
{
    public Guid Id { get; }

    public string Name { get; }

    public CampusType Type { get; }

    public List<KnowledgeBuilding> Buildings { get; }

    public KnowledgeCampus(
        string name,
        CampusType type)
    {
        Id = Guid.NewGuid();

        Name = name;

        Type = type;

        Buildings = new();
    }

    public void AddBuilding(KnowledgeBuilding building)
    {
        Buildings.Add(building);
    }
}