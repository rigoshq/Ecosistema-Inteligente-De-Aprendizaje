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

    public IReadOnlyList<Mission> GetAll()
    {
        return _missions;
    }
}