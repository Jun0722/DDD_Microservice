using System;
using System.Linq;
using DDD.Domain.Interfaces;

namespace DDD.Insfrastructure.Data.Repository
{
    /// <summary>
    /// 泛型仓储，实现泛型仓储接口
    /// </summary>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        public void Add(TEntity T)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
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

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity T)
        {
            throw new NotImplementedException();
        }
    }
}
