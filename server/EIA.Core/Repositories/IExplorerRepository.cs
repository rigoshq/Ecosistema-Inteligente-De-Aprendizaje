using EIA.Domain.Entities.Explorer;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EIA.Core.Repositories;

public interface IExplorerRepository
{
    Task AddAsync(Explorer explorer);
    Task<List<Explorer>> GetAllAsync();
    Task<Explorer?> GetByIdAsync(Guid id);
}
