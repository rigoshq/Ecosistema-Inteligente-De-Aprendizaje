using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EIA.Core.DTOs;
using EIA.Core.Repositories;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.Services;

public class ExplorerService
{
    private readonly IExplorerRepository _repository;

    public ExplorerService(IExplorerRepository repository)
    {
        _repository = repository ?? throw new ArgumentNullException(nameof(repository));
    }

    public async Task<Explorer> RegisterAsync(ExplorerRegistrationDto dto)
    {
        // ✅ Usamos el constructor de la entidad con los 4 parámetros requeridos
        var newExplorer = new Explorer(
            firstName: dto.FirstName,
            lastName: dto.LastName,
            userName: dto.UserName,
            email: dto.Email // ⚠️ Aquí está el parámetro que faltaba
        );

        await _repository.AddAsync(newExplorer);
        return newExplorer;
    }

    public async Task<List<Explorer>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }

    public async Task<Explorer?> GetByIdAsync(Guid id)
    {
        return await _repository.GetByIdAsync(id);
    }
}
