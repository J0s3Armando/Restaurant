using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IMethodPaymentService
    {
        Task<MethodPayment> GetByID(int ID);
        Task<bool> Update(MethodPayment methodPayment);
        Task<List<MethodPayment>> GetAll();
    }
}
