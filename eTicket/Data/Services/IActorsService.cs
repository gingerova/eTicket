using eTicket.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTicket.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id,Actor actor);
        Task DeleteAsync(int id);
    }
}
