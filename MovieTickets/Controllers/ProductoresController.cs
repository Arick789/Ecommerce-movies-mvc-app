using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Data;

namespace MovieTickets.Controllers
{
    public class ProductoresController : Controller
    {
        private readonly AppDbContext _context;

        public ProductoresController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            var allProductores = await _context.Productores.ToListAsync();
            return View(allProductores);
        }
    }
}
