namespace EIA.Domain.Entities.Dialogue;

public class DialogueCondition
{
    public int MinimumLevel { get; }

    public bool MissionCompleted { get; }

    public DialogueCondition(
        int minimumLevel,
        bool missionCompleted)
    {
        MinimumLevel = minimumLevel;

        MissionCompleted = missionCompleted;
    }
}