using Microsoft.AspNetCore.Mvc;
using DevTrack.Models;

namespace DevTrack.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TechnologiesController : ControllerBase
{
    private static readonly List<Technology> technologies = new();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(technologies);
    }
}