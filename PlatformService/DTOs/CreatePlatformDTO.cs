using System.ComponentModel.DataAnnotations;

namespace PlatformService.DTOs
{
    public class CreatePlatformDTO
    {
        [Required]
        public string PlatformName { get; set; }
        [Required]
        public string Publisher { get; set; }
        [Required]
        public string Cost { get; set; }
    }
}
