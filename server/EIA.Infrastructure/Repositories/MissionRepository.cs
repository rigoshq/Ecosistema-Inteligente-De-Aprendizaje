using EIA.Core.Interfaces;
using EIA.Domain.Entities.Missions;
using EIA.Infrastructure.Seed;

namespace EIA.Infrastructure.Repositories;

public class MissionRepository : IMissionRepository
{
    private readonly List<Mission> _missions;

    public MissionRepository()
    {
        _missions = MissionSeeder.Create();
    }

    public Task<List<Mission>> GetAllAsync()
    {
        return Task.FromResult(_missions);
    }

    public Task<Mission?> GetByIdAsync(Guid id)
    {
        return Task.FromResult(
            _missions.FirstOrDefault(m => m.Id == id));
    }

    public Task AddAsync(Mission mission)
    {
        _missions.Add(mission);
        return Task.CompletedTask;
    }

    public Task UpdateAsync(Mission mission)
    {
        return Task.CompletedTask;
    }

    public Task DeleteAsync(Guid id)
    {
        var mission = _missions.FirstOrDefault(x => x.Id == id);

        if (mission != null)
            _missions.Remove(mission);

        return Task.CompletedTask;
    }
}