using EIA.Domain.Entities.Explorer; // ⚠️ Namespace actualizado
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EIA.Core.Repositories;

public class ExplorerRepository : IExplorerRepository
{
    // ⚠️ NOTA: Esto es una lista en memoria de ejemplo. 
    // Si usas Entity Framework Core, aquí inyectarías tu DbContext.
    private readonly List<Explorer> _explorers = new(); 

    public Task AddAsync(Explorer explorer)
    {
        _explorers.Add(explorer);
        return Task.CompletedTask;
    }

    public Task<List<Explorer>> GetAllAsync()
    {
        return Task.FromResult(_explorers);
    }

    public Task<Explorer?> GetByIdAsync(Guid id)
    {
        var explorer = _explorers.FirstOrDefault(x => x.Id == id);
        return Task.FromResult(explorer);
    }
}