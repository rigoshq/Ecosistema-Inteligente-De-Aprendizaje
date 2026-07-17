using EIA.Core.Repositories;
using EIA.Domain.Entities;

namespace EIA.Infrastructure.Repositories;

public class ExplorerRepository : IExplorerRepository
{
    private static readonly List<Explorer> _explorers = new();

    public Task AddAsync(Explorer explorer)
    {
        _explorers.Add(explorer);
        return Task.CompletedTask;
    }

    public Task<List<Explorer>> GetAllAsync()
    {
        return Task.FromResult(_explorers);
    }
}