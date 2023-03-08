using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IOrderService
    {
        Task<Order> Insert(Order order);
        Task<bool> Update(Order order);
        Task<bool> Cancel(int ID);
        Task<Order> GetByID(int ID);
        Task<List<Order>> GetAllPending();
        Task<List<Order>> GetAllByIDTable(int ID);
    }
}

