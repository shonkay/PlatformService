using System;
using System.Threading.Tasks;

namespace PlatformService.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        Task<int> Complete();
        void Cancel();
        Task BeginTransactionAsync();
        Task RollbackAsync();
        Task CommitAsync();
    }
}
