

using Services.PlatformService.src.Shared.DataTransferObjects;

namespace Services.PlatformService.src.Service.Contracts;

public interface IPlatformService
{
    Task<PlatformDto> CreatePlatformAsync (PlatformForCreationDto  creationDto);
    Task<IEnumerable<PlatformDto>> GetAllPlatformsAsync ();
}