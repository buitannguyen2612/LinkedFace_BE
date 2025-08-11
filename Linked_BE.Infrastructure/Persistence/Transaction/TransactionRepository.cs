using Linked_BE.Application.Interfaces;
using Linked_BE.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Linked_BE.Infrastructure.Persistence.Transaction
{
    public class TransactionRepository : ITransactionManager
    {
        private readonly AppDbContext _dbContext;
        private IDbContextTransaction _transaction;

        public TransactionRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task BeginTransactionAsync()
        {
            _transaction = await _dbContext.Database.BeginTransactionAsync();
        }

        public async Task CommitTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.CommitAsync();
                _transaction.Dispose();
            }
        }

        public async Task RollbackTransactionAsync()
        {
            if (_transaction != null)
            {
                await _transaction.RollbackAsync();
                _transaction.Dispose();
            }
        }

    }
}