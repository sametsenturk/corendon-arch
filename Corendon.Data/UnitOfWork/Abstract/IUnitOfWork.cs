using Microsoft.EntityFrameworkCore.Storage;
using System.Data;

namespace Corendon.Data.UnitOfWork.Abstract
{
    public interface IUnitOfWork<TDBContext>
    {
        IDbContextTransaction CurrentTransaction { get; set; }

        void SaveChanges();

        void BeginTransaction();

        void CommitTransaction();

        void RollBackTransaction();

        void JoinExistingTransaction(IUnitOfWork<TDBContext> unitOfWork);

        void BeginTransaction(IsolationLevel level);

        int SetIsolationLevel(IsolationLevel level);

        void OpenConnection();

        void CloseConnection();

        Task SaveChangesAsync();

        Task BeginTransactionAsync();

        Task CommitTransactionAsync();

        Task RollBackTransactionAsync();

        Task BeginTransactionAsync(IsolationLevel level);
    }
}
