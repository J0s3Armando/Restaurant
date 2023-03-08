using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IProductService
    {
        Task<Product> Insert(Product product);
        Task<bool> Update(Product product);
        Task<bool> Delete(Product product);
        Task<Product> GetByID(int ID);
        Task<List<Product>> GetAll();
        Task<List<Product>> GetAllByName(string name);
    }
}
