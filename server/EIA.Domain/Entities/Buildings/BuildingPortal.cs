namespace EIA.Domain.Entities.Buildings;

public class BuildingPortal
{
    public string Destination { get; private set; }

    public bool Enabled { get; private set; }

    public BuildingPortal(string destination)
    {
        Destination = destination;

        Enabled = true;
    }

    public void Enable()
    {
        Enabled = true;
    }

    public void Disable()
    {
        Enabled = false;
    }
}