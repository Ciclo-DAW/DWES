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
    
    public class ConsolasController : Controller
    {
        private readonly GameStoreContext _context;

        public ConsolasController(GameStoreContext context)
        {
            _context = context;
        }

        // GET: Consolas
        public async Task<IActionResult> Index()
        {
            var gameStoreContext = _context.Consolas.Include(c => c.Marca).Include(c => c.Tienda);
            return View(await gameStoreContext.ToListAsync());
        }

        // GET: Consolas/ListAll/5
        public async Task<IActionResult> ListAll(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consola = await _context.Consolas
                .Include(c => c.Marca)
                .Include(c => c.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);

            var resultados = await _context.Consolas
                //.Include(c => c.Marca)
                //.Include(c => c.Tienda)
                .Where(m => m.Modelo == consola.Modelo)
                .ToListAsync(); //Devolver todos los resultados en los que el modelo es igual al modelo de la actual
            
            if (consola == null)
            {
                return NotFound();
            }

            return View(resultados);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consola = await _context.Consolas
                .Include(c => c.Marca)
                .Include(c => c.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);

     
            if (consola == null)
            {
                return NotFound();
            }

            return View(consola);
        }

        // GET: Consolas/Create
        [Authorize]
        public IActionResult Create()
        {
            ViewData["MarcaId"] = new SelectList(_context.Marca, "ID", "Nombre");
            ViewData["TiendaId"] = new SelectList(_context.Tienda, "ID", "Nombre");
            return View();
        }

        // POST: Consolas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,MarcaId,Modelo,Descripcion,Cantidad,Precio,FechaSalida,Estado,TiendaId")] Consola consola)
        {
            if (ModelState.IsValid)
            {
                _context.Add(consola);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MarcaId"] = new SelectList(_context.Marca, "ID", "Nombre", consola.MarcaId);
            ViewData["TiendaId"] = new SelectList(_context.Tienda, "ID", "Nombre", consola.TiendaId);
            return View(consola);
        }

        // GET: Consolas/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consola = await _context.Consolas.FindAsync(id);
            if (consola == null)
            {
                return NotFound();
            }
            ViewData["MarcaId"] = new SelectList(_context.Marca, "ID", "Nombre", consola.MarcaId);
            ViewData["TiendaId"] = new SelectList(_context.Tienda, "ID", "Nombre", consola.TiendaId);
            return View(consola);
        }

        // POST: Consolas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,MarcaId,Modelo,Descripcion,Cantidad,Precio,FechaSalida,Estado,TiendaId")] Consola consola)
        {
            if (id != consola.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(consola);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConsolaExists(consola.ID))
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
            ViewData["MarcaId"] = new SelectList(_context.Marca, "ID", "Nombre", consola.MarcaId);
            ViewData["TiendaId"] = new SelectList(_context.Tienda, "ID", "Nombre", consola.TiendaId);
            return View(consola);
        }

        // GET: Consolas/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var consola = await _context.Consolas
                .Include(c => c.Marca)
                .Include(c => c.Tienda)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (consola == null)
            {
                return NotFound();
            }

            return View(consola);
        }

        // POST: Consolas/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var consola = await _context.Consolas.FindAsync(id);
            _context.Consolas.Remove(consola);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConsolaExists(int id)
        {
            return _context.Consolas.Any(e => e.ID == id);
        }
    }
}
