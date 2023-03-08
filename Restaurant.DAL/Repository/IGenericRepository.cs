using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Repository
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<TEntity> Insert(TEntity entity);
        Task<bool> Update(TEntity entity);
        Task<bool> Delete (TEntity entity);
        IQueryable<TEntity> Consult(Expression<Func<TEntity,bool>> expression = null);
    }
}
