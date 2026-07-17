using EIA.Core.DTOs;
using EIA.Core.Repositories;
using EIA.Domain.Entities;

namespace EIA.Core.Services;

public class ExplorerService
{
    private readonly IExplorerRepository _repository;

    public ExplorerService(IExplorerRepository repository)
    {
        _repository = repository;
    }

    public async Task RegisterAsync(ExplorerRegistrationDto dto)
    {
        var explorer = new Explorer(
            dto.FirstName,
            dto.LastName,
            dto.UserName,
            dto.Email);

        await _repository.AddAsync(explorer);
    }

    public async Task<List<Explorer>> GetAllAsync()
    {
        return await _repository.GetAllAsync();
    }
}