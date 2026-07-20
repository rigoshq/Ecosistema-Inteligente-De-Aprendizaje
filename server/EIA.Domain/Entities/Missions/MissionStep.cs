using EIA.Domain.Entities.Missions.Enums;

namespace EIA.Domain.Entities.Missions;

public class MissionStep
{
    public Guid Id { get; private set; }

    public Guid MissionId { get; private set; }

    public int Order { get; private set; }

    public string Title { get; private set; }

    public string Description { get; private set; }

    public ObjectiveType ObjectiveType { get; private set; }

    public int TargetValue { get; private set; }

    public MissionStep()
    {
        Id = Guid.NewGuid();

        Title = string.Empty;

        Description = string.Empty;
    }

    public MissionStep(
        Guid missionId,
        int order,
        string title,
        string description,
        ObjectiveType objectiveType,
        int targetValue)
        : this()
    {
        MissionId = missionId;
        Order = order;
        Title = title;
        Description = description;
        ObjectiveType = objectiveType;
        TargetValue = targetValue;
    }
}