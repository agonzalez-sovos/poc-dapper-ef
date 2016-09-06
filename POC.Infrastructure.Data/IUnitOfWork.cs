using POC.Domain.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POC.Infrastructure.Data
{
    public interface IUnitOfWork
    {
        IDbSet<TEntity> GetSet<TEntity>() where TEntity : EntityBase, IAggregateRoot;
        int Commit();
    }
}
