using System;
using System.Linq;
using DDD.Domain.Interfaces;
using DDD.Insfrastructure.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace DDD.Insfrastructure.Data.Repository
{
    /// <summary>
    /// 泛型仓储，实现泛型仓储接口
    /// </summary>
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly StudyContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        public Repository(StudyContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }


        public void Add(TEntity T)
        {
            _dbSet.Add(T);
            _context.SaveChanges();

        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet;
        }

        public TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
            _context.SaveChanges();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Update(TEntity T)
        {
            _dbSet.Update(T);
            _context.SaveChanges();
        }
    }
}
