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
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _repository;
        public ProductService(IGenericRepository<Product> repository) 
        { 
            _repository = repository;
        }
        public async Task<bool> Delete(Product product)
        {
            try
            {
                await _repository.Delete(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Product>> GetAll()
        {
            try
            {
                List<Product> products = await _repository.Consult(prod => prod.RemoveDate==null)
                                         .Include(category => category.IdcategoryNavigation)
                                         .ToListAsync();
                return products;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<Product>> GetAllByName(string name)
        {
            try
            {
                List<Product> products = await _repository.Consult(prod => prod.Name.Contains(name) && prod.RemoveDate==null)
                                        .Include(category => category.IdcategoryNavigation)
                                        .ToListAsync();
                return products;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Product> GetByID(int ID)
        {
            try
            {
                Product product = await _repository.Consult(prod => prod.Id == ID && prod.RemoveDate==null)
                                   .Include(category => category.IdcategoryNavigation)
                                  .FirstAsync();
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<Product> Insert(Product product)
        {
            try
            {
                Product productInserted = await _repository.Insert(product);
                Product productInfo = await _repository.Consult(prod => prod.Id == productInserted.Id)
                                      .Include(category => category.IdcategoryNavigation)
                                      .FirstAsync();
                return productInfo;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(Product product)
        {
            try
            {
                Product productUpdate = await _repository.Consult(prod => prod.Id == product.Id).FirstAsync();
                if (productUpdate==null)
                {
                    return false;
                }

                productUpdate.SalePrice = product.SalePrice;
                productUpdate.HightPrice = product.HightPrice;
                productUpdate.BasePrice = product.BasePrice;
                productUpdate.Name = product.Name;
                productUpdate.Description = product.Description;
                productUpdate.Idcategory = product.Idcategory;
                productUpdate.IsSuspend = product.IsSuspend;
                productUpdate.LastUpDate = product.LastUpDate;

                await _repository.Update(productUpdate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
