using Demo.DAL.Data.Contexts;
using Demo.DAL.Models;
using Demo.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories.Classes
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly AppDbContext _dbContext;

        public GenericRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(TEntity entity)
        {
            if(entity is null) return 0;
            _dbContext.Add(entity);
            return _dbContext.SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            if (entity is null) return 0;
            _dbContext.Remove(entity);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll() => _dbContext.Set<TEntity>().Where(X=>X.IsDeleted == false).AsNoTracking().ToList();

        public TEntity? GetById(int Id) => _dbContext.Set<TEntity>().Find(Id);

        public int Update(TEntity entity)
        {
            if (entity is null) return 0;
            _dbContext.Update(entity);
            return _dbContext.SaveChanges();
        }
    }
}
