using Services.PlatformService.src.Contracts;

namespace Services.PlatformService.src.Repository;

public sealed class RepositoryManger : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IPlatformRepository> _platformRepository;


    public RepositoryManger(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _platformRepository = new Lazy<IPlatformRepository>(()=> new PlatformRepository(repositoryContext));

    }
    public async Task SaveAsync()
    {
        await _repositoryContext.SaveChangesAsync();
    }


    public IPlatformRepository Platform => _platformRepository.Value;

}