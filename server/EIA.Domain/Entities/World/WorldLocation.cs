namespace EIA.Domain.Entities.World;

public class WorldLocation
{
    public Guid Id { get; }

    public string Name { get; }

    public string Description { get; }

    public string Image { get; }

    public List<WorldLocation> ConnectedLocations { get; }

    public List<Guid> Buildings { get; }

    public List<Guid> Npcs { get; }

    public bool IsInitialLocation { get; }

    public WorldLocation(
        string name,
        string description,
        string image,
        bool isInitialLocation = false)
    {
        Id = Guid.NewGuid();

        Name = name;

        Description = description;

        Image = image;

        IsInitialLocation = isInitialLocation;

        ConnectedLocations = new();

        Buildings = new();

        Npcs = new();
    }

    public void Connect(WorldLocation location)
    {
        if (ConnectedLocations.Contains(location))
            return;

        ConnectedLocations.Add(location);
    }

    public void AddBuilding(Guid buildingId)
    {
        if (!Buildings.Contains(buildingId))
            Buildings.Add(buildingId);
    }

    public void AddNpc(Guid npcId)
    {
        if (!Npcs.Contains(npcId))
            Npcs.Add(npcId);
    }
}