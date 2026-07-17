using EIA.Core.DTOs;
using EIA.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace EIA.Api.Controllers;

[ApiController]
[Route("api/explorers")]
public class ExplorerController : ControllerBase
{
    private readonly ExplorerService _service;

    public ExplorerController(ExplorerService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var explorers = await _service.GetAllAsync();
        return Ok(explorers);
    }

    [HttpPost]
    public async Task<IActionResult> Create(
        ExplorerRegistrationDto dto)
    {
        await _service.RegisterAsync(dto);

        return Ok(new
        {
            Message = "Explorer created successfully."
        });
    }
}