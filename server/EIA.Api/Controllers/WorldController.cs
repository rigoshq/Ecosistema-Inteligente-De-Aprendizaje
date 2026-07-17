using EIA.Core.World;
using Microsoft.AspNetCore.Mvc;

namespace EIA.Api.Controllers;

[ApiController]
[Route("api/world")]
public class WorldController : ControllerBase
{
    private readonly WorldService _worldService;

    public WorldController(WorldService worldService)
    {
        _worldService = worldService;
    }

    [HttpGet]
    public IActionResult GetWorld()
    {
        return Ok(_worldService.World);
    }
}