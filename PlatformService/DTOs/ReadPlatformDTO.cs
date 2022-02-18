using PlatformService.Models;

namespace PlatformService.DTOs
{
    public class ReadPlatformDTO : BaseModel
    {
        public string PlatformName { get; set; }
        public string Publisher { get; set; }
        public string Cost { get; set; }
    }
}
