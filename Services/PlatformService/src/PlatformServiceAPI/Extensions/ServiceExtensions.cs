using Microsoft.EntityFrameworkCore;
using Services.PlatformService.src.Contracts;
using Services.PlatformService.src.Repository;
using Services.PlatformService.src.Service.Contracts;

namespace Services.PlatformService.src.PlatformServiceAPI.Extensions;

public static class ServiceExtensions
{
    //INFO: To make RepositoryContext run in Runtime instead of Design time:
    public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration) =>
    services.AddDbContext<RepositoryContext>(opts =>
        opts.UseNpgsql(configuration.GetConnectionString("PostgreSQLConnection"))
    );

    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
    services.AddScoped<IRepositoryManager, RepositoryManger>();
    public static void ConfigureServiceManager(this IServiceCollection services) =>
    services.AddScoped<IServiceManager, ServiceManager>();

}
