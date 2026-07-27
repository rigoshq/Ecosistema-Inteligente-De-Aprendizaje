namespace EIA.Domain.Entities.Explorer;

public class LearningJourney
{
    public Guid Id { get; }

    public Guid ExplorerId { get; }

    public DateTime StartedAt { get; }

    public DateTime? FinishedAt { get; private set; }

    public Guid? CurrentDistrictId { get; private set; }

    public Guid? CurrentBuildingId { get; private set; }

    public Guid? CurrentMissionId { get; private set; }

    public int CompletedMissions { get; private set; }

    public int ExperienceEarned { get; private set; }

    public bool IsFinished => FinishedAt != null;

    public LearningJourney(Guid explorerId)
    {
        Id = Guid.NewGuid();

        ExplorerId = explorerId;

        StartedAt = DateTime.UtcNow;
    }

    public void EnterDistrict(Guid districtId)
    {
        CurrentDistrictId = districtId;
    }

    public void EnterBuilding(Guid buildingId)
    {
        CurrentBuildingId = buildingId;
    }

    public void StartMission(Guid missionId)
    {
        CurrentMissionId = missionId;
    }

    public void CompleteMission(int experience)
    {
        CompletedMissions++;

        ExperienceEarned += experience;

        CurrentMissionId = null;
    }

    public void Finish()
    {
        FinishedAt = DateTime.UtcNow;
    }
}