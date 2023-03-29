

using Services.PlatformService.src.Contracts;

namespace Services.PlatformService.src.Service.Contracts;

public class PlatformService:IPlatformService
{
    private readonly IRepositoryManager _repositoryManager;
    public PlatformService(IRepositoryManager repositoryManager)
    {
        _repositoryManager = repositoryManager;
    }
}