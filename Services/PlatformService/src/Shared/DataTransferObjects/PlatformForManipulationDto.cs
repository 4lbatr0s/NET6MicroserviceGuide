

using System.ComponentModel.DataAnnotations;

namespace Services.PlatformService.src.Shared.DataTransferObjects;

public record PlatformForManipulationDto {
    [Required]
    public string Name { get; init; } //INFO: init instead of set to support XML responses.
    [Required]
    public string Publisher { get; init; }
    [Required]
    public string Cost { get; init; }
}