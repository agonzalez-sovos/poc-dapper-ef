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
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : EntityBase, IAggregateRoot
    {
        private readonly IUnitOfWork _unitOfWork;

        public Repository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public TEntity AddOrUpdate(TEntity item)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity Remove(TEntity item)
        {
            throw new NotImplementedException();
        }

        private IDbSet<TEntity> GetSet()
        {
            return _unitOfWork.GetSet<TEntity>();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public int Commit()
        {
            return _unitOfWork.Commit();
        }
    }
}
