
using System.Linq.Expressions;

namespace Services.PlatformService.src.Contracts;
public interface IRepositoryBase<T>{
    IQueryable<T> FindAll(bool trackChanges);
    IQueryable<T> FindAllByCondition (Expression<Func<T, bool>> condition, bool trackChanges);
    void Update(T value);
    void Delete(T value);
    void Create(T value);
}