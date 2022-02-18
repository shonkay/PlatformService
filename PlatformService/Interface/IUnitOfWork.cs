using System;
using System.Threading.Tasks;

namespace PlatformService.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IPlatform Platform { get; }
        Task<int> Complete();
        void Cancel();
        Task BeginTransactionAsync();
        Task RollbackAsync();
        Task CommitAsync();
    }
}
