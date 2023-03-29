
using Microsoft.EntityFrameworkCore;
using Services.PlatformService.src.Contracts;
using Services.PlatformService.src.Entities.Models;

namespace Services.PlatformService.src.Repository;

public class PlatformRepository: RepositoryBase<Platform>, IPlatformRepository{

    public PlatformRepository(RepositoryContext context):base(context)//INFO: Invokes RepositoryBase's constructor.
    {
        
    }

    public void CreatePlatform(Platform platform)
    {
        Create(platform);
    }

    public void DeletePlatform(Platform platform)
    {
        Delete(platform);
    }

    public async Task<IEnumerable<Platform>> GetAllPlatforms(bool trackChanges)
    {
        return await FindAll(trackChanges).OrderBy(p=>p.Name).ToListAsync();;
    }

    public async Task<Platform> GetPlatformById(Guid Id, bool trackChanges)
    {
        return await FindAllByCondition(c=> c.Id.Equals(Id), trackChanges).SingleOrDefaultAsync();
    }
}