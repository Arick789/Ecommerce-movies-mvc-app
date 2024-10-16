using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieTickets.Data;
using MovieTickets.Data.Services;
using MovieTickets.Models;

namespace MovieTickets.Controllers
{
    public class ProductoresController : Controller
    {
        private readonly IProductoresService _service;

        public ProductoresController(IProductoresService service)
        {
            _service = service;
        }
        public async Task <IActionResult> Index()
        {
            var allProductores = await _service.GetAllAsync();
            return View(allProductores);
        }

        //GET: Actores/Create
        public  IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("NombreCompleto, FotoPerfilURL, Bio")] Productor productor)
        {
            if (!ModelState.IsValid)
            {
                return View(productor);
            }
            await _service.AddAsync(productor);
            return RedirectToAction(nameof(Index));
        }
    }
}
