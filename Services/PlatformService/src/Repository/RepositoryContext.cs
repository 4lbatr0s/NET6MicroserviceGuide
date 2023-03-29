using Services.PlatformService.src.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Services.PlatformService.src.Repository;

public class RepositoryContext:DbContext{

    public RepositoryContext(DbContextOptions options):base(options)
    {
        
    }    

    DbSet<Platform>? Platforms {get;set;}
}