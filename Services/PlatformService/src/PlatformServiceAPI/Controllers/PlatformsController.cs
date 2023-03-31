using Microsoft.AspNetCore.Mvc;
using Services.PlatformService.src.Service.Contracts;
using Services.PlatformService.src.Shared.DataTransferObjects;

namespace PlatformServiceAPI.Controllers;

[ApiController]
[Route("api/platforms")]
public class PlatformsController : ControllerBase
{

    private readonly IServiceManager _serviceManager;
    public PlatformsController(IServiceManager serviceManager)
    {
        _serviceManager = serviceManager;
    }

    [HttpGet]
    public async Task<IActionResult> GellAllPlatformsAsync()
    {
        var result = await _serviceManager.PlatformService.GetAllPlatformsAsync(trackChanges: false);
        return Ok(result);
    }

    [HttpGet("{id:guid}", Name = "PlatformById")]//INFO: Our path is api/companies/id, our id's type is GUID!
    public async Task<IActionResult> GetPlatform(Guid id)
    {
        var platform = await _serviceManager.PlatformService.GetPlatformByIdAsync(id, trackChanges: false);
        return Ok(platform);
    }

    [HttpPost]
    public async Task<IActionResult> CreateCompany([FromBody] PlatformForCreationDto platform)
    {
        var createdPlatform = await _serviceManager.PlatformService.CreatePlatformAsync(platform);
        return CreatedAtRoute("PlatformById", new { id = createdPlatform.Id }, createdPlatform); //INFO: How to return a static object.
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeletePlatform(Guid platformId)
    {
        await _serviceManager.PlatformService.DeletePlatformAsync(platformId, trackChanges: false);
        return NoContent();
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteEmployeeForCompany(Guid platformId, Guid id)
    {
        await _serviceManager.PlatformService.DeletePlatformAsync(platformId, trackChanges: false);
        return NoContent();
    }


}
