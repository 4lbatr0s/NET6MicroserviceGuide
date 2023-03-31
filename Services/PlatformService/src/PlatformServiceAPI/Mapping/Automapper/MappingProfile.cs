

using AutoMapper;
using Services.PlatformService.src.Entities.Models;
using Services.PlatformService.src.Shared.DataTransferObjects;

namespace Services.PlatformService.src.PlatformServiceAPI.Mapping.AutoMapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {

        //INFO: Resource=>Destination.
        CreateMap<PlatformForCreationDto, Platform>().ReverseMap();//INFO: ReverseMap enables two way mapping.
        CreateMap<Platform, PlatformDto>();
    }
}