namespace EIA.Domain.Entities.Missions;

public class ExplorerMission
{
    public Guid Id { get; private set; }

    public Guid MissionId { get; private set; }

    public DateTime AcceptedAt { get; private set; }

    public DateTime? CompletedAt { get; private set; }

    public bool Completed { get; private set; }

    public int CurrentStep { get; private set; }

    public ExplorerMission()
    {
        Id = Guid.NewGuid();
    }

    public ExplorerMission(Guid missionId)
        : this()
    {
        MissionId = missionId;
        AcceptedAt = DateTime.UtcNow;
        CurrentStep = 1;
    }

    public void Complete()
    {
        Completed = true;
        CompletedAt = DateTime.UtcNow;
    }

    public void NextStep()
    {
        CurrentStep++;
    }
}