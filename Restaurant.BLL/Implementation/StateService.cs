using Restaurant.BLL.Repository;
using Restaurant.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.BLL.Implementation
{
    public class StateService : IStateService
    {
        public Task<bool> Delete(State state)
        {
            throw new NotImplementedException();
        }

        public Task<List<State>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<State>> GetAllByIDCountry(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<State> GetByID(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<State> Insert(State state)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Update(State state)
        {
            throw new NotImplementedException();
        }
    }
}
