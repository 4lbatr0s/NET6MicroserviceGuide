

using AutoMapper;
using Services.PlatformService.src.Contracts;
using Services.PlatformService.src.Entities.Models;
using Services.PlatformService.src.Shared.DataTransferObjects;

namespace Services.PlatformService.src.Service.Contracts;

public class PlatformService:IPlatformService
{
    private readonly IRepositoryManager _repositoryManager;
    private readonly IMapper _mapper;
    public PlatformService(IRepositoryManager repositoryManager, IMapper mapper)
    {
        _repositoryManager = repositoryManager;
        _mapper = mapper;
    }

    public async Task<PlatformDto> CreatePlatformAsync(PlatformForCreationDto creationDto)
    {
        //Destination=>Resource
        var platformEntity = _mapper.Map<Platform>(creationDto);
        _repositoryManager.Platform.Create(platformEntity);
        await _repositoryManager.SaveAsync();
        var platformToReturn = _mapper.Map<PlatformDto>(platformEntity);
        return platformToReturn;
    }

    public Task<IEnumerable<PlatformDto>> GetAllPlatformsAsync()
    {
        throw new NotImplementedException();
    }
}