using Microsoft.AspNetCore.Mvc;
using MovieTickets.Data;
using MovieTickets.Data.Services;
using MovieTickets.Models;

namespace MovieTickets.Controllers
{
    public class ActoresController : Controller
    {
        private readonly IActoresService _service;

        public ActoresController(IActoresService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //GET: Actores/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("NombreCompleto, FotoPerfilURL, Bio")]Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }

        //GET: Actores/Details
        public async Task<IActionResult> Details(int id)
        {
            var actorDetalles = await _service.GetByIdAsync(id);

            if (actorDetalles == null) return View("NotFound");
            return View(actorDetalles);
        }

        //GET: Actores/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetalles = await _service.GetByIdAsync(id);

            if (actorDetalles == null) return View("NotFound");
            return View(actorDetalles);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, NombreCompleto, FotoPerfilURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }

        //GET: Actores/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetalles = await _service.GetByIdAsync(id);

            if (actorDetalles == null) return View("NotFound");
            return View(actorDetalles);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetalles = await _service.GetByIdAsync(id);
            if (actorDetalles == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
