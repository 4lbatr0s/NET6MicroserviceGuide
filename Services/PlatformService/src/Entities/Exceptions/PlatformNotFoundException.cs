

namespace Services.PlatformService.src.Entities.Exceptions;

public sealed class PlatformNotFoundException:NotFoundException{
    public PlatformNotFoundException(Guid platformId):base($"The platform with id:${platformId} doesn't exist in the database")
    {

    }
}