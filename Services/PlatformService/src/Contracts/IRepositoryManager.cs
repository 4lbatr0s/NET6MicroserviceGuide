
using System.Linq.Expressions;

namespace Services.PlatformService.src.Contracts;
public interface IRepositoryManager{
    IPlatformRepository Platform {get;}
    Task SaveAsync();//INFO: We're going to implement this function in the RepositoryManger, it will be our EF Core saving action.
}