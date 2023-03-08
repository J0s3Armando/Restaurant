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
    public class CountryService : ICountryService
    {
        private readonly IGenericRepository<Country> _repository;
        public CountryService(IGenericRepository<Country> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Country country)
        {
            try
            {
                await _repository.Delete(country);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Country>> GetAll()
        {
            try
            {
                List<Country> countries = await _repository.Consult(co => co.RemoveDate==null).ToListAsync();
                return countries;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Country> GetByID(int ID)
        {
            try
            {
                Country country = await _repository.Consult( co => co.Id == ID && co.RemoveDate==null ).FirstAsync();
                return country;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Country>> GetByName(string name)
        {
            try
            {
                List<Country> countries = await _repository.Consult(co => co.Name.Contains(name) && co.RemoveDate==null).ToListAsync();
                return countries;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Country> Insert(Country country)
        {
            try
            {
                Country co = await _repository.Insert(country);
                return co;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(Country country)
        {

            try
            {
                Country updateCountry = await _repository.Consult( co=> co.Id==country.Id && co.RemoveDate==null).FirstAsync();
                if (updateCountry == null)
                {
                    throw new Exception("User not exists");
                }

                updateCountry.Name = country.Name;
                updateCountry.Abbreviation = country.Abbreviation;
                updateCountry.LastUpdate = country.LastUpdate;

                await _repository.Update(updateCountry);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
