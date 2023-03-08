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
    internal class CompanyService : ICompanyService
    {
        private readonly IGenericRepository<Company> _repository;
        public CompanyService(IGenericRepository<Company> repository)
        {
            _repository = repository;
        }
        public async Task<Company> Get()
        {
            try
            {
                Company company = await _repository.Consult().FirstAsync();
                return company;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(Company company)
        {
            try
            {
                await _repository.Update(company);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
