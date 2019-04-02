using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameStore.Data;
using GameStore.Models;
using Microsoft.AspNetCore.Authorization;

namespace GameStore.Controllers
{
    public class JuegosController : Controller
    {
        private readonly GameStoreContext _context;

        public JuegosController(GameStoreContext context)
        {
            _context = context;
        }

        // GET: Juegos
        public async Task<IActionResult> Index()
        {
            var gameStoreContext = _context.Juegos.Include(j => j.Tienda);
            return View(await gameStoreContext.ToListAsync());
        }

        // GET: Consolas/ListAll/5
        public async Task<IActionResult> ListAll(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juego = await _context.Juegos
                .Include(j => j.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);

            var resultados = await _context.Juegos.Include(j => j.Tienda).Where
                (m => m.Nombre == juego.Nombre).ToListAsync(); //Devolver todos los resultados en los que el nombre es igual al nombre del juego actual

            if (juego == null)
            {
                return NotFound();
            }

            return View(resultados);
        }

        // GET: Juegos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juego = await _context.Juegos
                .Include(j => j.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (juego == null)
            {
                return NotFound();
            }

            return View(juego);
        }

        // GET: Juegos/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["TiendaId"] = new SelectList(_context.Tienda, "ID", "Nombre");
            return View();
        }

        // POST: Juegos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Modelo,Descripcion,Cantidad,Precio,FechaSalida,Estado,Genero,TiendaId")] Juego juego)
        {
            if (ModelState.IsValid)
            {
                _context.Add(juego);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TiendaId"] = new SelectList(_context.Tienda, "ID", "Nombre", juego.TiendaId);
            return View(juego);
        }

        // GET: Juegos/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juego = await _context.Juegos.FindAsync(id);
            if (juego == null)
            {
                return NotFound();
            }
            ViewData["TiendaId"] = new SelectList(_context.Tienda, "ID", "Nombre", juego.TiendaId);
            return View(juego);
        }

        // POST: Juegos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Modelo,Descripcion,Cantidad,Precio,FechaSalida,Estado,Genero,TiendaId")] Juego juego)
        {
            if (id != juego.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(juego);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JuegoExists(juego.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["TiendaId"] = new SelectList(_context.Tienda, "ID", "Nombre", juego.TiendaId);
            return View(juego);
        }

        // GET: Juegos/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juego = await _context.Juegos
                .Include(j => j.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (juego == null)
            {
                return NotFound();
            }

            return View(juego);
        }

        // POST: Juegos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var juego = await _context.Juegos.FindAsync(id);
            _context.Juegos.Remove(juego);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JuegoExists(int id)
        {
            return _context.Juegos.Any(e => e.ID == id);
        }
    }
}
