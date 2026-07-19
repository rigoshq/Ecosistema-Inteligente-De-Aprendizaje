namespace EIA.Domain.Entities.Missions;

public class ExplorerMission
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public Guid MissionId { get; set; }

    public string MissionCode { get; set; } = "";

    public string MissionName { get; set; } = "";

    public DateTime AcceptedAt { get; set; }

    public DateTime? CompletedAt { get; set; }

    public bool Completed { get; private set; }

    public void Complete()
    {
        Completed = true;
        CompletedAt = DateTime.UtcNow;
    }
}