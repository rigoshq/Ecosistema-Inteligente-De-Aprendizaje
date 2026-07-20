namespace EIA.Domain.Entities.Missions;

public class MissionRequirement
{
    public Guid Id { get; private set; }

    public Guid MissionId { get; private set; }

    public string RequirementType { get; private set; }

    public string Value { get; private set; }

    public MissionRequirement()
    {
        Id = Guid.NewGuid();

        RequirementType = string.Empty;

        Value = string.Empty;
    }

    public MissionRequirement(
        Guid missionId,
        string requirementType,
        string value)
        : this()
    {
        MissionId = missionId;
        RequirementType = requirementType;
        Value = value;
    }
}