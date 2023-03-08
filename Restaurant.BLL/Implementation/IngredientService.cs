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
    public class IngredientService : IIngredientService
    {
        private readonly IGenericRepository<Ingredient> _repository;
        public IngredientService(IGenericRepository<Ingredient> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Ingredient ingredient)
        {
            try
            {
                await _repository.Delete(ingredient);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public async Task<List<Ingredient>> GetAll()
        {
            try
            {
                List<Ingredient> ingredients = await _repository.Consult(ing => ing.RemoveDate==null).ToListAsync();
                return ingredients;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Ingredient> GetByID(int ID)
        {
            try
            {
                Ingredient ingredient = await _repository.Consult(ing => ing.Id == ID && ing.RemoveDate==null).FirstAsync();
                return ingredient;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<Ingredient> Insert(Ingredient ingredient)
        {
            try
            {
                Ingredient ingredientInserted = await _repository.Insert(ingredient);
                return ingredientInserted;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<bool> Update(Ingredient ingredient)
        {
            try
            {
                Ingredient ingredientUpdate = await _repository.Consult(ing => ing.RemoveDate==null).FirstAsync();
                if (ingredientUpdate == null)
                {
                    return false;
                }

                ingredientUpdate.Name = ingredient.Name;
                ingredientUpdate.Price = ingredient.Price;
                ingredientUpdate.LastUpDate = ingredient.LastUpDate;
                await _repository.Update(ingredientUpdate);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
