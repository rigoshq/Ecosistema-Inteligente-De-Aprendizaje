namespace EIA.Domain.Entities.World;

public class KnowledgeCity
{
    public Guid Id { get; }

    public string Name { get; }

    public List<KnowledgeDistrict> Districts { get; }

    public List<KnowledgeCampus> Campuses { get; }


    public KnowledgeCity(
        string name)
    {
        Id = Guid.NewGuid();

        Name = name;

        Districts = new();

        Campuses = new();
    }


    public void AddDistrict(
        KnowledgeDistrict district)
    {
        Districts.Add(district);
    }


    public void AddCampus(
        KnowledgeCampus campus)
    {
        Campuses.Add(campus);
    }
}