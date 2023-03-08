using Restaurant.BLL.Repository;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Implementation
{
    public class TableBranchService : ITableBranchService
    {
        public Task<bool> Delete(TableBranch branch)
        {
            throw new NotImplementedException();
        }

        public Task<List<TableBranch>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<TableBranch>> GetAllByIDBranch(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<List<TableBranch>> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<TableBranch> GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<TableBranch> Insert(TableBranch branch)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(TableBranch branch)
        {
            throw new NotImplementedException();
        }
    }
}
