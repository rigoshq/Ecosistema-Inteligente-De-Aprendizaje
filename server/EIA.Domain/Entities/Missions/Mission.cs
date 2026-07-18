namespace EIA.Domain.Entities.Missions;

public class Mission
{
    public Guid Id { get; }

    public string Code { get; }

    public string Name { get; private set; }

    public string Description { get; private set; }

    public string Subject { get; private set; }

    public int Experience { get; private set; }
    
    public MissionStatus Status { get; private set; }

    public Mission(
        string code,
        string name,
        string description,
        string subject,
        int experience)
    {
        Id = Guid.NewGuid();

        Code = code;

        Name = name;

        Description = description;

        Subject = subject;

        Experience = experience;

        Status = MissionStatus.Available;
    }

    public void Start()
    {
    Status = MissionStatus.InProgress;
    }

    public void Complete()
    {
    Status = MissionStatus.Completed;
    }
}