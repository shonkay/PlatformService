using PlatformService.Context;
using PlatformService.Interface;
using PlatformService.Models;

namespace PlatformService.Repository
{
    public class PlatformRepository : GenericRepository<Platform>, IPlatform
    {
        public PlatformRepository(DataContext context) : base(context)
        {

        }

    }
}
