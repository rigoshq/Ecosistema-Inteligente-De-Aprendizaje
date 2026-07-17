using Microsoft.AspNetCore.Mvc;

namespace EIA.Api.Controllers;

[ApiController]
[Route("api/system")]
public class SystemController : ControllerBase
{
    [HttpGet("status")]
    public IActionResult Status()
    {
        return Ok(new
        {
            Application = "EIA",
            Version = "0.1.0",
            Status = "Running",
            Timestamp = DateTime.UtcNow
        });
    }
}