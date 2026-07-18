using DevTrack.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevTrack.Controllers;

[ApiController]
[Route("api/[controller]")]
public class TechnologiesController : ControllerBase
{
    private readonly ITechnologyService _service;

    public TechnologiesController(ITechnologyService technologyService)
    {
        _service = technologyService;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var technologies = await _service.GetAllAsync();

        return Ok(technologies);
    }
}