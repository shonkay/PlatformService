using PlatformService.Context;
using PlatformService.Interface;
using PlatformService.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformService.Repository
{
    public class PlatformRepository : GenericRepository<Platform>, IPlatform
    {
        public PlatformRepository(DataContext context) : base(context)
        {

        }

        public async Task<Platform> GetByPlatformName(string platform) 
        {
            var entity = await Find(x => x.PlatformName == platform);
            return entity.FirstOrDefault();
        }

    }
}
