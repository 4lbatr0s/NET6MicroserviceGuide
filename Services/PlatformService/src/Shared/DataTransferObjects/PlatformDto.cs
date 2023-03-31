namespace Services.PlatformService.src.Shared.DataTransferObjects;

public record PlatformDto:PlatformForManipulationDto{
    public Guid Id { get; set; }
    
}
