using eTicket.Models;

namespace eTicket.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> GetAllAsync();
        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task<Actor> UpdateAsync(int id, Actor newActor);//yeni aktör ve id eşleşirse veritabanı güncellenecek
        Task DeleteAsync(int id);
        
    }
}
