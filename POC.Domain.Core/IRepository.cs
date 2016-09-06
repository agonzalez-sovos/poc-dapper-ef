using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace POC.Domain.Core
{
    public interface IRepository<TEntity> where TEntity : EntityBase, IAggregateRoot
    {
        TEntity Get(int id);
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> predicate);
        void Add(TEntity item);
        void Update(TEntity item);
        void Remove(TEntity item);
        void Commit();
    }
}
