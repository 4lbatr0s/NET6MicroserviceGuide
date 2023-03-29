
using Services.PlatformService.src.Entities.Models;

namespace Services.PlatformService.src.Contracts;

public interface IPlatformRepository:IRepositoryBase<Platform>{ 
    Task<IEnumerable<Platform>> GetAllPlatforms(bool trackChanges);
    Task<Platform> GetPlatformById(Guid Id, bool trackChanges);
    void CreatePlatform(Platform platform);
    void DeletePlatform(Platform platform);
}