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
    public class UserService : IUserService
    {
        private readonly IGenericRepository<User> _repository;
        public UserService( IGenericRepository<User> repository)
        {
            _repository = repository;
        }

        public async Task<List<User>> GetAll()
        {
            try
            {
                List<User> users = await _repository.Consult()
                                   .Include(rol => rol.IdrolNavigation)
                                   .Include(country => country.IdcountryNavigation)
                                   .Include(state => state.IdstateNavigation)
                                   .ToListAsync();
                return users;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<User> GetByEmailPassword(string email, string password)
        {
            try
            {
                User user = await _repository.Consult(us => us.Email.Equals(email) && us.Password.Equals(password))
                            .Include(rol => rol.IdrolNavigation)
                            .Include(country => country.IdcountryNavigation)
                            .Include(state => state.IdstateNavigation)
                            .FirstAsync();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<User> GetById(int ID)
        {
            try
            {
                User user = await _repository.Consult(usr => usr.Id == ID)
                            .Include(rol => rol.IdrolNavigation)
                            .Include(country => country.IdcountryNavigation)
                            .Include(state=> state.IdstateNavigation)
                            .FirstAsync();
                return user;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<User> Insert(User user)
        {
            try
            {
               User newUser = await _repository.Insert(user);
               User newUserInfo = await _repository.Consult(usr=> usr.Id == newUser.Id)
                                    .Include(rol => rol.IdrolNavigation)
                                    .Include(country => country.IdcountryNavigation)
                                    .Include(state => state.IdstateNavigation)
                                    .FirstAsync(); 
               return newUserInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(User user)
        {
            try
            {
                await _repository.Update(user);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
