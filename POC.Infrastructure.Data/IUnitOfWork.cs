using POC.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Infrastructure.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IDbSet<TEntity> CreateSet<TEntity>() where TEntity : EntityBase, IAggregateRoot;
        void Attach<TEntity>(TEntity item) where TEntity : EntityBase, IAggregateRoot;
        void SetModified<TEntity>(TEntity item) where TEntity : EntityBase, IAggregateRoot;
        void Commit();
    }
}
