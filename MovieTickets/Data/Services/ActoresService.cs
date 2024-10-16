using Microsoft.EntityFrameworkCore;
using MovieTickets.Models;

namespace MovieTickets.Data.Services
{
    public class ActoresService :EntityBaseRepository<Actor>, IActoresService
    {
        public ActoresService(AppDbContext context): base(context) { }
    }
}
