

using System.Diagnostics;
using AutoMapper;
using Services.PlatformService.src.Contracts;
using Services.PlatformService.src.Entities.Exceptions;
using Services.PlatformService.src.Entities.Models;
using Services.PlatformService.src.Shared.DataTransferObjects;

namespace Services.PlatformService.src.Service.Contracts;

public class PlatformService : IPlatformService
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

    public async Task DeletePlatformAsync(Guid platformId, bool trackChanges)
    {
        var platform = await GetPlatformAndCheckIfItExists(platformId, trackChanges);
        _repositoryManager.Platform.DeletePlatform(platform);
        await _repositoryManager.SaveAsync();
    }

    public async Task<IEnumerable<PlatformDto>> GetAllPlatformsAsync(bool trackChanges)
    {
        var companies = await _repositoryManager.Platform.GetAllPlatforms(trackChanges);
        var companyDtos = _mapper.Map<IEnumerable<PlatformDto>>(companies); //INFO: Destination => Resource, opposite of Mapping Profile!
        return companyDtos;
    }

    public async Task<PlatformDto> GetPlatformByIdAsync(Guid platformId, bool trackChanges)
    {
        var platformEntity = await GetPlatformAndCheckIfItExists(platformId, trackChanges);
        var platformDto = _mapper.Map<PlatformDto>(platformEntity);
        return platformDto;
    }

    public async Task UpdatePlatformAsync(Guid platformId, PlatformForUpdateDto platformForUpadteDto, bool trackChanges)
    {
        var platformEntity = await GetPlatformAndCheckIfItExists(platformId, trackChanges);
        _mapper.Map(platformForUpadteDto, platformEntity);
        await _repositoryManager.SaveAsync();
    }


    //INFO: Private methods for implementing the DRY principle
    private async Task<Platform> GetPlatformAndCheckIfItExists(Guid platformId, bool trackChanges)
    {
        var company = await _repositoryManager.Platform.GetPlatformById(platformId, trackChanges);
        if (company is null)
            throw new PlatformNotFoundException(platformId);
        return company;
    }
}