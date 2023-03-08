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
    public class OrderService : IOrderService
    {
        private readonly IGenericRepository<Order> _repository;
        public OrderService(IGenericRepository<Order> repository)
        {
            _repository = repository;
        }
        public Task<bool> Cancel(int ID)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> GetAllByIDTable(int ID)
        {
            try
            {
                List<Order> orders = await _repository.Consult(order => order.Id==ID).ToListAsync();
                return orders;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Task<List<Order>> GetAllPending()
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Insert(Order order)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
