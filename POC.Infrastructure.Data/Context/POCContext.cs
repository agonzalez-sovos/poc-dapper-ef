using POC.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Infrastructure.Data.Context
{
    public class POCContext : DbContext, IUnitOfWork
    {
        public POCContext() : base("POC") { }

        public void Attach<TEntity>(TEntity item) where TEntity : EntityBase, IAggregateRoot
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            throw new NotImplementedException();
        }

        public IDbSet<TEntity> CreateSet<TEntity>() where TEntity : EntityBase, IAggregateRoot
        {
            throw new NotImplementedException();
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : EntityBase, IAggregateRoot
        {
            throw new NotImplementedException();
        }
    }
}
