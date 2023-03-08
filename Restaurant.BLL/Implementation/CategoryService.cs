using Microsoft.EntityFrameworkCore;
using Restaurant.BLL.Repository;
using Restaurant.DAL.Repository;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Implementation
{
    internal class CategoryService : ICategoryService
    {
        private readonly IGenericRepository<Category> _repository;
        public CategoryService(IGenericRepository<Category> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Category category)
        {
            try
            {
                await _repository.Delete(category);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Category>> GetAll()
        {
            try
            {
                List<Category> categories = await _repository.Consult(cat => cat.RemoveDate==null).ToListAsync();
                return categories;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Category>> GetAllByName(string name)
        {
            try
            {
                List<Category> categories = await _repository.Consult(cat => cat.Name.Contains(name) && cat.RemoveDate==null).ToListAsync();
                return categories;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Category> GetById(int id)
        {
            try
            {
                Category category = await _repository.Consult( cat => cat.Id == id && cat.RemoveDate==null).FirstAsync();
                return category;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Category> Insert(Category category)
        {
            try
            {
                Category categoryInserted = await _repository.Insert(category);
                return categoryInserted;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(Category category)
        {
            try
            {
                Category categoryUpdate = await _repository.Consult( cat => cat.Id == category.Id && cat.RemoveDate == null).FirstAsync();
                if(categoryUpdate == null)
                {
                    return false;
                }

                categoryUpdate.LastUpdate = category.LastUpdate;
                categoryUpdate.Name = category.Name;

                await _repository.Update(categoryUpdate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
