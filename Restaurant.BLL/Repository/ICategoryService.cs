using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface ICategoryService
    {
        Task<Category> GetById(int ID);
        Task<List<Category>> GetAll();
        Task<List<Category>> GetAllByName(string name);
        Task<bool> Delete(Category category);
        Task<bool> Update(Category category);
        Task<Category> Insert(Category category);
    }
}
