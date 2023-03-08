using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IImageStorageService
    {
        Task<string> Upload(Stream image, string folder, string fileName);
        Task<bool> Remove(string folder, string fileName);
    }
}
