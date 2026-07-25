namespace EIA.Domain.Entities.World;

public class KnowledgeDistrict
{
    public Guid Id { get; }

    public string Name { get; }

    public string Description { get; }

    public string Icon { get; }

    public List<Guid> Buildings { get; }

    public List<Guid> NPCs { get; }

    public List<Guid> Laboratories { get; }

    public KnowledgeDistrict(
        string name,
        string description,
        string icon)
    {
        Id = Guid.NewGuid();

        Name = name;

        Description = description;

        Icon = icon;

        Buildings = new();

        NPCs = new();

        Laboratories = new();
    }

    public void AddBuilding(Guid buildingId)
    {
        if (!Buildings.Contains(buildingId))
            Buildings.Add(buildingId);
    }

    public void AddNpc(Guid npcId)
    {
        if (!NPCs.Contains(npcId))
            NPCs.Add(npcId);
    }

    public void AddLaboratory(Guid laboratoryId)
    {
        if (!Laboratories.Contains(laboratoryId))
            Laboratories.Add(laboratoryId);
    }
}