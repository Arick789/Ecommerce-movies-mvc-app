using MovieTickets.Models;

namespace MovieTickets.Data.Services
{
    public class ProductoresService : EntityBaseRepository<Productor>, IProductoresService
    {
        public ProductoresService(AppDbContext context) : base(context)
        {
            
        }
    }
}
