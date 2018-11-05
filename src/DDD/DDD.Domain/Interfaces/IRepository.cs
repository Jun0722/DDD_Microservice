using System;
using System.Linq;

namespace DDD.Domain.Interfaces
{
    /// <summary>
    /// 定义泛型仓储接口，并继承IDisposable，显式释放资源
    /// </summary>
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity T);

        TEntity GetById(Guid id);

        IQueryable<TEntity> GetAll();

        void Update(TEntity T);

        void Remove(Guid id);

        int SaveChanges();
    }
}
