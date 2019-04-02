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
    public class PerifericosController : Controller
    {
        private readonly GameStoreContext _context;

        public PerifericosController(GameStoreContext context)
        {
            _context = context;
        }

        // GET: Perifericos
        public async Task<IActionResult> Index()
        {
            var gameStoreContext = _context.Perifericos.Include(p => p.Consola);
            return View(await gameStoreContext.ToListAsync());
        }

        // GET: Perifericos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periferico = await _context.Perifericos
                .Include(p => p.Consola)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (periferico == null)
            {
                return NotFound();
            }

            return View(periferico);
        }

        // GET: Perifericos/Create
        public IActionResult Create()
        {
            ViewData["ConsolaId"] = new SelectList(_context.Consolas, "ID", "Modelo");
            return View();
        }

        // POST: Perifericos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Marca,Modelo,Descripcion,Cantidad,Precio,FechaSalida,Estado,Tipo,ConsolaId")] Periferico periferico)
        {
            if (ModelState.IsValid)
            {
                _context.Add(periferico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ConsolaId"] = new SelectList(_context.Consolas, "ID", "Modelo", periferico.ConsolaId);
            return View(periferico);
        }

        // GET: Perifericos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periferico = await _context.Perifericos.FindAsync(id);
            if (periferico == null)
            {
                return NotFound();
            }
            ViewData["ConsolaId"] = new SelectList(_context.Consolas, "ID", "Modelo", periferico.ConsolaId);
            return View(periferico);
        }

        // POST: Perifericos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Marca,Modelo,Descripcion,Cantidad,Precio,FechaSalida,Estado,Tipo,ConsolaId")] Periferico periferico)
        {
            if (id != periferico.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(periferico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerifericoExists(periferico.ID))
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
            ViewData["ConsolaId"] = new SelectList(_context.Consolas, "ID", "Modelo", periferico.ConsolaId);
            return View(periferico);
        }

        // GET: Perifericos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var periferico = await _context.Perifericos
                .Include(p => p.Consola)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (periferico == null)
            {
                return NotFound();
            }

            return View(periferico);
        }

        // POST: Perifericos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var periferico = await _context.Perifericos.FindAsync(id);
            _context.Perifericos.Remove(periferico);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerifericoExists(int id)
        {
            return _context.Perifericos.Any(e => e.ID == id);
        }
    }
}
