using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IOrderProductService
    {
        Task<OrderProduct> Insert(OrderProduct product);
        Task<bool> Cancel(int ID, DateTime cancelDate);
        Task<bool> Update(OrderProduct product);
        Task<List<OrderProduct>> GetAllByIDOrder(int ID);
    }
}
