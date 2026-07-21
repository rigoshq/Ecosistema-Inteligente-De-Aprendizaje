namespace EIA.Domain.Entities.Buildings;

public class BuildingFloor
{
    public int Level { get; private set; }

    public string Name { get; private set; }

    public BuildingFloor(
        int level,
        string name)
    {
        Level = level;

        Name = name;
    }
}