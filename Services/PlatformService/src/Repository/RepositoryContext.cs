using Services.PlatformService.src.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Services.PlatformService.src.Repository;

public class RepositoryContext:DbContext{

    public RepositoryContext(DbContextOptions options):base(options)
    {
        
    }    
    //INFO: For database seeding!
    protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder); //Configures the schema for the identity framework!
        modelBuilder.ApplyConfiguration(new PlatformConfiguration());
    }

    DbSet<Platform>? Platforms {get;set;}
}