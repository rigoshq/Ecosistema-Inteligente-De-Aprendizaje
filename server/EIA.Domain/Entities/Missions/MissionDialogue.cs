namespace EIA.Domain.Entities.Missions;

public class MissionDialogue
{
    public Guid Id { get; private set; }

    public Guid MissionId { get; private set; }

    public Guid NpcId { get; private set; }

    public int Sequence { get; private set; }

    public string Text { get; private set; }

    public MissionDialogue()
    {
        Id = Guid.NewGuid();

        Text = string.Empty;
    }

    public MissionDialogue(
        Guid missionId,
        Guid npcId,
        int sequence,
        string text)
        : this()
    {
        MissionId = missionId;
        NpcId = npcId;
        Sequence = sequence;
        Text = text;
    }
}