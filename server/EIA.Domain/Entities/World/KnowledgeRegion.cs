using EIA.Domain.Entities.World.Enums;

namespace EIA.Domain.Entities.World;

public class KnowledgeRegion
{
    public Guid Id { get; }

    public string Name { get; }

    public RegionType Type { get; }

    public List<KnowledgeCity> Cities { get; }

    public KnowledgeRegion(
        string name,
        RegionType type)
    {
        Id = Guid.NewGuid();

        Name = name;

        Type = type;

        Cities = new();
    }

    public void AddCity(KnowledgeCity city)
    {
        Cities.Add(city);
    }
}