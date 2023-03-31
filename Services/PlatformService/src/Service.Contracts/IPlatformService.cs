

using Services.PlatformService.src.Shared.DataTransferObjects;

namespace Services.PlatformService.src.Service.Contracts;

public interface IPlatformService
{
    Task<PlatformDto> CreatePlatformAsync (PlatformForCreationDto  creationDto);
    Task<IEnumerable<PlatformDto>> GetAllPlatformsAsync (bool trackChanges);
    
    Task<PlatformDto> GetPlatformByIdAsync (Guid platformId, bool trackChanges);

    Task DeletePlatformAsync (Guid platformId, bool trackChanges);
    Task UpdatePlatformAsync (Guid platformId, PlatformForUpdateDto platformForUpdateDto, bool trackChanges);

}