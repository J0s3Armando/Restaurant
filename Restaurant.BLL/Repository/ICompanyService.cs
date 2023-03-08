using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface ICompanyService
    {
        Task<Company> Get();
        Task<bool> Update(Company company);
    }
}
