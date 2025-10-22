using Demo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DAL.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : BaseEntity ,new()
    {
        IEnumerable<TEntity> GetAll();
        TEntity? GetById(int Id);
        int Add(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);

    }
}
