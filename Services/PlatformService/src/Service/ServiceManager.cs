
using Services.PlatformService.src.Contracts;

namespace Services.PlatformService.src.Service.Contracts;

public sealed class ServiceManager:IServiceManager
{
    private readonly Lazy<IPlatformService> _platformService;

    public ServiceManager(IRepositoryManager repositoryManager)
    {   
        _platformService = new Lazy<IPlatformService>(()=> new PlatformService(repositoryManager));
    }


    IPlatformService PlatformService => _platformService.Value;
}