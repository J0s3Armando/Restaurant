using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IBranchService
    {
        Task<Branch> Insert(Branch branch);
        Task<bool> Update(Branch branch);
        Task<bool> Delete(Branch branch);
        Task<Branch> GetById(int ID);
        Task<List<Branch>> GetAllByName(string name);
        Task<List<Branch>> GetAll();
    }
}
