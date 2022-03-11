using PlatformService.Models;
using System.Threading.Tasks;

namespace PlatformService.Interface
{
    public interface IPlatform : IGeneric<Platform>
    {
        Task<Platform> GetByPlatformName(string platform);
    }
}
