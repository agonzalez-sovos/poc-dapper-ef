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
            Set<TEntity>().Attach(item);
        }

        public void Commit()
        {
            SaveChanges();
        }

        public IDbSet<TEntity> CreateSet<TEntity>() where TEntity : EntityBase, IAggregateRoot
        {
            return Set<TEntity>();
        }

        public void SetModified<TEntity>(TEntity item) where TEntity : EntityBase, IAggregateRoot
        {
            Entry(item).State = EntityState.Modified;
        }
    }
}
