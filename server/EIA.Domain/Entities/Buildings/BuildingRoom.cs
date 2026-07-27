namespace EIA.Domain.Entities.Buildings;

public class BuildingRoom
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }


    public BuildingRoom(
        string name)
    {
        Id = Guid.NewGuid();

        Name = name;
    }
}