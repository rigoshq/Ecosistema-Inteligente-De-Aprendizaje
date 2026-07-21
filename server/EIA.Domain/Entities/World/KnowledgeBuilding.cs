using EIA.Domain.Entities.World.Enums;

namespace EIA.Domain.Entities.World;

public class KnowledgeBuilding
{
    public Guid Id { get; }

    public string Name { get; }

    public BuildingCategory Category { get; }

    public List<BuildingFloor> Floors { get; }

    public KnowledgeBuilding(
        string name,
        BuildingCategory category)
    {
        Id = Guid.NewGuid();

        Name = name;

        Category = category;

        Floors = new();
    }

    public void AddFloor(BuildingFloor floor)
    {
        Floors.Add(floor);
    }
}