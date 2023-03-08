using Restaurant.BLL.Repository;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Implementation
{
    public class ImageService : IImageService
    {
        public Task<bool> Delete(Image image)
        {
            throw new NotImplementedException();
        }

        public Task<List<Image>> GetByIDProduct(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<Image> Insert(Image image)
        {
            throw new NotImplementedException();
        }
    }
}
