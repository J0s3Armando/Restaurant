using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IImageService
    {
        Task<Image> Insert(Image image);
        Task<bool> Delete(Image image);
        Task<List<Image>> GetByIDProduct(int ID);
    }
}
