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
        public POCContext() : base("") { }

        public int Commit()
        {
            return SaveChanges();
        }

        public IDbSet<TEntity> GetSet<TEntity>() where TEntity : EntityBase, IAggregateRoot
        {
            return Set<TEntity>();
        }
    }
}
