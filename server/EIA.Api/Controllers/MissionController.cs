using EIA.Core.Missions;
using Microsoft.AspNetCore.Mvc;

namespace EIA.Api.Controllers;

[ApiController]
[Route("api/missions")]
public class MissionController : ControllerBase
{
    private readonly MissionService _missionService;

    public MissionController(MissionService missionService)
    {
        _missionService = missionService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(_missionService.GetAll());
    }
}