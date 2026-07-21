namespace EIA.Domain.Entities.Campus;

public class Campus
{
    public Guid Id { get; private set; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public CampusEnvironment Environment { get; private set; }

    public CampusGate MainGate { get; private set; }

    public CampusSpawnPoint SpawnPoint { get; private set; }

    public CampusMusic Music { get; private set; }

    public bool Active { get; private set; }

    private Campus()
    {
        Id = Guid.NewGuid();

        Name = string.Empty;

        Description = string.Empty;

        Environment = new CampusEnvironment();

        MainGate = new CampusGate("Entrada Principal");

        SpawnPoint = new CampusSpawnPoint(
            0,
            0,
            0,
            0);

        Music = new CampusMusic(
            "CampusTheme",
            0.5f,
            true);

        Active = true;
    }

    public Campus(
        string name,
        string description)
        : this()
    {
        Name = name;

        Description = description;
    }

    public void Activate()
    {
        Active = true;
    }

    public void Deactivate()
    {
        Active = false;
    }

    public void OpenCampus()
    {
        MainGate.OpenGate();
    }

    public void CloseCampus()
    {
        MainGate.CloseGate();
    }
}