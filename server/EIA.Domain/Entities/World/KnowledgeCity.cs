namespace EIA.Domain.Entities.World;

public class KnowledgeCity
{
    public Guid Id { get; }

    public string Name { get; }

    public List<KnowledgeCampus> Campuses { get; }

    public KnowledgeCity(string name)
    {
        Id = Guid.NewGuid();

        Name = name;

        Campuses = new();
    }

    public void AddCampus(KnowledgeCampus campus)
    {
        Campuses.Add(campus);
    }
}