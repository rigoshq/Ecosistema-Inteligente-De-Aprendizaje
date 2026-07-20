using EIA.Domain.Entities.Missions;

namespace EIA.Core.Interfaces;

public interface IMissionRepository
{
    Task<List<Mission>> GetAllAsync();

    Task<Mission?> GetByIdAsync(Guid id);

    Task AddAsync(Mission mission);

    Task UpdateAsync(Mission mission);

    Task DeleteAsync(Guid id);
}