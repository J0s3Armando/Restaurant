using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IUserService
    {
        Task<User> Insert(User user);
        Task<User> GetByEmailPassword(string email, string password);
        Task<bool> Update(User user);
        Task<User> GetById(int ID);
        Task<List<User>> GetAll();
    }
}
