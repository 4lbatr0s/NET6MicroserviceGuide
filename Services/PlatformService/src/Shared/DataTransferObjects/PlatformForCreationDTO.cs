

using System.ComponentModel.DataAnnotations;

namespace Services.PlatformService.src.Shared.DataTransferObjects;

//INFO: Records are immutable after initiated, better options more sustainable compared to classes.
public record PlatformForCreationDto:PlatformForManipulationDto{    
}
