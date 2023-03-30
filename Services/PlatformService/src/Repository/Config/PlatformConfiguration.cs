using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Services.PlatformService.src.Entities.Models;

public class PlatformConfiguration : IEntityTypeConfiguration<Platform>
{
    //INFO:To invoke this configuration, we have to change the RepositoryContext class
    public void Configure(EntityTypeBuilder<Platform> builder)
    {
        builder.HasData
        (
        new Platform
        {
            Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
            Name = "Dotnet",
            Publisher = "Microsoft",
            Cost = "Free"
        },
        new Platform
        {
            Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
            Name = "SQL Server Express",
            Publisher = "Microsoft",
            Cost = "Free"
        },
                new Platform
                {
                    Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                    Name = "Kubernetes",
                    Publisher = "Cloud Native Computing",
                    Cost = "Free"
                }
        );
    }
}