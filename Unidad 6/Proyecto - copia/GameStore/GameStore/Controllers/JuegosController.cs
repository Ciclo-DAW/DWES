using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GameStore.Data;
using GameStore.Models;

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
            var gameStoreContext = _context.Juegos.Include(j => j.Consola);
            return View(await gameStoreContext.ToListAsync());
        }

        // GET: Juegos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juego = await _context.Juegos
                .Include(j => j.Consola)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (juego == null)
            {
                return NotFound();
            }

            return View(juego);
        }

        // GET: Juegos/Create
        public IActionResult Create()
        {
            ViewData["ConsolaId"] = new SelectList(_context.Consolas, "ID", "Modelo");
            return View();
        }

        // POST: Juegos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nombre,Descripcion,Cantidad,Precio,FechaSalida,Estado,Genero,ConsolaId")] Juego juego)
        {
            if (ModelState.IsValid)
            {
                _context.Add(juego);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConsolaId"] = new SelectList(_context.Consolas, "ID", "Modelo", juego.ConsolaId);
            return View(juego);
        }

        // GET: Juegos/Edit/5
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
            ViewData["ConsolaId"] = new SelectList(_context.Consolas, "ID", "Modelo", juego.ConsolaId);
            return View(juego);
        }

        // POST: Juegos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nombre,Descripcion,Cantidad,Precio,FechaSalida,Estado,Genero,ConsolaId")] Juego juego)
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
            ViewData["ConsolaId"] = new SelectList(_context.Consolas, "ID", "Modelo", juego.ConsolaId);
            return View(juego);
        }

        // GET: Juegos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juego = await _context.Juegos
                .Include(j => j.Consola)
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
