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
    public class OrderProductService : IOrderProductService
    {
        private readonly IGenericRepository<OrderProduct> _repository;
        public OrderProductService(IGenericRepository<OrderProduct> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Cancel(int ID, DateTime cancelDate)
        {
            try
            {
                OrderProduct orderProduct = await _repository.Consult(order => order.Id==ID).FirstAsync();
                orderProduct.CancelDate = cancelDate;
                orderProduct.LastUpDate = cancelDate;
                await _repository.Update(orderProduct);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<OrderProduct>> GetAllByIDOrder(int ID)
        {
            try
            {
                List<OrderProduct> orderProducts = await _repository.Consult( order => order.Idorder == ID)
                                                   .Include(order => order.IdorderNavigation)     
                                                   .Include(category => category.IdcategoryNavigation)
                                                   .ToListAsync();
                return orderProducts;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<OrderProduct> Insert(OrderProduct product)
        {
            try
            {
                OrderProduct orderProduct = await _repository.Insert(product);
                OrderProduct orderProductInfo = await _repository.Consult(order => order.Id == orderProduct.Id)
                                                .Include(order => order.IdorderNavigation)
                                                .Include(category => category.IdcategoryNavigation)
                                                .FirstAsync();
                return orderProductInfo;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(OrderProduct product)
        {
            try
            {
                OrderProduct orderProductUpdate = await _repository.Consult( order => order.Id == product.Id).FirstAsync();
                if (orderProductUpdate == null)
                {
                    return false;
                }

                orderProductUpdate.Idcategory = product.Idcategory;
                orderProductUpdate.Price = product.Price;
                orderProductUpdate.Quantity = product.Quantity;
                orderProductUpdate.LastUpDate = product.LastUpDate;

                await _repository.Update(orderProductUpdate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
