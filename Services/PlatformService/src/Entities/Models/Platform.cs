using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Services.PlatformService.src.Entities.Models;

public class Platform{

    [Column("CompanyId")]
    [Required]
    public Guid Id {get;set;}
    [Required]
    public string Name { get; set; }
    [Required]
    public string Publisher { get; set; }
    [Required]
    public string Cost { get; set; }    
}