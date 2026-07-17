namespace EIA.Domain.Entities;

public class LearningWorld
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public List<KnowledgeCity> Cities { get; private set; }

    public LearningWorld(string name)
    {
        Id = Guid.NewGuid();
        Name = name;
        Cities = new List<KnowledgeCity>();
    }

    public void AddCity(KnowledgeCity city)
    {
        Cities.Add(city);
    }
}