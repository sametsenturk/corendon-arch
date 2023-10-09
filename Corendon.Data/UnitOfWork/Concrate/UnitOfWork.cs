using Corendon.Data.UnitOfWork.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace Corendon.Data.UnitOfWork.Concrate
{
    public class UnitOfWork<TDBContext> : IUnitOfWork<TDBContext> where TDBContext : DbContext
    {
        public TDBContext currentDBContext { get; set; }

        public IDbContextTransaction CurrentTransaction { get; set; }

        public UnitOfWork(TDBContext context)
        {
            currentDBContext = context;
        }

        public void BeginTransaction()
        {
            CurrentTransaction = currentDBContext.Database.BeginTransaction();
        }

        public void BeginTransaction(IsolationLevel level)
        {
            CurrentTransaction = currentDBContext.Database.BeginTransaction(level);
        }

        public void CommitTransaction()
        {
            if (CurrentTransaction != null)
            {
                CurrentTransaction.Commit();
            }
        }

        public void RollBackTransaction()
        {
            if (CurrentTransaction != null)
            {
                CurrentTransaction.Rollback();
            }
        }

        public void SaveChanges()
        {
            currentDBContext.SaveChanges();
        }

        public void JoinExistingTransaction(IUnitOfWork<TDBContext> unitOfWork)
        {
            currentDBContext.Database.UseTransaction(unitOfWork.CurrentTransaction.GetDbTransaction());
        }

        public int SetIsolationLevel(IsolationLevel level)
        {
            string text = "SET TRANSACTION ISOLATION LEVEL ";
            return RelationalDatabaseFacadeExtensions.ExecuteSqlRaw(sql: level switch
            {
                IsolationLevel.ReadCommitted => text + "READ COMMITTED",
                IsolationLevel.ReadUncommitted => text + "READ UNCOMMITTED",
                IsolationLevel.RepeatableRead => text + "REPEATABLE READ",
                IsolationLevel.Serializable => text + "SERIALIZABLE",
                IsolationLevel.Snapshot => text + "SNAPSHOT",
                _ => text + "READ COMMITTED",
            }, databaseFacade: currentDBContext.Database, parameters: Array.Empty<object>());
        }

        public void CloseConnection()
        {
            if (currentDBContext.Database.CanConnect())
            {
                currentDBContext.Database.CloseConnection();
            }
        }

        public void OpenConnection()
        {
            if (!currentDBContext.Database.CanConnect())
            {
                currentDBContext.Database.OpenConnection();
            }
        }

        public async Task SaveChangesAsync()
        {
            await currentDBContext.SaveChangesAsync();
        }

        public async Task BeginTransactionAsync()
        {
            CurrentTransaction = await currentDBContext.Database.BeginTransactionAsync();
        }

        public async Task BeginTransactionAsync(IsolationLevel level)
        {
            CurrentTransaction = await currentDBContext.Database.BeginTransactionAsync(level);
        }

        public async Task CommitTransactionAsync()
        {
            if (CurrentTransaction != null)
            {
                await CurrentTransaction.CommitAsync();
            }
        }

        public async Task RollBackTransactionAsync()
        {
            if (CurrentTransaction != null)
            {
                await CurrentTransaction.RollbackAsync();
            }
        }
    }
}
