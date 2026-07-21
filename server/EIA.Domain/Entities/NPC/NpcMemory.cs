namespace EIA.Domain.Entities.NPC;

public class NpcMemory
{
    public DateTime LastInteraction { get; private set; }

    public Guid? LastMissionId { get; private set; }

    public string LastTopic { get; private set; }

    public int TotalInteractions { get; private set; }

    public NpcMemory()
    {
        LastTopic = string.Empty;

        TotalInteractions = 0;
    }

    public void RegisterInteraction(
        Guid? missionId,
        string topic)
    {
        LastInteraction = DateTime.UtcNow;

        LastMissionId = missionId;

        LastTopic = topic;

        TotalInteractions++;
    }
}