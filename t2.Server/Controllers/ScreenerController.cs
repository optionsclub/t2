using Microsoft.AspNetCore.Mvc;

namespace t2.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ScreenerController : ControllerBase
{
    [HttpGet("volume")]
    public IActionResult GetVolume()
    {
        var data = new[]
        {
            new
            {
                Symbol="RELIANCE",
                Volume=2500000,
                AvgVolume=1000000,
                RVOL=2.5
            },
            new
            {
                Symbol="HDFCBANK",
                Volume=1800000,
                AvgVolume=1200000,
                RVOL=1.5
            }
        };

        return Ok(data);
    }
}