using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface ITableBranchService
    {
        Task<TableBranch> Insert(TableBranch branch);
        Task<bool> Update(TableBranch branch);
        Task<bool> Delete(TableBranch branch);
        Task<TableBranch> GetByID(int ID);
        Task<List<TableBranch>> GetAll();
        Task<List<TableBranch>> GetAllByName(string name);
        Task<List<TableBranch>> GetAllByIDBranch(int ID);
    }
}
