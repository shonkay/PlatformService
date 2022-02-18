using Microsoft.EntityFrameworkCore.Storage;
using PlatformService.Context;
using PlatformService.Interface;
using System.Threading.Tasks;

namespace PlatformService.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        private IDbContextTransaction _transaction;

        public UnitOfWork(DataContext context, IPlatform platform)
        {
            _context = context;
            Platform = platform;
        }

        public IPlatform Platform { get; private set; }
        public async Task<int> Complete() => await _context.SaveChanges();
        public async void Cancel() => await _context.DisposeAsync();
        public void Dispose() => _context.Dispose();
        public async Task BeginTransactionAsync() => _transaction = await _context.Database.BeginTransactionAsync();
        public async Task RollbackAsync() => await _transaction.RollbackAsync();
        public async Task CommitAsync() => await _transaction.CommitAsync();
    }
}
