using EIA.Domain.Entities.Explorer;
using EIA.Domain.Entities.Missions;

namespace EIA.Core.Missions;

public class MissionService
{
    private readonly List<Mission> _missions;

    public MissionService()
    {
        _missions = new();
    }

    public void Load(IEnumerable<Mission> missions)
    {
        _missions.Clear();
        _missions.AddRange(missions);
    }

    public IReadOnlyCollection<Mission> GetAll()
    {
        return _missions.AsReadOnly();
    }

    public Mission? GetById(Guid id)
    {
        return _missions.FirstOrDefault(m => m.Id == id);
    }

    public IReadOnlyCollection<Mission> GetAvailable(int explorerLevel)
    {
        return _missions
            .Where(m => m.CanBeAccepted(explorerLevel))
            .ToList()
            .AsReadOnly();
    }

    public bool StartMission(
        Explorer explorer,
        Guid missionId)
    {
        var mission = GetById(missionId);

        if (mission is null)
            return false;

        mission.Start();

        return true;
    }

    public bool CompleteMission(
        Explorer explorer,
        Guid missionId)
    {
        var mission = GetById(missionId);

        if (mission is null)
            return false;

        mission.Complete();

        return true;
    }

    public bool ClaimReward(
        Explorer explorer,
        Guid missionId)
    {
        var mission = GetById(missionId);

        if (mission is null)
            return false;

        mission.ClaimReward();

        return true;
    }
}