using eTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTicket.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
           var actor = await _context.Actors.FindAsync(id);
            _context.Actors.Remove(actor);
            _context.SaveChanges();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var actors = await _context.Actors.ToListAsync();
            return actors;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var actor = await _context.Actors.FirstOrDefaultAsync(n=> n.Id == id);
            return actor;
        }

        public async Task<Actor> UpdateAsync(int id, Actor actor)
        {
            var actorFind = await _context.Actors.FirstOrDefaultAsync(n=> n.Id == id);
            actorFind.ProfilePicture = actor.ProfilePicture;
            actorFind.ActorName=actor.ActorName;
            actorFind.Bio=actor.Bio;
            _context.Actors.Update(actorFind);
            await _context.SaveChangesAsync();
            return actorFind;
        }
    }
}
