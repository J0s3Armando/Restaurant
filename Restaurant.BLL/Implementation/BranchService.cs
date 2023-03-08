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
    public class BranchService : IBranchService
    {
        private readonly IGenericRepository<Branch> _repository;
        public BranchService(IGenericRepository<Branch> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Branch branch)
        {
            try
            {
                await _repository.Delete(branch);
                return true; 
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Branch>> GetAll()
        {
            try
            {
                List<Branch> branches = await _repository.Consult(br => br.RemoveDate == null)
                                        .Include(company => company.IdcompanyNavigation)
                                        .Include(country => country.IdcountryNavigation)
                                        .Include(state => state.IdstateNavigation)
                                        .ToListAsync();
                return branches;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Branch>> GetAllByName(string name)
        {
            try
            {
                List<Branch> branches = await _repository.Consult(branchName => branchName.Name.Contains(name) && branchName.RemoveDate==null)
                                        .Include(company => company.IdcompanyNavigation)
                                        .Include(country => country.IdcountryNavigation)
                                        .Include(state => state.IdstateNavigation)
                                        .ToListAsync();
                return branches;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Branch> GetById(int ID)
        {
            try
            {
                Branch branch = await _repository.Consult(br => br.Id == ID && br.RemoveDate==null)
                                .Include(company => company.IdcompanyNavigation)
                                .Include(country => country.IdcountryNavigation)
                                .Include(state => state.IdstateNavigation)
                                .FirstAsync();
                if(branch==null)
                {
                    throw new Exception("No existe el registro.");
                }
                return branch;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Branch> Insert(Branch branch)
        {
            try
            {
               Branch insertedBranch = await _repository.Insert(branch);
               Branch branchInfo = await _repository.Consult( br => br.Id == insertedBranch.Id)
                                    .Include(company => company.IdcompanyNavigation)
                                    .Include(country => country.IdcountryNavigation)
                                    .Include(state => state.IdstateNavigation)
                                    .FirstAsync();
               return branchInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(Branch branch)
        {
            try
            {
                Branch branchUpdate = await _repository.Consult(us=> us.Id== branch.Id && us.RemoveDate==null).FirstAsync();
                if (branchUpdate == null)
                    return false;

                branchUpdate.Telephone = branch.Telephone;
                branchUpdate.Address = branch.Address;
                branchUpdate.Idcountry = branch.Idcountry;
                branchUpdate.Idstate = branch.Idstate;
                branchUpdate.Name = branch.Name;
                branchUpdate.PostalCode = branch.PostalCode;
                branchUpdate.LastUpdate = branch.LastUpdate;

                await _repository.Update(branchUpdate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
