namespace EIA.Domain.Entities.Interactions;

public class InteractionRequirement
{
    public int MinimumLevel { get; }

    public bool MissionRequired { get; }

    public Guid? RequiredMissionId { get; }

    public InteractionRequirement(
        int minimumLevel,
        bool missionRequired,
        Guid? requiredMissionId)
    {
        MinimumLevel = minimumLevel;

        MissionRequired = missionRequired;

        RequiredMissionId = requiredMissionId;
    }
}