using Restaurant.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL.Implementation
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly RestaurantContext _context;
        public GenericRepository(RestaurantContext context) 
        {
            _context = context;
        }
        public async Task<TEntity> Insert(TEntity entity)
        {
            try
            {
                await _context.Set<TEntity>().AddAsync(entity);
                await _context.SaveChangesAsync();
                return entity;
            }
            catch (Exception)
            {
                throw new Exception("Error to add the record.");
            }
        }

        public async Task<bool> Update(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error to Update the record.");
            }
        }

        public async Task<bool> Delete(TEntity entity)
        {
            try
            {
                _context.Set<TEntity>().Update(entity);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Error to Remove the record.");
            }
        }

        public IQueryable<TEntity> Consult(Expression<Func<TEntity, bool>> expression = null)
        {
            try
            {
                IQueryable<TEntity> result = expression == null ? _context.Set<TEntity>() : _context.Set<TEntity>().Where(expression);
                return result;
            }
            catch (Exception)
            {
                throw new Exception("Error to Retrieve the records.");
            }
        }
    }
}
