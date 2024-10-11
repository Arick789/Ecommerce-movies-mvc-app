using MovieTickets.Models;

namespace MovieTickets.Data.Services
{
    public interface IActoresService
    {
        Task<IEnumerable<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id);
        Task AddAsync(Actor actor);
        Task <Actor> UpdateAsync(int id, Actor newActor);
        Task DeleteAsync(int id);
    }
}
