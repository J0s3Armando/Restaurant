using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IIngredientService
    {
        Task<Ingredient> Insert(Ingredient ingredient);
        Task<bool> Update(Ingredient ingredient);
        Task<bool> Delete(Ingredient ingredient);
        Task<Ingredient> GetByID(int ID);
        Task<List<Ingredient>> GetAll();
    }
}
