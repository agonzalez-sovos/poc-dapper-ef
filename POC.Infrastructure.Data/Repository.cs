using POC.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

namespace POC.Infrastructure.Data
{
    public class Repository<TEntity> : IDisposable, IRepository<TEntity> where TEntity : EntityBase, IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Add(TEntity item)
        {
            GetSet().Add(item);
        }

        public IQueryable<TEntity> GetAll()
        {
            return GetSet();
        }

        public TEntity Get(int id)
        {
            return GetSet().Find(id);
        }

        public IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> predicate)
        {
            return GetSet().Where(predicate);
        }

        public void Remove(TEntity item)
        {
            if (item == null)
            {
                _unitOfWork.Attach(item);
                GetSet().Remove(item);
            }
        }

        private IDbSet<TEntity> GetSet()
        {
            return _unitOfWork.CreateSet<TEntity>();
        }

        public void Commit()
        {
            _unitOfWork.Commit();
        }

        public void Update(TEntity item)
        {
            if (item != null)
            {
                _unitOfWork.SetModified(item);
            }
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }
    }
}
