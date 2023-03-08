using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IProductImageService
    {
        Task<ProductImage> Insert(ProductImage image);
        Task<bool> Update(ProductImage image);
        Task<bool> Delete(ProductImage image);
        Task<List<ProductImage>> GetAllByIDProduct();
    }
}
