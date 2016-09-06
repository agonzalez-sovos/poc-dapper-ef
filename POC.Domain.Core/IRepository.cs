using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POC.Domain.Core
{
    public interface IRepository<TEntity> : IDisposable where TEntity : EntityBase, IAggregateRoot
    {
        TEntity GetById(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> predicate);
        TEntity AddOrUpdate(TEntity item);
        TEntity Remove(TEntity item);
        int Commit();
    }
}
