using eTicket.Models;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Data.Services
{
    public class ActorsService : IActorsService
    {
        private readonly AppDbContext _context;
        public ActorsService(AppDbContext context)
        {
            _context = context;  
        }

        public async Task AddAsync(Actor actor)//bu method ile actors nesnesine yeni actor eklenir ve veri tabanına eklenir
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var data = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            _context.Actors.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>> GetAllAsync()
        {
            var data = await _context.Actors.ToListAsync();
            return data;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
            var data =await _context.Actors.FirstOrDefaultAsync(n => n.Id==id);
            return data;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;

        }
    }
}
