namespace EIA.Domain.Entities.Buildings;

public class BuildingEntrance
{
    public string Name { get; private set; }

    public bool Open { get; private set; }

    public BuildingEntrance(string name)
    {
        Name = name;

        Open = true;
    }

    public void OpenEntrance()
    {
        Open = true;
    }

    public void CloseEntrance()
    {
        Open = false;
    }
}