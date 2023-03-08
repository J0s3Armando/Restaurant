using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface ICountryService
    {
        Task<Country> Insert(Country country);
        Task<bool> Update(Country country);
        Task<bool> Delete(Country country);
        Task<Country> GetByID(int ID);
        Task<List<Country>> GetByName(string name);
        Task<List<Country>> GetAll();
    }
}
