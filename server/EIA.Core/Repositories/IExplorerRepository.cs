using EIA.Domain.Entities;

namespace EIA.Core.Repositories;

public interface IExplorerRepository
{
    Task AddAsync(Explorer explorer);

    Task<List<Explorer>> GetAllAsync();
}