
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Services.PlatformService.src.Contracts;

namespace Services.PlatformService.src.Repository;

public abstract class RepositoryBase<T>:IRepositoryBase<T> where T : class
{
    protected RepositoryContext _repositoryContext;
    public RepositoryBase(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
    }

    public void Create(T value)
    {
        _repositoryContext.Set<T>().Add(value);
    }

    public void Delete(T value)
    {
        _repositoryContext.Set<T>().Remove(value);
    }

    public IQueryable<T> FindAll(bool trackChanges)
    {
        return !trackChanges ? 
        _repositoryContext.Set<T>().AsNoTracking():
        _repositoryContext.Set<T>();
    }

    public IQueryable<T> FindAllByCondition(Expression<Func<T, bool>> condition, bool trackChanges)
    {
        return !trackChanges ? 
        _repositoryContext.Set<T>().Where(condition).AsNoTracking():
        _repositoryContext.Set<T>().Where(condition);
    }

    public void Update(T value)
    {
        _repositoryContext.Set<T>().Update(value);

    }
}