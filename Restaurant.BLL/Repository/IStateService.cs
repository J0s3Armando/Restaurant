using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Repository
{
    public interface IStateService
    {
        Task<State> Insert(State state);
        Task<bool> Update(State state);
        Task<bool> Delete(State state);
        Task<List<State>> GetAll();
        Task<List<State>> GetAllByIDCountry(int ID);
        Task<State> GetByID(int ID);
    }
}
