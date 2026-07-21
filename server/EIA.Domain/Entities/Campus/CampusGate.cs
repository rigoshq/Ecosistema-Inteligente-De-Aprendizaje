namespace EIA.Domain.Entities.Campus;

public class CampusGate
{
    public string Name { get; private set; }

    public bool Open { get; private set; }

    public CampusGate(string name)
    {
        Name = name;

        Open = true;
    }

    public void OpenGate()
    {
        Open = true;
    }

    public void CloseGate()
    {
        Open = false;
    }
}