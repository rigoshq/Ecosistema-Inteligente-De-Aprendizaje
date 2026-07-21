namespace EIA.Domain.Entities.World;

public class InteractiveObject
{
    public Guid Id { get; }

    public string Name { get; }

    public bool Enabled { get; private set; }

    public InteractiveObject(string name)
    {
        Id = Guid.NewGuid();

        Name = name;

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