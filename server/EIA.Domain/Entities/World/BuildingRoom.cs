namespace EIA.Domain.Entities.World;

public class BuildingRoom
{
    public Guid Id { get; }

    public string Name { get; }

    public int Capacity { get; }


    public BuildingRoom(
        string name,
        int capacity)
    {
        Id = Guid.NewGuid();

        Name = name;

        Capacity = capacity;
    }
}