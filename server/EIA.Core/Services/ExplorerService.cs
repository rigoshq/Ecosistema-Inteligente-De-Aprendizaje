using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EIA.Core.DTOs;
using EIA.Core.Pipeline;
using EIA.Core.Repositories;
using EIA.Domain.Entities.Explorer;

namespace EIA.Core.Services;

public class ExplorerService
{
    private readonly IExplorerRepository _repository;

    private readonly ExplorerIntelligencePipeline _pipeline;

    public ExplorerService(
        IExplorerRepository repository,
        ExplorerIntelligencePipeline pipeline)
    {
        _repository = repository
            ?? throw new ArgumentNullException(nameof(repository));

        _pipeline = pipeline
            ?? throw new ArgumentNullException(nameof(pipeline));
    }

    public async Task<Explorer> RegisterAsync(
        ExplorerRegistrationDto dto)
    {
        var newExplorer = new Explorer(
            firstName: dto.FirstName,
            lastName: dto.LastName,
            userName: dto.UserName,
            email: dto.Email
        );

        await _repository.AddAsync(newExplorer);

        //------------------------------------------------------
        // Próximamente:
        //
        // Crear AcademicRecord
        // Inicializar Cognitive Twin
        // Inicializar Educational Memory
        // Inicializar Knowledge Genome
        // Ejecutar ExplorerIntelligencePipeline
        //------------------------------------------------------

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