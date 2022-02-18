using Microsoft.EntityFrameworkCore;
using PlatformService.Models;
using System.Threading.Tasks;

namespace PlatformService.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public virtual DbSet<Platform> Platform { get; set; }

        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
