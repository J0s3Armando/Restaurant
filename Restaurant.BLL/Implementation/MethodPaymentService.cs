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
    public class MethodPaymentService : IMethodPaymentService
    {
        private readonly IGenericRepository<MethodPayment> _repository;
        public MethodPaymentService(IGenericRepository<MethodPayment> repository)
        {
            _repository = repository;
        }
        public async Task<List<MethodPayment>> GetAll()
        {
            try
            {
                List<MethodPayment> methodPayments = await _repository.Consult().ToListAsync();
                return methodPayments;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<MethodPayment> GetByID(int ID)
        {
            try
            {
                MethodPayment methodPayment = await _repository.Consult(method => method.Id== ID ).FirstAsync();
                return methodPayment;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(MethodPayment methodPayment)
        {
            try
            {
                MethodPayment methodPaymentUpdate = await _repository.Consult(method => method.Id==methodPayment.Id).FirstAsync();
                if (methodPaymentUpdate==null)
                {
                    return false;
                }

                methodPaymentUpdate.Name = methodPayment.Name;
                methodPaymentUpdate.LastUpDate = methodPaymentUpdate.LastUpDate;
                await _repository.Update(methodPaymentUpdate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
